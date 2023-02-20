using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace ConsoleApp1
{
    public partial class Iletisim : Form
    {
        public Iletisim()
        {
            InitializeComponent();
        }
        string epostaa= "feysithesap@gmail.com";
        private void btnGonder_Click(object sender, EventArgs e)
        {
            MailMessage ePosta = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("feysithesap@gmail.com", "123456789kemal");
            istemci.Port = 587;
            istemci.Host = "smtp.gmail.com";
            istemci.EnableSsl = true;
            ePosta.To.Add(epostaa);
            ePosta.From = new MailAddress("feysithesap@gmail.com");
            ePosta.Subject = txtKonu.Text;
            ePosta.Body = richTextBox1.Text +"\n "+txtMailAdresi.Text;
            istemci.Send(ePosta);
            MessageBox.Show("Mesajınız iletilmiştir .");
        }

        private void Iletisim_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            Login Login = new Login();//açılacak form
            Login.Show(); 
            Hide(); // Login formunu kapatır
        }

        private void Iletisim_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtAd, "Adınızı Girin");
            toolTip1.SetToolTip(txtKonu, "Konuyu Giriniz");
            toolTip1.SetToolTip(txtMailAdresi, "Mail Adresinizi Giriniz");
            toolTip1.SetToolTip(richTextBox1, "Şikayet / Önerinizi Yazınız");
            toolTip1.SetToolTip(btnGeriDon, "Geri dönmek için tıklayınız");
            toolTip1.SetToolTip(btnGonder, "Göndermek için tıklayınız");
        }
    }
}
