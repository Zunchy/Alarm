using System;
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

namespace Alarm
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            // Find your Account Sid and Auth Token at twilio.com/user/account
            string AccountSid = "ACde508c15e365dd92a9ad401840e03733";
            string AuthToken = "9a6804457c7d00fd1c1bd15b01c4b193";

            TwilioClient.Init(AccountSid, AuthToken);

            var message = MessageResource.Create(
            body: "Call me to wake me up.",
            from: new Twilio.Types.PhoneNumber("+14402765334"),
            to: new Twilio.Types.PhoneNumber("+12167744556")
        );

            Console.WriteLine(message.Sid);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");

            
        }



        private void currentTimer_Tick(object sender, EventArgs e)
        {
            currentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void alarmTimer_Tick(object sender, EventArgs e)
        {

        }

        private void setAlarm_Click(object sender, EventArgs e)
        {

            lblAlarmTime.Text = alarmBox.Text;

            if (amRadio.Checked)
                lblAlarmTime.Text += " AM";
            else
                lblAlarmTime.Text += " PM";



        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {

            if (lblAlarmTime.Text == currentTime.Text)
                MessageBox.Show("Yo dawg wake yo stanky ass up");
        }
    }
}