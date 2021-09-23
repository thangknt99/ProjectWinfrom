using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQLTV
{
    public partial class frmGiaoDienChinh : Form
    {
        public frmGiaoDienChinh()
        {
            InitializeComponent();
        }

        private void mnuquanlysach_Click(object sender, EventArgs e)
        {
            frmQLSach QLSach = new frmQLSach();
            QLSach.Show();
        }

        private void mnuquanlydocgia_Click(object sender, EventArgs e)
        {
            frmQLDocGia QLDocGia = new frmQLDocGia();
            QLDocGia.Show();
        }

        private void mnuquanlymuontra_Click(object sender, EventArgs e)
        {
            frmQLMuonTra QLMuonTra = new frmQLMuonTra();
            QLMuonTra.Show();
        }

        private void mnuthongkebaocao_Click(object sender, EventArgs e)
        {
            frmBaoCaoThongKe BaoCaoThongKe = new frmBaoCaoThongKe();
            BaoCaoThongKe.Show();
        }

        

        private void frmGiaoDienChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn thoát.", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void mnudangky_Click(object sender, EventArgs e)
        {
            frmDangKyTT DKTT = new frmDangKyTT();
            DKTT.Show();
        }

        private void mnudoimatkhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau DoiMKTT = new frmDoiMatKhau();
            DoiMKTT.Show();
        }

        private void mnudx_Click(object sender, EventArgs e)
        {
            const string message = "Bạn có muốn đăng xuất không?";
            const string caption = "Hệ thống";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmGiaoDienChinh giaodienchinh = new frmGiaoDienChinh();
                giaodienchinh.Close();
                giaodienchinh.Dispose();
                frmDangNhap dangnhap = new frmDangNhap();
                this.Hide();
                dangnhap.Closed += (s, args) => this.Close();
                dangnhap.Show();
            }
            else
            {
                this.Close();
            }

        }
    }
}
