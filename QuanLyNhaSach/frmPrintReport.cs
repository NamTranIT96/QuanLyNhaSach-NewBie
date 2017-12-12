using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BusinessEntities.Repositories;
namespace QuanLyNhaSach
{
    public partial class frmPrintReport : DevExpress.XtraEditors.XtraForm
    {
        public frmPrintReport()
        {
            InitializeComponent();
        }
        public void PrintHoaDonBanHang(string chiNhanh, string tenCuaHang, string dienThoaiCuaHang, DateTime ngayBan, 
            string maHoaDon, string tenKhachHang, string diaChiKhachHang, string dienThoaiKhachHang, 
            string tenNguoiBan, List<HangHoaTempRepositories> listHangHoa, double chietKhau, double tongCong)
        {
            frmReport_HoaDonBanHang frmReportHoaDonBanHang = new frmReport_HoaDonBanHang();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in frmReportHoaDonBanHang.Parameters)
                p.Visible = false;
            frmReportHoaDonBanHang.initData(chiNhanh, tenCuaHang, dienThoaiCuaHang, ngayBan, maHoaDon, tenKhachHang,
                diaChiKhachHang, dienThoaiKhachHang, tenNguoiBan, listHangHoa, chietKhau, tongCong);
            documentViewer1.DocumentSource = frmReportHoaDonBanHang;
            frmReportHoaDonBanHang.CreateDocument();
        }
    }
}