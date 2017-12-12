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
using QuanLyNhaSach.Properties;
using System.IO;

namespace QuanLyNhaSach
{
    public partial class frmDoiTac_NhaCungCap_XemChiTiet : Form
    {
        private bool checkEdit = false;
        private string maNhaCungCap = null;
        private frmDoiTac_NhaCungCap frmNhaCungCap;
        private NhaCungCapServices nhaCungCapServices;
        private NhomNhaCungCapServices nhomNhaCCServices;
        public frmDoiTac_NhaCungCap_XemChiTiet()
        {
            InitializeComponent();
        }

        public frmDoiTac_NhaCungCap_XemChiTiet(frmDoiTac_NhaCungCap frmNhaCungCap, string maNhaCC)
        {
            maNhaCungCap = maNhaCC;
            this.frmNhaCungCap = frmNhaCungCap;
            InitializeComponent();
            nhaCungCapServices = new NhaCungCapServices();
            nhomNhaCCServices = new NhomNhaCungCapServices();
        }

        private void frmDoiTac_NhaCungCap_XemChiTiet_Load(object sender, EventArgs e)
        {
            setDataFirstToForm();
            
        }
        private void setDataFirstToForm()
        {
            if (maNhaCungCap != null)
            {
                NhaCungCap temp = nhaCungCapServices.getNhaCCByMaNhaCungCap(maNhaCungCap);
                if (temp != null)
                {
                    txtBoxMaNhaCC.Text = temp.MaNhaCungCap;
                    txtBoxTenNhaCC.Text = temp.TenNhaCungCap;
                    txtBoxDienThoai.Text = temp.DienThoai;
                    txtEmail.Text = temp.Email;
                    txtBoxDiaChi.Text = temp.DiaChi;
                    comboBoxKhuVuc.Text = temp.KhuVuc;
                    comboBoxNhomNhaCC.Text = nhomNhaCCServices.getNameNhomNhaCCByMaNhom((int)temp.NhomNhaCC);
                    txtBoxThuocCongTy.Text = temp.CongTy;
                    
                    if(temp.Logo !=null)
                    {
                        try
                        {
                            string path = Application.StartupPath + temp.Logo;
                            pictureBoxHinhAnhLoGo.Image = Image.FromFile(path);
                        }
                        catch
                        {
                            pictureBoxHinhAnhLoGo.Image = Resources.insert_image_icon;
                        }
                    }
                    else
                    {
                        pictureBoxHinhAnhLoGo.Image = Resources.insert_image_icon;
                    }
                }
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    if (nhaCungCapServices.setPathForLogo(maNhaCungCap, path))
                    {
                        File.Copy(filepath, appPath + iName);
                        pictureBoxHinhAnhLoGo.Image = new Bitmap(f.OpenFile());
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

        private void btnChinhSuaThongTin_Click(object sender, EventArgs e)
        {
            if (btnChinhSuaThongTin.Text == "Chỉnh sửa")
            {
                // đổi tên
                btnChinhSuaThongTin.Text = "OK";
                // show các icon và enable các textbox;
                // Tắt readonly
                checkEdit = true;
                txtBoxTenNhaCC.ReadOnly = false;
                txtBoxDienThoai.ReadOnly = false;
                txtBoxDiaChi.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtBoxThuocCongTy.ReadOnly = false;

                // chỉnh lại màu trắng
                txtBoxTenNhaCC.BackColor = Color.White;
                txtBoxDienThoai.BackColor = Color.White;
                txtBoxDiaChi.BackColor = Color.White;
                txtEmail.BackColor = Color.White;
                txtBoxThuocCongTy.BackColor = Color.White;
                comboBoxNhomNhaCC.BackColor = Color.White;
                comboBoxKhuVuc.BackColor = Color.White;

                // show các button chỉnh sửa và thêm
                btnEditImage.Visible = true;

                // forcus txt đầu tiên
                this.txtBoxTenNhaCC.Focus();

            }
            // nếu bấm OKE
            else
            {
                // xét các trường hợp trong các ô text box bị trống
                if (txtBoxTenNhaCC.Text == "")
                {
                    MessageBox.Show("Tên nhà cung cấp không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtBoxDienThoai.Text == "")
                {
                    MessageBox.Show("Điện thoại không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtEmail.Text == "")
                {
                    MessageBox.Show("Email không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtBoxDiaChi.Text == "")
                {
                    MessageBox.Show("Địa chỉ không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (comboBoxKhuVuc.Text == "")
                {
                    MessageBox.Show("Khu vực không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (comboBoxNhomNhaCC.Text == "")
                {
                    MessageBox.Show("Nhóm nhà cung cấp không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Nếu tất cả các trường hợp đều thỏa, tiến hành thực hiện chức năng save

            }
        }
    }
}
