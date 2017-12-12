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
    public partial class frmGiaoDich_XemTraHang : Form
    {
        private HoaDonTraHangServices hoaDonTraHangServices;
        public frmGiaoDich_XemTraHang()
        {
            InitializeComponent();
            hoaDonTraHangServices = new HoaDonTraHangServices();
        }

        private void frmGiaoDich_XemTraHang_Load(object sender, EventArgs e)
        {
            loadDataDataGirdView();
        }

        private void loadDataDataGirdView()
        {
            dataGridDanhSachHoaDonTraHang.DataSource = hoaDonTraHangServices.getALLHoaDonTraHangConvertToDataTable();
        }
    }
}
