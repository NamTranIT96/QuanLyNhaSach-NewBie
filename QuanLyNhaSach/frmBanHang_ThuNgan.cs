using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using BusinessEntities;
using DevExpress.XtraTab;
using BusinessEntities.Repositories;
namespace QuanLyNhaSach
{
    public partial class frmBanHang_ThuNgan : Form
    {
        /// <summary>
        /// Khai bao doi tuong
        /// </summary>

        private HangHoaServices hangHoaServices;
        private HoaDonTempServices hoaDonTempServices;
        private NguoiDungServices nguoiDungServices;
        private KhachHangServices khachHangServices;
        private HoaDonBanHangServices hoaDonBanHangServices;
        private ChiNhanhServices chiNhanhServices;
        private string maNDSuDung = null; // Mã người dùng đang sử dụng
        private string maKHDangMua = null;
        private string tenKHDangMua = null;
        private double soTichDiemKHDangMua = 0;

        public frmBanHang_ThuNgan()
        {
            InitializeComponent();
            hangHoaServices = new HangHoaServices();
            hoaDonTempServices = new HoaDonTempServices();
            nguoiDungServices = new NguoiDungServices();
            khachHangServices = new KhachHangServices();
            hoaDonBanHangServices = new HoaDonBanHangServices();
            chiNhanhServices = new ChiNhanhServices();
            initDataFirstHoaDonTemp();
            getDataForTextBoxSearch();
            getDataForTextBoxKhachHang();
        }

        private void frmBanHang_ThuNgan_Load(object sender, EventArgs e)
        {
            timerForHoaDon.Start();
        }

        #region Event button

        private void btnBack_Click(object sender, EventArgs e)
        {

            //int countFormQLBanHang = Application.OpenForms.OfType<frmQuanLyBanHang>().Count();

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
        private void txtTimKhachHang_Enter(object sender, EventArgs e)
        {
            if (txtTimKhachHang.Text == "Khách lẻ")
            {
                txtTimKhachHang.Text = "";
                txtTimKhachHang.ForeColor = Color.Black;
            }
        }

        private void txtTimKhachHang_Leave(object sender, EventArgs e)
        {
            if (txtTimKhachHang.Text == "")
            {
                txtTimKhachHang.Text = "Khách lẻ";
                txtTimKhachHang.ForeColor = Color.Black;
            }
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            int num = tabControlDanhSachHangHoa.TabPages.Count() + 1;
            string name = "Hóa đơn " + num.ToString();
            while (searchIndex(name) != null)
            {
                num++;
                name = "Hóa đơn " + num.ToString();
            }

            // Thêm Một hoá đơn mới
            if (hoaDonTempServices.addHoaDonTemp(name))
            {

            }
            else
            {
                MessageBox.Show("Đã có lỗi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Thêm trang mới
            tabControlDanhSachHangHoa.TabPages.Add(name);

            foreach (XtraTabPage tabpage in tabControlDanhSachHangHoa.TabPages)
            {
                if (tabpage.Text == name)
                {
                    //this.dataGridDanhSachHangHoa_HoaDon.Rows.Clear();
                    tabpage.Controls.Add(this.dataGridDanhSachHangHoa_HoaDon);
                    tabpage.Controls.Add(this.panelInsideHoaDonRight);
                    tabpage.Controls.Add(this.panelInsideHoaDonLeft);
                    tabpage.Controls.Add(this.panelInsideHoaDonTop);
                }
            }
            int index = (int)searchIndex(name);
            tabControlDanhSachHangHoa.SelectedTabPageIndex = index;

            //update Infor panel HoaDon
            updateInforChiTietHoaDon();
        }
        /// <summary>
        /// Xóa hóa đơn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn xoá hoá đơn này?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (hoaDonTempServices.deleteHoaDonInListHoaDonTempByTenHoaDon(tabControlDanhSachHangHoa
                    .SelectedTabPage.Text))
                {
                    tabControlDanhSachHangHoa.TabPages.RemoveAt(tabControlDanhSachHangHoa.SelectedTabPageIndex);

                }
                else
                {
                    MessageBox.Show("Đã có lỗi trong vấn đề xóa trang hóa đơn", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {

            }
        }
        // Hàm này dùng để tìm xem đã có cái tabpage nào có cái tên đó chưa
        // nếu có thì trả về cái index của cái tab đang có
        // nếu chưa thì trả về null
        private int? searchIndex(string text)
        {
            int? index = null;
            foreach (XtraTabPage tabpage in tabControlDanhSachHangHoa.TabPages)
            {
                if (tabpage.Text.Equals(text))
                {
                    index = tabControlDanhSachHangHoa.TabPages.IndexOf(tabpage);
                }
            }
            return index;
        }

        private void tabControlDanhSachHangHoa_SelectedPageChanging(object sender, TabPageChangingEventArgs e)
        {


        }

        private void tabControlDanhSachHangHoa_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            if (tabControlDanhSachHangHoa.TabPages.Count > 0)
            {
                string name = tabControlDanhSachHangHoa.TabPages[tabControlDanhSachHangHoa.SelectedTabPageIndex].Text;
                foreach (XtraTabPage tabpage in tabControlDanhSachHangHoa.TabPages)
                {
                    if (tabpage.Text == name)
                    {
                        //this.dataGridDanhSachHangHoa_HoaDon.Rows.Clear();
                        DataTable datasource = hoaDonTempServices.getAllHangHoaInHoaDonByTenHoaDon(name);
                        if (datasource != null)
                        {
                            this.dataGridDanhSachHangHoa_HoaDon.DataSource = datasource;
                        }
                        tabpage.Controls.Add(this.dataGridDanhSachHangHoa_HoaDon);
                        tabpage.Controls.Add(this.panelInsideHoaDonRight);
                        tabpage.Controls.Add(this.panelInsideHoaDonLeft);
                        tabpage.Controls.Add(this.panelInsideHoaDonTop);
                    }
                }
                updateInforChiTietHoaDon();

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
                    // Thêm sản phẩm vào datagridview để show các sản phẩm đã chọn
                    DataTable datatable = (DataTable)dataGridDanhSachHangHoa_HoaDon.DataSource as DataTable;
                    DataRow row = datatable.NewRow();

                    row[0] = maHangHoa;
                    row[1] = hangHoaServices.getTenHangHoaByMaHangHoa(maHangHoa);
                    row[2] = hangHoaServices.getDonViTinhByMaHangHoa(maHangHoa);
                    row[3] = numSoLuong.Value;
                    row[4] = hangHoaServices.getGiaTienHangHoaByMaHangHoa(maHangHoa);
                    row[5] = hangHoaServices.getGiaTienHangHoaByMaHangHoa(maHangHoa) * (double)numSoLuong.Value;

                    // thêm các sản phẩm vào hoá đơn temp ( lưu vào bộ nhớ tạm )
                    string nameHoaDon = tabControlDanhSachHangHoa.SelectedTabPage.Text;

                    bool checkAddHoaDon = hoaDonTempServices.addHangHoaToHoaDonByTenHoaDon(nameHoaDon, maHangHoa,
                        hangHoaServices.getTenHangHoaByMaHangHoa(maHangHoa), // tenHH
                        hangHoaServices.getDonViTinhByMaHangHoa(maHangHoa), // donViTinh
                        (int)numSoLuong.Value, //so luong
                        hangHoaServices.getGiaTienHangHoaByMaHangHoa(maHangHoa), // gia tien
                        (hangHoaServices.getGiaTienHangHoaByMaHangHoa(maHangHoa) * (double)numSoLuong.Value)); // Tong gia
                    if (checkAddHoaDon)
                    {
                        //nếu lưu vào bộ nhớ tạm thành công thì mới thêm vào datagridview

                        datatable.Rows.Add(row);
                        datatable.AcceptChanges();
                        dataGridDanhSachHangHoa_HoaDon.DataSource = datatable;

                        //dataGridDanhSachHangHoa_HoaDon.Rows.Add(row);
                    }
                    else
                    {
                        // Có lỗi xảy ra
                        MessageBox.Show("Đã có lỗi xảy ra trong quá trình thêm sản phẩm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                // Nếu đã có trong danh sách
                else
                {
                    string nameHoaDon = tabControlDanhSachHangHoa.SelectedTabPage.Text;
                    if (hoaDonTempServices.editHangHoaInHoaDon(nameHoaDon, maHangHoa, int.Parse(numSoLuong.Value.ToString())))
                    {
                        updateHangHoaInDatagridView(maHangHoa);
                    }
                }
                // Cập nhật các thông số bên Hóa đơn Panel
                updateInforChiTietHoaDon();
            }
        }


        private void btnSearchKhachHang_Click(object sender, EventArgs e)
        {
            frmBanHang_ThuNgan_TimKiemKhachHang frmTimKiemKhachHang = new frmBanHang_ThuNgan_TimKiemKhachHang(this);
            frmTimKiemKhachHang.Show();
        }

        private void txtNumberGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8; // 8 is backspace
            if (e.KeyChar == (char)13) // 13 is enter
            {
                txtNumberGiamGia.Text = string.Format("{0:n0}", double.Parse(txtNumberGiamGia.Text));
            }
        }

        private void txtNumberGiamGia_Click(object sender, EventArgs e)
        {
            txtNumberGiamGia.SelectAll();
            txtNumberGiamGia.Focus();
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
                    setTienKhachHangTraToHoaDonTemp();
                    lblNumberTienThuaTraKhach.Text = string.Format("{0:n0}",
                       (double.Parse(txtNumBerKhachThanhToan.Text) - double.Parse(lblNumberKhachCanTra.Text)));
                }
            }
        }

        private void txtNumBerKhachThanhToan_Click(object sender, EventArgs e)
        {
            txtNumBerKhachThanhToan.SelectAll();
            txtNumBerKhachThanhToan.Focus();
        }

        private void txtNumberGiamGia_Leave(object sender, EventArgs e)
        {
            txtNumberGiamGia.Text = string.Format("{0:n0}", double.Parse(txtNumberGiamGia.Text));
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
        #endregion


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
            foreach (DataGridViewRow temp in dataGridDanhSachHangHoa_HoaDon.Rows)
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

        private void updateHangHoaInDatagridView(string maHangHoa)
        {
            foreach (DataGridViewRow temp in dataGridDanhSachHangHoa_HoaDon.Rows)
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


        #region fuction hổ trợ Ban đầu
        private void getDataForTextBoxSearch()
        {
            List<string> data = hangHoaServices.getAllNameHangHoa();
            txtBoxSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection dataString = new AutoCompleteStringCollection();
            dataString.AddRange(data.ToArray());
            txtBoxSearch.AutoCompleteCustomSource = dataString;
            txtBoxSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void getDataForTextBoxKhachHang()
        {
            List<string> data = khachHangServices.getAllNameKhachHang();
            txtTimKhachHang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection dataString = new AutoCompleteStringCollection();
            dataString.AddRange(data.ToArray());
            txtTimKhachHang.AutoCompleteCustomSource = dataString;
            txtTimKhachHang.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void initDataFirstHoaDonTemp()
        {
            hoaDonTempServices.addHoaDonTemp("Hóa đơn 1");
            if (tabControlDanhSachHangHoa.TabPages.Count > 0)
            {
                // Tên hóa đơn temp
                string name = tabControlDanhSachHangHoa.TabPages[tabControlDanhSachHangHoa.SelectedTabPageIndex].Text;
                // Thêm dữ liệu vào datagridview
                foreach (XtraTabPage tabpage in tabControlDanhSachHangHoa.TabPages)
                {
                    if (tabpage.Text == name)
                    {
                        //this.dataGridDanhSachHangHoa_HoaDon.Rows.Clear();
                        DataTable datasource = hoaDonTempServices.getAllHangHoaInHoaDonByTenHoaDon(name);
                        if (datasource != null)
                        {
                            this.dataGridDanhSachHangHoa_HoaDon.DataSource = datasource;
                        }
                        tabpage.Controls.Add(this.dataGridDanhSachHangHoa_HoaDon);
                        tabpage.Controls.Add(this.panelInsideHoaDonRight);
                        tabpage.Controls.Add(this.panelInsideHoaDonLeft);
                        tabpage.Controls.Add(this.panelInsideHoaDonTop);
                    }
                }
            }
        }
        #endregion


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

        // Hàm cập nhật các thông số hóa đơn bên tay phải.
        private void updateInforChiTietHoaDon()
        {

            // tên hóa đơn
            string name = tabControlDanhSachHangHoa.TabPages[tabControlDanhSachHangHoa.SelectedTabPageIndex].Text;
            // Tổng tiền
            double tongtien = hoaDonTempServices.getTongTienByTenHoaDon(name);

            // MaKH va Tien Khach hang da tra [0] makh, [1] tienkhdatra
            List<string> maKHAndTienTra = hoaDonTempServices.getMaKHAndTienTraByTenHoaDon(name);
            if (maKHAndTienTra == null)
            {
                MessageBox.Show("Đã có lỗi xãy ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // tên khách hàng
            string tenKH;
            // phần trăm giảm giá  
            double phanTramgiamgia;
            // Tiền giảm giá;
            double tienGiamGia = 0;


            if (maKHAndTienTra[0] == "Khách lẻ")
            {
                // Set tên khách hàng
                tenKH = "Khách lẻ";
                txtTimKhachHang.Text = tenKH;

                // Set tổng tiền khách hàng mua
                lblNumberTongTienHang.Text = string.Format("{0:n0}", tongtien);

                // set số tiền khách được giảm
                txtNumberGiamGia.Text = "0";

                // set số tiền khách cần phải trả
                lblNumberKhachCanTra.Text = string.Format("{0:n0}", tongtien);

                // Số tiền khách đưa là
                txtNumBerKhachThanhToan.Text = string.Format("{0:n0}", double.Parse(maKHAndTienTra[1]));

                // số tiền phải trả lại cho khách là
                lblNumberTienThuaTraKhach.Text = string.Format("{0:n0}",
                    double.Parse(txtNumBerKhachThanhToan.Text) - double.Parse(lblNumberKhachCanTra.Text));

            }
            else
            {
                // Set tên khách hàng
                tenKH = khachHangServices.getTenKhachHangByMaKH(maKHAndTienTra[0]);
                txtTimKhachHang.Text = tenKH;

                // Tìm số điểm tích được của khách hàng theo mã khách hàng
                phanTramgiamgia = khachHangServices.getSoPhanTramTichDiem(maKHAndTienTra[0]);

                // Lấy số tiền khách hàng đã trả
                txtNumBerKhachThanhToan.Text = string.Format("{0:n0}", maKHAndTienTra[1]);

                if (tongtien >= 0)
                {
                    // set giá trị tổng tiền lên panel
                    lblNumberTongTienHang.Text = string.Format("{0:n0}", tongtien);

                    // kiểm tra có được giảm giá hay không
                    if (tongtien >= 250000)
                    {
                        tienGiamGia = ((phanTramgiamgia / 100) * tongtien);
                        txtNumberGiamGia.Text = string.Format("{0:n0}", tienGiamGia);
                    }
                    else
                    {
                        txtNumberGiamGia.Text = "0";
                    }
                    lblNumberKhachCanTra.Text = string.Format("{0:n0}", (tongtien - tienGiamGia));

                    // Tiền thừa trả khách
                    lblNumberTienThuaTraKhach.Text = string.Format("{0:n0}",
                    double.Parse(txtNumBerKhachThanhToan.Text) - double.Parse(lblNumberKhachCanTra.Text));
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void setKhachHangDangMua(string maKH, string tenKH, double tichDiem)
        {
            maKHDangMua = maKH;
            tenKHDangMua = tenKH;
            soTichDiemKHDangMua = tichDiem;
            this.txtTimKhachHang.Text = tenKHDangMua;
            setInforKhachHangToHoaDonTemp(); // set mã khách hàng vào hóa đơn temp
            updateInforChiTietHoaDon();
        }
        /// <summary>
        /// Set thông tin khách hàng vào hóa đơn temp
        /// </summary>
        private void setInforKhachHangToHoaDonTemp()
        {
            string tenHoaDon = tabControlDanhSachHangHoa.TabPages[tabControlDanhSachHangHoa.SelectedTabPageIndex].Text;
            if (!hoaDonTempServices.setMaKHByTenHoaDon(tenHoaDon, maKHDangMua))
            {
                MessageBox.Show("Có lỗi xảy ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setTienKhachHangTraToHoaDonTemp()
        {
            string tenHoaDon = tabControlDanhSachHangHoa.TabPages[tabControlDanhSachHangHoa.SelectedTabPageIndex].Text;
            if (!hoaDonTempServices.setTienKhachHangTra(tenHoaDon, double.Parse(txtNumBerKhachThanhToan.Text)))
            {
                MessageBox.Show("Có lỗi xảy ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if(dataGridDanhSachHangHoa_HoaDon.Rows.Count==0)
            {
                MessageBox.Show("Chưa có hàng hóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtNumBerKhachThanhToan.Text=="0")
            {
                MessageBox.Show("Khách hàng chưa thanh toán tiền", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //tên hóa đơn
            string tenHoaDon = tabControlDanhSachHangHoa.TabPages[tabControlDanhSachHangHoa.SelectedTabPageIndex].Text;

            // Thêm dữ liệu vào database hóa đơn bán hàng và thêm  dữ liệu vào database sản phẩm hóa đơn

            if(hoaDonBanHangServices.addNewHoaDonBanHangAndSanPhamHoaDon(hoaDonTempServices.getHoaDonTempByTenHoaDon(tenHoaDon), maNDSuDung, DateTime.Parse(lblThoiGian.Text)))
            {
                // nếu thêm dữ liệu thành công, load lên report vẫn dùng các dữ liệu của hóa đơn temp

                frmPrintReport m_frmPrintReport = new frmPrintReport();

                string chiNhanh = chiNhanhServices.getTenChiNhanhHienTai();
                string tenCuaHang = chiNhanhServices.getTenCuaHang();
                string dienThoaiCuaHang = chiNhanhServices.getDienThoaiCuaHang();
                DateTime ngayBan = DateTime.Parse(lblThoiGian.Text);
                string maHoaDon = hoaDonBanHangServices.getCurrentMaHoaDonBanHang();
                string tenkhachHang = tenKHDangMua;
                string diaChiKhachHang = khachHangServices.getDiaChiKhachHangByMaKH(maKHDangMua);
                string dienThoaiKhachHang = khachHangServices.getDienThoaiKhachHangByMaKH(maKHDangMua);
                string tenNguoiBan = nguoiDungServices.getTenNguoiDungBymaND(maNDSuDung);
                double chietkhau = double.Parse(txtNumberGiamGia.Text.ToString());
                double tongCong = 0;
                List<HangHoaTempRepositories> listHHTemp = hoaDonTempServices.getAllHangHoaTempByTenHoaDon(tenHoaDon);
                if(listHHTemp==null)
                {
                    MessageBox.Show("Đã có lỗi xãy ra trong quá trình tạo report", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                m_frmPrintReport.PrintHoaDonBanHang(chiNhanh, tenCuaHang, dienThoaiCuaHang, ngayBan,
                    maHoaDon, tenkhachHang, diaChiKhachHang, dienThoaiKhachHang, 
                    tenNguoiBan, listHHTemp,chietkhau,tongCong);
                m_frmPrintReport.Show();
                //m_frmPrintReport.PrintHoaDonBanHang()

                /*
                // nếu thêm dữ liệu thành công, thực hiện xóa các dữ liệu trong hóa đơn temp;
                if (!hoaDonTempServices.deleteHoaDonInListHoaDonTempByTenHoaDon(tenHoaDon))
                {
                    MessageBox.Show("Đã có lỗi xãy ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("OKE", "OKE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                */
            }



            // close tabpage và xóa dữ liệu bên panel hóa đơn
        }

        private void txtNumberGiamGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridDanhSachHangHoa_HoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridDanhSachHangHoa_HoaDon.Columns[e.ColumnIndex].Name == "btnXoa")
            {
                // tên hóa đơn
                string tenHoaDon = tabControlDanhSachHangHoa.TabPages[tabControlDanhSachHangHoa.SelectedTabPageIndex].Text;
                // mã hàng hóa
                string maHangHoa = dataGridDanhSachHangHoa_HoaDon.Rows[e.RowIndex].Cells[1].Value.ToString();

                // thực hiện xóa hàng hóa trong hóa đơn temp
                if(hoaDonTempServices.deleteHangHoaInHoaDonTemByTenHoaDonAndMaHangHoa(tenHoaDon,maHangHoa))
                {
                    // xóa thành công
                    // cập nhật lại giá trị panel hóa đơn bên phải
                    updateInforChiTietHoaDon();
                }
                else
                {
                    // xóa không thành công
                    MessageBox.Show("Đã có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dataGridDanhSachHangHoa_HoaDon.Rows.RemoveAt(e.RowIndex);

            }
        }
    }
}
