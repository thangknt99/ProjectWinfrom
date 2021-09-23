using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace PhanMemQLTV
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        string chuoiKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection;
        private SqlCommand myCommand;

        private void DongForm(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        // Phương thức kiểm tra Đk tài khoản
        private int kq = 0;
        private void kTraDK()
        {
            if (txtTenDangNhap.Text.Length > 0 && txtMatKhau.Text.Length > 0)
                kq = 1;
        }

        // Phương thức kiểm tra TKTT
        private int x1 = 0, x2 = 0;
        private void xacThucTKTT()
        {
            myConnection = new SqlConnection(chuoiKetNoi);
            myConnection.Open();
            string strCauTruyVan = "select count(*) from tblThuThu where TenTaiKhoanTT=@acc and MatKhauTT=@pass";
            myCommand = new SqlCommand(strCauTruyVan, myConnection);
            myCommand.Parameters.Add(new SqlParameter("@acc", txtTenDangNhap.Text));
            myCommand.Parameters.Add(new SqlParameter("@pass", txtMatKhau.Text));
            x1 = (int)myCommand.ExecuteScalar();
            myConnection.Close();
        }

        // Phương thức kiểm tra TKDG
        private void xacThucTKDG()
        {
            myConnection = new SqlConnection(chuoiKetNoi);
            myConnection.Open();
            string strCauTruyVan = "select count(*) from tblDocGia where TenTaiKhoanDG=@acc and MatKhauDG=@pass";
            myCommand = new SqlCommand(strCauTruyVan, myConnection);
            myCommand.Parameters.Add(new SqlParameter("@acc", txtTenDangNhap.Text));
            myCommand.Parameters.Add(new SqlParameter("@pass", txtMatKhau.Text));
            x2 = (int)myCommand.ExecuteScalar();
            myConnection.Close();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SaveSettings();
            kTraDK();
            if (kq == 1)
            {
                if (chkQuanTri.Checked)
                {
                    try
                    {
                        xacThucTKTT();
                        if (x1 == 1)
                        {
                            frmGiaoDienChinh GiaoDienChinh = new frmGiaoDienChinh();
                            GiaoDienChinh.FormClosed += new FormClosedEventHandler(DongForm);
                            this.Hide();
                            GiaoDienChinh.Show();
                        }
                        else
                        {
                            MessageBox.Show("Sai Tên Đăng Nhập hoặc Mật Khẩu.\nVui lòng nhập lại.", "Thông Báo");
                            //txtTenDangNhap.Clear();
                            //txtMatKhau.Clear();
                            txtTenDangNhap.Focus();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (chkDocGia.Checked)
                {
                    try
                    {
                        xacThucTKDG();
                        if (x2 == 1)
                        {
                            //MessageBox.Show("ĐG Đăng Nhập thành công.", "Thông Báo");
                            //frmGiaoDienChinh GiaoDienChinh = new frmGiaoDienChinh();
                            //GiaoDienChinh.FormClosed += new FormClosedEventHandler(DongForm);
                            //this.Hide();
                            //GiaoDienChinh.Show();

                            frmDocGia DG = new frmDocGia(txtTenDangNhap.Text);
                            DG.Show();
                        }
                        else
                        {
                            MessageBox.Show("Sai Tên Đăng Nhập hoặc Mật Khẩu.\nVui lòng nhập lại.", "Thông Báo");
                            //txtTenDangNhap.Clear();
                            //txtMatKhau.Clear();
                            txtTenDangNhap.Focus();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            else
                MessageBox.Show("Vui lòng nhập Tài Khoản và Mật Khẩu.", "Thông Báo");
        }
        private void ReadSettings()
        {
            if (Properties.Settings.Default.RememberMe == true)
            {
                txtTenDangNhap.Text = Properties.Settings.Default.UserName;
                txtMatKhau.Text = Properties.Settings.Default.Password;
                ckbRemember.Checked = true;
            }
            else
            {
                txtTenDangNhap.Text = "";
                txtMatKhau.Text = "";
                ckbRemember.Checked = false;
            }
        }
        private void SaveSettings()
        {
            if (ckbRemember.Checked)
            {
                Properties.Settings.Default.UserName = txtTenDangNhap.Text;
                Properties.Settings.Default.Password = txtMatKhau.Text;
                Properties.Settings.Default.RememberMe = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = txtTenDangNhap.Text;
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.RememberMe = false;
                Properties.Settings.Default.Save();
            }
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            chkQuanTri.Checked = true;
            ReadSettings();
        }
    }
}