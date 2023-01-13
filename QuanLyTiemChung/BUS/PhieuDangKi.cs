using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemChung.BUS
{
    class PhieuDangKi
    {
        private string mapdk;
        private string ngayLap;
        private string goiVaccine;
        private string ngayTiem;
        private string nvGhiNhan;
        private string makh;

        private static PhieuDangKi instance;
        private PhieuDangKi(string ngayLap0, string goiVaccine0, string ngayTiem0, string nvGhiNhan0, string makh0)
        {
            this.ngayLap = ngayLap0;
            this.goiVaccine = goiVaccine0;
            this.ngayTiem = ngayTiem0;
            this.nvGhiNhan = nvGhiNhan0;
            this.makh = makh0;
            int cnt = 1;
            DataTable dt = DAO.PhieuDangKyDB.layAllPhieuDangKy();
            foreach (DataRow row in dt.Rows)
            {
                cnt++;
            }

            this.mapdk = "PDK" + cnt.ToString();
        }
        public static PhieuDangKi GetPhieuDangKi(string ngayLap0, string goiVaccine0, string ngayTiem0, string nvGhiNhan0, string makh0)
        {
            if (instance != null)
            {
                instance.ngayLap = ngayLap0;
                instance.goiVaccine = goiVaccine0;
                instance.ngayTiem = ngayTiem0;
                instance.nvGhiNhan = nvGhiNhan0;
                instance.makh = makh0;
                int cnt = 1;
                DataTable dt = DAO.PhieuDangKyDB.layAllPhieuDangKy();
                foreach (DataRow row in dt.Rows)
                {
                    cnt++;
                }

                instance.mapdk = "PDK" + cnt.ToString();
            }
            else
            {
                instance = new PhieuDangKi(ngayLap0, goiVaccine0, ngayTiem0, nvGhiNhan0, makh0);
            }
            return instance;
        }
        public string getMapdk()
        {
            return this.mapdk;
        }
        public string getNgayLap()
        {
            return this.ngayLap;
        }
        public string getGoiVaccine()
        {
            return this.goiVaccine;
        }
        public string getNgayTiem()
        {
            return this.ngayTiem;
        }
        public string getNvGhiNhan()
        {
            return this.nvGhiNhan;
        }
        public string getMakh()
        {
            return this.makh;
        }
        public bool themPhieuDangKy()
        {
            return DAO.PhieuDangKyDB.themPhieuDangKy(this);
        }
    }
}
