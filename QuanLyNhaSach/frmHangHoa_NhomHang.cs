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
    public partial class frmHangHoa_NhomHang : Form
    {
        frmHangHoa_DanhMucHangHoa_XemChiTietHangHoa frmXemChiTietHH = new frmHangHoa_DanhMucHangHoa_XemChiTietHangHoa();
        NhomHangServices nhomHangServices;
        public frmHangHoa_NhomHang()
        {
            InitializeComponent();
        }

        public frmHangHoa_NhomHang(frmHangHoa_DanhMucHangHoa_XemChiTietHangHoa frmXemChiTietHangHoa)
        {
            InitializeComponent();
            nhomHangServices = new NhomHangServices();
            frmXemChiTietHH = frmXemChiTietHangHoa;
            getDataComBoBox();
        }

        private void frmHangHoa_NhomHang_Load(object sender, EventArgs e)
        {

        }

        private void getDataComBoBox()
        {
            comboBoxDanhSachNhomHang.DataSource = nhomHangServices.loadAllNameNhomHang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtBoxThemNhomHang.Text == "")
            {
                MessageBox.Show("Chưa nhập tên nhóm hàng mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có muốn thêm mới nhóm hàng?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // thêm dữ liệu vào database
                int check = nhomHangServices.addNewNhomHang(txtBoxThemNhomHang.Text);
                if (check == 1)
                {
                    DialogResult ketQua = MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (ketQua == DialogResult.OK)
                    {
                        // tắt form và trả về giá trị tại combobox bên kia
                        frmXemChiTietHH.setTextInComboboxNhomHang(txtBoxThemNhomHang.Text);
                        this.Hide();
                    }

                }
                else
                {
                    if (check == 0)
                    {
                        MessageBox.Show("Đã có nhóm hàng này rồi, nên không thể thêm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
