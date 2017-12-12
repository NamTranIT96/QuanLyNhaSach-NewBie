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
    public partial class frmDoiTac_KhachHang : Form
    {
        KhachHangServices khachHangServices;
        public frmDoiTac_KhachHang()
        {
            khachHangServices = new KhachHangServices();
            InitializeComponent();
        }

        private void frmDoiTac_KhachHang_Load(object sender, EventArgs e)
        {
            loadDataFirstToDatagridview();
        }
        private void loadDataFirstToDatagridview()
        {
            dataGridDanhSachKhachHang.DataSource = khachHangServices.getAllKhachHang();
        }

        private void dataGridDanhSachKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridDanhSachKhachHang.Columns[e.ColumnIndex].Name == "XemCT")
            {

                string maKhachHang = dataGridDanhSachKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                frmDoiTac_KhachHang_XemChiTiet frmDoiTacKhachHang_XemChiTiet = new frmDoiTac_KhachHang_XemChiTiet(this, maKhachHang);
                frmDoiTacKhachHang_XemChiTiet.Show();

            }
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {

        }
    }
}
