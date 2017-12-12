using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using BusinessEntities.EF;
namespace QuanLyNhaSach
{
    public partial class frmBanHang_TraHang_XemChiTietHoaDon : Form
    {
        private string maHoaDon = null;
        private frmBanHang_TraHang frmBanHangTraHang;
        private HoaDonBanHangServices hoaDonBanHangServices;
        private HoaDonTraHangServices hoaDonTraHangServices;
        private KhachHangServices khachHangServices;
        private NguoiDungServices nguoiDungServices;
        private SanPhamHoaDonServices sanPhamHoaDonServices;
        public frmBanHang_TraHang_XemChiTietHoaDon()
        {
            InitializeComponent();
        }
        public frmBanHang_TraHang_XemChiTietHoaDon(frmBanHang_TraHang frmBanHangTraHang, string maHoaDon)
        {
            this.maHoaDon = maHoaDon;
            this.frmBanHangTraHang = frmBanHangTraHang;
            hoaDonBanHangServices = new HoaDonBanHangServices();
            hoaDonTraHangServices = new HoaDonTraHangServices();
            khachHangServices = new KhachHangServices();
            nguoiDungServices = new NguoiDungServices();
            sanPhamHoaDonServices = new SanPhamHoaDonServices();

            InitializeComponent();
            setDataToForm();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setDataToForm()
        {
            HoaDonBanHang temp = hoaDonBanHangServices.getHoaDonBanHangByMaHoaDon(maHoaDon);
            if(temp!=null)
            {
                // Set thông tin hóa đơn phía bên trên
                lblValueMaHoaDon.Text = temp.MaHoaDon_BanHang;
                if (temp.MaKhachHang != null)
                    lblVaLueTenKhachHang.Text = khachHangServices.getTenKhachHangByMaKH(temp.MaKhachHang);
                else
                    lblVaLueTenKhachHang.Text = "Khách lẻ";

                lblVaLueNguoiThu.Text = nguoiDungServices.getTenNguoiDungBymaND(temp.MaNguoiDung);
                lblValueThoiGian.Text = temp.NgayGio.ToString();
                lblValueTongTien.Text = string.Format("{0:n0}",temp.TongTien);
                lblValueChiecKhau.Text = string.Format("{0:n0}", temp.ChietKhau);
                lblValueThanhTien.Text = string.Format("{0:n0}", temp.TongCong);

                // Set thông tin vào datagridview phía dưới

                DataTable datasource = sanPhamHoaDonServices.getSanPhamHoaDonByMaHoaDon(maHoaDon);
                dataGridSanPhamHoaDon.DataSource = datasource;

                // set thông tin vào panel chi tiết hóa đơn bên tay phải

                lblValueRightMaHoaDon.Text = temp.MaHoaDon_BanHang;
                lblValueRightTenKhachHang.Text = lblVaLueTenKhachHang.Text;
                lblValueRightNguoiThu.Text = lblVaLueNguoiThu.Text;
                lblValueRightThanhTien.Text = lblValueThanhTien.Text;
                lblValueRightPhiTraHang.Text = string.Format("{0:n0}", (temp.TongCong * 0.1));
                lblValueRightTraLaiKhach.Text = string.Format("{0:n0}", (temp.TongCong - (temp.TongCong * 0.1)));



            }
            else
            {
                MessageBox.Show("Có lỗi xãy ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            DialogResult output = MessageBox.Show("Bạn có chắc muốn trả hóa đơn này? Bạn nên thực hiện thu hồi hóa đơn của khách hàng!", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(output == DialogResult.Yes)
            {
                // Thêm dữ liệu vào hóa đơn trả hàng và set status false cho hóa đơn được trả
                // Thêm dữ liệu vào hóa đơn trả hàng
                HoaDonTraHang hoaDonTraHang = new HoaDonTraHang();
                HoaDonBanHang temp = hoaDonBanHangServices.getHoaDonBanHangByMaHoaDon(maHoaDon);

                hoaDonTraHang.MaHoaDon_TraHang = hoaDonTraHangServices.getTheNewMaHoaDonTraHang();
                hoaDonTraHang.MaHoaDon_BanHang = maHoaDon;
                hoaDonTraHang.MaKhachHang = temp.MaKhachHang;
                hoaDonTraHang.MaNguoiDung = temp.MaNguoiDung;
                hoaDonTraHang.NgayGio = DateTime.Parse(lblValueRightThoiGian.Text);
                hoaDonTraHang.ThanhTien = temp.TongCong;
                hoaDonTraHang.PhiTraHang = double.Parse(lblValueRightPhiTraHang.Text);
                hoaDonTraHang.TienTraLaiKhach = double.Parse(lblValueRightTraLaiKhach.Text);

                if(hoaDonTraHangServices.addNewHoaDonTraHang(hoaDonTraHang))
                {
                    // nếu thêm hóa đơn trả hàng thành công.
                    // Set giá trị STATUS của hóa đơn vừa trả lại thành false;
                    if(hoaDonBanHangServices.setStatusFasleByMaHoaDon(maHoaDon))
                    {
                        DialogResult check = MessageBox.Show("Trả hàng thành công :D", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if(check == DialogResult.OK)
                        {
                            this.frmBanHangTraHang.reloadDatagridviewDanhSachHoaDon();
                            this.Hide();
                        }
                    }
                }
                // load form tạo report lên và in
            }
            else
            {

            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.lblValueRightThoiGian.Text = DateTime.Now.ToString();
        }

        private void frmBanHang_TraHang_XemChiTietHoaDon_Load(object sender, EventArgs e)
        {
            this.timer.Start();
        }
    }
}
