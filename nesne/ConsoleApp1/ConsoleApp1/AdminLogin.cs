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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        AdminModel admin;
        private string connectionString = "Data Source=DESKTOP-D6Q3R77\\SQLEXPRESS01;Initial Catalog=NesneTabanlıProgramlama;Integrated Security=True";

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                admin = connection.QueryFirstOrDefault<AdminModel>("SELECT * FROM Admin WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre", new
                {
                    KullaniciAdi = txtKullaniciAdi.Text,
                    Sifre = txtSifre.Text
                });

                if (admin == null)
                {
                    MessageBox.Show("Kullanıcı adı ya da şifre yanlış.");
                    return;
                }
            }
            if (admin.KullaniciAdi != null)
            {
                adminpanel Admin = new adminpanel();//açılacak form
                Admin.Show(); //form 2 açılıyor.
                Hide(); // Login formunu kapatır
            }
        }
    }
}
