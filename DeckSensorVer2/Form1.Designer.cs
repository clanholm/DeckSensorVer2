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
            GrpBoxCommSettings = new GroupBox();
            GrpBoxPresets = new GroupBox();
            TxtBoxIpAddress = new TextBox();
            LblIpAddress = new Label();
            LblUdpPortListen = new Label();
            LblUdpPortSend = new Label();
            LblUnitId = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            RadioBtnPreset1 = new RadioButton();
            RadioBtnPreset2 = new RadioButton();
            RadioBtnPreset3 = new RadioButton();
            RadioBtnPreset4 = new RadioButton();
            BtnStartListening = new Button();
            BtnStopListening = new Button();
            BtnQueryPresets = new Button();
            GrpBoxZoneStatus = new GroupBox();
            BtnZone1 = new Button();
            BtnZone2 = new Button();
            BtnZone3 = new Button();
            BtnZone4 = new Button();
            BtnZone5 = new Button();
            BtnZone6 = new Button();
            BtnQueryZones = new Button();
            GrpBoxCommSettings.SuspendLayout();
            GrpBoxPresets.SuspendLayout();
            GrpBoxZoneStatus.SuspendLayout();
            SuspendLayout();
            // 
            // GrpBoxCommSettings
            // 
            GrpBoxCommSettings.Controls.Add(BtnStopListening);
            GrpBoxCommSettings.Controls.Add(BtnStartListening);
            GrpBoxCommSettings.Controls.Add(textBox3);
            GrpBoxCommSettings.Controls.Add(textBox2);
            GrpBoxCommSettings.Controls.Add(textBox1);
            GrpBoxCommSettings.Controls.Add(LblUnitId);
            GrpBoxCommSettings.Controls.Add(LblUdpPortSend);
            GrpBoxCommSettings.Controls.Add(LblUdpPortListen);
            GrpBoxCommSettings.Controls.Add(LblIpAddress);
            GrpBoxCommSettings.Controls.Add(TxtBoxIpAddress);
            GrpBoxCommSettings.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GrpBoxCommSettings.Location = new Point(12, 12);
            GrpBoxCommSettings.Name = "GrpBoxCommSettings";
            GrpBoxCommSettings.Size = new Size(491, 217);
            GrpBoxCommSettings.TabIndex = 0;
            GrpBoxCommSettings.TabStop = false;
            GrpBoxCommSettings.Text = "Communication Settings";
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
            GrpBoxPresets.TabIndex = 1;
            GrpBoxPresets.TabStop = false;
            GrpBoxPresets.Text = "Presets";
            // 
            // TxtBoxIpAddress
            // 
            TxtBoxIpAddress.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtBoxIpAddress.Location = new Point(155, 48);
            TxtBoxIpAddress.Name = "TxtBoxIpAddress";
            TxtBoxIpAddress.Size = new Size(171, 30);
            TxtBoxIpAddress.TabIndex = 0;
            TxtBoxIpAddress.Text = "192.168.100.100";
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
            // textBox1
            // 
            textBox1.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(155, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 30);
            textBox1.TabIndex = 5;
            textBox1.Text = "42501";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(155, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 30);
            textBox2.TabIndex = 6;
            textBox2.Text = "42001";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(155, 165);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 30);
            textBox3.TabIndex = 7;
            textBox3.Text = "1";
            // 
            // RadioBtnPreset1
            // 
            RadioBtnPreset1.AutoSize = true;
            RadioBtnPreset1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RadioBtnPreset1.Location = new Point(20, 48);
            RadioBtnPreset1.Name = "RadioBtnPreset1";
            RadioBtnPreset1.Size = new Size(94, 27);
            RadioBtnPreset1.TabIndex = 0;
            RadioBtnPreset1.TabStop = true;
            RadioBtnPreset1.Text = "Preset 1";
            RadioBtnPreset1.UseVisualStyleBackColor = true;
            // 
            // RadioBtnPreset2
            // 
            RadioBtnPreset2.AutoSize = true;
            RadioBtnPreset2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RadioBtnPreset2.Location = new Point(20, 85);
            RadioBtnPreset2.Name = "RadioBtnPreset2";
            RadioBtnPreset2.Size = new Size(94, 27);
            RadioBtnPreset2.TabIndex = 1;
            RadioBtnPreset2.TabStop = true;
            RadioBtnPreset2.Text = "Preset 2";
            RadioBtnPreset2.UseVisualStyleBackColor = true;
            // 
            // RadioBtnPreset3
            // 
            RadioBtnPreset3.AutoSize = true;
            RadioBtnPreset3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RadioBtnPreset3.Location = new Point(20, 126);
            RadioBtnPreset3.Name = "RadioBtnPreset3";
            RadioBtnPreset3.Size = new Size(94, 27);
            RadioBtnPreset3.TabIndex = 2;
            RadioBtnPreset3.TabStop = true;
            RadioBtnPreset3.Text = "Preset 3";
            RadioBtnPreset3.UseVisualStyleBackColor = true;
            // 
            // RadioBtnPreset4
            // 
            RadioBtnPreset4.AutoSize = true;
            RadioBtnPreset4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RadioBtnPreset4.Location = new Point(20, 163);
            RadioBtnPreset4.Name = "RadioBtnPreset4";
            RadioBtnPreset4.Size = new Size(94, 27);
            RadioBtnPreset4.TabIndex = 3;
            RadioBtnPreset4.TabStop = true;
            RadioBtnPreset4.Text = "Preset 4";
            RadioBtnPreset4.UseVisualStyleBackColor = true;
            // 
            // BtnStartListening
            // 
            BtnStartListening.Location = new Point(343, 48);
            BtnStartListening.Name = "BtnStartListening";
            BtnStartListening.Size = new Size(127, 69);
            BtnStartListening.TabIndex = 8;
            BtnStartListening.Text = "Start Listening";
            BtnStartListening.UseVisualStyleBackColor = true;
            // 
            // BtnStopListening
            // 
            BtnStopListening.Enabled = false;
            BtnStopListening.Location = new Point(343, 126);
            BtnStopListening.Name = "BtnStopListening";
            BtnStopListening.Size = new Size(127, 69);
            BtnStopListening.TabIndex = 9;
            BtnStopListening.Text = "Stop Listening";
            BtnStopListening.UseVisualStyleBackColor = true;
            // 
            // BtnQueryPresets
            // 
            BtnQueryPresets.Enabled = false;
            BtnQueryPresets.Location = new Point(120, 70);
            BtnQueryPresets.Name = "BtnQueryPresets";
            BtnQueryPresets.Size = new Size(127, 106);
            BtnQueryPresets.TabIndex = 9;
            BtnQueryPresets.Text = "Get Current Preset";
            BtnQueryPresets.UseVisualStyleBackColor = true;
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
            GrpBoxZoneStatus.Size = new Size(776, 236);
            GrpBoxZoneStatus.TabIndex = 2;
            GrpBoxZoneStatus.TabStop = false;
            GrpBoxZoneStatus.Text = "Channel Status";
            // 
            // BtnZone1
            // 
            BtnZone1.Enabled = false;
            BtnZone1.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnZone1.Location = new Point(24, 35);
            BtnZone1.Name = "BtnZone1";
            BtnZone1.Size = new Size(100, 100);
            BtnZone1.TabIndex = 10;
            BtnZone1.Text = "1";
            BtnZone1.UseVisualStyleBackColor = true;
            // 
            // BtnZone2
            // 
            BtnZone2.Enabled = false;
            BtnZone2.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnZone2.Location = new Point(150, 35);
            BtnZone2.Name = "BtnZone2";
            BtnZone2.Size = new Size(100, 100);
            BtnZone2.TabIndex = 11;
            BtnZone2.Text = "2";
            BtnZone2.UseVisualStyleBackColor = true;
            // 
            // BtnZone3
            // 
            BtnZone3.Enabled = false;
            BtnZone3.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnZone3.Location = new Point(276, 35);
            BtnZone3.Name = "BtnZone3";
            BtnZone3.Size = new Size(100, 100);
            BtnZone3.TabIndex = 12;
            BtnZone3.Text = "3";
            BtnZone3.UseVisualStyleBackColor = true;
            // 
            // BtnZone4
            // 
            BtnZone4.Enabled = false;
            BtnZone4.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnZone4.Location = new Point(402, 35);
            BtnZone4.Name = "BtnZone4";
            BtnZone4.Size = new Size(100, 100);
            BtnZone4.TabIndex = 13;
            BtnZone4.Text = "4";
            BtnZone4.UseVisualStyleBackColor = true;
            // 
            // BtnZone5
            // 
            BtnZone5.Enabled = false;
            BtnZone5.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnZone5.Location = new Point(528, 35);
            BtnZone5.Name = "BtnZone5";
            BtnZone5.Size = new Size(100, 100);
            BtnZone5.TabIndex = 14;
            BtnZone5.Text = "5";
            BtnZone5.UseVisualStyleBackColor = true;
            // 
            // BtnZone6
            // 
            BtnZone6.Enabled = false;
            BtnZone6.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnZone6.Location = new Point(654, 35);
            BtnZone6.Name = "BtnZone6";
            BtnZone6.Size = new Size(100, 100);
            BtnZone6.TabIndex = 15;
            BtnZone6.Text = "6";
            BtnZone6.UseVisualStyleBackColor = true;
            // 
            // BtnQueryZones
            // 
            BtnQueryZones.Location = new Point(24, 156);
            BtnQueryZones.Name = "BtnQueryZones";
            BtnQueryZones.Size = new Size(226, 62);
            BtnQueryZones.TabIndex = 16;
            BtnQueryZones.Text = "Get Channel Status";
            BtnQueryZones.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 884);
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
        }

        #endregion

        private GroupBox GrpBoxCommSettings;
        private TextBox TxtBoxIpAddress;
        private GroupBox GrpBoxPresets;
        private Label LblUnitId;
        private Label LblUdpPortSend;
        private Label LblUdpPortListen;
        private Label LblIpAddress;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
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
    }
}