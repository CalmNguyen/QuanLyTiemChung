using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemChung.DAO
{
    class LichLamViecDB
    {
        public static DataTable layAllLichLamViec()
        {
            string query = "select * from LichLamViec";
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
        public static bool themLichLamViec(BUS.LichLamViec llv)
        {
            using (SqlConnection conn = Connect.Connection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = conn;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT into LichLamViec(MaNV, Ngay, Ca) VALUES (@manv, @ngay, @ca)";
                        command.Parameters.AddWithValue("@manv", llv.getManv());
                        command.Parameters.AddWithValue("@ngay", llv.getNgay());
                        command.Parameters.AddWithValue("@ca", llv.getCa());
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
        public static DataTable layLichLamViecTheoMaNV(string ma)
        {
            string query = "select * from LichLamViec where MaNV = '" + ma + "'";
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
