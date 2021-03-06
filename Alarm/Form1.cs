﻿using System;
using Twilio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio.Clients;
using Twilio.Rest.Api.V2010.Account;
using System.Media;
using System.Speech.Synthesis;
using System.IO;

namespace Alarm
{
    public partial class Form1 : Form
    {

        public SoundPlayer audio;
        public SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        public Boolean minute = false;


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");

            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            simpleSound.Play();
        }



        private void currentTimer_Tick(object sender, EventArgs e)
        {
            currentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }


        private void setAlarm_Click(object sender, EventArgs e)
        {

            lblAlarmTime.Text = alarmBox.Text;

            if (amRadio.Checked)
                lblAlarmTime.Text += " AM";
            else
                lblAlarmTime.Text += " PM";

            afterMinute.Enabled = true;

        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {

            if (lblAlarmTime.Text == currentTime.Text)
            {

                int randNum;

                Random rnd = new Random();
                randNum = rnd.Next(1, 9);

                switch (randNum)
                {
                    case 1:
                        audio = new SoundPlayer(Alarm.Properties.Resources.alarm);
                        break;
                    case 2:
                        audio = new SoundPlayer(Alarm.Properties.Resources.alert);
                        break;
                    case 3:
                        audio = new SoundPlayer(Alarm.Properties.Resources.chicken);
                        break;
                    case 4:
                        audio = new SoundPlayer(Alarm.Properties.Resources.church);
                        break;
                    case 5:
                        audio = new SoundPlayer(Alarm.Properties.Resources.dialup);
                        break;
                    case 6:
                        audio = new SoundPlayer(Alarm.Properties.Resources.geese);
                        break;
                    case 7:
                        audio = new SoundPlayer(Alarm.Properties.Resources.siren);
                        break;
                    case 8:
                        audio = new SoundPlayer(Alarm.Properties.Resources.ufo);
                        break;
                }

                audio.PlayLooping();

                btnOff.Visible = true;
                setAlarm.Visible = false;
            }
        }

        private void afterMinute_Tick(object sender, EventArgs e)
        {
            DateTime alarmTime = DateTime.Parse(lblAlarmTime.Text);
            DateTime nowTIme = DateTime.Parse(currentTime.Text);

            TimeSpan difference = nowTIme - alarmTime;

            if (difference.Minutes == 01 && minute == false)
            {

                string AccountSid = "ACde508c15e365dd92a9ad401840e03733";
                string AuthToken = "9a6804457c7d00fd1c1bd15b01c4b193";

                TwilioClient.Init(AccountSid, AuthToken);

                var message = MessageResource.Create(
                body: "This message was sent because I was unable to wake up from my alarm. Yes I am a failure I know. Please call to wake me up.",
                from: new Twilio.Types.PhoneNumber("+14402765334"),
                to: new Twilio.Types.PhoneNumber("+12167744556")
                );

                minute = true;
                audio.Stop();


            } //end if

            if (difference.Minutes >= 02 && minute == true)
            {


                synthesizer.Volume = 100;  // 0...100
                synthesizer.Rate = 5;     // -10...10
                synthesizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);


                synthesizer.SpeakAsync("AAAAAAAAAAAAAAAAAAA WAKE UP AAAAAAAAAAAAAAAAAAAAAAAAAAA WAKE UP AAAAAAAAAAAHHHHHHH");

            }

        }


        private void amRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            afterMinute.Enabled = false;

            audio.Stop();

            synthesizer.Dispose();

            MessageBox.Show("Alarm Stopped");

        }
    }
}