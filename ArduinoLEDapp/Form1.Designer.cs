namespace ArduinoLEDapp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textboxBlinks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBlink = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonMotorOn = new System.Windows.Forms.Button();
            this.buttonMotorOff = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonReadVoltage = new System.Windows.Forms.Button();
            this.textboxReadVoltage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LedOFF = new System.Windows.Forms.Button();
            this.LedON = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxAvailableComPorts = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textboxBlinks
            // 
            this.textboxBlinks.Location = new System.Drawing.Point(223, 200);
            this.textboxBlinks.Name = "textboxBlinks";
            this.textboxBlinks.Size = new System.Drawing.Size(146, 31);
            this.textboxBlinks.TabIndex = 0;
            this.textboxBlinks.TextChanged += new System.EventHandler(this.textboxBlinks_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arduino GUI";
            // 
            // buttonBlink
            // 
            this.buttonBlink.Location = new System.Drawing.Point(384, 194);
            this.buttonBlink.Name = "buttonBlink";
            this.buttonBlink.Size = new System.Drawing.Size(144, 42);
            this.buttonBlink.TabIndex = 3;
            this.buttonBlink.Text = "Start Blink";
            this.buttonBlink.UseVisualStyleBackColor = true;
            this.buttonBlink.Click += new System.EventHandler(this.buttonBlink_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Servo Motor";
            // 
            // buttonMotorOn
            // 
            this.buttonMotorOn.Location = new System.Drawing.Point(223, 378);
            this.buttonMotorOn.Name = "buttonMotorOn";
            this.buttonMotorOn.Size = new System.Drawing.Size(144, 40);
            this.buttonMotorOn.TabIndex = 5;
            this.buttonMotorOn.Text = "ON";
            this.buttonMotorOn.UseVisualStyleBackColor = true;
            this.buttonMotorOn.Click += new System.EventHandler(this.buttonMotorOn_Click);
            // 
            // buttonMotorOff
            // 
            this.buttonMotorOff.Location = new System.Drawing.Point(384, 378);
            this.buttonMotorOff.Name = "buttonMotorOff";
            this.buttonMotorOff.Size = new System.Drawing.Size(144, 40);
            this.buttonMotorOff.TabIndex = 6;
            this.buttonMotorOff.Text = "OFF";
            this.buttonMotorOff.UseVisualStyleBackColor = true;
            this.buttonMotorOff.Click += new System.EventHandler(this.buttonMotorOff_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Voltage Read";
            // 
            // buttonReadVoltage
            // 
            this.buttonReadVoltage.Location = new System.Drawing.Point(384, 253);
            this.buttonReadVoltage.Name = "buttonReadVoltage";
            this.buttonReadVoltage.Size = new System.Drawing.Size(144, 42);
            this.buttonReadVoltage.TabIndex = 10;
            this.buttonReadVoltage.Text = "Refresh";
            this.buttonReadVoltage.UseVisualStyleBackColor = true;
            this.buttonReadVoltage.Click += new System.EventHandler(this.buttonReadVoltage_Click);
            // 
            // textboxReadVoltage
            // 
            this.textboxReadVoltage.Location = new System.Drawing.Point(223, 259);
            this.textboxReadVoltage.Name = "textboxReadVoltage";
            this.textboxReadVoltage.Size = new System.Drawing.Size(146, 31);
            this.textboxReadVoltage.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "MESSAGES";
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(191, 455);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(378, 31);
            this.messageBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Blink Speed (1 - 3)";
            // 
            // LedOFF
            // 
            this.LedOFF.Location = new System.Drawing.Point(384, 328);
            this.LedOFF.Name = "LedOFF";
            this.LedOFF.Size = new System.Drawing.Size(144, 40);
            this.LedOFF.TabIndex = 17;
            this.LedOFF.Text = "OFF";
            this.LedOFF.UseVisualStyleBackColor = true;
            this.LedOFF.Click += new System.EventHandler(this.LedOFF_Click);
            // 
            // LedON
            // 
            this.LedON.Location = new System.Drawing.Point(223, 328);
            this.LedON.Name = "LedON";
            this.LedON.Size = new System.Drawing.Size(144, 40);
            this.LedON.TabIndex = 18;
            this.LedON.Text = "ON";
            this.LedON.UseVisualStyleBackColor = true;
            this.LedON.Click += new System.EventHandler(this.LedON_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Red LED";
            // 
            // comboBoxAvailableComPorts
            // 
            this.comboBoxAvailableComPorts.FormattingEnabled = true;
            this.comboBoxAvailableComPorts.Location = new System.Drawing.Point(223, 121);
            this.comboBoxAvailableComPorts.Name = "comboBoxAvailableComPorts";
            this.comboBoxAvailableComPorts.Size = new System.Drawing.Size(173, 33);
            this.comboBoxAvailableComPorts.TabIndex = 20;
            this.comboBoxAvailableComPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxAvailableComPorts_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "COM Port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 525);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxAvailableComPorts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LedON);
            this.Controls.Add(this.LedOFF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textboxReadVoltage);
            this.Controls.Add(this.buttonReadVoltage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonMotorOff);
            this.Controls.Add(this.buttonMotorOn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBlink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxBlinks);
            this.Name = "Form1";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxBlinks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBlink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonMotorOn;
        private System.Windows.Forms.Button buttonMotorOff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonReadVoltage;
        private System.Windows.Forms.TextBox textboxReadVoltage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button LedOFF;
        private System.Windows.Forms.Button LedON;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxAvailableComPorts;
        private System.Windows.Forms.Label label7;
    }
}

