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
using Twilio;
using Twilio.Rest.Api.V2010.Account;
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
            currentTimer.Enabled=false;
            
            music.Stop();
            MessageBox.Show("ARISE MY SON");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            alarmBox.Visible = false;
            amRadio.Visible = false;
            pmRadio.Visible = false;
            currentTime.Visible = false;
            lblAlarmTime.Visible = false;
            setAlarm.Visible = false;
            music.Play();
        }

        private void afterMinute_Tick(object sender, EventArgs e)
        {
            DateTime alarmTime = DateTime.Parse(lblAlarmTime.Text);
            DateTime nowTIme = DateTime.Parse(currentTime.Text);

            Boolean minute = false;
            TimeSpan difference = nowTIme - alarmTime;
            if (difference.Minutes == 01 && minute == false)
            {


                string AccountSid = "ACde508c15e365dd92a9ad401840e03733";
                string AuthToken = "9a6804457c7d00fd1c1bd15b01c4b193";

                TwilioClient.Init(AccountSid, AuthToken);

                var message = MessageResource.Create(
                body: "Call me to wake me up.",
                from: new Twilio.Types.PhoneNumber("+14402765334"),
                to: new Twilio.Types.PhoneNumber("+12167744556")
            );
                minute = true;
                audio.Stop();
                afterMinute.Enabled = false;
            } //end if




        }
    }
}
