using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-S657VTM\\SQLEXPRESS;Initial Catalog=demoFormaoo;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }
    }
}
