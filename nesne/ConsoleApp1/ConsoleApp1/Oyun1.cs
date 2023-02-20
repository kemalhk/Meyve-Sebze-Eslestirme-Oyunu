using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;


namespace ConsoleApp1
{
    public partial class Oyun1 : Form
    {
        public Oyun1()
        {
            InitializeComponent();
        }
        
        private List<Label> labels = new List<Label>();
        public static int score = 0;
       
        bool d1 = true, d2 = false, d3 = false, d4 = false, bitti = false;

        private void Oyun1_Load(object sender, EventArgs e)
        {
            btnDigerOyun.Visible = false;
            btnDigerOyun.Enabled = false;
            btnDigerOyun.FlatStyle = FlatStyle.Flat;
            btnDigerOyun.BackColor = Color.Transparent;

            // in den sonra sadece label olanlar gelsin diye 
            foreach (Label label in this.Controls.OfType<Label>())
            {
                label.BackColor = System.Drawing.Color.Transparent;
                ControlExtension.Draggable(label, true);
            }
        }

        private void btnDigerOyun_Click(object sender, EventArgs e)
        {
            Oyun Oyun = new Oyun();
            Oyun.Show();
            Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Label label in this.Controls.OfType<Label>())
            {   //label ile picturebox çakışmasını kontrol ediyor 
                if (pictureBox1.Bounds.IntersectsWith(label.Bounds)) 
                {
                    if (pictureBox1.Tag.ToString() == label.Text) // picturebox dagı ile label aynı ise doğru
                    {
                        label.Text = null;
                        label.Visible = false;
                        score += 5;
                        label7.Text = score.ToString();
                        MessageBox.Show("Doğru Cevap");
                    }
                    else if (!string.IsNullOrEmpty(label.Text))  // label null değilse
                    {
                        label.Text = null;
                        label.Visible = false;
                        MessageBox.Show("Yanlış Cevap");
                    }
                }
                //çakışma varsa doğru 
                if (pictureBox2.Bounds.IntersectsWith(label.Bounds))
                {
                    if (pictureBox2.Tag.ToString() == label.Text)
                    {
                        label.Text = null;
                        label.Visible = false;
                        score += 5;
                        label7.Text = score.ToString();
                        MessageBox.Show("Doğru Cevap");

                    }
                    else if (!string.IsNullOrEmpty(label.Text))

                    {
                        label.Text = null;
                        label.Visible = false;
                        MessageBox.Show("Yanlış Cevap");

                    }
                }
                //çakışma varsa doğru 
                if (pictureBox3.Bounds.IntersectsWith(label.Bounds))
                {
                    if (pictureBox3.Tag.ToString() == label.Text)
                    {
                        label.Text = null;
                        label.Visible = false;
                        score += 5;
                        label7.Text = score.ToString();
                        MessageBox.Show("Doğru Cevap");
                    }
                    else if (!string.IsNullOrEmpty(label.Text))

                    {
                        label.Text = null;
                        label.Visible = false;
                        MessageBox.Show("Yanlış Cevap");
                    }
                }
                //çakışma varsa doğru 
                if (pictureBox4.Bounds.IntersectsWith(label.Bounds))
                {
                    if (pictureBox4.Tag.ToString() == label.Text)
                    {
                        label.Text = null;
                        label.Visible = false;
                        score += 5;
                        label7.Text = score.ToString();
                        MessageBox.Show("Doğru Cevap");

                    }
                    else if (!string.IsNullOrEmpty(label.Text))

                    {
                        label.Text = null;
                        label.Visible = false;
                        MessageBox.Show("Yanlış Cevap");

                    }
                }
                //çakışma varsa doğru 
                if (pictureBox5.Bounds.IntersectsWith(label.Bounds))
                {
                    if (pictureBox5.Tag.ToString() == label.Text)
                    {
                        label.Text = null;
                        label.Visible = false;
                        score += 5;
                        label7.Text = score.ToString();
                        MessageBox.Show("Doğru Cevap");
                    }
                    else if (!string.IsNullOrEmpty(label.Text))
                    {
                        label.Text = null;
                        label.Visible = false;
                        MessageBox.Show("Yanlış Cevap");

                    }
                }
            }
            if (string.IsNullOrEmpty(label1.Text) && string.IsNullOrEmpty(label2.Text) && string.IsNullOrEmpty(label3.Text) && string.IsNullOrEmpty(label4.Text) && string.IsNullOrEmpty(label5.Text) && d1)
            {
                // 2. resimler
                this.pictureBox1.Image = Properties.Resources.biber;
                pictureBox1.Tag = "Biber";
                this.pictureBox2.Image = Properties.Resources.elma;
                pictureBox2.Tag = "Elma";
                this.pictureBox3.Image = Properties.Resources.erik_100_gr_4950;
                pictureBox3.Tag = "Erik";
                this.pictureBox4.Image = Properties.Resources.kiraz;
                pictureBox4.Tag = "Kiraz";
                this.pictureBox5.Image = Properties.Resources.kivi;
                pictureBox5.Tag = "Kivi";
                d1 = false;
                d2 = true;
            }
            else if (string.IsNullOrEmpty(label8.Text) && string.IsNullOrEmpty(label9.Text) && string.IsNullOrEmpty(label10.Text) && string.IsNullOrEmpty(label11.Text) && string.IsNullOrEmpty(label12.Text) && d2)
            {
                //3. resimler
                this.pictureBox1.Image = Properties.Resources.limon;
                pictureBox1.Tag = "Limon";
                this.pictureBox2.Image = Properties.Resources.muz;
                pictureBox2.Tag = "Muz";
                this.pictureBox3.Image = Properties.Resources.nar;
                pictureBox3.Tag = "Nar";
                this.pictureBox4.Image = Properties.Resources.portakal;
                pictureBox4.Tag = "Portakal";
                this.pictureBox5.Image = Properties.Resources.sarimsak;
                pictureBox5.Tag = "Sarımsak";
                d2 = false;
                d3 = true;
            }

            else if (string.IsNullOrEmpty(label13.Text) && string.IsNullOrEmpty(label14.Text) && string.IsNullOrEmpty(label15.Text) && string.IsNullOrEmpty(label16.Text) && string.IsNullOrEmpty(label17.Text) && d3)
            {
                //4.resimler
                this.pictureBox1.Image = Properties.Resources.sogan;
                pictureBox1.Tag = "Soğan";
                this.pictureBox2.Image = Properties.Resources.cucumber;
                pictureBox2.Tag = "Salatalık";
                this.pictureBox3.Image = Properties.Resources.pt;
                pictureBox3.Tag = "Patlıcan";
                this.pictureBox4.Image = Properties.Resources.misir;
                pictureBox4.Tag = "Mısır";
                this.pictureBox5.Image = Properties.Resources.kabak;
                pictureBox5.Tag = "Kabak";
                d3 = false;
                d4 = true;
            }
            else if (string.IsNullOrEmpty(label18.Text) && string.IsNullOrEmpty(label19.Text) && string.IsNullOrEmpty(label20.Text) && string.IsNullOrEmpty(label21.Text) && string.IsNullOrEmpty(label22.Text) && d4)
            {
                d4 = false;

            }
            else if (bitti) // bitti true ise 
            {
                btnDigerOyun.Visible = true;
                btnDigerOyun.Enabled = true;

                return; // program durmadığı için 
            }
            else if (!d1 && !d2 && !d3 && !d4)
            {
                timer1.Enabled = false;
                timer1.Stop();
                bitti = true;
               
            }
        }

        
    }
}
