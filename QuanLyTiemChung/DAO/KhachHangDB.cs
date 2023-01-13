using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemChung.DAO
{
    class KhachHangDB
    {
        public static bool themKhachHang(BUS.KhachHang kh)
        {

            using (SqlConnection conn = Connect.Connection())
            {
                conn.Open();
                try
                {
                    SqlTransaction transaction;
                    using (SqlCommand command = new SqlCommand())
                    {
                        transaction = conn.BeginTransaction();
                        command.Connection = conn;
                        command.Transaction = transaction;
                        
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT INTO KhachHang(MaKH, HoTenKH, NgaySinh, GioiTinh, DiaChi, SDT) VALUES(@MaKH, @HoTenKH, @NgaySinh, @GioiTinh, @DiaChi, @SDT)";
                        command.Parameters.AddWithValue("@MaKH", kh.getMakh());
                        command.Parameters.AddWithValue("@HoTenKH", kh.getHoten());
                        command.Parameters.AddWithValue("@NgaySinh", kh.getNgaySinh());
                        command.Parameters.AddWithValue("@GioiTinh", kh.getGioiTinh());
                        command.Parameters.AddWithValue("@DiaChi", kh.getDiaChi());
                        command.Parameters.AddWithValue("@SDT", kh.getPhone());
                        
                        command.ExecuteNonQuery();
                        transaction.Commit();
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
        public static DataTable layAllKhachHang()
        {
            string query = "select * from KhachHang";
            DataSet data = new DataSet();
            using (SqlConnection conn = Connect.Connection())
            {
                conn.Open();
                SqlDataAdapter adpter = new SqlDataAdapter(query, conn);
                adpter.Fill(data);
                conn.Close();
            }
            return data.Tables[0];
        }
    }
}
