using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TextmagicRest;
using TextmagicRest.Model;

namespace Alarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");

            //    var message = new MailMessage();
            //    message.From = new MailAddress("ragected@gmail.com");

            //    message.To.Add(new MailAddress("2167744556@vmobl.com"));//See carrier destinations below
            //                                                            //message.To.Add(new MailAddress("5551234568@txt.att.net"));

            //    //message.CC.Add(new MailAddress("carboncopy@foo.bar.com"));
            //    message.Subject = "This is my subject";
            //    message.Body = "This is the content";

            //    var client = new SmtpClient("google.com");
            //    client.Send(message);

            var client = new Client("test", "my-api-key");
            var link = client.SendMessage("Hello from TextMagic API", "+12167744556");
            if (link.Success)
            {
                Console.WriteLine("Message ID {0} has been successfully sent", link.Id);
            }
            else
            {
                Console.WriteLine("Message was not sent due to following exception: {0}", link.ClientException.Message);
          }
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