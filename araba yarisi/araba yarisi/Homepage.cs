using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace araba_yarisi
{
    public partial class Homepage : Form 
    {
        public Homepage()
        {
            InitializeComponent();
        }



        private void Homepage_Load(object sender, EventArgs e)
        {
            openmusic();
        }

        private void openmusic()
        {
            SoundPlayer music = new SoundPlayer();
            string musicAddress = Application.StartupPath + "\\BasGaza.wav";
            music.SoundLocation = musicAddress;
            music.Play();
        }


        private void btn_homestart_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();

        }
    }
}
