using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Dapper;
using System.Net;
using System.Net.Mail;


namespace ConsoleApp1
{
    public partial class Kayit : Form
    {

        private string connectionString = "Data Source=DESKTOP-D6Q3R77\\SQLEXPRESS01;Initial Catalog=NesneTabanlıProgramlama;Integrated Security=True";




        public Kayit()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        string onaykodu;
        
        

        private void button2_Click(object sender, EventArgs e)
        {

            Login Login = new Login();//açılacak form
            Login.Show(); //form 2 açılıyor.
            Close(); // Login formunu kapatır
        }

        private void Kayit_Load(object sender, EventArgs e)
        {
            btnOnay.Visible = false;
            lblOnayKodu.Visible = false;
            txtOnay.Visible = false;
            onaykodu = rnd.Next(100) + rnd.Next(100).ToString();


            toolTip1.SetToolTip(btnKayıtOl, "Kayıt Olmak için tıklayınız");
            toolTip1.SetToolTip(btnOnay, "Onaylamak için tıklayınız");
            toolTip1.SetToolTip(button2, "Geri dönmek için tıklayınız");
            toolTip1.SetToolTip(txtEposta, "E postanızı yazınız");
            toolTip1.SetToolTip(txtKullaniciAdiKayıtOl, "Kullanıcı adınızı giriniz");
            toolTip1.SetToolTip(txtOnay, "Onay kodunuzu yazınız");
            toolTip1.SetToolTip(txtSifreKayıtOl, "Şifrenizi Yazınız");

        }

        private void btnKayıtOl_Click(object sender, EventArgs e)

        {

            // textbox dolu boş kontrol
            if (string.IsNullOrEmpty(txtKullaniciAdiKayıtOl.Text) || string.IsNullOrEmpty(txtSifreKayıtOl.Text) || string.IsNullOrEmpty(txtEposta.Text))
            {
                MessageBox.Show("Alanlar boş geçilemez.");
                return;
            }

            // kullanıcı kaydı ekleme işlemleri
            using (var connection = new SqlConnection(connectionString))
            {
                // tekrarlanan kayıt engelleme
                var kullanici = connection.QueryFirstOrDefault<KullaniciModel>("Select * from Kullanici WHERE KullaniciAdi=@KullaniciAdi",
                        new
                        {
                            KullaniciAdi = txtKullaniciAdiKayıtOl.Text
                        });
                if (kullanici != null)
                {
                    MessageBox.Show("aynı Kullanıcı adı ile kullanıcı var");
                    return;
                }

                // aynı kayıt yoksa yeni kayıt ekleme

                //mail doğrulama
                
                MailMessage ePosta = new MailMessage();
                SmtpClient istemci = new SmtpClient();
                istemci.Credentials = new System.Net.NetworkCredential("mrerensen6@gmail.com", "Erensen55.");
                istemci.Port = 587;
                istemci.Host = "smtp.gmail.com";
                istemci.EnableSsl = true;
                ePosta.To.Add(txtEposta.Text);
                ePosta.From = new MailAddress("mrerensen6@gmail.com");
                ePosta.Subject = "Doğrulama Kodu";
                ePosta.Body = onaykodu;
                istemci.Send(ePosta);

                btnKayıtOl.Visible = false;
                btnOnay.Visible = true;
                lblOnayKodu.Visible = true;
                txtOnay.Visible = true;
                

               



                /*  connection.Execute(@"
                          INSERT INTO 
                              Kullanici 
                              ([KullaniciAdi], [Sifre], [Eposta]) 
                          VALUES 
                          (@KullaniciAdi, @Sifre, @Eposta)
                      ", new
                  {
                      KullaniciAdi = txtKullaniciAdiKayıtOl.Text,
                      Sifre = txtSifreKayıtOl.Text,
                      Eposta = txtEposta.Text,
                  });

                  MessageBox.Show("Kayıt İşlemi Başarılı");
                  Login Login = new Login();//açılacak form
                  Login.Show(); //form 2 açılıyor.
                  Close(); // Login formunu kapatır*/
            }
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                if (txtOnay.Text == onaykodu)
                {
                    connection.Execute(@"
                        INSERT INTO 
	                        Kullanici 
	                        ([KullaniciAdi], [Sifre], [Eposta]) 
                        VALUES 
	                    (@KullaniciAdi, @Sifre, @Eposta)
                    ", new
                    {
                        KullaniciAdi = txtKullaniciAdiKayıtOl.Text,
                        Sifre = txtSifreKayıtOl.Text,
                        Eposta = txtEposta.Text,
                    });

                    MessageBox.Show("Kayıt İşlemi Başarılı");
                    Login Login = new Login();//açılacak form
                    Login.Show(); //form 2 açılıyor.
                    this.Hide();
                }
            }
        }

        private void Kayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

