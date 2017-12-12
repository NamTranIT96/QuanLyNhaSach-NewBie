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
    public partial class frmGiaoDich_NhapHang : Form
    {
        private HangHoaServices hangHoaServices;
        private NguoiDungServices nguoiDungServices;
        private KhachHangServices khachHangServices;
        private NhaCungCapServices nhacungCapServices;
        private string maNDSuDung = null; // Mã người dùng đang sử dụng

        public frmGiaoDich_NhapHang()
        {
            InitializeComponent();
            hangHoaServices = new HangHoaServices();
            nguoiDungServices = new NguoiDungServices();
            khachHangServices = new KhachHangServices();
            nhacungCapServices = new NhaCungCapServices();
        }

        private void frmGiaoDich_NhapHang_Load(object sender, EventArgs e)
        {
            timerForHoaDon.Start();
            setFormatDataGrid();
            getDataForTextBoxSearch();
            getDataForTextBoxTimNhaCC();
        }

        private void txtBoxSearch_Enter(object sender, EventArgs e)
        {
            if (txtBoxSearch.Text == "Tìm mặt hàng")
            {
                txtBoxSearch.Text = "";
                txtBoxSearch.ForeColor = Color.Black;
            }
        }

        private void txtBoxSearch_Leave(object sender, EventArgs e)
        {
            if (txtBoxSearch.Text == "")
            {
                txtBoxSearch.Text = "Tìm mặt hàng";
                txtBoxSearch.ForeColor = Color.DarkGray;
            }
        }


        private void txtTimNhaCC_Enter(object sender, EventArgs e)
        {
            if (txtTimNhaCC.Text == "Tìm nhà cung cấp")
            {
                txtTimNhaCC.Text = "";
                txtTimNhaCC.ForeColor = Color.Black;
            }
        }

        private void txtTimNhaCC_Leave(object sender, EventArgs e)
        {
            if (txtTimNhaCC.Text == "")
            {
                txtTimNhaCC.Text = "Tìm nhà cung cấp";
                txtTimNhaCC.ForeColor = Color.DarkGray;
            }
        }

        private void txtNumberGiamGia_Click(object sender, EventArgs e)
        {
            txtNumberGiamGia.SelectAll();
            txtNumberGiamGia.Focus();
        }

        private void txtNumberGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8; // 8 is backspace
            if (e.KeyChar == (char)13) // 13 is enter
            {
                txtNumberGiamGia.Text = string.Format("{0:n0}", double.Parse(txtNumberGiamGia.Text));
            }
        }

        private void txtNumBerKhachThanhToan_Click(object sender, EventArgs e)
        {
            txtNumBerKhachThanhToan.SelectAll();
            txtNumBerKhachThanhToan.Focus();
        }

        private void txtNumBerKhachThanhToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8; // 8 is backspace
            if (e.KeyChar == (char)13) // 13 is enter
            {
                txtNumBerKhachThanhToan.Text = string.Format("{0:n0}", double.Parse(txtNumBerKhachThanhToan.Text));
                if (double.Parse(txtNumBerKhachThanhToan.Text) < double.Parse(lblNumberKhachCanTra.Text))
                {
                    MessageBox.Show("Không đủ tiền trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Cập nhật tiền khách hàng trả trong hoadontemp
                    //setTienKhachHangTraToHoaDonTemp();
                    lblNumberTienThuaTraKhach.Text = string.Format("{0:n0}",
                       (double.Parse(txtNumBerKhachThanhToan.Text) - double.Parse(lblNumberKhachCanTra.Text)));
                }
            }
        }

        private void txtNumBerKhachThanhToan_Leave(object sender, EventArgs e)
        {
            txtNumBerKhachThanhToan.Text = string.Format("{0:n0}", double.Parse(txtNumBerKhachThanhToan.Text));
            if (double.Parse(txtNumBerKhachThanhToan.Text) < double.Parse(lblNumberKhachCanTra.Text))
            {
                MessageBox.Show("Không đủ tiền trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lblNumberTienThuaTraKhach.Text = string.Format("{0:n0}",
                    (double.Parse(txtNumBerKhachThanhToan.Text) - double.Parse(lblNumberKhachCanTra.Text)));
            }
        }

        private void btnThemHangHoaVaoDanhSach_Click(object sender, EventArgs e)
        {
            if (txtBoxSearch.Text == "" || txtBoxSearch.Text == "Tìm mặt hàng")
            {
                MessageBox.Show("Chưa nhập tên mặt hàng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numSoLuong.Value <= 0)
            {
                MessageBox.Show("Chưa nhập số lượng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string maHangHoa = hangHoaServices.getMaHangHoaByTenHangHoa(txtBoxSearch.Text);
            if (maHangHoa == null)
            {
                MessageBox.Show("Không có hàng hoá này!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Kiểm tra xem hàng hoá này đã có trong datagridview chưa
                if (checkHangHoaInDataGridView(maHangHoa))
                {
                    //// Thêm sản phẩm vào datagridview để show các sản phẩm đã chọn
                    DataTable datatable = (DataTable)dataGridDanhSachHangHoa_NhapHang.DataSource as DataTable;
                    DataRow row = datatable.NewRow();

                    row[0] = maHangHoa;
                    row[1] = hangHoaServices.getTenHangHoaByMaHangHoa(maHangHoa);
                    row[2] = hangHoaServices.getDonViTinhByMaHangHoa(maHangHoa);
                    row[3] = numSoLuong.Value;
                    row[4] = hangHoaServices.getGiaTienHangHoaByMaHangHoa(maHangHoa);
                    row[5] = hangHoaServices.getGiaTienHangHoaByMaHangHoa(maHangHoa) * (double)numSoLuong.Value;
                    //  thêm vào datagridview
                    try
                    {
                        datatable.Rows.Add(row);
                        datatable.AcceptChanges();
                        dataGridDanhSachHangHoa_NhapHang.DataSource = datatable;
                    }
                    catch
                    {
                        MessageBox.Show("Đã có lỗi xảy ra trong quá trình thêm sản phẩm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }

                }
                // Nếu đã có trong danh sách
                else
                {
                        updateHangHoaInDatagridView(maHangHoa);
                }
                // Cập nhật các thông số bên Hóa đơn Panel
                //updateInforChiTietHoaDon();
            }
        }

        /// <summary>
        /// Hàm này kiểm tra xem hàng hoá thêm mới vào datagridview đã có chưa, nếu có rồi thì 
        /// chỉ tăng số lượng, không duplicate
        /// Trả vê false khi đã có sản phẩm
        /// trả về true khi chưa có sản phẩm
        /// </summary>
        /// <param name="maHH"></param>
        /// <returns></returns>
        private bool checkHangHoaInDataGridView(string maHH)
        {
            foreach (DataGridViewRow temp in dataGridDanhSachHangHoa_NhapHang.Rows)
            {
                if (temp.Cells[1].Value == null)
                {
                    continue;
                }
                if (temp.Cells[1].Value.ToString() == maHH)
                {
                    return false;
                }
            }
            return true;
        }

        private void getDataForTextBoxSearch()
        {
            List<string> data = hangHoaServices.getAllNameHangHoa();
            txtBoxSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection dataString = new AutoCompleteStringCollection();
            dataString.AddRange(data.ToArray());
            txtBoxSearch.AutoCompleteCustomSource = dataString;
            txtBoxSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void getDataForTextBoxTimNhaCC()
        {
            List<string> data = nhacungCapServices.getAllNameNhaCungCap();
            txtTimNhaCC.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection dataString = new AutoCompleteStringCollection();
            dataString.AddRange(data.ToArray());
            txtTimNhaCC.AutoCompleteCustomSource = dataString;
            txtTimNhaCC.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public void setMaNDSuDung(string maND)
        {
            maNDSuDung = maND;
            if (maNDSuDung != null)
            {
                lblTenNhanVien.Text = nguoiDungServices.getTenNguoiDungBymaND(maNDSuDung);
            }
        }

        private void timerForHoaDon_Tick(object sender, EventArgs e)
        {
            this.lblThoiGian.Text = DateTime.Now.ToString();
        }


        private void updateHangHoaInDatagridView(string maHangHoa)
        {
            foreach (DataGridViewRow temp in dataGridDanhSachHangHoa_NhapHang.Rows)
            {
                if (temp.Cells[1].Value == null)
                {
                    continue;
                }
                if (temp.Cells[1].Value.ToString() == maHangHoa)
                {
                    temp.Cells[4].Value = int.Parse(temp.Cells[4].Value.ToString()) + (int)numSoLuong.Value;
                    temp.Cells[6].Value = int.Parse(temp.Cells[4].Value.ToString()) * double.Parse(temp.Cells[5].Value.ToString());
                }
            }
        }
        private void setFormatDataGrid()
        {
            dataGridDanhSachHangHoa_NhapHang.DataSource = hangHoaServices.setFormatDataTable();
        }
    }
}
