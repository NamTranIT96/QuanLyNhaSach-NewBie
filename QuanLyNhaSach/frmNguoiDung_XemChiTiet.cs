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
using BusinessEntities.EF;
using System.IO;
using QuanLyNhaSach.Properties;

namespace QuanLyNhaSach
{
    public partial class frmNguoiDung_XemChiTiet : Form
    {
        private string maNguoiDung = null;
        private frmMain m_frmMain;
        private NguoiDungServices nguoiDungServices;
        private UtilitiesServices utilitiesServices;
        private VaiTroServices vaiTroServices;
        private ChiNhanhServices chiNhanhServices;
        public frmNguoiDung_XemChiTiet()
        {
            InitializeComponent();
        }
        public frmNguoiDung_XemChiTiet(frmMain mfrmMain, string maND)
        {
            m_frmMain = mfrmMain;
            this.maNguoiDung = maND;
            InitializeComponent();
            nguoiDungServices = new NguoiDungServices();
            vaiTroServices = new VaiTroServices();
            chiNhanhServices = new ChiNhanhServices();
            utilitiesServices = new UtilitiesServices();
        }

        private void frmNguoiDung_XemChiTiet_Load(object sender, EventArgs e)
        {

            setDataComboBox();
            setDataFirstToForm();
        }

       

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setDataComboBox()
        {
            //get data combobox khu vuc nguoi dung

            comboBoxGioiTinh.DataSource = utilitiesServices.getDataGioiTinh();
            comboBoxKhuVuc.DataSource = utilitiesServices.getDataTinhThanh();

        }

        private void setDataFirstToForm()
        {
            if (maNguoiDung != null)
            {
                NguoiDung temp = nguoiDungServices.getMaNDangDungByMaND(maNguoiDung);
            
                if (temp != null)
                {
                    txtBoxMaND.Text = temp.MaNguoiDung;
                    txtBoxTenND.Text = temp.TenNguoiDung;
                    txtBoxDienThoai.Text = temp.DienThoai;
                    txtBoxDiaChi.Text = temp.DiaChi;
                    txtBoxNgaySinh.Text = temp.NgaySinh.ToString();
                    comboBoxKhuVuc.Text = temp.KhuVuc;
                    txtBoxEmail.Text = temp.Email;
                    comboBoxGioiTinh.Text = temp.GioiTinh;
                    txtBoxVaiTro.Text = vaiTroServices.getTenVaiTroByMaVaiTro((int)temp.VaiTro);
                    txtBoxChiNhanh.Text = chiNhanhServices.getTenVaiTroByMaChiNhanh((int)temp.ChiNhanh);
                    txtBoxPhuongXa.Text = temp.PhuongXa;
                    if (temp.AnhDaiDien != null)
                    {
                        try
                        {
                            string path = Application.StartupPath + temp.AnhDaiDien;
                            pictureBoxHinhAnhDaiDien.Image = Image.FromFile(path);
                        }
                        catch
                        {
                            pictureBoxHinhAnhDaiDien.Image = Resources.insert_image_icon;
                        }
                    }
                    else
                    {
                        pictureBoxHinhAnhDaiDien.Image = Resources.insert_image_icon;
                    }
                }
            }
        }

    }

  }

