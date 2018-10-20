using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm
{
    public partial class Form2 : Form
    {

        SoundPlayer music;
        public Form2(SoundPlayer audio)
        {
            InitializeComponent();

            music = audio;
        }

        private void btnOff_Click(object sender, EventArgs e)

        {
            music.Stop();
            
        }
    }
}
