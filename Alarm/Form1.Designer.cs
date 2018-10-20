namespace Alarm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.amRadio = new System.Windows.Forms.RadioButton();
            this.pmRadio = new System.Windows.Forms.RadioButton();
            this.currentTime = new System.Windows.Forms.Label();
            this.currentTimer = new System.Windows.Forms.Timer(this.components);
            this.alarmBox = new System.Windows.Forms.MaskedTextBox();
            this.alarmTimer = new System.Windows.Forms.Timer(this.components);
            this.setAlarm = new System.Windows.Forms.Button();
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            this.lblAlarmTime = new System.Windows.Forms.Label();
            this.afterMinute = new System.Windows.Forms.Timer(this.components);
            this.speechTimer = new System.Windows.Forms.Timer(this.components);
            this.btnOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set Alarm";
            // 
            // amRadio
            // 
            this.amRadio.AutoSize = true;
            this.amRadio.Location = new System.Drawing.Point(117, 39);
            this.amRadio.Name = "amRadio";
            this.amRadio.Size = new System.Drawing.Size(41, 17);
            this.amRadio.TabIndex = 2;
            this.amRadio.Text = "AM";
            this.amRadio.UseVisualStyleBackColor = true;
            this.amRadio.CheckedChanged += new System.EventHandler(this.amRadio_CheckedChanged);
            // 
            // pmRadio
            // 
            this.pmRadio.AutoSize = true;
            this.pmRadio.Location = new System.Drawing.Point(164, 39);
            this.pmRadio.Name = "pmRadio";
            this.pmRadio.Size = new System.Drawing.Size(41, 17);
            this.pmRadio.TabIndex = 3;
            this.pmRadio.Text = "PM";
            this.pmRadio.UseVisualStyleBackColor = true;
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.Location = new System.Drawing.Point(223, 41);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(35, 13);
            this.currentTime.TabIndex = 4;
            this.currentTime.Text = "label2";
            // 
            // currentTimer
            // 
            this.currentTimer.Enabled = true;
            this.currentTimer.Interval = 999;
            this.currentTimer.Tick += new System.EventHandler(this.currentTimer_Tick);
            // 
            // alarmBox
            // 
            this.alarmBox.Location = new System.Drawing.Point(52, 36);
            this.alarmBox.Mask = "90:00:00";
            this.alarmBox.Name = "alarmBox";
            this.alarmBox.Size = new System.Drawing.Size(49, 20);
            this.alarmBox.TabIndex = 5;
            this.alarmBox.ValidatingType = typeof(System.DateTime);
            // 
            // alarmTimer
            // 
            this.alarmTimer.Enabled = true;
            this.alarmTimer.Interval = 998;
            // 
            // setAlarm
            // 
            this.setAlarm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.setAlarm.Location = new System.Drawing.Point(0, 259);
            this.setAlarm.Name = "setAlarm";
            this.setAlarm.Size = new System.Drawing.Size(502, 30);
            this.setAlarm.TabIndex = 6;
            this.setAlarm.Text = "Set Alarm";
            this.setAlarm.UseVisualStyleBackColor = true;
            this.setAlarm.Click += new System.EventHandler(this.setAlarm_Click);
            // 
            // timerCheck
            // 
            this.timerCheck.Enabled = true;
            this.timerCheck.Interval = 999;
            this.timerCheck.Tick += new System.EventHandler(this.timerCheck_Tick);
            // 
            // lblAlarmTime
            // 
            this.lblAlarmTime.AutoSize = true;
            this.lblAlarmTime.Location = new System.Drawing.Point(49, 71);
            this.lblAlarmTime.Name = "lblAlarmTime";
            this.lblAlarmTime.Size = new System.Drawing.Size(0, 13);
            this.lblAlarmTime.TabIndex = 7;
            // 
            // afterMinute
            // 
            this.afterMinute.Interval = 999;
            this.afterMinute.Tick += new System.EventHandler(this.afterMinute_Tick);
            // 
            // speechTimer
            // 
            this.speechTimer.Enabled = true;
            this.speechTimer.Interval = 999;
            // 
            // btnOff
            // 
            this.btnOff.Image = ((System.Drawing.Image)(resources.GetObject("btnOff.Image")));
            this.btnOff.Location = new System.Drawing.Point(0, 87);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(502, 175);
            this.btnOff.TabIndex = 8;
            this.btnOff.Text = "Stop Alarm";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Visible = false;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 289);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.lblAlarmTime);
            this.Controls.Add(this.setAlarm);
            this.Controls.Add(this.alarmBox);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.pmRadio);
            this.Controls.Add(this.amRadio);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rude Alarm Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer currentTimer;
        private System.Windows.Forms.Timer alarmTimer;
        private System.Windows.Forms.Timer timerCheck;
        public System.Windows.Forms.Timer afterMinute;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton amRadio;
        public System.Windows.Forms.RadioButton pmRadio;
        public System.Windows.Forms.Label currentTime;
        public System.Windows.Forms.Button setAlarm;
        public System.Windows.Forms.MaskedTextBox alarmBox;
        public System.Windows.Forms.Label lblAlarmTime;
        private System.Windows.Forms.Button btnOff;
        public System.Windows.Forms.Timer speechTimer;
    }
}