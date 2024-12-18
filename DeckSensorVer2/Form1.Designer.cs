﻿namespace DeckSensorVer2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            GrpBoxCommSettings = new GroupBox();
            TxtBoxUniId = new TextBox();
            TxtBoxUdpSendPort = new TextBox();
            TxtBoxUdpListenPort = new TextBox();
            BtnStopListening = new Button();
            BtnStartListening = new Button();
            LblUnitId = new Label();
            LblUdpPortSend = new Label();
            LblUdpPortListen = new Label();
            LblIpAddress = new Label();
            TxtBoxIpAddress = new TextBox();
            GrpBoxPresets = new GroupBox();
            BtnQueryPresets = new Button();
            RadioBtnPreset4 = new RadioButton();
            RadioBtnPreset3 = new RadioButton();
            RadioBtnPreset2 = new RadioButton();
            RadioBtnPreset1 = new RadioButton();
            GrpBoxZoneStatus = new GroupBox();
            BtnQueryZones = new Button();
            BtnZone6 = new Button();
            BtnZone5 = new Button();
            BtnZone4 = new Button();
            BtnZone3 = new Button();
            BtnZone2 = new Button();
            BtnZone1 = new Button();
            TxtBoxSentData = new TextBox();
            TxtBoxReceivedData = new TextBox();
            LblSentData = new Label();
            LblReceivedData = new Label();
            BtnClearSentData = new Button();
            BtnClearReceivedData = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            BtnSendHeartbeat = new Button();
            TxtBoxHeartbeat = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            toolTipListenPort = new ToolTip(components);
            toolTipSendPort = new ToolTip(components);
            GrpBoxCommSettings.SuspendLayout();
            GrpBoxPresets.SuspendLayout();
            GrpBoxZoneStatus.SuspendLayout();
            SuspendLayout();
            // 
            // GrpBoxCommSettings
            // 
            GrpBoxCommSettings.Controls.Add(TxtBoxUniId);
            GrpBoxCommSettings.Controls.Add(TxtBoxUdpSendPort);
            GrpBoxCommSettings.Controls.Add(TxtBoxUdpListenPort);
            GrpBoxCommSettings.Controls.Add(BtnStopListening);
            GrpBoxCommSettings.Controls.Add(BtnStartListening);
            GrpBoxCommSettings.Controls.Add(LblUnitId);
            GrpBoxCommSettings.Controls.Add(LblUdpPortSend);
            GrpBoxCommSettings.Controls.Add(LblUdpPortListen);
            GrpBoxCommSettings.Controls.Add(LblIpAddress);
            GrpBoxCommSettings.Controls.Add(TxtBoxIpAddress);
            GrpBoxCommSettings.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GrpBoxCommSettings.Location = new Point(12, 12);
            GrpBoxCommSettings.Name = "GrpBoxCommSettings";
            GrpBoxCommSettings.Size = new Size(491, 217);
            GrpBoxCommSettings.TabIndex = 22;
            GrpBoxCommSettings.TabStop = false;
            GrpBoxCommSettings.Text = "Communication Settings";
            // 
            // TxtBoxUniId
            // 
            TxtBoxUniId.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtBoxUniId.Location = new Point(155, 161);
            TxtBoxUniId.Name = "TxtBoxUniId";
            TxtBoxUniId.Size = new Size(171, 30);
            TxtBoxUniId.TabIndex = 3;
            TxtBoxUniId.Text = "7";
            TxtBoxUniId.TextChanged += TxtBoxUniId_TextChanged;
            // 
            // TxtBoxUdpSendPort
            // 
            TxtBoxUdpSendPort.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtBoxUdpSendPort.Location = new Point(155, 122);
            TxtBoxUdpSendPort.Name = "TxtBoxUdpSendPort";
            TxtBoxUdpSendPort.Size = new Size(171, 30);
            TxtBoxUdpSendPort.TabIndex = 2;
            TxtBoxUdpSendPort.Text = "42007";
            toolTipSendPort.SetToolTip(TxtBoxUdpSendPort, "Enter The Port Number of the \"Listen\" Port Set In The Deck Sensor. \r\nValue must be 1-65535");
            TxtBoxUdpSendPort.TextChanged += TxtBoxUdpSendPort_TextChanged;
            TxtBoxUdpSendPort.MouseHover += TxtBoxUdpSendPort_MouseHover;
            // 
            // TxtBoxUdpListenPort
            // 
            TxtBoxUdpListenPort.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtBoxUdpListenPort.Location = new Point(155, 83);
            TxtBoxUdpListenPort.Name = "TxtBoxUdpListenPort";
            TxtBoxUdpListenPort.Size = new Size(171, 30);
            TxtBoxUdpListenPort.TabIndex = 1;
            TxtBoxUdpListenPort.Text = "42507";
            toolTipListenPort.SetToolTip(TxtBoxUdpListenPort, "Enter The Port Number of the \"Target\" Port Set In The Deck Sensor. \r\nValue Must be 1-65535");
            TxtBoxUdpListenPort.TextChanged += TxtBoxUdpListenPort_TextChanged;
            TxtBoxUdpListenPort.MouseHover += TxtBoxUdpListenPort_MouseHover;
            // 
            // BtnStopListening
            // 
            BtnStopListening.Enabled = false;
            BtnStopListening.Location = new Point(343, 126);
            BtnStopListening.Name = "BtnStopListening";
            BtnStopListening.Size = new Size(127, 69);
            BtnStopListening.TabIndex = 5;
            BtnStopListening.Text = "Stop Listening";
            BtnStopListening.UseVisualStyleBackColor = true;
            BtnStopListening.Click += BtnStopListening_Click;
            // 
            // BtnStartListening
            // 
            BtnStartListening.Location = new Point(343, 48);
            BtnStartListening.Name = "BtnStartListening";
            BtnStartListening.Size = new Size(127, 69);
            BtnStartListening.TabIndex = 4;
            BtnStartListening.Text = "Start Listening";
            BtnStartListening.UseVisualStyleBackColor = true;
            BtnStartListening.Click += BtnStartListening_Click;
            // 
            // LblUnitId
            // 
            LblUnitId.AutoSize = true;
            LblUnitId.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblUnitId.Location = new Point(79, 165);
            LblUnitId.Name = "LblUnitId";
            LblUnitId.Size = new Size(70, 23);
            LblUnitId.TabIndex = 4;
            LblUnitId.Text = "Unit ID:";
            LblUnitId.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LblUdpPortSend
            // 
            LblUdpPortSend.AutoSize = true;
            LblUdpPortSend.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblUdpPortSend.Location = new Point(24, 126);
            LblUdpPortSend.Name = "LblUdpPortSend";
            LblUdpPortSend.Size = new Size(125, 23);
            LblUdpPortSend.TabIndex = 3;
            LblUdpPortSend.Text = "UDP Send Port";
            LblUdpPortSend.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LblUdpPortListen
            // 
            LblUdpPortListen.AutoSize = true;
            LblUdpPortListen.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblUdpPortListen.Location = new Point(10, 87);
            LblUdpPortListen.Name = "LblUdpPortListen";
            LblUdpPortListen.Size = new Size(139, 23);
            LblUdpPortListen.TabIndex = 2;
            LblUdpPortListen.Text = "UDP Listen Port:";
            LblUdpPortListen.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LblIpAddress
            // 
            LblIpAddress.AutoSize = true;
            LblIpAddress.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblIpAddress.Location = new Point(50, 48);
            LblIpAddress.Name = "LblIpAddress";
            LblIpAddress.Size = new Size(99, 23);
            LblIpAddress.TabIndex = 1;
            LblIpAddress.Text = "IP Address:";
            LblIpAddress.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TxtBoxIpAddress
            // 
            TxtBoxIpAddress.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtBoxIpAddress.Location = new Point(155, 44);
            TxtBoxIpAddress.Name = "TxtBoxIpAddress";
            TxtBoxIpAddress.Size = new Size(171, 30);
            TxtBoxIpAddress.TabIndex = 0;
            TxtBoxIpAddress.Text = "10.20.78.181";
            TxtBoxIpAddress.TextChanged += TxtBoxIpAddress_TextChanged;
            // 
            // GrpBoxPresets
            // 
            GrpBoxPresets.Controls.Add(BtnQueryPresets);
            GrpBoxPresets.Controls.Add(RadioBtnPreset4);
            GrpBoxPresets.Controls.Add(RadioBtnPreset3);
            GrpBoxPresets.Controls.Add(RadioBtnPreset2);
            GrpBoxPresets.Controls.Add(RadioBtnPreset1);
            GrpBoxPresets.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GrpBoxPresets.Location = new Point(522, 12);
            GrpBoxPresets.Name = "GrpBoxPresets";
            GrpBoxPresets.Size = new Size(266, 217);
            GrpBoxPresets.TabIndex = 23;
            GrpBoxPresets.TabStop = false;
            GrpBoxPresets.Text = "Presets";
            // 
            // BtnQueryPresets
            // 
            BtnQueryPresets.Enabled = false;
            BtnQueryPresets.Location = new Point(120, 70);
            BtnQueryPresets.Name = "BtnQueryPresets";
            BtnQueryPresets.Size = new Size(127, 106);
            BtnQueryPresets.TabIndex = 10;
            BtnQueryPresets.Text = "Get Current Preset";
            BtnQueryPresets.UseVisualStyleBackColor = true;
            BtnQueryPresets.Click += BtnQueryPresets_Click;
            // 
            // RadioBtnPreset4
            // 
            RadioBtnPreset4.AutoSize = true;
            RadioBtnPreset4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RadioBtnPreset4.Location = new Point(20, 163);
            RadioBtnPreset4.Name = "RadioBtnPreset4";
            RadioBtnPreset4.Size = new Size(94, 27);
            RadioBtnPreset4.TabIndex = 9;
            RadioBtnPreset4.TabStop = true;
            RadioBtnPreset4.Text = "Preset 4";
            RadioBtnPreset4.UseVisualStyleBackColor = true;
            // 
            // RadioBtnPreset3
            // 
            RadioBtnPreset3.AutoSize = true;
            RadioBtnPreset3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RadioBtnPreset3.Location = new Point(20, 126);
            RadioBtnPreset3.Name = "RadioBtnPreset3";
            RadioBtnPreset3.Size = new Size(94, 27);
            RadioBtnPreset3.TabIndex = 8;
            RadioBtnPreset3.TabStop = true;
            RadioBtnPreset3.Text = "Preset 3";
            RadioBtnPreset3.UseVisualStyleBackColor = true;
            // 
            // RadioBtnPreset2
            // 
            RadioBtnPreset2.AutoSize = true;
            RadioBtnPreset2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RadioBtnPreset2.Location = new Point(20, 85);
            RadioBtnPreset2.Name = "RadioBtnPreset2";
            RadioBtnPreset2.Size = new Size(94, 27);
            RadioBtnPreset2.TabIndex = 7;
            RadioBtnPreset2.TabStop = true;
            RadioBtnPreset2.Text = "Preset 2";
            RadioBtnPreset2.UseVisualStyleBackColor = true;
            // 
            // RadioBtnPreset1
            // 
            RadioBtnPreset1.AutoSize = true;
            RadioBtnPreset1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RadioBtnPreset1.Location = new Point(20, 48);
            RadioBtnPreset1.Name = "RadioBtnPreset1";
            RadioBtnPreset1.Size = new Size(94, 27);
            RadioBtnPreset1.TabIndex = 6;
            RadioBtnPreset1.TabStop = true;
            RadioBtnPreset1.Text = "Preset 1";
            RadioBtnPreset1.UseVisualStyleBackColor = true;
            // 
            // GrpBoxZoneStatus
            // 
            GrpBoxZoneStatus.Controls.Add(BtnQueryZones);
            GrpBoxZoneStatus.Controls.Add(BtnZone6);
            GrpBoxZoneStatus.Controls.Add(BtnZone5);
            GrpBoxZoneStatus.Controls.Add(BtnZone4);
            GrpBoxZoneStatus.Controls.Add(BtnZone3);
            GrpBoxZoneStatus.Controls.Add(BtnZone2);
            GrpBoxZoneStatus.Controls.Add(BtnZone1);
            GrpBoxZoneStatus.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GrpBoxZoneStatus.Location = new Point(12, 250);
            GrpBoxZoneStatus.Name = "GrpBoxZoneStatus";
            GrpBoxZoneStatus.Size = new Size(776, 230);
            GrpBoxZoneStatus.TabIndex = 2;
            GrpBoxZoneStatus.TabStop = false;
            GrpBoxZoneStatus.Text = "Channel Status";
            // 
            // BtnQueryZones
            // 
            BtnQueryZones.Enabled = false;
            BtnQueryZones.Location = new Point(276, 151);
            BtnQueryZones.Name = "BtnQueryZones";
            BtnQueryZones.Size = new Size(226, 62);
            BtnQueryZones.TabIndex = 11;
            BtnQueryZones.Text = "Get Channel Status";
            BtnQueryZones.UseVisualStyleBackColor = true;
            BtnQueryZones.Click += BtnQueryZones_Click;
            // 
            // BtnZone6
            // 
            BtnZone6.BackColor = Color.LightGray;
            BtnZone6.Enabled = false;
            BtnZone6.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnZone6.ForeColor = SystemColors.ControlText;
            BtnZone6.Location = new Point(654, 35);
            BtnZone6.Name = "BtnZone6";
            BtnZone6.Size = new Size(100, 100);
            BtnZone6.TabIndex = 21;
            BtnZone6.Text = "6";
            BtnZone6.UseVisualStyleBackColor = false;
            // 
            // BtnZone5
            // 
            BtnZone5.BackColor = Color.LightGray;
            BtnZone5.Enabled = false;
            BtnZone5.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnZone5.ForeColor = SystemColors.ControlText;
            BtnZone5.Location = new Point(528, 35);
            BtnZone5.Name = "BtnZone5";
            BtnZone5.Size = new Size(100, 100);
            BtnZone5.TabIndex = 20;
            BtnZone5.Text = "5";
            BtnZone5.UseVisualStyleBackColor = false;
            // 
            // BtnZone4
            // 
            BtnZone4.BackColor = Color.LightGray;
            BtnZone4.Enabled = false;
            BtnZone4.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnZone4.ForeColor = SystemColors.ControlText;
            BtnZone4.Location = new Point(402, 35);
            BtnZone4.Name = "BtnZone4";
            BtnZone4.Size = new Size(100, 100);
            BtnZone4.TabIndex = 19;
            BtnZone4.Text = "4";
            BtnZone4.UseVisualStyleBackColor = false;
            // 
            // BtnZone3
            // 
            BtnZone3.BackColor = Color.LightGray;
            BtnZone3.Enabled = false;
            BtnZone3.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnZone3.ForeColor = SystemColors.ControlText;
            BtnZone3.Location = new Point(276, 35);
            BtnZone3.Name = "BtnZone3";
            BtnZone3.Size = new Size(100, 100);
            BtnZone3.TabIndex = 18;
            BtnZone3.Text = "3";
            BtnZone3.UseVisualStyleBackColor = false;
            // 
            // BtnZone2
            // 
            BtnZone2.BackColor = Color.LightGray;
            BtnZone2.Enabled = false;
            BtnZone2.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnZone2.ForeColor = SystemColors.ControlText;
            BtnZone2.Location = new Point(150, 35);
            BtnZone2.Name = "BtnZone2";
            BtnZone2.Size = new Size(100, 100);
            BtnZone2.TabIndex = 17;
            BtnZone2.Text = "2";
            BtnZone2.UseVisualStyleBackColor = false;
            // 
            // BtnZone1
            // 
            BtnZone1.BackColor = Color.LightGray;
            BtnZone1.Enabled = false;
            BtnZone1.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnZone1.ForeColor = SystemColors.ControlText;
            BtnZone1.Location = new Point(24, 35);
            BtnZone1.Name = "BtnZone1";
            BtnZone1.Size = new Size(100, 100);
            BtnZone1.TabIndex = 16;
            BtnZone1.Text = "1";
            BtnZone1.UseVisualStyleBackColor = false;
            // 
            // TxtBoxSentData
            // 
            TxtBoxSentData.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtBoxSentData.Location = new Point(18, 541);
            TxtBoxSentData.Multiline = true;
            TxtBoxSentData.Name = "TxtBoxSentData";
            TxtBoxSentData.ReadOnly = true;
            TxtBoxSentData.ScrollBars = ScrollBars.Vertical;
            TxtBoxSentData.Size = new Size(230, 327);
            TxtBoxSentData.TabIndex = 14;
            // 
            // TxtBoxReceivedData
            // 
            TxtBoxReceivedData.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtBoxReceivedData.Location = new Point(270, 541);
            TxtBoxReceivedData.Multiline = true;
            TxtBoxReceivedData.Name = "TxtBoxReceivedData";
            TxtBoxReceivedData.ReadOnly = true;
            TxtBoxReceivedData.ScrollBars = ScrollBars.Vertical;
            TxtBoxReceivedData.Size = new Size(518, 327);
            TxtBoxReceivedData.TabIndex = 15;
            // 
            // LblSentData
            // 
            LblSentData.AutoSize = true;
            LblSentData.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblSentData.ImageAlign = ContentAlignment.MiddleLeft;
            LblSentData.Location = new Point(18, 506);
            LblSentData.Name = "LblSentData";
            LblSentData.Size = new Size(166, 29);
            LblSentData.TabIndex = 24;
            LblSentData.Text = "Sent Data (Hex)";
            LblSentData.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblReceivedData
            // 
            LblReceivedData.AutoSize = true;
            LblReceivedData.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblReceivedData.ImageAlign = ContentAlignment.MiddleLeft;
            LblReceivedData.Location = new Point(270, 506);
            LblReceivedData.Name = "LblReceivedData";
            LblReceivedData.Size = new Size(212, 29);
            LblReceivedData.TabIndex = 25;
            LblReceivedData.Text = "Received Data (Hex)";
            LblReceivedData.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnClearSentData
            // 
            BtnClearSentData.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClearSentData.Location = new Point(18, 874);
            BtnClearSentData.Name = "BtnClearSentData";
            BtnClearSentData.Size = new Size(128, 81);
            BtnClearSentData.TabIndex = 12;
            BtnClearSentData.Text = "Clear Sent Data";
            BtnClearSentData.UseVisualStyleBackColor = true;
            BtnClearSentData.Click += BtnClearSentData_Click;
            // 
            // BtnClearReceivedData
            // 
            BtnClearReceivedData.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClearReceivedData.Location = new Point(270, 874);
            BtnClearReceivedData.Name = "BtnClearReceivedData";
            BtnClearReceivedData.Size = new Size(140, 81);
            BtnClearReceivedData.TabIndex = 13;
            BtnClearReceivedData.Text = "Clear Received Data";
            BtnClearReceivedData.UseVisualStyleBackColor = true;
            BtnClearReceivedData.Click += BtnClearReceivedData_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork_1;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted_1;
            // 
            // BtnSendHeartbeat
            // 
            BtnSendHeartbeat.Enabled = false;
            BtnSendHeartbeat.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSendHeartbeat.Location = new Point(478, 874);
            BtnSendHeartbeat.Name = "BtnSendHeartbeat";
            BtnSendHeartbeat.Size = new Size(300, 60);
            BtnSendHeartbeat.TabIndex = 27;
            BtnSendHeartbeat.Text = "Send Heartbeat Request";
            BtnSendHeartbeat.UseVisualStyleBackColor = true;
            BtnSendHeartbeat.Click += BtnSendHeartbeat_Click;
            // 
            // TxtBoxHeartbeat
            // 
            TxtBoxHeartbeat.BackColor = SystemColors.Control;
            TxtBoxHeartbeat.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtBoxHeartbeat.ForeColor = Color.DarkGray;
            TxtBoxHeartbeat.Location = new Point(478, 940);
            TxtBoxHeartbeat.Name = "TxtBoxHeartbeat";
            TxtBoxHeartbeat.ReadOnly = true;
            TxtBoxHeartbeat.Size = new Size(300, 27);
            TxtBoxHeartbeat.TabIndex = 28;
            TxtBoxHeartbeat.Text = "Heartbeat Received will show here.";
            TxtBoxHeartbeat.TextAlign = HorizontalAlignment.Center;
            // 
            // timer1
            // 
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // toolTipListenPort
            // 
            toolTipListenPort.BackColor = Color.FromArgb(255, 192, 128);
            toolTipListenPort.ForeColor = Color.Black;
            // 
            // toolTipSendPort
            // 
            toolTipSendPort.BackColor = Color.FromArgb(255, 192, 128);
            toolTipSendPort.ForeColor = Color.Black;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 967);
            Controls.Add(TxtBoxHeartbeat);
            Controls.Add(BtnSendHeartbeat);
            Controls.Add(BtnClearReceivedData);
            Controls.Add(BtnClearSentData);
            Controls.Add(LblReceivedData);
            Controls.Add(LblSentData);
            Controls.Add(TxtBoxReceivedData);
            Controls.Add(TxtBoxSentData);
            Controls.Add(GrpBoxZoneStatus);
            Controls.Add(GrpBoxPresets);
            Controls.Add(GrpBoxCommSettings);
            Name = "Form1";
            Text = "Deck Sensor Tester Ver 2";
            Load += Form1_Load;
            GrpBoxCommSettings.ResumeLayout(false);
            GrpBoxCommSettings.PerformLayout();
            GrpBoxPresets.ResumeLayout(false);
            GrpBoxPresets.PerformLayout();
            GrpBoxZoneStatus.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GrpBoxCommSettings;
        private TextBox TxtBoxIpAddress;
        private GroupBox GrpBoxPresets;
        private Label LblUnitId;
        private Label LblUdpPortSend;
        private Label LblUdpPortListen;
        private Label LblIpAddress;
        private RadioButton RadioBtnPreset4;
        private RadioButton RadioBtnPreset3;
        private RadioButton RadioBtnPreset2;
        private RadioButton RadioBtnPreset1;
        private Button BtnStopListening;
        private Button BtnStartListening;
        private Button BtnQueryPresets;
        private GroupBox GrpBoxZoneStatus;
        private Button BtnZone1;
        private Button BtnZone6;
        private Button BtnZone5;
        private Button BtnZone4;
        private Button BtnZone3;
        private Button BtnZone2;
        private Button BtnQueryZones;
        private TextBox TxtBoxSentData;
        private TextBox TxtBoxReceivedData;
        private Label LblSentData;
        private Label LblReceivedData;
        private Button BtnClearSentData;
        private Button BtnClearReceivedData;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox TxtBoxUniId;
        private TextBox TxtBoxUdpSendPort;
        private TextBox TxtBoxUdpListenPort;
        private Button BtnSendHeartbeat;
        private TextBox TxtBoxHeartbeat;
        private System.Windows.Forms.Timer timer1;
        private ToolTip toolTipListenPort;
        private ToolTip toolTipSendPort;
    }
}
