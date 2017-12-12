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
    public partial class frmHangHoa_ThietLapGiaHangHoa_TaoGiaMoi : Form
    {
        private frmHangHoa_ThietLapGiaHangHoa frmThietLapGia;
        private double giaCu;
        private string maHangHoa;
        public frmHangHoa_ThietLapGiaHangHoa_TaoGiaMoi()
        {
            InitializeComponent();
            
        }

        public frmHangHoa_ThietLapGiaHangHoa_TaoGiaMoi(frmHangHoa_ThietLapGiaHangHoa frmThietLapGiaHangHoa, double giaCu,string maHangHoa)
        {
            frmThietLapGia = frmThietLapGiaHangHoa;
            this.giaCu = giaCu;
            this.maHangHoa = maHangHoa;
            InitializeComponent();
            setDataFirstToForm();
        }

        private void setDataFirstToForm()
        {
            txtBoxGiaCu.Text = string.Format("{0:n0}", giaCu);
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if(txtBoxGiaMoi.Text=="")
            {
                MessageBox.Show("Giá mới không được để trống!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //cập nhật giá bán mới cho sản phẩm
        }
    }
}
