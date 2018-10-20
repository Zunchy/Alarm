﻿namespace Alarm
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
            this.alarmTimer.Tick += new System.EventHandler(this.alarmTimer_Tick);
            // 
            // setAlarm
            // 
            this.setAlarm.Location = new System.Drawing.Point(117, 88);
            this.setAlarm.Name = "setAlarm";
            this.setAlarm.Size = new System.Drawing.Size(75, 23);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 117);
            this.Controls.Add(this.lblAlarmTime);
            this.Controls.Add(this.setAlarm);
            this.Controls.Add(this.alarmBox);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.pmRadio);
            this.Controls.Add(this.amRadio);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton amRadio;
        private System.Windows.Forms.RadioButton pmRadio;
        private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.Timer currentTimer;
        private System.Windows.Forms.Timer alarmTimer;
        private System.Windows.Forms.Button setAlarm;
        private System.Windows.Forms.Timer timerCheck;
        internal System.Windows.Forms.MaskedTextBox alarmBox;
        private System.Windows.Forms.Label lblAlarmTime;
    }
}