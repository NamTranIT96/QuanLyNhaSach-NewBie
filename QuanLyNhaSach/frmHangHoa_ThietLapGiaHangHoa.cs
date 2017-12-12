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
    public partial class frmHangHoa_ThietLapGiaHangHoa : Form
    {
        HangHoaServices hangHoaServices;
        public frmHangHoa_ThietLapGiaHangHoa()
        {
            InitializeComponent();
            hangHoaServices = new HangHoaServices();
        }

        private void frmHangHoa_ThietLapGiaHangHoa_Load(object sender, EventArgs e)
        {
            loadDataFirstToForm();
        }

        private void loadDataFirstToForm()
        {
            dataGridDanhSachHangHoa.DataSource = hangHoaServices.getAllHangHoaToChinhSuaGia();
        }

        private void dataGridDanhSachHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridDanhSachHangHoa.Columns[e.ColumnIndex].Name == "TaoGiaMoi")
            {
                string maHangHoa = dataGridDanhSachHangHoa.Rows[e.RowIndex].Cells[1].Value.ToString();
                string giaCu = dataGridDanhSachHangHoa.Rows[e.RowIndex].Cells[4].Value.ToString();
                frmHangHoa_ThietLapGiaHangHoa_TaoGiaMoi frmHangHoa_TaoGiaMoi
                    = new frmHangHoa_ThietLapGiaHangHoa_TaoGiaMoi(this, double.Parse(giaCu), maHangHoa);

                frmHangHoa_TaoGiaMoi.Show();
            }
        }
    }
}
