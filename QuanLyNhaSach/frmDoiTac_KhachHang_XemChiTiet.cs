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
    public partial class frmDoiTac_KhachHang_XemChiTiet : Form
    {
        private bool checkEdit = false;
        private string maKhachHang = null;
        private frmDoiTac_KhachHang frmDoiTacKH;
        private KhachHangServices khachHangServices;
        private NhomKhachHangServices nhomKhachHangServices;
        private UtilitiesServices utilitiesServices;
        public frmDoiTac_KhachHang_XemChiTiet()
        {
            InitializeComponent();
        }

        public frmDoiTac_KhachHang_XemChiTiet(frmDoiTac_KhachHang frmDoiTacKhachHang, string maKH)
        {
            frmDoiTacKH = frmDoiTacKhachHang;
            this.maKhachHang = maKH;
            InitializeComponent();
            khachHangServices = new KhachHangServices();
            nhomKhachHangServices = new NhomKhachHangServices();
            utilitiesServices = new UtilitiesServices();
        }

        private void frmDoiTac_KhachHang_XemChiTiet_Load(object sender, EventArgs e)
        {
            setDataComboBox();
            setDataFirstToForm();
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void setDataFirstToForm()
        {
            if (maKhachHang != null)
            {
                KhachHang temp = khachHangServices.getKhachHangByMaKhachHang(maKhachHang);
                if (temp != null)
                {
                    txtBoxMaKhachHang.Text = temp.MaKhachHang;
                    txtBoxTenKhachHang.Text = temp.TenKhachHang;
                    txtBoxMaSoThue.Text = temp.MaSoThue;
                    txtBoxDienThoai.Text = temp.DienThoai;
                    txtBoxDiaChi.Text = temp.DiaChi;
                    txtBoxNgaySinh.Text = temp.NgaySinh.ToString();
                    comboBoxNhomKhachHang.Text = nhomKhachHangServices.getNameNhomKhachHangByMaNhom((int)temp.Nhom);
                    comboBoxKhuVuc.Text = temp.KhuVuc;
                    comboBoxGioiTinh.Text = temp.GioiTinh;
                    txtBoxEmail.Text = temp.Email;
                    txtBoxTichDiem.Text = string.Format("{0:n0}", temp.TichDiem);
                    txtBoxTienDaMua.Text = string.Format("{0:n0}", temp.TongTienMua);
                    txtBoxGhiChu.Text = string.Format("{0:n0}", temp.Ghichu);

                    if (temp.AnhDaiDien != null)
                    {
                        try
                        {
                            string path = Application.StartupPath + temp.AnhDaiDien;
                            pictureBoxHinhAnhDaiDien.Image = Image.FromFile(path);
                        }
                        catch
                        {
                            pictureBoxHinhAnhDaiDien.Image = Resources.insert_image_icon;
                        }
                    }
                    else
                    {
                        pictureBoxHinhAnhDaiDien.Image = Resources.insert_image_icon;
                    }
                }
            }
        }

        private void setDataComboBox()
        {
            //get data combobox nhom khach hang, gioi tinh, khu vuc
            comboBoxNhomKhachHang.DataSource = nhomKhachHangServices.getAllNameNhomKhachHang();
            comboBoxGioiTinh.DataSource = utilitiesServices.getDataGioiTinh();
            comboBoxKhuVuc.DataSource = utilitiesServices.getDataTinhThanh();

        }

        private void btnChinhSuaThongTin_Click(object sender, EventArgs e)
        {
            if(btnChinhSuaThongTin.Text == "Chỉnh sửa")
            {
                btnChinhSuaThongTin.Text = "OK";

                // Tắt readonly
                txtBoxMaSoThue.ReadOnly = false;
                txtBoxTenKhachHang.ReadOnly = false;
                txtBoxDienThoai.ReadOnly = false;
                txtBoxDiaChi.ReadOnly = false;
                txtBoxNgaySinh.ReadOnly = false;
                txtBoxEmail.ReadOnly = false;
                txtBoxGhiChu.ReadOnly = false;
                // chỉnh lại màu trắng
                txtBoxMaSoThue.BackColor = Color.White;
                txtBoxTenKhachHang.BackColor = Color.White;
                txtBoxDienThoai.BackColor = Color.White;
                txtBoxDiaChi.BackColor = Color.White;
                txtBoxNgaySinh.BackColor = Color.White;
                txtBoxEmail.BackColor = Color.White;
                txtBoxGhiChu.BackColor = Color.White;
                comboBoxGioiTinh.BackColor = Color.White;
                comboBoxKhuVuc.BackColor = Color.White;
                comboBoxNhomKhachHang.BackColor = Color.White;

                // show các button chỉnh sửa và thêm
                btnEditImage.Visible = true;

                // forcus txt đầu tiên
                this.txtBoxTenKhachHang.Focus();
            }
            else
            {
                // xét các trường hợp trong các ô text box bị trống
                if (txtBoxTenKhachHang.Text == "")
                {
                    MessageBox.Show("Tên khách hàng không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtBoxDienThoai.Text == "")
                {
                    MessageBox.Show("Điện thoại không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtBoxEmail.Text == "")
                {
                    MessageBox.Show("Email không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtBoxDiaChi.Text == "")
                {
                    MessageBox.Show("Địa chỉ không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtBoxNgaySinh.Text == "")
                {
                    MessageBox.Show("Ngày sinh không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (comboBoxKhuVuc.Text == "")
                {
                    MessageBox.Show("Khu vực không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (comboBoxGioiTinh.Text == "")
                {
                    MessageBox.Show("Giới tính không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (comboBoxNhomKhachHang.Text == "")
                {
                    MessageBox.Show("Nhóm khách hàng không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // thỏa hết thì lưu data
                // Nếu tất cả các trường hợp đều thỏa, tiến hành thực hiện chức năng save
                if (khachHangServices.editKhachHang(maKhachHang, txtBoxTenKhachHang.Text, txtBoxDienThoai.Text,
                    txtBoxDiaChi.Text, comboBoxKhuVuc.Text,null,txtBoxMaSoThue.Text,txtBoxNgaySinh.Text,comboBoxGioiTinh.Text,
                    txtBoxEmail.Text,comboBoxNhomKhachHang.Text,txtBoxGhiChu.Text))
                {
                    // sau đó sẽ đổi lại các button trở lại ban đầu
                    // đổi tên
                    btnChinhSuaThongTin.Text = "Chỉnh sửa";
                    // show các icon và enable các textbox;
              
                    checkEdit = false;
                    // bat readonly
                    txtBoxMaSoThue.ReadOnly = true;
                    txtBoxTenKhachHang.ReadOnly = true;
                    txtBoxDienThoai.ReadOnly = true;
                    txtBoxDiaChi.ReadOnly = true;
                    txtBoxNgaySinh.ReadOnly = true;
                    txtBoxEmail.ReadOnly = true;
                    txtBoxGhiChu.ReadOnly = true;
                    // chỉnh lại màu trắng
                    txtBoxMaSoThue.BackColor = Color.FromArgb(216, 252, 216);
                    txtBoxTenKhachHang.BackColor = Color.FromArgb(216, 252, 216);
                    txtBoxDienThoai.BackColor = Color.FromArgb(216, 252, 216);
                    txtBoxDiaChi.BackColor = Color.FromArgb(216, 252, 216);
                    txtBoxNgaySinh.BackColor = Color.FromArgb(216, 252, 216);
                    txtBoxEmail.BackColor = Color.FromArgb(216, 252, 216);
                    txtBoxGhiChu.BackColor = Color.FromArgb(216, 252, 216);
                    comboBoxGioiTinh.BackColor = Color.FromArgb(216, 252, 216);
                    comboBoxKhuVuc.BackColor = Color.FromArgb(216, 252, 216);
                    comboBoxNhomKhachHang.BackColor = Color.FromArgb(216, 252, 216);

                    // show các button chỉnh sửa và thêm
                    btnEditImage.Visible = false;
                    // forcus txt đầu tiên
                    this.txtBoxTenKhachHang.Focus();
                    // luu thanh cong
                    MessageBox.Show("Lưu thành công :D", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
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
                    if (khachHangServices.setPathForAvatar(maKhachHang, path))
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
    }
}
