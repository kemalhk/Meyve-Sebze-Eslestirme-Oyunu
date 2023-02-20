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
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=DESKTOP-D6Q3R77\\SQLEXPRESS01;Initial Catalog=NesneTabanlıProgramlama;Integrated Security=True";



        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            // textbox dolu boş kontrol
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtEposta.Text))
            {
                MessageBox.Show("Alanlar boş geçilemez.");
                return;
            }
            

            KullaniciModel kullanici;
            using (var connection = new SqlConnection(connectionString))
            {
                kullanici = connection.QueryFirstOrDefault<KullaniciModel>("SELECT * FROM Kullanici WHERE KullaniciAdi = @KullaniciAdi AND Eposta = @EPosta", new
                {
                    KullaniciAdi = txtKullaniciAdi.Text,
                    Eposta = txtEposta.Text
                });

                if (kullanici == null)
                {
                    MessageBox.Show("Kullanıcı adı ya da e posta hatalı");
                    return;
                }

                kullanici = connection.QueryFirstOrDefault<KullaniciModel>("SELECT * FROM Kullanici WHERE KullaniciAdi = @Sifre", new
                {
                    Sifre = txtKullaniciAdi.Text
                    
                });


                MailMessage ePosta = new MailMessage();
                SmtpClient istemci = new SmtpClient();
                istemci.Credentials = new System.Net.NetworkCredential("feysithesap@gmail.com", "123456789kemal");
                istemci.Port = 587;
                istemci.Host = "smtp.gmail.com";
                istemci.EnableSsl = true;
                ePosta.To.Add(txtEposta.Text);
                ePosta.From = new MailAddress("feysithesap@gmail.com");
                ePosta.Subject = "Şifre Hatırlatma";
                ePosta.Body = kullanici.Sifre;
                istemci.Send(ePosta);
                MessageBox.Show("Şifreniz mail olarak gönderilmiştir.");
            }
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login Login = new Login();//açılacak form
            Login.Show(); //form 2 açılıyor.
            Hide(); // Login formunu kapatır
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void SifremiUnuttum_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnSifremiUnuttum, "Şifremi Unuttum");
            toolTip1.SetToolTip(button1, "Geri Dönmek için tıklayınız");
            toolTip1.SetToolTip(txtKullaniciAdi, "Kullanıcı Adınızı Giriniz");
            toolTip1.SetToolTip(txtEposta, "E posta adresinizi giriniz");
        }
    }
}
