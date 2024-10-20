using System.Collections;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace DeckSensorVer2
{
    public partial class Form1 : Form
    {
        int udpListenPort = 42507;
        int udpSendPort = 42007;
        int unitId = 7;
        string strIpAddress = "10.20.78.181";
        bool isListening = false;

        UdpClient udpClient = new UdpClient();

        // Create Array variable names for button arrays
        private RadioButton[] presetButtons;
        private Button[] zoneStatusButtons;

        public Form1()
        {
            InitializeComponent();
            // Assign buttons and radio buttons to Array variables
            presetButtons = [RadioBtnPreset1, RadioBtnPreset2, RadioBtnPreset3, RadioBtnPreset4];
            zoneStatusButtons = [BtnZone1, BtnZone2, BtnZone3, BtnZone4, BtnZone5, BtnZone6];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // subscribe preset button arrays to click event
            foreach (var presetButton in presetButtons)
            {
                presetButton.Click += PresetButton_Click;
            }
            // subscribe button array to click event
            foreach (var zoneButton in zoneStatusButtons)
            {
                zoneButton.Click += ZoneButton_Click;
            }
        }

        private void ZoneButton_Click(object? sender, EventArgs e)
        {
            // initialize click event for array
            Button? clickedZoneStatusBtn = sender as Button;

            if (clickedZoneStatusBtn != null)
            {
                int zoneStatusBtnIdx = Array.IndexOf(zoneStatusButtons, clickedZoneStatusBtn);
                Byte[] zoneByte = { 0x01, 0x02, 0x04, 0x08, 0x10, 0x20 };
                Byte[] dataToSend = { 0x54, 0x66, 0x66, zoneByte[zoneStatusBtnIdx] };
                sendDataToDeckSensor(dataToSend);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private void PresetButton_Click(object? sender, EventArgs e)
        {
            // initialize click event for array
            RadioButton? clickedRadioBtn = sender as RadioButton;

            int presetBtnIdx = Array.IndexOf(presetButtons, clickedRadioBtn);

            if (clickedRadioBtn != null)
            {
                if (presetButtons[presetBtnIdx].Checked == true)
                {
                    sendPreset(presetBtnIdx);
                }
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private void BtnQueryPresets_Click(object sender, EventArgs e)
        {
            Byte[] dataToSend = { 0x54, 0x66, 0x65, 0x00 };
            sendDataToDeckSensor(dataToSend);
        }

        private void BtnQueryZones_Click(object sender, EventArgs e)
        {
            Byte[] dataToSend = { 0x54, 0x66, 0x66, 0x3F };
            sendDataToDeckSensor(dataToSend);
        }

        private void BtnClearSentData_Click(object sender, EventArgs e)
        {
            TxtBoxSentData.Text = "";
        }

        private void BtnClearReceivedData_Click(object sender, EventArgs e)
        {
            TxtBoxReceivedData.Text = "";
        }

        private void sendPreset(int presetToSend)
        {
            if (presetToSend >= 0 && presetToSend < 4)
            {
                Byte byteToSend = BitConverter.GetBytes(presetToSend)[0];
                Byte[] dataToSend = { 0x54, 0x66, 0x64, byteToSend };
                sendDataToDeckSensor(dataToSend);
            }
        }

        private void sendDataToDeckSensor(byte[] dataToSend)
        {
            udpClient.Send(dataToSend, dataToSend.Length, strIpAddress, udpSendPort);
            updateSentData(dataToSend);
        }

        private void parseReceivedData(byte[] dataReceived)
        {
            int dataType = dataReceived[2]; // 0x65(Dec 101)=Preset | 0x6A(Dec 106)=Zone Status

            for (int i = 0; i < dataReceived.Length; i++)
            {
                int byteToSend = dataReceived[i];
                TxtBoxReceivedData.Text += byteToSend.ToString("X2") + " "; // formats text to use 2 char hex
            }
            TxtBoxReceivedData.Text += "\r\n";

           
            switch (dataType)
            {
                case 101: // Preset Status Received - Preset Data has no Unit ID
                    int whichPreset = dataReceived[3];
                    if (presetButtons[whichPreset].Checked == false)
                    {
                        presetButtons[whichPreset].Checked = true;
                    }
                    break;

                case 106: // Zone Status Received
                    if (unitId == dataReceived[5])
                    {
                        int whichZone = dataReceived[11];
                        int statusOfZone = dataReceived[12];
                        switch (statusOfZone)
                        {
                            case 1: // Zone Normal
                                zoneStatusButtons[whichZone].BackColor = Color.Green;
                                break;

                            case 2: // Zone in Alarm
                                zoneStatusButtons[whichZone].BackColor = Color.Red;
                                break;

                            case 99: // Zone in Trouble
                                zoneStatusButtons[whichZone].BackColor = Color.Violet;
                                break;

                            default:
                                break;
                        }
                    }
                    break;

                default:
                    break;
            }
        }

        private void updateSentData(byte[] bytesSent)
        {
            int dataLength = bytesSent.Length;

            for (int i = 0; i < dataLength; i++)
            {
                int byteSent = bytesSent[i];
                TxtBoxSentData.Text += byteSent.ToString("X2") + " ";// formats text to use 2 char hex
            }

            TxtBoxSentData.Text += "\r\n";
        }

        private void BtnStartListening_Click(object sender, EventArgs e)
        {
            // background worker  allows listener to run in its own thread so that it doesn't halt entire program
            if (!backgroundWorker1.IsBusy)
            {
                isListening = true;
                strIpAddress = TxtBoxIpAddress.Text;
                udpListenPort = int.Parse(TxtBoxUdpListenPort.Text);
                udpSendPort = int.Parse(TxtBoxUdpSendPort.Text);
                unitId = int.Parse(TxtBoxUniId.Text);
                backgroundWorker1.RunWorkerAsync(); // starts the background worker
                BtnStartListening.Text = "Listening";
                BtnStartListening.Enabled = false;
                BtnStopListening.Text = "Stop Listening";
                BtnStopListening.Enabled = true;
                BtnStartListening.BackColor = Color.LightGreen;
                BtnQueryPresets.Enabled = true;
                BtnQueryZones.Enabled = true;
                for (int i = 0; i <= 5; i++)
                {
                    zoneStatusButtons[i].Enabled = true;
                }
            }
        }

        private void BtnStopListening_Click(object sender, EventArgs e)
        {
            if (isListening)
            {
                byte[] dataToSend = { 0x54, 0x66, 0x65, 0x00 };
                int byteLength = dataToSend.Length;
                isListening = false;
                backgroundWorker1.CancelAsync(); // stops the backgroundworker
                BtnQueryPresets.Enabled = false;
                BtnQueryZones.Enabled = false;
                BtnStartListening.BackColor = Color.LightGray;
                BtnStartListening.Text = "Start Listening";
                BtnStartListening.Enabled = true;
                BtnStopListening.Text = "Stopped";
                BtnStopListening.Enabled = false;
                for (int i = 0; i <= 5; i++)
                {
                    zoneStatusButtons[i].Enabled = false;
                }
                sendDataToDeckSensor(dataToSend);
            }
        }

        private void TxtBoxIpAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxUdpListenPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxUdpSendPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxUniId_TextChanged(object sender, EventArgs e)
        {

        }

        // creates the UDP listener in its own thread
        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            UdpClient listener = new UdpClient(udpListenPort);
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, udpListenPort);

            while (isListening)
            {
                byte[] recvBytes = listener.Receive(ref groupEP);

                this.Invoke(new MethodInvoker(delegate { parseReceivedData(recvBytes); }));
            }

            listener.Close();
        }

        // this runs when backgroundworker is complete
        private void backgroundWorker1_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
            isListening = false;
            BtnQueryPresets.Enabled = false;
            BtnQueryZones.Enabled = false;
        }
    }
}
