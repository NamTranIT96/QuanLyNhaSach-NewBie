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
    public partial class frmHangHoa_ThuocTinh : Form
    {
        private frmHangHoa_DanhMucHangHoa_XemChiTietHangHoa frmXemChiTietHH;
        private ThuocTinhHangHoaServices thuocTinhHHServices;
        int maThuocTinh = -1;

        public frmHangHoa_ThuocTinh()
        {
            InitializeComponent();
        }

        public frmHangHoa_ThuocTinh(frmHangHoa_DanhMucHangHoa_XemChiTietHangHoa frmXemChiTietHH, int maThuocTinh)
        {
            InitializeComponent();
            this.frmXemChiTietHH = frmXemChiTietHH;
            this.maThuocTinh = maThuocTinh;
            thuocTinhHHServices = new ThuocTinhHangHoaServices();
        }

        private void frmHangHoa_ThuocTinh_Load(object sender, EventArgs e)
        {
            loadDataCombobox();
            loadDataFirstToForm();        
        }

        private void loadDataFirstToForm()
        {
            if (maThuocTinh != -1)
            {
                List<string> temp = thuocTinhHHServices.getThongTinTTByMaThuocTinh(maThuocTinh);
                if (temp != null)
                {
                    comboBoxMauSac.Text = temp[0];
                    txtBoxKichThuoc.Text = temp[1];
                    txtKhac.Text = temp[2];
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra!", "Lổi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi load dữ liệu!", "Lổi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void loadDataCombobox()
        {
            List<string> data = new List<string>();
            data.Add("Trắng");
            data.Add("Đen");
            data.Add("Đỏ");
            data.Add("Xanh");
            data.Add("Vàng");
            data.Add("Lục");
            data.Add("Lam");
            data.Add("Chàm");
            data.Add("Tím");
            data.Add("Tổng hợp");
            comboBoxMauSac.DataSource = data;
        }
    }
}
