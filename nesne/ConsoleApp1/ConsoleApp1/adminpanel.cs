using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Dapper;

namespace ConsoleApp1
{
    public partial class adminpanel : Form
    {
        public adminpanel()
        {
            InitializeComponent();
        }

        
        private string connectionString = "Data Source=DESKTOP-D6Q3R77\\SQLEXPRESS01;Initial Catalog=NesneTabanlıProgramlama;Integrated Security=True";
        private int KullaniciId;
        

        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var sql = @"select * from kullanici";
                var kullaniciSkorlari = connection.Query<KullaniciModel>(sql).ToList();

               
                dataGridView1.DataSource = kullaniciSkorlari;
            }
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["KullaniciAdi"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Sifre"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["Eposta"].Value.ToString();
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Datagridte tıklanan satırı üstteki textboxlara atar
            KullaniciId = (int)(dataGridView1.Rows[e.RowIndex]?.Cells[3]?.Value); 
            textBox1.Text = dataGridView1.Rows[e.RowIndex]?.Cells[0]?.Value?.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex]?.Cells[1]?.Value?.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex]?.Cells[2]?.Value?.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                //Personel güncelleme işlemleri
                connection.Execute(@"UPDATE 
                    Kullanici 
                    SET 
                        KullaniciAdi = @KullaniciAdi,
                        Sifre = @Sifre,
                        Eposta = @Eposta
                    WHERE
                        ID = @ID
                    ", new
                {
                    KullaniciAdi = textBox1.Text,
                    Sifre = textBox2.Text,
                    Eposta = textBox3.Text,
                    ID = KullaniciId
                });
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(@"delete from Kullanici

                where ID = '" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "'"
             );
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {   // kayıt etme
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(@"
                        INSERT INTO 
                            Kullanici 
                            ([KullaniciAdi], [Sifre], [Eposta]) 
                        VALUES 
                        (@KullaniciAdi, @Sifre, @Eposta)
                    ", new
                {
                    KullaniciAdi = textBox1.Text,
                    Sifre = textBox2.Text,
                    Eposta = textBox3.Text
                });
            }
        }

        private void adminpanel_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login Login = new Login();//açılacak form
            Login.Show(); //form 2 açılıyor.
            Hide(); // Login formunu kapatır
        }

        
    }
}
