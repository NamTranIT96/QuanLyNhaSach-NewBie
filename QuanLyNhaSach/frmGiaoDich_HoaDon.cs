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

namespace QuanLyNhaSach
{
    public partial class frmGiaoDich_HoaDon : Form
    {
        private HoaDonBanHangServices hoaDonBanHangServices;
        private KhachHangServices khachangServices;

        public frmGiaoDich_HoaDon()
        {
            InitializeComponent();
            hoaDonBanHangServices = new HoaDonBanHangServices();
            khachangServices = new KhachHangServices();
        }

        private void frmGiaoDich_HoaDon_Load(object sender, EventArgs e)
        {
            loadDataToDataGridViewHoaDonBanHang();
            getDataTxtTheoMaHoaDon();
            getDataTxtTheoTenKhachHang();
        }

        private void txtTheoMaHoaDon_Leave(object sender, EventArgs e)
        {
            if (txtTheoMaHoaDon.Text == "")
            {
                txtTheoMaHoaDon.Text = "Theo mã hóa đơn";
                txtTheoMaHoaDon.ForeColor = Color.Gray;
            }
        }

        private void txtTheoMaHoaDon_Enter(object sender, EventArgs e)
        {
            if (txtTenKhachHang.Text == "Theo tên khách hàng")
            {
                txtTenKhachHang.Text = "";
                txtTenKhachHang.ForeColor = Color.Black;
            }
        }

        private void txtTenKhachHang_Leave(object sender, EventArgs e)
        {
            if (txtTenKhachHang.Text == "")
            {
                txtTenKhachHang.Text = "Theo tên khách hàng";
                txtTenKhachHang.ForeColor = Color.Gray;
            }
        }

        private void txtTenKhachHang_Enter(object sender, EventArgs e)
        {
            if (txtTenKhachHang.Text == "Theo tên khách hàng")
            {
                txtTenKhachHang.Text = "";
                txtTenKhachHang.ForeColor = Color.Black;
            }
        }

        private void loadDataToDataGridViewHoaDonBanHang()
        {
            DataTable datasource = hoaDonBanHangServices.getAllHoaDonBanHang();
            if (datasource != null)
            {
                dataGridDanhSachHoaDon.DataSource = datasource;
            }
            else
            {
                MessageBox.Show("Có lỗi sảy ra khi load danh sách hóa đơn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getDataTxtTheoMaHoaDon()
        {
            List<string> data = hoaDonBanHangServices.getAllMaHoaDon();
            txtTheoMaHoaDon.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection dataString = new AutoCompleteStringCollection();
            dataString.AddRange(data.ToArray());
            txtTheoMaHoaDon.AutoCompleteCustomSource = dataString;
            txtTheoMaHoaDon.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void getDataTxtTheoTenKhachHang()
        {
            List<string> data = khachangServices.getAllNameKhachHang();
            txtTenKhachHang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection dataString = new AutoCompleteStringCollection();
            dataString.AddRange(data.ToArray());
            txtTenKhachHang.AutoCompleteCustomSource = dataString;
            txtTenKhachHang.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void dataGridDanhSachHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridDanhSachHoaDon.Columns[e.ColumnIndex].Name == "XemCT")
            {
                //dataGridDanhSachHoaDon.Rows.RemoveAt(e.RowIndex);
                string maHoaDon = dataGridDanhSachHoaDon.Rows[e.RowIndex].Cells[1].Value.ToString();
                //frmBanHang_TraHang_XemChiTietHoaDon frmTraHang_ChiTietHoaDon
                //    = new frmBanHang_TraHang_XemChiTietHoaDon(this, maHoaDon);

                //frmTraHang_ChiTietHoaDon.Show();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (checkBoxThoiGian.Checked == false)
            {

                if (txtTheoMaHoaDon.Text == "Theo mã hóa đơn" || txtTheoMaHoaDon.Text == "")
                {
                    if (txtTenKhachHang.Text == "Theo tên khách hàng" || txtTenKhachHang.Text == "")
                    {
                        MessageBox.Show("Chưa nhập thông tin cần tìm");
                        return;
                    }
                    else
                    {
                        // Trường hợp chỉ tìm theo tên khách hàng
                        // kiểm tra xem tên khách hàng đó có tồn tại
                        if (khachangServices.checkKhachHangCoTonTaiTheoTen(txtTenKhachHang.Text))
                        {
                            // nếu đúng
                            dataGridDanhSachHoaDon.DataSource = hoaDonBanHangServices.searchHoaDonBanHangTheoMaHoaDonHoacTenKhachHang(null, txtTenKhachHang.Text);
                        }
                        else
                        {
                            MessageBox.Show("Không có khách hàng này", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                else
                {
                    // Trường hợp đã có mã hóa đơn
                    if (hoaDonBanHangServices.checkHoaDonCoTonTaiTheoMaHoaDon(txtTheoMaHoaDon.Text))
                    {
                        //nếu có mã hóa đơn này trong data
                        if (txtTenKhachHang.Text == "Theo tên khách hàng" || txtTenKhachHang.Text == "")
                        {
                            dataGridDanhSachHoaDon.DataSource = hoaDonBanHangServices.
                                searchHoaDonBanHangTheoMaHoaDonHoacTenKhachHang(txtTheoMaHoaDon.Text);

                        }
                        else
                        {
                            if (khachangServices.checkKhachHangCoTonTaiTheoTen(txtTenKhachHang.Text))
                            {
                                dataGridDanhSachHoaDon.DataSource = hoaDonBanHangServices.
                                    searchHoaDonBanHangTheoMaHoaDonHoacTenKhachHang(txtTheoMaHoaDon.Text, txtTenKhachHang.Text);
                            }
                            else
                            {
                                MessageBox.Show("Không có khách hàng này", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Không có mã hóa đơn này", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                // Tìm kiếm theo thời gian
            }
        }
    }
}
