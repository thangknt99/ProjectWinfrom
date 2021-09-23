using PhanMemQLTV.Reports;
using System;

using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PhanMemQLTV
{
    public partial class frmReportViewerBaoCaoThongKe : Form
    {
        public frmReportViewerBaoCaoThongKe()
        {
            InitializeComponent();
        }
        string chuoiKetNoi = ConfigurationManager.ConnectionStrings["strConn"].ConnectionString;
        private SqlConnection myConnection;
        private SqlCommand myCommand;
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            myConnection = new SqlConnection(chuoiKetNoi);
            myConnection.Open();

            //myCommand = new SqlCommand("Sp_BCTK", myConnection);
            //myCommand.CommandType = CommandType.StoredProcedure;

            string strCauTruyVanKhoSach = "select s.TenSach,s.ChuDe,sum(SLNhap) as TongSach, sum(DonGia) as TongGiaTriSach from tblSach s group by s.TenSach, s.ChuDe";

            myCommand = new SqlCommand(strCauTruyVanKhoSach, myConnection);

            List<BaoCaoThongKeKhoSachModel> dataList = new List<BaoCaoThongKeKhoSachModel>();
            SqlDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                var obj = new BaoCaoThongKeKhoSachModel();
                obj.TenSach = reader[0] != null ? reader[0].ToString() : "";
                obj.ChuDe = reader[1] != null ? reader[1].ToString() : "";
                obj.TongSach = int.Parse(reader[2].ToString());
                obj.TongGiaTriSach = int.Parse(reader[3].ToString());

                dataList.Add(obj);
            }
            CrystalReport1 cr = new CrystalReport1();
            cr.SetDataSource(dataList);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Show();
           
        }
    }
    
}
