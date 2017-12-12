namespace QuanLyNhaSach
{
    partial class frmGiaoDich_XemTraHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.btnTimKiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dateTimeDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dateTimeTuNgay = new System.Windows.Forms.DateTimePicker();
            this.panelTimKiem = new System.Windows.Forms.Panel();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.panelDanhSachHoaDonMain = new System.Windows.Forms.Panel();
            this.dataGridDanhSachHoaDonTraHang = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.maHDTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHDBAnHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachHAng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNguoidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhiTraHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienTraLaiKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMaginMainRight = new System.Windows.Forms.Panel();
            this.panelMaginMainLeft = new System.Windows.Forms.Panel();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtTheoMaHoaDon = new System.Windows.Forms.TextBox();
            this.panelDanhSachHoaDonBot = new System.Windows.Forms.Panel();
            this.lblDanhSachHoaDon = new System.Windows.Forms.Label();
            this.panelDanhSachHoaDon = new System.Windows.Forms.Panel();
            this.panelDanhSachHoaDonTop = new System.Windows.Forms.Panel();
            this.panelMarginMid = new System.Windows.Forms.Panel();
            this.panelLeftTop = new System.Windows.Forms.Panel();
            this.panelThoiGian = new System.Windows.Forms.Panel();
            this.checkBoxThoiGian = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.panelTimKiemLeft = new System.Windows.Forms.Panel();
            this.panelMarginLeft = new System.Windows.Forms.Panel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelMarginTop = new System.Windows.Forms.Panel();
            this.panelTimKiem.SuspendLayout();
            this.panelDanhSachHoaDonMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDanhSachHoaDonTraHang)).BeginInit();
            this.panelDanhSachHoaDon.SuspendLayout();
            this.panelDanhSachHoaDonTop.SuspendLayout();
            this.panelLeftTop.SuspendLayout();
            this.panelThoiGian.SuspendLayout();
            this.panelTimKiemLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.Location = new System.Drawing.Point(9, 4);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(99, 22);
            this.lblThoiGian.TabIndex = 2;
            this.lblThoiGian.Text = "     Thời gian";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.BorderRadius = 0;
            this.btnTimKiem.ButtonText = " Tìm kiếm";
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.DisabledColor = System.Drawing.Color.Gray;
            this.btnTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTimKiem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Iconimage = global::QuanLyNhaSach.Properties.Resources.search_white;
            this.btnTimKiem.Iconimage_right = null;
            this.btnTimKiem.Iconimage_right_Selected = null;
            this.btnTimKiem.Iconimage_Selected = null;
            this.btnTimKiem.IconMarginLeft = 5;
            this.btnTimKiem.IconMarginRight = 0;
            this.btnTimKiem.IconRightVisible = true;
            this.btnTimKiem.IconRightZoom = 0D;
            this.btnTimKiem.IconVisible = true;
            this.btnTimKiem.IconZoom = 70D;
            this.btnTimKiem.IsTab = false;
            this.btnTimKiem.Location = new System.Drawing.Point(74, 422);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.btnTimKiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTimKiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimKiem.selected = false;
            this.btnTimKiem.Size = new System.Drawing.Size(114, 42);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = " Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Textcolor = System.Drawing.Color.White;
            this.btnTimKiem.TextFont = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dateTimeDenNgay
            // 
            this.dateTimeDenNgay.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDenNgay.Location = new System.Drawing.Point(10, 331);
            this.dateTimeDenNgay.Name = "dateTimeDenNgay";
            this.dateTimeDenNgay.Size = new System.Drawing.Size(244, 25);
            this.dateTimeDenNgay.TabIndex = 12;
            // 
            // dateTimeTuNgay
            // 
            this.dateTimeTuNgay.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTuNgay.Location = new System.Drawing.Point(10, 270);
            this.dateTimeTuNgay.Name = "dateTimeTuNgay";
            this.dateTimeTuNgay.Size = new System.Drawing.Size(245, 25);
            this.dateTimeTuNgay.TabIndex = 11;
            // 
            // panelTimKiem
            // 
            this.panelTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.panelTimKiem.Controls.Add(this.lblTimKiem);
            this.panelTimKiem.Location = new System.Drawing.Point(10, 55);
            this.panelTimKiem.Name = "panelTimKiem";
            this.panelTimKiem.Size = new System.Drawing.Size(245, 30);
            this.panelTimKiem.TabIndex = 1;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.ForeColor = System.Drawing.Color.White;
            this.lblTimKiem.Location = new System.Drawing.Point(8, 3);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(95, 22);
            this.lblTimKiem.TabIndex = 2;
            this.lblTimKiem.Text = "     Tìm kiếm";
            // 
            // panelDanhSachHoaDonMain
            // 
            this.panelDanhSachHoaDonMain.Controls.Add(this.dataGridDanhSachHoaDonTraHang);
            this.panelDanhSachHoaDonMain.Controls.Add(this.panelMaginMainRight);
            this.panelDanhSachHoaDonMain.Controls.Add(this.panelMaginMainLeft);
            this.panelDanhSachHoaDonMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDanhSachHoaDonMain.Location = new System.Drawing.Point(0, 55);
            this.panelDanhSachHoaDonMain.Name = "panelDanhSachHoaDonMain";
            this.panelDanhSachHoaDonMain.Size = new System.Drawing.Size(707, 380);
            this.panelDanhSachHoaDonMain.TabIndex = 13;
            // 
            // dataGridDanhSachHoaDonTraHang
            // 
            this.dataGridDanhSachHoaDonTraHang.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridDanhSachHoaDonTraHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridDanhSachHoaDonTraHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDanhSachHoaDonTraHang.BackgroundColor = System.Drawing.Color.White;
            this.dataGridDanhSachHoaDonTraHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDanhSachHoaDonTraHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDanhSachHoaDonTraHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridDanhSachHoaDonTraHang.ColumnHeadersHeight = 30;
            this.dataGridDanhSachHoaDonTraHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridDanhSachHoaDonTraHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHDTH,
            this.maHDBAnHang,
            this.tenKhachHAng,
            this.tenNguoidung,
            this.NgayGio,
            this.ThanhTien,
            this.PhiTraHang,
            this.TienTraLaiKhach});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridDanhSachHoaDonTraHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridDanhSachHoaDonTraHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDanhSachHoaDonTraHang.DoubleBuffered = true;
            this.dataGridDanhSachHoaDonTraHang.EnableHeadersVisualStyles = false;
            this.dataGridDanhSachHoaDonTraHang.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.dataGridDanhSachHoaDonTraHang.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridDanhSachHoaDonTraHang.Location = new System.Drawing.Point(10, 0);
            this.dataGridDanhSachHoaDonTraHang.Name = "dataGridDanhSachHoaDonTraHang";
            this.dataGridDanhSachHoaDonTraHang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridDanhSachHoaDonTraHang.Size = new System.Drawing.Size(687, 380);
            this.dataGridDanhSachHoaDonTraHang.TabIndex = 6;
            // 
            // maHDTH
            // 
            this.maHDTH.DataPropertyName = "MaHoaDon_TraHang";
            this.maHDTH.HeaderText = "Mã HD trả hàng";
            this.maHDTH.Name = "maHDTH";
            // 
            // maHDBAnHang
            // 
            this.maHDBAnHang.DataPropertyName = "MaHoaDon_BanHang";
            this.maHDBAnHang.HeaderText = "Mã HD bán hàng";
            this.maHDBAnHang.Name = "maHDBAnHang";
            // 
            // tenKhachHAng
            // 
            this.tenKhachHAng.DataPropertyName = "TenKhachHang";
            this.tenKhachHAng.HeaderText = "Tên khách hàng";
            this.tenKhachHAng.Name = "tenKhachHAng";
            // 
            // tenNguoidung
            // 
            this.tenNguoidung.DataPropertyName = "TenNguoiDung";
            this.tenNguoidung.HeaderText = "Tên người dùng";
            this.tenNguoidung.Name = "tenNguoidung";
            // 
            // NgayGio
            // 
            this.NgayGio.DataPropertyName = "NgayGio";
            this.NgayGio.HeaderText = "Ngày giờ";
            this.NgayGio.Name = "NgayGio";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // PhiTraHang
            // 
            this.PhiTraHang.DataPropertyName = "PhiTraHang";
            this.PhiTraHang.HeaderText = "Phí trả hàng";
            this.PhiTraHang.Name = "PhiTraHang";
            // 
            // TienTraLaiKhach
            // 
            this.TienTraLaiKhach.DataPropertyName = "TienTraLaiKhach";
            this.TienTraLaiKhach.HeaderText = "Tiền trả lại khách";
            this.TienTraLaiKhach.Name = "TienTraLaiKhach";
            // 
            // panelMaginMainRight
            // 
            this.panelMaginMainRight.BackColor = System.Drawing.Color.White;
            this.panelMaginMainRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMaginMainRight.Location = new System.Drawing.Point(697, 0);
            this.panelMaginMainRight.Name = "panelMaginMainRight";
            this.panelMaginMainRight.Size = new System.Drawing.Size(10, 380);
            this.panelMaginMainRight.TabIndex = 8;
            // 
            // panelMaginMainLeft
            // 
            this.panelMaginMainLeft.BackColor = System.Drawing.Color.White;
            this.panelMaginMainLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMaginMainLeft.Location = new System.Drawing.Point(0, 0);
            this.panelMaginMainLeft.Name = "panelMaginMainLeft";
            this.panelMaginMainLeft.Size = new System.Drawing.Size(10, 380);
            this.panelMaginMainLeft.TabIndex = 7;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachHang.ForeColor = System.Drawing.Color.Gray;
            this.txtTenKhachHang.Location = new System.Drawing.Point(10, 141);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(245, 25);
            this.txtTenKhachHang.TabIndex = 15;
            this.txtTenKhachHang.Text = "Theo tên khách hàng";
            // 
            // txtTheoMaHoaDon
            // 
            this.txtTheoMaHoaDon.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTheoMaHoaDon.ForeColor = System.Drawing.Color.Gray;
            this.txtTheoMaHoaDon.Location = new System.Drawing.Point(10, 106);
            this.txtTheoMaHoaDon.Name = "txtTheoMaHoaDon";
            this.txtTheoMaHoaDon.Size = new System.Drawing.Size(245, 25);
            this.txtTheoMaHoaDon.TabIndex = 14;
            this.txtTheoMaHoaDon.Text = "Theo mã hóa đơn";
            // 
            // panelDanhSachHoaDonBot
            // 
            this.panelDanhSachHoaDonBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.panelDanhSachHoaDonBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDanhSachHoaDonBot.Location = new System.Drawing.Point(0, 435);
            this.panelDanhSachHoaDonBot.Name = "panelDanhSachHoaDonBot";
            this.panelDanhSachHoaDonBot.Size = new System.Drawing.Size(707, 64);
            this.panelDanhSachHoaDonBot.TabIndex = 12;
            // 
            // lblDanhSachHoaDon
            // 
            this.lblDanhSachHoaDon.AutoSize = true;
            this.lblDanhSachHoaDon.Font = new System.Drawing.Font("UTM Avo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(77)))), ((int)(((byte)(91)))));
            this.lblDanhSachHoaDon.Location = new System.Drawing.Point(5, 10);
            this.lblDanhSachHoaDon.Name = "lblDanhSachHoaDon";
            this.lblDanhSachHoaDon.Size = new System.Drawing.Size(302, 28);
            this.lblDanhSachHoaDon.TabIndex = 10;
            this.lblDanhSachHoaDon.Text = "Danh Sách Hóa Đơn Trả Hàng";
            // 
            // panelDanhSachHoaDon
            // 
            this.panelDanhSachHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDanhSachHoaDon.Controls.Add(this.panelDanhSachHoaDonMain);
            this.panelDanhSachHoaDon.Controls.Add(this.panelDanhSachHoaDonBot);
            this.panelDanhSachHoaDon.Controls.Add(this.panelDanhSachHoaDonTop);
            this.panelDanhSachHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDanhSachHoaDon.Location = new System.Drawing.Point(286, 10);
            this.panelDanhSachHoaDon.Name = "panelDanhSachHoaDon";
            this.panelDanhSachHoaDon.Size = new System.Drawing.Size(709, 501);
            this.panelDanhSachHoaDon.TabIndex = 15;
            // 
            // panelDanhSachHoaDonTop
            // 
            this.panelDanhSachHoaDonTop.BackColor = System.Drawing.Color.White;
            this.panelDanhSachHoaDonTop.Controls.Add(this.lblDanhSachHoaDon);
            this.panelDanhSachHoaDonTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDanhSachHoaDonTop.Location = new System.Drawing.Point(0, 0);
            this.panelDanhSachHoaDonTop.Name = "panelDanhSachHoaDonTop";
            this.panelDanhSachHoaDonTop.Size = new System.Drawing.Size(707, 55);
            this.panelDanhSachHoaDonTop.TabIndex = 11;
            // 
            // panelMarginMid
            // 
            this.panelMarginMid.BackColor = System.Drawing.Color.White;
            this.panelMarginMid.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMarginMid.Location = new System.Drawing.Point(276, 10);
            this.panelMarginMid.Name = "panelMarginMid";
            this.panelMarginMid.Size = new System.Drawing.Size(10, 501);
            this.panelMarginMid.TabIndex = 14;
            // 
            // panelLeftTop
            // 
            this.panelLeftTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeftTop.Controls.Add(this.txtTenKhachHang);
            this.panelLeftTop.Controls.Add(this.txtTheoMaHoaDon);
            this.panelLeftTop.Controls.Add(this.btnTimKiem);
            this.panelLeftTop.Controls.Add(this.dateTimeDenNgay);
            this.panelLeftTop.Controls.Add(this.dateTimeTuNgay);
            this.panelLeftTop.Controls.Add(this.panelTimKiem);
            this.panelLeftTop.Controls.Add(this.panelThoiGian);
            this.panelLeftTop.Controls.Add(this.lblDenNgay);
            this.panelLeftTop.Controls.Add(this.lblTuNgay);
            this.panelLeftTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeftTop.Location = new System.Drawing.Point(0, 0);
            this.panelLeftTop.Name = "panelLeftTop";
            this.panelLeftTop.Size = new System.Drawing.Size(266, 501);
            this.panelLeftTop.TabIndex = 9;
            // 
            // panelThoiGian
            // 
            this.panelThoiGian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.panelThoiGian.Controls.Add(this.checkBoxThoiGian);
            this.panelThoiGian.Controls.Add(this.lblThoiGian);
            this.panelThoiGian.ForeColor = System.Drawing.Color.White;
            this.panelThoiGian.Location = new System.Drawing.Point(10, 204);
            this.panelThoiGian.Name = "panelThoiGian";
            this.panelThoiGian.Size = new System.Drawing.Size(245, 30);
            this.panelThoiGian.TabIndex = 3;
            // 
            // checkBoxThoiGian
            // 
            this.checkBoxThoiGian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkBoxThoiGian.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkBoxThoiGian.Checked = false;
            this.checkBoxThoiGian.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.checkBoxThoiGian.ForeColor = System.Drawing.Color.White;
            this.checkBoxThoiGian.Location = new System.Drawing.Point(5, 5);
            this.checkBoxThoiGian.Name = "checkBoxThoiGian";
            this.checkBoxThoiGian.Size = new System.Drawing.Size(20, 20);
            this.checkBoxThoiGian.TabIndex = 3;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenNgay.Location = new System.Drawing.Point(7, 310);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(75, 18);
            this.lblDenNgay.TabIndex = 10;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuNgay.Location = new System.Drawing.Point(7, 249);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(63, 18);
            this.lblTuNgay.TabIndex = 9;
            this.lblTuNgay.Text = "Từ ngày:";
            // 
            // panelTimKiemLeft
            // 
            this.panelTimKiemLeft.BackColor = System.Drawing.Color.White;
            this.panelTimKiemLeft.Controls.Add(this.panelLeftTop);
            this.panelTimKiemLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTimKiemLeft.Location = new System.Drawing.Point(10, 10);
            this.panelTimKiemLeft.Name = "panelTimKiemLeft";
            this.panelTimKiemLeft.Size = new System.Drawing.Size(266, 501);
            this.panelTimKiemLeft.TabIndex = 13;
            // 
            // panelMarginLeft
            // 
            this.panelMarginLeft.BackColor = System.Drawing.Color.White;
            this.panelMarginLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMarginLeft.Location = new System.Drawing.Point(0, 10);
            this.panelMarginLeft.Name = "panelMarginLeft";
            this.panelMarginLeft.Size = new System.Drawing.Size(10, 501);
            this.panelMarginLeft.TabIndex = 11;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 1;
            this.bunifuElipse2.TargetControl = this;
            // 
            // panelMarginTop
            // 
            this.panelMarginTop.BackColor = System.Drawing.Color.White;
            this.panelMarginTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMarginTop.Location = new System.Drawing.Point(0, 0);
            this.panelMarginTop.Name = "panelMarginTop";
            this.panelMarginTop.Size = new System.Drawing.Size(995, 10);
            this.panelMarginTop.TabIndex = 12;
            // 
            // frmGiaoDich_XemTraHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 511);
            this.Controls.Add(this.panelDanhSachHoaDon);
            this.Controls.Add(this.panelMarginMid);
            this.Controls.Add(this.panelTimKiemLeft);
            this.Controls.Add(this.panelMarginLeft);
            this.Controls.Add(this.panelMarginTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGiaoDich_XemTraHang";
            this.Text = "frmGiaoDich_XemTraHang";
            this.Load += new System.EventHandler(this.frmGiaoDich_XemTraHang_Load);
            this.panelTimKiem.ResumeLayout(false);
            this.panelTimKiem.PerformLayout();
            this.panelDanhSachHoaDonMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDanhSachHoaDonTraHang)).EndInit();
            this.panelDanhSachHoaDon.ResumeLayout(false);
            this.panelDanhSachHoaDonTop.ResumeLayout(false);
            this.panelDanhSachHoaDonTop.PerformLayout();
            this.panelLeftTop.ResumeLayout(false);
            this.panelLeftTop.PerformLayout();
            this.panelThoiGian.ResumeLayout(false);
            this.panelThoiGian.PerformLayout();
            this.panelTimKiemLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelDanhSachHoaDon;
        private System.Windows.Forms.Panel panelDanhSachHoaDonMain;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridDanhSachHoaDonTraHang;
        private System.Windows.Forms.Panel panelMaginMainRight;
        private System.Windows.Forms.Panel panelMaginMainLeft;
        private System.Windows.Forms.Panel panelDanhSachHoaDonBot;
        private System.Windows.Forms.Panel panelDanhSachHoaDonTop;
        private System.Windows.Forms.Label lblDanhSachHoaDon;
        private System.Windows.Forms.Panel panelMarginMid;
        private System.Windows.Forms.Panel panelTimKiemLeft;
        private System.Windows.Forms.Panel panelLeftTop;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtTheoMaHoaDon;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimKiem;
        private System.Windows.Forms.DateTimePicker dateTimeDenNgay;
        private System.Windows.Forms.DateTimePicker dateTimeTuNgay;
        private System.Windows.Forms.Panel panelTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Panel panelThoiGian;
        private Bunifu.Framework.UI.BunifuCheckbox checkBoxThoiGian;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Panel panelMarginLeft;
        private System.Windows.Forms.Panel panelMarginTop;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDBAnHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachHAng;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNguoidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhiTraHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienTraLaiKhach;
    }
}