using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using BusinessEntities.Repositories;
namespace QuanLyNhaSach
{
    public partial class frmReport_HoaDonBanHang : DevExpress.XtraReports.UI.XtraReport
    {
        public frmReport_HoaDonBanHang()
        {
            InitializeComponent();
        }
        public void initData(string chiNhanh, string tenCuaHang, string dienThoaiCuaHang, DateTime ngayBan, string maHoaDon,
            string tenKhachHang, string diaChiKhachHang, string dienThoaiKhachHang, string tenNguoiBan,
            List<HangHoaTempRepositories> listHangHoa, double chietKhau, double tongCong)
        {
            pChiNhanh.Value = chiNhanh;
            pTenCuaHang.Value = tenCuaHang;
            pDienThoaiChiNhanh.Value = dienThoaiCuaHang;
            pNgayBan.Value = ngayBan;
            pMaHoaDon.Value = maHoaDon;
            pKhachHang.Value = tenKhachHang;
            pDiaChiKhachHang.Value = diaChiKhachHang;
            pDienThoaiKhachHang.Value = dienThoaiKhachHang;
            pNguoiBan.Value = tenNguoiBan;
            pChietKhau.Value = chietKhau;
            pTongCong.Value = tongCong;
            objectDataSource1.DataSource = listHangHoa;
        }

    }
}
