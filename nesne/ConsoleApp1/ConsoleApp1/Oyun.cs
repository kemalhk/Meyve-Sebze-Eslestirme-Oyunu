using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace ConsoleApp1
{
    public partial class Oyun : Form
    {
        public Oyun()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=DESKTOP-D6Q3R77\\SQLEXPRESS01;Initial Catalog=NesneTabanlıProgramlama;Integrated Security=True";





        private List<Label> labels = new List<Label>();
        //int score = Oyun1.score;
        int scoree = Oyun1.score;
        bool d1 = true, d2 = false, d3 = false, d4 = false, bitti = false;

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciSayfasi KullaniciSayfasi = new KullaniciSayfasi();
            KullaniciSayfasi.Show();
            Hide();
        }

        private void Oyun_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Tan;
            button1.FlatAppearance.MouseOverBackColor = Color.Tan;

            // in den sonra sadece label olanlar gelsin diye 
            foreach (Label label in this.Controls.OfType<Label>())
            {
                label.BackColor = System.Drawing.Color.Transparent;
                ControlExtension.Draggable(label, true);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Label label in this.Controls.OfType<Label>())
            {//çakışma varsa doğru 
                if (pictureBox1.Bounds.IntersectsWith(label.Bounds))
                {
                    if (pictureBox1.Tag.ToString() == label.Text)
                    {
                        label.Text = null;
                        label.Visible = false;
                        scoree += 5;
                        label7.Text = scoree.ToString();
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
                if (pictureBox2.Bounds.IntersectsWith(label.Bounds))
                {
                    if (pictureBox2.Tag.ToString() == label.Text)
                    {
                        label.Text = null;
                        label.Visible = false;
                        scoree += 5;
                        label7.Text = scoree.ToString();
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
                        scoree += 5;
                        label7.Text = scoree.ToString();
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
                        scoree += 5;
                        label7.Text = scoree.ToString();
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
                        scoree += 5;
                        label7.Text = scoree.ToString();
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
                // ilk mekan
                this.pictureBox1.Image = Properties.Resources.biber;
                pictureBox1.Tag = "Pepper";
                this.pictureBox2.Image = Properties.Resources.elma;
                pictureBox2.Tag = "Apple";
                this.pictureBox3.Image = Properties.Resources.erik_100_gr_4950;
                pictureBox3.Tag = "Plum";
                this.pictureBox4.Image = Properties.Resources.kiraz;
                pictureBox4.Tag = "Cherry";
                this.pictureBox5.Image = Properties.Resources.kivi;
                pictureBox5.Tag = "Kiwi";
                d1 = false;
                d2 = true;
            }
            else if (string.IsNullOrEmpty(label8.Text) && string.IsNullOrEmpty(label9.Text) && string.IsNullOrEmpty(label10.Text) && string.IsNullOrEmpty(label11.Text) && string.IsNullOrEmpty(label12.Text) && d2)
            {

                this.pictureBox1.Image = Properties.Resources.limon;
                pictureBox1.Tag = "Lemon";
                this.pictureBox2.Image = Properties.Resources.muz;
                pictureBox2.Tag = "Banana";
                this.pictureBox3.Image = Properties.Resources.nar;
                pictureBox3.Tag = "Pomegranate";
                this.pictureBox4.Image = Properties.Resources.portakal;
                pictureBox4.Tag = "Orange";
                this.pictureBox5.Image = Properties.Resources.sarimsak;
                pictureBox5.Tag = "Garlic";
                d2 = false;
                d3 = true;
            }

            else if (string.IsNullOrEmpty(label13.Text) && string.IsNullOrEmpty(label14.Text) && string.IsNullOrEmpty(label15.Text) && string.IsNullOrEmpty(label16.Text) && string.IsNullOrEmpty(label17.Text) && d3)
            {
                this.pictureBox1.Image = Properties.Resources.sogan;
                pictureBox1.Tag = "Onion";
                this.pictureBox2.Image = Properties.Resources.cucumber;
                pictureBox2.Tag = "Cucumber";
                this.pictureBox3.Image = Properties.Resources.pt;
                pictureBox3.Tag = "aubergine";
                this.pictureBox4.Image = Properties.Resources.misir;
                pictureBox4.Tag = "Corn";
                this.pictureBox5.Image = Properties.Resources.kabak;
                pictureBox5.Tag = "Pumpkin";
                d3 = false;
                d4 = true;
            }
            else if (string.IsNullOrEmpty(label18.Text) && string.IsNullOrEmpty(label19.Text) && string.IsNullOrEmpty(label20.Text) && string.IsNullOrEmpty(label21.Text) && string.IsNullOrEmpty(label22.Text) && d4)
            {
                d4 = false;

            }
            else if (bitti)
            {
                return; //bug fix
            }
            else if (!d1 && !d2 && !d3 && !d4)
            {
                timer1.Enabled = false;
                timer1.Stop();
                bitti = true;
                button1.Visible = true;
                button1.Enabled = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                MessageBox.Show("Oyun Bitti");
                using (var connection = new SqlConnection(connectionString))
                {
                            var sqlinsert = @"insert into skor (KullaniciAdi,Skor,Tarih) values (@KullaniciAdi,@Skor,@Tarih)";
                            connection.Execute(sqlinsert, new
                            {
                                KullaniciAdi = Login.kullaniciadi,
                                Skor = label7.Text,
                                Tarih= DateTime.Now
                            });


                }
            }
        }
    }
}

