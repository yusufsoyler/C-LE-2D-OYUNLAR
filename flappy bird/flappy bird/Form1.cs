using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy_bird
{
    public partial class Form1 : Form
    {
        //uygulamamızda kullanacagımız değişkenler

        int boruHızı = 8;
        int gravity = 10;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            //borulara carptıgında oyunu bitiren kodlar
            //boru hızını ve yerlerini random atan yerler
            flappyBird.Top += gravity;
            BoruAlt.Left -= boruHızı;
            BoruÜst.Left -= boruHızı;
            label1.Text="Score:" + score;
            if (BoruAlt.Left < -150)
            {
                BoruAlt.Left = 800;
                score++;
            }
            if (BoruÜst.Left < -180)  
            {

                BoruÜst.Left = 950;

                score++;


            }
            //borunun ustunden veya altından gecmemizi belirleyen şartlar
            if(flappyBird.Bounds.IntersectsWith(BoruAlt.Bounds)||flappyBird.Bounds.IntersectsWith(BoruÜst.Bounds)||flappyBird.Bounds.IntersectsWith(Zemin.Bounds))
{

                endGame();  


            }


        }

      private void gamekeyisdone(object sender, KeyEventArgs e)
        {
            

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            //space e bastıgımızda ne kadar yukarı hareket etmesi gerektiğinin belirlendiği yer
            if (e.KeyCode == Keys.Space )
            {
                gravity = 10;
            }
        }
        private void endGame()
        {
            // oyun sonu mesajımızı görüntülüyoruz
            gameTimer.Stop();
            label1.Text = "GAME OVER!!!! :)";
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            //space e her basıldıgında ne kadar assagı düşecegini belirliyoruz
            if(e.KeyCode == Keys.Space)
            {
                gravity = -10 ;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
