using BusinessLogicLayer;
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
    public partial class frmBanHang_ThuNgan_TimKiemKhachHang : Form
    {
        private KhachHangServices khachHangServices;
        private frmBanHang_ThuNgan frmthuNganTemp;
        public frmBanHang_ThuNgan_TimKiemKhachHang()
        {
            InitializeComponent();
            khachHangServices = new KhachHangServices();
        }
        public frmBanHang_ThuNgan_TimKiemKhachHang(frmBanHang_ThuNgan frmThuNgan)
        {
            InitializeComponent();
            khachHangServices = new KhachHangServices();
            frmthuNganTemp = frmThuNgan;
        }

        private void frmBanHang_ThuNgan_TimKiemKhachHang_Load(object sender, EventArgs e)
        {
            loadDataAllKhachHangToDataGridView();
        }
        private void loadDataAllKhachHangToDataGridView()
        {
            DataTable datasource = khachHangServices.getAllKhachHang();
            if (datasource != null)
            {
                this.dataGridDanhSachKhachHang.DataSource = datasource;
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxSearch_Enter(object sender, EventArgs e)
        {
            if (txtBoxSearch.Text == "Tìm khách hàng")
            {
                txtBoxSearch.Text = "";
                txtBoxSearch.ForeColor = Color.Black;
            }
        }

        private void txtBoxSearch_Leave(object sender, EventArgs e)
        {
            if (txtBoxSearch.Text == "")
            {
                txtBoxSearch.Text = "Tìm khách hàng";
                txtBoxSearch.ForeColor = Color.DarkGray;
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (dataGridDanhSachKhachHang.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridDanhSachKhachHang.SelectedRows[0];
                string maKH = row.Cells[0].Value.ToString();
                string tenKH = row.Cells[1].Value.ToString();
                double tichDiem = double.Parse(row.Cells[5].Value.ToString());
                frmthuNganTemp.setKhachHangDangMua(maKH, tenKH,tichDiem);
                this.Hide();
            }
        }
    }
}
