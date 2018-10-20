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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
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

