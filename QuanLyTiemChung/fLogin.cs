using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyTiemChung
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxUsername.Text.Length==0)
                {
                    MessageBox.Show("Usename không được bỏ trống");
                    return;
                }    
                else if(textBoxPassword.Text.Length==0)
                {
                    MessageBox.Show("Password không được bỏ trống");
                    return;
                }    
                else if (textBoxPassword.Text.Length < 8)
                {
                    MessageBox.Show("Mật khẩu không hợp lệ");
                    return;
                }
                BUS.NhanVien nv = new BUS.NhanVien(textBoxUsername.Text, textBoxPassword.Text);
                string vitri = nv.layViTri();
                if (vitri != "")
                {
                    if (vitri == "Dieu hanh")
                    {
                        fNhanVien_DieuHanh f = new fNhanVien_DieuHanh();
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    else if (vitri == "Y/ Bac si")
                    {
                        fNhanVien_YBacSi f = new fNhanVien_YBacSi(textBoxUsername.Text);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    else if(vitri == "Ke toan")
                    {
                        NVKeToan f = new NVKeToan(textBoxUsername.Text);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }  
                    else if (vitri == "Tiep tan")
                    {
                        fNhanVien_TiepTan f = new fNhanVien_TiepTan(textBoxUsername.Text);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    else if(vitri == "Quan ly")
                    {
                        fQuanLy f = new fQuanLy();
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    } 
                }
                else
                {
                    MessageBox.Show("Username hoặc password không hợp lệ");
                }
            }
            catch
            {
                MessageBox.Show("Username hoặc password không hợp lệ");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
