using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemChung.DAO
{
    class Connect
    {
        public static SqlConnection Connection()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DT03IGN;Initial Catalog=QuanLytiemChung;Integrated Security=True");
            return conn;
        }
    }
}
