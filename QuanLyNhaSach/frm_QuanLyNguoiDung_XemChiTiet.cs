using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class frm_QuanLyNguoiDung_XemChiTiet : Form
    {
        public frm_QuanLyNguoiDung_XemChiTiet()
        {
            InitializeComponent();
        }
        //}
        //private void btnChinhSuaThongTin_Click(object sender, EventArgs e)
        //{
        //    if (btnChinhSuaThongTin.Text == "Chỉnh sửa")
        //    {
        //        btnChinhSuaThongTin.Text = "OK";

//        // Tắt readonly

//        txtBoxTenND.ReadOnly = false;
//        txtBoxDienThoai.ReadOnly = false;
//        txtBoxDiaChi.ReadOnly = false;
//        txtBoxNgaySinh.ReadOnly = false;
//        txtBoxEmail.ReadOnly = false;

//        // chỉnh lại màu trắng

//        txtBoxTenND.BackColor = Color.White;
//        txtBoxDienThoai.BackColor = Color.White;
//        txtBoxDiaChi.BackColor = Color.White;
//        txtBoxNgaySinh.BackColor = Color.White;
//        txtBoxEmail.BackColor = Color.White;
//        comboBoxKhuVuc.BackColor = Color.White;

//        // show các button chỉnh sửa và thêm
//        btnEditImage.Visible = true;

//        // forcus txt đầu tiên
//        this.txtBoxTenND.Focus();
//    }
//    else
//    {
//        // xét các trường hợp trong các ô text box bị trống
//        if (txtBoxTenND.Text == "")
//        {
//            MessageBox.Show("Tên người dùng không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            return;
//        }
//        if (txtBoxDienThoai.Text == "")
//        {
//            MessageBox.Show("Điện thoại không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            return;
//        }
//        if (txtBoxEmail.Text == "")
//        {
//            MessageBox.Show("Email không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            return;
//        }
//        if (txtBoxDiaChi.Text == "")
//        {
//            MessageBox.Show("Địa chỉ không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            return;
//        }
//        if (txtBoxNgaySinh.Text == "")
//        {
//            MessageBox.Show("Ngày sinh không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            return;
//        }
//        if (comboBoxKhuVuc.Text == "")
//        {
//            MessageBox.Show("Khu vực không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            return;
//        }
//        if (comboBoxGioiTinh.Text == "")
//        {
//            MessageBox.Show("Giới tính không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            return;
//        }

//        if (txtBoxVaiTro.Text == "")
//        {
//            MessageBox.Show("Vai Trò không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            return;
//        }
//        if (txtBoxChiNhanh.Text == "")
//        {
//            MessageBox.Show("Chi Nhánh không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            return;
//        }
//        if (txtBoxPhuongXa.Text == "")
//        {
//            MessageBox.Show("Phường xã không được để trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            return;
//        }
//        // thỏa hết thì lưu data

//    }
//}

/*

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
            if (nguoiDungServices.setPathForAvatar(maNguoiDung, path))
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
 */
}
}
