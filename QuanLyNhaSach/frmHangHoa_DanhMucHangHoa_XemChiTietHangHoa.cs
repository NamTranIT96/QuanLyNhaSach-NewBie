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
using System.IO;
using QuanLyNhaSach.Properties;

namespace QuanLyNhaSach
{
    public partial class frmHangHoa_DanhMucHangHoa_XemChiTietHangHoa : Form
    {
        private bool checkEdit = false;
        private string maHangHoa = null;
        private HangHoaServices hangHoaServices;
        private DonViTinhServices donViTinhServices;
        private NhomHangServices nhomHangServices;
        private ThuocTinhHangHoaServices thuoctinhServices;
        public frmHangHoa_DanhMucHangHoa_XemChiTietHangHoa()
        {
            InitializeComponent();
        }
        public frmHangHoa_DanhMucHangHoa_XemChiTietHangHoa(frmHangHoa_DanhMucHangHoa frmDanhMucHangHoa, string maHangHoa)
        {
            this.maHangHoa = maHangHoa;
            hangHoaServices = new HangHoaServices();
            donViTinhServices = new DonViTinhServices();
            nhomHangServices = new NhomHangServices();
            thuoctinhServices = new ThuocTinhHangHoaServices();
            InitializeComponent();
        }

        private void frmHangHoa_DanhMucHangHoa_XemChiTietHangHoa_Load(object sender, EventArgs e)
        {
            this.labelHinhAnhSanPham.Focus();
            loadDataCombobox();
            setDataFirstToForm();
        }

        private void comboBoxNhomHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!checkEdit)
                e.KeyChar = (char)Keys.None;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxDonViTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!checkEdit)
                e.KeyChar = (char)Keys.None;
        }

        private void btnChinhSuaThongTin_Click(object sender, EventArgs e)
        {
            // nếu chỉnh sửa 
            if (btnChinhSuaThongTin.Text == "Chỉnh sửa")
            {
                // đổi tên
                btnChinhSuaThongTin.Text = "OK";
                // show các icon và enable các textbox;
                // Tắt readonly
                checkEdit = true;
                txtBoxTenHangHoa.ReadOnly = false;
                txtBoxGiaBan.ReadOnly = false;
                txtBoxGiaVon.ReadOnly = false;
                numericUpDownTonKho.ReadOnly = false;


                // chỉnh lại màu trắng
                txtBoxTenHangHoa.BackColor = Color.White;
                txtBoxGiaBan.BackColor = Color.White;
                txtBoxGiaVon.BackColor = Color.White;
                numericUpDownTonKho.BackColor = Color.White;
                txtBoxThuocTinh.BackColor = Color.White;
                comboBoxDonViTinh.BackColor = Color.White;
                comboBoxNhomHang.BackColor = Color.White;

                // show các button chỉnh sửa và thêm
                btnAddNhomHang.Visible = true;
                btnAddDonViTinh.Visible = true;
                btnEditImage.Visible = true;
                btnEditThuocTinh.Visible = true;
                // forcus txt đầu tiên
                this.txtBoxTenHangHoa.Focus();

            }
            // nếu bấm OKE
            else
            {
                // xét các trường hợp trong các ô text box bị trống
                if (txtBoxTenHangHoa.Text == "")
                {
                    MessageBox.Show("Tên hàng hóa không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (comboBoxDonViTinh.Text == "")
                {
                    MessageBox.Show("Đơn vị tính không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (comboBoxNhomHang.Text == "")
                {
                    MessageBox.Show("Nhóm hàng không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtBoxGiaBan.Text == "")
                {
                    MessageBox.Show("Giá bán không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtBoxGiaVon.Text == "")
                {
                    MessageBox.Show("Giá vốn không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (numericUpDownTonKho.Value < 0)
                {
                    MessageBox.Show("Tồn kho không được nhỏ hơn 0 !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Nếu tất cả các trường hợp đều thỏa, tiến hành thực hiện chức năng save
                if (hangHoaServices.editHangHoa(maHangHoa, txtBoxTenHangHoa.Text, comboBoxNhomHang.Text, txtBoxGiaBan.Text, txtBoxGiaVon.Text,
                    numericUpDownTonKho.Value.ToString(), comboBoxDonViTinh.Text, txtBoxMaSKU.Text))
                {
                    // sau đó sẽ đổi lại các button trở lại ban đầu
                    // đổi tên
                    btnChinhSuaThongTin.Text = "Chỉnh sửa";
                    // show các icon và enable các textbox;
                    // Tắt readonly
                    checkEdit = false;
                    txtBoxTenHangHoa.ReadOnly = true;
                    txtBoxGiaBan.ReadOnly = true;
                    txtBoxGiaVon.ReadOnly = true;
                    numericUpDownTonKho.ReadOnly = true;


                    // chỉnh lại màu trắng
                    txtBoxTenHangHoa.BackColor = Color.FromArgb(216, 252, 216);
                    txtBoxGiaBan.BackColor = Color.FromArgb(216, 252, 216);
                    txtBoxGiaVon.BackColor = Color.FromArgb(216, 252, 216);
                    numericUpDownTonKho.BackColor = Color.FromArgb(216, 252, 216);
                    txtBoxThuocTinh.BackColor = Color.FromArgb(216, 252, 216);
                    comboBoxDonViTinh.BackColor = Color.FromArgb(216, 252, 216);
                    comboBoxNhomHang.BackColor = Color.FromArgb(216, 252, 216);

                    // show các button chỉnh sửa và thêm
                    btnAddNhomHang.Visible = false;
                    btnAddDonViTinh.Visible = false;
                    btnEditImage.Visible = false;
                    btnEditThuocTinh.Visible = false;
                    // forcus txt đầu tiên
                    this.txtBoxTenHangHoa.Focus();
                    // luu thanh cong
                    MessageBox.Show("Lưu thành công :D", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void setDataFirstToForm()
        {
            if (this.maHangHoa != null)
            {
                HangHoa hangHoa = hangHoaServices.getHangHoaByMaHangHoa(maHangHoa);
                if (hangHoa != null)
                {
                    txtBoxMaHangHoa.Text = hangHoa.MaHangHoa;
                    txtBoxMaSKU.Text = hangHoa.MaBarCode;

                    txtBoxTenHangHoa.Text = hangHoa.TenHang;
                    txtBoxGiaBan.Text = string.Format("{0:n0}", hangHoa.GiaBan);
                    txtBoxGiaVon.Text = string.Format("{0:n0}", hangHoa.GiaVon);
                    numericUpDownTonKho.Value = (int)hangHoa.TonKho;

                    comboBoxDonViTinh.Text = donViTinhServices.getNameDonViTinhByMaDonVi((int)hangHoa.DonViTinh);
                    comboBoxNhomHang.Text = nhomHangServices.getNameNhomHangByMaNhomHang((int)hangHoa.NhomHang);

                    txtBoxThuocTinh.Text = thuoctinhServices.getThuocTinhHangHoa((int)hangHoa.ThuocTinh);

                    string resFolder = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources");

                    // hình ảnh
                    if (hangHoa.AnhDaiDien != null)
                    {
                        try
                        {
                            string path = Application.StartupPath + hangHoa.AnhDaiDien;
                            pictureBoxHinhAnhDaiDien.Image = Image.FromFile(path);
                        }
                        catch
                        {
                            pictureBoxHinhAnhDaiDien.Image = Resources.insert_image_icon;
                        }
                    }
                    else
                    {
                        pictureBoxHinhAnhDaiDien.Image = Properties.Resources.insert_image_icon;
                    }
                }
            }
        }

        /// <summary>
        /// load data combobox nhom hang va don vi tinh
        /// </summary>
        private void loadDataCombobox()
        {
            comboBoxNhomHang.DataSource = nhomHangServices.loadAllNameNhomHang();
            comboBoxDonViTinh.DataSource = donViTinhServices.loadAllNameDonViTinh();
        }

        private void btnAddNhomHang_Click(object sender, EventArgs e)
        {
            frmHangHoa_NhomHang frmHangHoaNhomHang = new frmHangHoa_NhomHang(this);
            frmHangHoaNhomHang.Show();
        }

        private void btnAddDonViTinh_Click(object sender, EventArgs e)
        {
            frmHangHoa_DonViTinh frmHangHoaDonViTinh = new frmHangHoa_DonViTinh(this);
            frmHangHoaDonViTinh.Show();
        }

        private void btnEditThuocTinh_Click(object sender, EventArgs e)
        {
            HangHoa hangHoa = hangHoaServices.getHangHoaByMaHangHoa(maHangHoa);
            frmHangHoa_ThuocTinh frmHangHoaThuocTinh = new frmHangHoa_ThuocTinh(this, (int)hangHoa.ThuocTinh);
            frmHangHoaThuocTinh.Show();
        }

        private void btnEditImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Title = "Select a Image";
            f.Filter = "JPG(*.JPG)|*.jpg";

            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\ProImages\"; // <---
            if (Directory.Exists(appPath) == false)                                              // <---
            {                                                                                    // <---
                Directory.CreateDirectory(appPath);                                              // <---
            }

            if (f.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // save
                    string iName = f.SafeFileName;
                    string filepath = f.FileName;

                    // save image to database
                    string path = @"\ProImages\" + iName;
                    if (hangHoaServices.setPathForImageHangHoa(maHangHoa, path))
                    {
                        File.Copy(filepath, appPath + iName);
                        pictureBoxHinhAnhDaiDien.Image = new Bitmap(f.OpenFile());
                        MessageBox.Show("Thêm ảnh thành công :D", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xãy ra!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to open file " + ex.Message);
                }
            }
            else
            {
                f.Dispose();
            }

        }
        public void setTextInComBoBoxDonviTinh(string tenDonViTinh)
        {          
            comboBoxDonViTinh.DataSource = donViTinhServices.loadAllNameDonViTinh();
            comboBoxDonViTinh.Text = tenDonViTinh;
        }
        public void setTextInComboboxNhomHang(string tenNhomHang)
        {
            comboBoxNhomHang.DataSource = nhomHangServices.loadAllNameNhomHang();
            comboBoxNhomHang.Text = tenNhomHang;
            
        }
    }
}
