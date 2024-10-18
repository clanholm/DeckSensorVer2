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

        private RadioButton[] presetButtons;
        private Button[] zoneStatusButtons;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            presetButtons = [RadioBtnPreset1, RadioBtnPreset2, RadioBtnPreset3, RadioBtnPreset4];
            zoneStatusButtons = [BtnZone1, BtnZone2, BtnZone3, BtnZone4, BtnZone5, BtnZone6];

            foreach (var presetButton in presetButtons)
            {
                presetButton.Click += PresetButton_Click;
            }
        }

        private void PresetButton_Click(object? sender, EventArgs e)
        {
            RadioButton? clickedRadioBtn = sender as RadioButton;

            int presetBtnIdx = Array.IndexOf(presetButtons, clickedRadioBtn);
            if (presetBtnIdx >= 0)
            {
                if (presetButtons[presetBtnIdx].Checked == true)
                {
                    sendPreset(presetBtnIdx);
                }
            }
            // throw new NotImplementedException();
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
                TxtBoxReceivedData.Text += byteToSend.ToString("X2") + " ";
            }
            TxtBoxReceivedData.Text += "\r\n";

            if (unitId == dataReceived[5])
            {
                switch (dataType)
                {
                    case 101: // Preset Data Received
                        int whichPreset = dataReceived[3];
                        if (presetButtons[whichPreset].Checked == false) ;
                        {
                            presetButtons[whichPreset].Checked = true;
                        }
                        break;

                    case 106: // Zone Status Received
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
                        break;

                    default:
                        break;
                }
            }
        }

        private void updateSentData(byte[] bytesSent)
        {
            int dataLength = bytesSent.Length;

            for (int i = 0; i < dataLength; i++)
            {
                int byteSent = bytesSent[i];
                TxtBoxSentData.Text += byteSent.ToString("X2") + " ";
            }

            TxtBoxSentData.Text += "\r\n";
        }

        private void BtnStartListening_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                isListening = true;
                strIpAddress = TxtBoxIpAddress.Text;
                udpListenPort = int.Parse(TxtBoxUdpListenPort.Text);
                udpSendPort = int.Parse(TxtBoxUdpSendPort.Text);
                unitId = int.Parse(TxtBoxUniId.Text);
                backgroundWorker1.RunWorkerAsync();
                BtnStartListening.Text = "Listening";
                BtnStartListening.Enabled = false;
                BtnStopListening.Text = "Stop Listening";
                BtnStopListening.Enabled = true;
                BtnStartListening.BackColor = Color.LightGreen;
                BtnQueryPresets.Enabled = true;
                BtnQueryZones.Enabled = true;
            }
        }

        private void BtnStopListening_Click(object sender, EventArgs e)
        {
            if (isListening)
            {
                byte[] dataToSend = { 0x54, 0x66, 0x65, 0x00 };
                int byteLength = dataToSend.Length;
                isListening = false;
                backgroundWorker1.CancelAsync();
                BtnQueryPresets.Enabled = false;
                BtnQueryZones.Enabled = false;
                BtnStartListening.BackColor = Color.LightGray;
                BtnStartListening.Text = "Start Listening";
                BtnStartListening.Enabled = true;
                BtnStopListening.Text = "Stopped";
                BtnStopListening.Enabled = false;
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

        private void backgroundWorker1_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
            isListening = false;
            BtnQueryPresets.Enabled = false;
            BtnQueryZones.Enabled = false;
        }
    }
}
