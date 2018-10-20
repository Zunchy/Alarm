using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Alarm
{
    public partial class Form2 : Form1
    {


        SoundPlayer music;
        public Form2(SoundPlayer audio)
        {
            InitializeComponent();

            music = audio;
        }

        private void btnOff_Click(object sender, EventArgs e)

        {

            afterMinute.Enabled = false;
          
            
            music.Stop();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            afterMinute.Enabled = false;
            label1.Visible = false;
            alarmBox.Visible = false;
            amRadio.Visible = false;
            pmRadio.Visible = false;
            currentTime.Visible = false;
            lblAlarmTime.Visible = false;
            setAlarm.Visible = false;
            music.Play();
        }
    }
}
