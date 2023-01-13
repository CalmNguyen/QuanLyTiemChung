using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemChung.DAO
{
    class LichRanhDB
    {
        public static DataTable layLichRanhTheoMaNV(string ma)
        {
            string query = "select * from LichRanh where MaNV = '" + ma + "'";
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

        public static bool themLichRanh(BUS.LichRanh lr)
        {
            using (SqlConnection conn = Connect.Connection())
            {
                conn.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = conn;            // <== lacking
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT into LichRanh(MaNV, Ngay, Ca) VALUES (@manv, @ngay, @ca)";
                        command.Parameters.AddWithValue("@manv", lr.getManv());
                        command.Parameters.AddWithValue("@ngay", lr.getNgay());
                        command.Parameters.AddWithValue("@ca", lr.getCa());
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
        public static DataTable layAllLichRanh()
        {
            string query = "select * from LichRanh";
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

        
        public static bool xoaLichRanh(BUS.LichRanh lr)
        {
            using (SqlConnection conn = Connect.Connection())
            {
                try
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.DeleteCommand = new SqlCommand("delete from LichRanh where MaNV = '" + lr.getManv() + "' and Ngay = '" + lr.getNgay() + "' and Ca = N'" + lr.getCa() + "'", conn);
                        da.DeleteCommand.ExecuteNonQuery();

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
