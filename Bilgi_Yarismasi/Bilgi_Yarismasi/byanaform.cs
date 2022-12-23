using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class byanaform : Form
    {
        public byanaform()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        //��klar�n kar�i�l��� olan butonlar
        private void Btnb_Click(object sender, EventArgs e)
        {
            Btna.Enabled = false;
            Btnb.Enabled = false;
            Btnc.Enabled = false;
            Btnd.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text=Btnb.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanl�s.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        //��klar�n kar�i�l��� olan butonlar
        private void Btnc_Click(object sender, EventArgs e)
        {
            Btna.Enabled = false;
            Btnb.Enabled = false;
            Btnc.Enabled = false;
            Btnd.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = Btnc.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanl�s.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }
        }
        //��klar�n kar�i�l��� olan butonlar
        private void Btnd_Click(object sender, EventArgs e)
        {
            Btna.Enabled = false;
            Btnb.Enabled = false;
            Btnc.Enabled = false;
            Btnd.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = Btnd.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanl�s.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }
        }
        //sonraki sorunun gelmesini saglayan buton
        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            Btna.Enabled = true;
            Btnb.Enabled = true;
            Btnc.Enabled = true;
            Btnd.Enabled = true;
            BtnSonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;


            // sorular buradan geliyor
            soruno++;
            LblSoru.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet Ka� y�l�nda ilan edilmi�tir?";
                Btna.Text = "1923";
                Btnb.Text = "1929";
                Btnc.Text = "1920";
                Btnd.Text = "1930";
                label4.Text = "1923";

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "�skenderun Teknik �niversitesi Ka� Y�l�nda Kurulmu�tur?";
                Btna.Text = "2012";
                Btnb.Text = "2013";
                Btnc.Text = "2015";
                Btnd.Text = "2010";
                label4.Text = "2015";

            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Ortalama �nsan �mr� Ka� Y�ld�r";
                Btna.Text = "73.5";
                Btnb.Text = "75";
                Btnc.Text = "72.3";
                Btnd.Text = "73.2";
                label4.Text = "73.2";

            }
            if(soruno == 4)
            {
                richTextBox1.Text = "K�z Kalesi hangi ilimizdedir";
                Btna.Text = "Hatay";
                Btnb.Text = "Mersin";
                Btnc.Text = "�zmir";
                Btnd.Text = "Ankara";
                label4.Text = "Mersin";
            }
            if(soruno==5)
            {
                richTextBox1.Text = "Yerel se�imler ka� y�lda bir yap�l�r?\r\n\r\n";
                Btna.Text = "5";
                Btnb.Text = "6";
                Btnc.Text = "2";
                Btnd.Text = "3";
                label4.Text = "5";
                BtnSonraki.Text = "SONU�LAR";
            }
            if(soruno==6)
            {
                Btna.Enabled = false;
                Btnb.Enabled = false;
                Btnc.Enabled = false;
                Btnd.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Do�ru:" + dogru + "\n" + "Yanl��" + yanlis);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //��klar�n kar�i�l��� olan butonlar
        private void Btna_Click(object sender, EventArgs e)
        {
            Btna.Enabled = false;   
            Btnb.Enabled = false;
            Btnc.Enabled = false;
            Btnd.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = Btna.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text=dogru.ToString();
                pictureBox1.Visible=true;   
            }
            else
            {
                yanlis++;
                LblYanl�s.Text = yanlis.ToString();
                pictureBox2.Visible=true;   

            }
        }

   
    }
}