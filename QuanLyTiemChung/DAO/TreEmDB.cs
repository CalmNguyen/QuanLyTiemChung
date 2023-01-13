using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemChung.DAO
{
    class TreEmDB
    {
        public static bool themTreEm(BUS.TreEm te)
        {
            using (SqlConnection conn = Connect.Connection())
            {
                conn.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = conn;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT INTO TreEm(MaKH, HoTenNguoiGiamHo, QuanHe, SDTNguoiGiamHo) VALUES (@MaKH, @HoTenNguoiGiamHo, @QuanHe, @SDTNguoiGiamHo)";
                        command.Parameters.AddWithValue("@MaKH", te.getMakh());
                        command.Parameters.AddWithValue("@HoTenNguoiGiamHo", te.getHoTenNguoiGiamHo());
                        command.Parameters.AddWithValue("@QuanHe", te.getQuanHe());
                        command.Parameters.AddWithValue("@SDTNguoiGiamHo", te.getPhoneNguoiGiamHo());

                        command.ExecuteNonQuery();

                    }
                    conn.Close();
                    return true;

                }
                catch
                {
                    conn.Close();
                    return false;
                }
            }
        }
    }
}
