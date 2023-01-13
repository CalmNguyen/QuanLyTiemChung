using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemChung.BUS
{
    class NhanVien
    {
        private string manv;
        private string password;
        public NhanVien(string manv0, string password0)
        {
            this.manv = manv0;
            this.password = password0;
        }
        public string getManv()
        {
            return this.manv;
        }
        public string getPassword()
        {
            return this.password;
        }
        public string layViTri()
        {
            DataTable vitri = DAO.NhanVienDB.layViTri(this);

            if (vitri.Rows.Count == 0)
            {
                return "";
            }
            return vitri.Rows[0]["ViTri"].ToString();
        }
    }
}
