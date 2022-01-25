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
using System.IO;

namespace araba_yarisi
{

    public partial class Form1 : Form
    {
        Homepage yeni = new Homepage();

        public Form1()
        {
            InitializeComponent();
            
        }

        

        int score = 0;
        int roadspeed = 20;
        int carspeed = 20;

        bool leftside = false;
        bool rightside = false;


        int othercarspeed = 35;

        Random rdn = new Random();

        


        public void startGame()
        {
            


            btn_startAgain.Enabled = false;
            hit.Visible = false;


            lbl_highScore.Text = Settings1.Default.highScore.ToString();


           

            carspeed = 20;
            othercarspeed = 20;
            score = 0;

            mycar.Left = 160;
            mycar.Top = 300;

            car1.Left = 30;
            car1.Top = 50;

            car2.Left = 320;
            car2.Top = 50;

            hit.Left = 165;
            hit.Top = 294;


            leftside = false;
            rightside = false;


            timer1.Start();


        }

        


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startGame();
            openmusic();

        }

        



        private void openmusic()
        {
            SoundPlayer music = new SoundPlayer();
            string musicAddress = Application.StartupPath + "\\WantToBreakFree.wav";
            music.SoundLocation = musicAddress;
            music.Play();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            score++;
            lbl_score.Text = score.ToString();

            road.Top += roadspeed;
            if (road.Top > 400) { road.Top = -100; }

            if (leftside) { mycar.Left -= carspeed; }
            if (rightside) { mycar.Left += carspeed; }

            if (mycar.Left < 1) { leftside = false; }
            else if (mycar.Left + mycar.Width > 510) { rightside = false; }

            car1.Top += carspeed;
            car2.Top += carspeed;

            if (car1.Top > panel1.Height)
            {
                changecar1();
                car1.Left = rdn.Next(20, 170);
                car1.Top = rdn.Next(80, 140) * -1;
            }
            if (car2.Top > panel1.Height)
            {
                changecar2();
                car2.Left = rdn.Next(195, 330);
                car2.Top = rdn.Next(80, 140) * -1;
            }

            if (mycar.Bounds.IntersectsWith(car1.Bounds) || mycar.Bounds.IntersectsWith(car2.Bounds))
            {
                endgame();

            }

        }

        public void changecar1()
        {
            int num = rdn.Next(1, 7);

            switch (num)
            {
                case 1:
                    car1.Image = Properties.Resources.araba5;
                    break;

                case 2:
                    car1.Image = Properties.Resources.araba7;
                    break;

                case 3:
                    car1.Image = Properties.Resources.araba3;
                    break;

                case 4:
                    car1.Image = Properties.Resources.araba4;
                    break;

                case 5:
                    car1.Image = Properties.Resources.araba5;
                    break;

                case 6:
                    car1.Image = Properties.Resources.araba6;
                    break;

                case 7:
                    car1.Image = Properties.Resources.araba7;
                    break;




            }





        }

        public void changecar2()
        {
            int num = rdn.Next(1, 7);

            switch (num)
            {
                case 1:
                    car1.Image = Properties.Resources.araba5;
                    break;

                case 2:
                    car1.Image = Properties.Resources.araba4;
                    break;

                case 3:
                    car1.Image = Properties.Resources.araba3;
                    break;

                case 4:
                    car1.Image = Properties.Resources.araba4;
                    break;

                case 5:
                    car1.Image = Properties.Resources.araba5;
                    break;

                case 6:
                    car1.Image = Properties.Resources.araba6;
                    break;

                case 7:
                    car1.Image = Properties.Resources.araba7;
                    break;




            }





        }


        public void endgame()
        {
            timer1.Stop();

            if (Convert.ToInt32(lbl_score.Text) > Convert.ToInt32(Settings1.Default.highScore.ToString()))
            {
                Settings1.Default.highScore = lbl_score.Text;
            }


            btn_startAgain.Enabled = true;
            hit.Visible = true;
            mycar.Controls.Add(hit);
            hit.Location = new Point(7, -5);
            hit.BringToFront();
            hit.BackColor = Color.Transparent;
            MessageBox.Show("congralations your score :" + lbl_score.Text, "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && mycar.Left > 0) { leftside = true; }
            if (e.KeyCode == Keys.Right && mycar.Left + mycar.Width < panel1.Width) { rightside = true; }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { leftside = false; }
            if (e.KeyCode == Keys.Right) { rightside = false; }
        }

        private void btn_startAgain_Click(object sender, EventArgs e)
        {
            
            startGame();
            
            

        }

        private void lbl_highScore_Click(object sender, EventArgs e)
        {

        }

        
    }


    

}
