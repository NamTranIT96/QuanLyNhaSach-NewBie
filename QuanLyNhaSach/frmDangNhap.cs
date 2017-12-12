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
    public partial class frmDangNhap : Form
    {
        // Khai báo đối tượng sử dụng
        private NguoiDungServices nguoiDungServices;
        private frmMain frmMain;
        private bool isLogin = false;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            nguoiDungServices = new NguoiDungServices();
            frmMain = new frmMain();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {


            if(txtBoxUserName.Text =="")
            {
                lblWarningUserName.Text = "Chưa nhập tên đăng nhập";
                lblWarningUserName.Visible = true;
                return;
            }
            
            if(txtBoxPassword.Text =="")
            {
                lblWarningPassword.Text = "Chưa nhập mật khẩu";
                lblWarningUserName.Visible = false;
                lblWarningPassword.Visible = true;
                return;
            }

            int check = nguoiDungServices.Login(txtBoxUserName.Text, txtBoxPassword.Text);

            // Check permission cua nguoi dung
            switch (check)
            {

                case -1:
                    {
                        // Tai khoan khong ton tai
                        lblWarningUserName.Text = "Tài khoản không tồn tại";
                        lblWarningUserName.Visible = true;
                        lblWarningPassword.Visible = false;
                        break;
                    }
                case 0:
                    {
                        // Mat khau khong dung
                        lblWarningUserName.Visible = false;
                        lblWarningPassword.Text = "Mật khẩu không chính xác";
                        lblWarningPassword.Visible = true;
                        break;
                    }
                default:
                    {
                        // Successlogin
                        lblWarningUserName.Visible = false;
                        lblWarningPassword.Visible = false;
                        //MessageBox.Show("đăng nhập thành công");
                         
                        frmMain.setPermission(check,nguoiDungServices.getMaNDangDung());
                        
                        isLogin = true;
                        break;
                    }
            }
            if(isLogin)
            {
                frmMain.Show();
                this.Hide();
            }
        }
    }
}
