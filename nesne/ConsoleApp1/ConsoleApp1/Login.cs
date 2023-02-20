using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;

namespace ConsoleApp1
{
    public partial class Login : Form
    {
        private string connectionString = "Data Source=DESKTOP-D6Q3R77\\SQLEXPRESS01;Initial Catalog=NesneTabanlıProgramlama;Integrated Security=True";


        public Login()
        {
            InitializeComponent();
            RememberMe();
        }
        // beni hatırla özelliği
        private void RememberMe()
        {
            if (Properties.Settings.Default.KullaniciAdi != string.Empty)
            {
                if (Properties.Settings.Default.Remember == true)
                {
                    txtKullaniciAdi.Text = Properties.Settings.Default.KullaniciAdi;
                    txtSifre.Text = Properties.Settings.Default.Sifre;
                    Remember.Checked = true;
                }
                else
                {
                    txtKullaniciAdi.Text = Properties.Settings.Default.KullaniciAdi;

                }

            }
        }
        private void Save_remember()
        {
            if (Remember.Checked)
            {
                Properties.Settings.Default.KullaniciAdi = txtKullaniciAdi.Text;
                Properties.Settings.Default.Sifre = txtSifre.Text;
                Properties.Settings.Default.Remember = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.KullaniciAdi = null;
                Properties.Settings.Default.Sifre = null;
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Save();
            }
        }




        public static string kullaniciadi;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            KullaniciModel kullanici;
            // textboxl dolu boş kontrol
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Alanlar boş geçilemez.");
                return;
            }

            using (var connection = new SqlConnection(connectionString))
            {
                kullanici = connection.QueryFirstOrDefault<KullaniciModel>("SELECT * FROM Kullanici WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre", new
                {
                    KullaniciAdi = txtKullaniciAdi.Text,
                    Sifre = txtSifre.Text
                });
                
                

                if (kullanici == null)
                {
                    MessageBox.Show("Kullanıcı adı ya da şifre yanlış.");
                    return;
                }
                
            }
            if (kullanici.KullaniciAdi != null)
            {
                kullaniciadi = kullanici.KullaniciAdi;
                MessageBox.Show("Giriş Başarılı");
                Save_remember();
                KullaniciSayfasi KullaniciSayfasi = new KullaniciSayfasi();//açılacak form
                KullaniciSayfasi.Show(); //form 2 açılıyor.
                Hide(); // Login formunu kapatır
            }
            
            

        }
        
        private void lnklblKayıtOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kayit kayit = new Kayit();//açılacak form
            kayit.Show(); //form 2 açılıyor.
            Hide(); // Login formunu kapatır
        }

        private void Remember_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lnklblSifreUnuttm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum SifremiUnuttum = new SifremiUnuttum();//açılacak form
            SifremiUnuttum.Show(); 
            Hide(); 
        }

        private void btnIletisim_Click(object sender, EventArgs e)
        {
            Iletisim Iletisim = new Iletisim();//açılacak form
            Iletisim.Show();
            Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtKullaniciAdi, "Kullacı Adınızı Giriniz");
            toolTip1.SetToolTip(txtSifre, "Şifrenizi Giriniz");
            toolTip1.SetToolTip(btnGiris, "Giriş Yapmak için tıklayınız");
            toolTip1.SetToolTip(lnklblKayıtOl, "Kayıt olmak için tıklayınız");
            toolTip1.SetToolTip(lnklblSifreUnuttm, "Şifrenizi unuttuysanız tıklayın");
            toolTip1.SetToolTip(btnIletisim, "İletişim sayfasını açmak için tıklayınız");
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminLogin AdminLogin = new AdminLogin();//açılacak form
            AdminLogin.Show(); //form 2 açılıyor.
            Hide(); // Login formunu kapatır
        }
    }
}
