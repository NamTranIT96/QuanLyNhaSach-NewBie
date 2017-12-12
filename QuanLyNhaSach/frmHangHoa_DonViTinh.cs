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
    public partial class frmHangHoa_DonViTinh : Form
    {
        frmHangHoa_DanhMucHangHoa_XemChiTietHangHoa frmXemChiTietHH = new frmHangHoa_DanhMucHangHoa_XemChiTietHangHoa();
        DonViTinhServices donViTinhServices;
        public frmHangHoa_DonViTinh()
        {
            InitializeComponent();
        }

        public frmHangHoa_DonViTinh(frmHangHoa_DanhMucHangHoa_XemChiTietHangHoa frmXemChiTiet)
        {
            InitializeComponent();
            donViTinhServices = new DonViTinhServices();
            frmXemChiTietHH = frmXemChiTiet;
            getDataComBoBox();
        }

        private void frmHangHoa_DonViTinh_Load(object sender, EventArgs e)
        {

        }

        private void getDataComBoBox()
        {
            comboBoxDanhSachDonViTinh.DataSource = donViTinhServices.loadAllNameDonViTinh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtBoxThemDonViTinh.Text == "")
            {
                MessageBox.Show("Chưa nhập tên đơn vị tính mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có muốn thêm mới đơn vị tính này?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // thêm dữ liệu vào database
                int check = donViTinhServices.addNewDonViTinh(txtBoxThemDonViTinh.Text);
                if (check == 1)
                {
                    DialogResult ketQua = MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (ketQua == DialogResult.OK)
                    {
                        // tắt form và trả về giá trị tại combobox bên kia
                        frmXemChiTietHH.setTextInComBoBoxDonviTinh(txtBoxThemDonViTinh.Text);
                        this.Hide();
                    }

                }
                else
                {
                    if(check == 0)
                    {
                        MessageBox.Show("Đã có đơn vị này rồi, nên không thể thêm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }
               
            }
            else
            {
                return;
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
