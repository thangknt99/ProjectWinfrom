
using PhanMemQLTV.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQLTV
{
    public partial class frmReportReviewHDMuonSach : Form
    {
        
        public frmReportReviewHDMuonSach()
        {
            InitializeComponent();
           
        }

        string chuoiKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection;
        private SqlCommand myCommand;
        private void rptViewer_Load(object sender, EventArgs e)
        {
            myConnection = new SqlConnection(chuoiKetNoi);
            myConnection.Open();

            //myCommand = new SqlCommand("Sp_QlMuonTra", myConnection);
            //myCommand.CommandType = CommandType.StoredProcedure;

            string strCauTruyVanHDMuonSach = "SELECT d.TenDG,d.SDTDG,s.TenSach,s.TinhTrang,s.Ghichu,p.NgayMuon,p.NgayTra FROM tblHSPhieuMuon p INNER JOIN tblDocGia d on p.MaDG = d.MaDG INNER JOIN tblSach s on p.MaSach = s.MaSach";
            
            myCommand = new SqlCommand(strCauTruyVanHDMuonSach, myConnection);
            
            List<HDMuonSachModel> dataList = new List<HDMuonSachModel>();
            SqlDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                var obj = new HDMuonSachModel();
                obj.TenDG = reader[0] != null ? reader[0].ToString() : "";
                obj.SDTDG = reader[1] != null ? reader[1].ToString() : "";
                obj.NgaySinhDG = reader[2] != null ? reader[2].ToString() : "";
                obj.TenSach = reader[3] != null ? reader[3].ToString() : "";
                obj.ChuDe = reader[4] != null ? reader[4].ToString() : "";
                obj.TinhTrang = reader[5] != null ? reader[5].ToString() : "";
                obj.Ghichu = reader[6] != null ? reader[6].ToString() : "";
                obj.NgayMuon = reader[7] != null ? reader[7].ToString() : "";
                obj.NgayTra = reader[8] != null ? reader[8].ToString() : "";
                dataList.Add(obj);
            }
            ReportHDMuonSach rp = new ReportHDMuonSach();
            rp.SetDataSource(dataList);
            rptViewer.ReportSource = rp;
            rptViewer.Show();
        }

        private void frmReportReviewHDMuonSach_Load(object sender, EventArgs e)
        {

        }
    }
}
