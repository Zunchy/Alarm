﻿namespace Alarm
{
    partial class Form2
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
            this.lblWake = new System.Windows.Forms.Label();
            this.btnOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentTime
            // 
            this.currentTime.Size = new System.Drawing.Size(68, 13);
            this.currentTime.Text = "01:18:43 PM";
            // 
            // setAlarm
            // 
            this.setAlarm.Location = new System.Drawing.Point(0, 420);
            this.setAlarm.Size = new System.Drawing.Size(800, 30);
            // 
            // lblWake
            // 
            this.lblWake.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWake.Location = new System.Drawing.Point(133, 9);
            this.lblWake.Name = "lblWake";
            this.lblWake.Size = new System.Drawing.Size(514, 180);
            this.lblWake.TabIndex = 0;
            this.lblWake.Text = "WAKE UP";
            // 
            // btnOff
            // 
            this.btnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOff.Location = new System.Drawing.Point(174, 218);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(407, 107);
            this.btnOff.TabIndex = 1;
            this.btnOff.Text = "TURN OFF ALARM";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.lblWake);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Controls.SetChildIndex(this.lblWake, 0);
            this.Controls.SetChildIndex(this.btnOff, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.amRadio, 0);
            this.Controls.SetChildIndex(this.pmRadio, 0);
            this.Controls.SetChildIndex(this.currentTime, 0);
            this.Controls.SetChildIndex(this.alarmBox, 0);
            this.Controls.SetChildIndex(this.setAlarm, 0);
            this.Controls.SetChildIndex(this.lblAlarmTime, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWake;
        private System.Windows.Forms.Button btnOff;
    }
}