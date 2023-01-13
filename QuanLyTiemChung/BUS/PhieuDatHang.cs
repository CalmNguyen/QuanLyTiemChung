using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemChung.BUS
{
    class PhieuDatHang
    {
        private string maPDH;
        private string soLuongDatMua;
        private string nhaCungCap;
        private string tenVaccine;

        public PhieuDatHang(string soLuongDatMua0, string nhaCungCap0, string tenVaccine0)
        {
            this.soLuongDatMua = soLuongDatMua0;
            this.nhaCungCap = nhaCungCap0;
            this.tenVaccine = tenVaccine0;
            int cnt = 1;

            DataTable dt = DAO.PhieuDatHangDB.layAllPhieuDatHang();
            foreach (DataRow row in dt.Rows)
            {
                cnt++;
            }
            this.maPDH = "PDH" + cnt.ToString();
        }

        public string getMaPDH()
        {
            return this.maPDH;
        }
        
        public string getSoLuongDatMua()
        {
            return this.soLuongDatMua;
        }
        public string getNhaCungCap()
        {
            return this.nhaCungCap;
        }
        public string getTenVaccine()
        {
            return this.tenVaccine;
        }
        public static DataTable layAllPhieuDatHang()
        {
            return DAO.PhieuDatHangDB.layAllPhieuDatHang();
        }

        public bool ThemPDH()
        {
            return DAO.PhieuDatHangDB.ThemPDH(this);
           
        }
    }
}
