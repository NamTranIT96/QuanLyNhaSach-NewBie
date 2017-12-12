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
using System.Drawing.Printing;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.LookAndFeel;

namespace QuanLyNhaSach
{
    public partial class frmMain : Form
    {
        public static bool checkMaximumSize = false;
        private int checkPermission = 0; // lấy thông tin vai trò của người dăng nhập
        private string maNDSuDung = null; // Mã người dùng đang sử dụng.
        private NguoiDungServices nguoidungServices;
        private frmBanHang_ThuNgan m_frmThuNgan;
        private frmBanHang_TraHang m_frmTraHang;
        private frmHangHoa_DanhMucHangHoa m_frmDanhMucHangHoa;
        private frmHangHoa_ThietLapGiaHangHoa m_frmThietLapGiaHangHoa;
        private frmGiaoDich_HoaDon m_frmDanhSachHoaDon;
        private frmGiaoDich_XemTraHang m_frmXemTraHang;
        private frmGiaoDich_NhapHang m_frmNhapHang;
        private frmDoiTac_KhachHang m_frmDoiTacKhachHang;
        private frmDoiTac_NhaCungCap m_frmDoiTacNhaCungCap;
        private frmBaoCao_CuoiNgay m_frmBaoCaoCuoiNgay;
        private frmBaoCao_TaiChinh m_frmBaoCaoTaiChinh;
        private frmNguoiDung_XemChiTiet m_frmNguoiDung_XemChiTiet;
        public frmMain()
        {
            nguoidungServices = new NguoiDungServices();

            m_frmThuNgan = new frmBanHang_ThuNgan();
            this.setSetting(m_frmThuNgan);
            m_frmTraHang = new frmBanHang_TraHang();
            this.setSetting(m_frmTraHang);
            m_frmDanhMucHangHoa = new frmHangHoa_DanhMucHangHoa();
            this.setSetting(m_frmDanhMucHangHoa);
            m_frmThietLapGiaHangHoa = new frmHangHoa_ThietLapGiaHangHoa();
            this.setSetting(m_frmThietLapGiaHangHoa);
            m_frmDanhSachHoaDon = new frmGiaoDich_HoaDon();
            this.setSetting(m_frmDanhSachHoaDon);
            m_frmXemTraHang = new frmGiaoDich_XemTraHang();
            this.setSetting(m_frmXemTraHang);
            m_frmNhapHang = new frmGiaoDich_NhapHang();
            this.setSetting(m_frmNhapHang);
            m_frmDoiTacKhachHang = new frmDoiTac_KhachHang();
            this.setSetting(m_frmDoiTacKhachHang);
            m_frmDoiTacNhaCungCap = new frmDoiTac_NhaCungCap();
            this.setSetting(m_frmDoiTacNhaCungCap);
            m_frmBaoCaoCuoiNgay = new frmBaoCao_CuoiNgay();
            this.setSetting(m_frmBaoCaoCuoiNgay);
            m_frmBaoCaoTaiChinh = new frmBaoCao_TaiChinh();
            this.setSetting(m_frmBaoCaoTaiChinh);
           

            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            setMenuByPermission();
            setInforNguoiDungToForm();
            this.transitionForm.ShowAsyc(this);
        }

        #region click event and button 

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (!checkMaximumSize)
            {
                this.WindowState = FormWindowState.Maximized;
                checkMaximumSize = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                checkMaximumSize = false;
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnOpenNavigate_Click(object sender, EventArgs e)
        {
            if (panelLeft.Width == 50)
            {

                panelLeft.Visible = false;
                panelLeft.Width = 215;
                lblChucVu.Visible = true;
                lblTen.Visible = true;
                animatorPanel2.ShowSync(panelLeft);
                animatorLogo.ShowSync(pictureBoxNguoiDung);
            }
            else
            {
                //pictureBoxNguoiDung.Visible = false;
                animatorLogo.HideSync(pictureBoxNguoiDung);
                panelLeft.Visible = false;
                panelLeft.Width = 50;
                lblChucVu.Visible = false;
                lblTen.Visible = false;
                animatorPanel.ShowSync(panelLeft);
            }
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            if (panelBanHangCanHide.Visible == true)
            {
                setPanelCanHideIsVisibleFalse();

            }
            else
            {
                setPanelCanHideIsVisibleFalse();
                panelBanHang.Height = 106;
                animatorLogo.ShowSync(panelBanHangCanHide);
            }
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            if (panelHangHoaCanHide.Visible == true)
            {
                setPanelCanHideIsVisibleFalse();
            }
            else
            {
                setPanelCanHideIsVisibleFalse();
                panelHangHoa.Height = 106;
                animatorLogo.ShowSync(panelHangHoaCanHide);
            }
        }

        private void btnGiaoDich_Click(object sender, EventArgs e)
        {
            if (panelGiaoDichCanHide.Visible == true)
            {
                setPanelCanHideIsVisibleFalse();
            }
            else
            {
                setPanelCanHideIsVisibleFalse();
                panelGiaoDich.Height = 166;
                animatorLogo.ShowSync(panelGiaoDichCanHide);
            }
        }
        private void btnDoiTac_Click(object sender, EventArgs e)
        {
            if (panelDoiTacCanHide.Visible == true)
            {
                setPanelCanHideIsVisibleFalse();
            }
            else
            {
                setPanelCanHideIsVisibleFalse();
                panelDoiTac.Height = 106;
                animatorLogo.ShowSync(panelDoiTacCanHide);
            }
        }
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (panelBaoCaoCanHide.Visible == true)
            {
                setPanelCanHideIsVisibleFalse();
            }
            else
            {
                setPanelCanHideIsVisibleFalse();
                panelBaoCao.Height = 106;
                animatorLogo.ShowSync(panelBaoCaoCanHide);
            }
        }

        #endregion

        #region Function to call

        // function to get panelMain
        public Panel getPanelMain
        {
            get { return this.panelMain; }
            set { this.panelMain = value; }
        }

        private void setSetting(Form form)
        {
            form.TopLevel = false;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
        }
        public void setForm(Form formToSet)
        {
            try
            {
                int a = this.panelMain.Controls.GetChildIndex(formToSet);
                if (a == 0) return;
            }
            catch
            {
                this.panelMain.Controls.Clear();
                this.panelMain.Controls.Add(formToSet);
                formToSet.Show();
            }
        }
        private void setPanelCanHideIsVisibleFalse()
        {
            // animatorLogo.HideSync(panelBanHangCanHide);
            panelBanHangCanHide.Visible = false;
            panelBanHang.Height = 46;

            //animatorLogo.HideSync(panelHangHoaCanHide);
            panelHangHoaCanHide.Visible = false;
            panelHangHoa.Height = 46;

            //animatorLogo.HideSync(panelGiaoDichCanHide);
            panelGiaoDichCanHide.Visible = false;
            panelGiaoDich.Height = 46;

            //animatorLogo.HideSync(panelDoiTacCanHide);
            panelDoiTacCanHide.Visible = false;
            panelDoiTac.Height = 46;

            //animatorLogo.HideSync(panelBaoCaoCanHide);
            panelBaoCaoCanHide.Visible = false;
            panelBaoCao.Height = 46;

        }

        #endregion

        #region Button BanHang

        private void btnThuNgan_Click(object sender, EventArgs e)
        {
            m_frmThuNgan.setMaNDSuDung(maNDSuDung);
            setForm(m_frmThuNgan);
        }

        private void btnTraHang_Click(object sender, EventArgs e)
        {
            m_frmTraHang.reloadDatagridviewDanhSachHoaDon();
            setForm(m_frmTraHang);
        }
        #endregion

        #region button HangHoa

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            setForm(m_frmDanhMucHangHoa);
        }

        private void btnThietLapGia_Click(object sender, EventArgs e)
        {
            setForm(m_frmThietLapGiaHangHoa);
        }
        #endregion

        #region button giaoDich
        /// <summary>
        /// Child of button giao dich
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            setForm(m_frmDanhSachHoaDon);
        }

        private void btnXemTraHang_Click(object sender, EventArgs e)
        {
            setForm(m_frmXemTraHang);
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            m_frmNhapHang.setMaNDSuDung(maNDSuDung);
            setForm(m_frmNhapHang);
        }

        private void btnTraHangNhap_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region button DoiTac
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            setForm(m_frmDoiTacKhachHang);
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            setForm(m_frmDoiTacNhaCungCap);
        }
        #endregion

        #region button Bao Cao
        private void btnBaoCaoCuoiNgay_Click(object sender, EventArgs e)
        {
            setForm(m_frmBaoCaoCuoiNgay);
        }
        private void btnBaoCaoTaiChinh_Click(object sender, EventArgs e)
        {
            setForm(m_frmBaoCaoTaiChinh);
        }

        #endregion

        #region setInforCheckPermisson
        // set vai tro 
        public void setPermission(int permisson,string maND)
        {
            if (permisson > 0)
            {
                checkPermission = permisson;
                maNDSuDung = maND;
            }
        }

        #endregion

        #region setMenuFollowPermision

        private void setMenuByPermission()
        {
            switch(checkPermission)
            {
                case 3:
                    {
                        panelHangHoa.Visible = false;
                        panelDoiTac.Visible = false;
                        panelBaoCao.Visible = false;
                        break;
                    }
                case 4:
                    {
                        panelBanHang.Visible = false;
                        break;
                    }           
            }
        }

        #endregion

        private void setInforNguoiDungToForm()
        {
            if(maNDSuDung != null)
            {
                lblTen.Text = nguoidungServices.getTenNguoiDungBymaND(maNDSuDung);
                lblChucVu.Text = nguoidungServices.getVaiTroNguoiDungBymaND(maNDSuDung);               
            }
        }

        private void btnXemThongTinNhanVien_Click(object sender, EventArgs e)
        {
            m_frmNguoiDung_XemChiTiet = new frmNguoiDung_XemChiTiet(this,maNDSuDung);
            m_frmNguoiDung_XemChiTiet.Show();
        }
    }
}
