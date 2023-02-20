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
    public partial class KullaniciSayfasi : Form
    {
        private string connectionString = "Data Source=DESKTOP-D6Q3R77\\SQLEXPRESS01;Initial Catalog=NesneTabanlıProgramlama;Integrated Security=True";


        public int ID;
        public KullaniciSayfasi()
        {
            InitializeComponent();
        }

        private void KullaniciSayfasi_Load(object sender, EventArgs e)
        {
            
            button2.FlatStyle = FlatStyle.Flat;
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = Color.Tan;
            button2.FlatAppearance.MouseOverBackColor = Color.Tan;

            //top10 listeleme 
            using (var connection = new SqlConnection(connectionString))
            {
                var sql = @"select  top 10 KullaniciAdi,Skor from skor order by skor desc ";
                var kullaniciSkorlari = connection.Query<SkorModel>(sql).ToList();
                foreach (var kullaniciSkor in kullaniciSkorlari)
                {
                    listView1.Items.Add(new ListViewItem(new string[] { kullaniciSkor.KullaniciAdi,kullaniciSkor.Skor.ToString()}));
                }
            }

            // en iyi 5 skorum listeleme
            using (var connection = new SqlConnection(connectionString))
            {
                List<string> names = new List<string> { Login.kullaniciadi };
                var sql = @"select  top 5 KullaniciAdi,Skor,Tarih from skor where KullaniciAdi in @names order by skor desc ";
                var kullaniciSkorlari = connection.Query<SkorModel>(sql, new { names }).ToList();
                foreach (var kullaniciSkor in kullaniciSkorlari)
                {
                    listView2.Items.Add(new ListViewItem(new string[] { kullaniciSkor.KullaniciAdi, kullaniciSkor.Skor.ToString() }));
                }
            }

            


            // aylık 10 listeleme
            
                using (var connection = new SqlConnection(connectionString))
                {

                
                
                    var sql = @"select  top 10 KullaniciAdi,Skor,Tarih from skor where Tarih >= @EndDate and Tarih <= @StartDate   order by skor desc ";
                    var kullaniciSkorlari = connection.Query<SkorModel>(sql,
                        new { 
                            
                            StartDate = DateTime.Now,
                            EndDate   = DateTime.Now.AddMonths(-1)
                        }).ToList();
                    foreach (var kullaniciSkor in kullaniciSkorlari)
                    {
                        listView3.Items.Add(new ListViewItem(new string[] { kullaniciSkor.KullaniciAdi, kullaniciSkor.Tarih.ToString(), kullaniciSkor.Skor.ToString() }));
                    }
                }

            // yıllık skor tablosu
            using (var connection = new SqlConnection(connectionString))
            {
                var sql = @"select  top 10 KullaniciAdi,Skor,Tarih from skor where Tarih >= @EndDate and Tarih <= @StartDate   order by skor desc ";
                var kullaniciSkorlari = connection.Query<SkorModel>(sql,
                    new
                    {
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now.AddYears(-1)
                    }).ToList();
                foreach (var kullaniciSkor in kullaniciSkorlari)
                {
                    listView4.Items.Add(new ListViewItem(new string[] { kullaniciSkor.KullaniciAdi, kullaniciSkor.Tarih.ToString(), kullaniciSkor.Skor.ToString() }));
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Oyun1 Oyun1 = new Oyun1();
            Oyun1.Show(); 
            Hide(); 
        }
       
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
