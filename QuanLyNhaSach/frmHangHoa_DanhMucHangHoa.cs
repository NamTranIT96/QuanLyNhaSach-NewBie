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
    public partial class frmHangHoa_DanhMucHangHoa : Form
    {
        private HangHoaServices hangHoaServices;
        public frmHangHoa_DanhMucHangHoa()
        {
            hangHoaServices = new HangHoaServices();
            InitializeComponent();
            
        }

        private void frmHangHoa_DanhMucHangHoa_Load(object sender, EventArgs e)
        {
            initDataForDatagridviewHangHoa();
        }

        private void txtTheoMaHoaDon_Leave(object sender, EventArgs e)
        {

        }

        private void txtTheoMaHoaDon_Enter(object sender, EventArgs e)
        {

        }
        public void initDataForDatagridviewHangHoa()
        {
            DataTable datasource = hangHoaServices.getAllHangHoa();
            dataGridDanhSachHangHoa.DataSource = datasource;
        }

        private void dataGridDanhSachHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridDanhSachHangHoa.Columns[e.ColumnIndex].Name == "XemCT")
            {
                //dataGridDanhSachHoaDon.Rows.RemoveAt(e.RowIndex);
                string maHangHoa = dataGridDanhSachHangHoa.Rows[e.RowIndex].Cells[1].Value.ToString();
                frmHangHoa_DanhMucHangHoa_XemChiTietHangHoa frmHangHoa_XemChiTietHangHoa
                    = new frmHangHoa_DanhMucHangHoa_XemChiTietHangHoa(this,maHangHoa);

                frmHangHoa_XemChiTietHangHoa.Show();
            }
        }
    }
}
