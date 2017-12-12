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
    public partial class frmDoiTac_NhaCungCap : Form
    {
        NhaCungCapServices nhaCungCapServices;
        public frmDoiTac_NhaCungCap()
        {
            InitializeComponent();
            nhaCungCapServices = new NhaCungCapServices();
        }

        private void frmDoiTac_NhaCungCap_Load(object sender, EventArgs e)
        {
            loadDataFirstToForm();
        }

        private void loadDataFirstToForm()
        {
            dataGridDanhSachNhaCungCap.DataSource = nhaCungCapServices.getAllNhaCungCap();
        }

        private void dataGridDanhSachNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridDanhSachNhaCungCap.Columns[e.ColumnIndex].Name == "XemCT")
            {
                //dataGridDanhSachHoaDon.Rows.RemoveAt(e.RowIndex);
                string maNhaCC = dataGridDanhSachNhaCungCap.Rows[e.RowIndex].Cells[1].Value.ToString();
                frmDoiTac_NhaCungCap_XemChiTiet frmDoiTac_NhaCungCap_XemChiTiet
                    = new frmDoiTac_NhaCungCap_XemChiTiet(this, maNhaCC);

                frmDoiTac_NhaCungCap_XemChiTiet.Show();
            }
        }
    }
}
