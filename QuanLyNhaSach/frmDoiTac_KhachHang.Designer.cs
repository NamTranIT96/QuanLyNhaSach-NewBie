namespace QuanLyNhaSach
{
    partial class frmDoiTac_KhachHang
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
            this.dataGridDanhSachKhachHang = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TichDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XemCT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelTimKiem = new System.Windows.Forms.Panel();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.panelThoiGian = new System.Windows.Forms.Panel();
            this.checkBoxThoiGian = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblPhanLoaiTheoNhom = new System.Windows.Forms.Label();
            this.panelMaginMainRight = new System.Windows.Forms.Panel();
            this.panelMaginMainLeft = new System.Windows.Forms.Panel();
            this.panelDanhSachHoaDonBot = new System.Windows.Forms.Panel();
            this.btnThemKhachHang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblDanhSachKhachHang = new System.Windows.Forms.Label();
            this.panelDanhSachHoaDon = new System.Windows.Forms.Panel();
            this.panelDanhSachHoaDonMain = new System.Windows.Forms.Panel();
            this.panelDanhSachHoaDonTop = new System.Windows.Forms.Panel();
            this.panelMarginMid = new System.Windows.Forms.Panel();
            this.panelLeftTop = new System.Windows.Forms.Panel();
            this.comboBoxPhanLoai = new System.Windows.Forms.ComboBox();
            this.lblChonKhachHang = new System.Windows.Forms.Label();
            this.panelTimKiemLeft = new System.Windows.Forms.Panel();
            this.panelMarginLeft = new System.Windows.Forms.Panel();
            this.panelMarginTop = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDanhSachKhachHang)).BeginInit();
            this.panelTimKiem.SuspendLayout();
            this.panelThoiGian.SuspendLayout();
            this.panelDanhSachHoaDonBot.SuspendLayout();
            this.panelDanhSachHoaDon.SuspendLayout();
            this.panelDanhSachHoaDonMain.SuspendLayout();
            this.panelDanhSachHoaDonTop.SuspendLayout();
            this.panelLeftTop.SuspendLayout();
            this.panelTimKiemLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridDanhSachKhachHang
            // 
            this.dataGridDanhSachKhachHang.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridDanhSachKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridDanhSachKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDanhSachKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dataGridDanhSachKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDanhSachKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDanhSachKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridDanhSachKhachHang.ColumnHeadersHeight = 30;
            this.dataGridDanhSachKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridDanhSachKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhachHang,
            this.TenKhachHang,
            this.DienThoai,
            this.NgaySinh,
            this.KhuVuc,
            this.TichDiem,
            this.XemCT});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridDanhSachKhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridDanhSachKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDanhSachKhachHang.DoubleBuffered = true;
            this.dataGridDanhSachKhachHang.EnableHeadersVisualStyles = false;
            this.dataGridDanhSachKhachHang.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.dataGridDanhSachKhachHang.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridDanhSachKhachHang.Location = new System.Drawing.Point(10, 0);
            this.dataGridDanhSachKhachHang.Name = "dataGridDanhSachKhachHang";
            this.dataGridDanhSachKhachHang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridDanhSachKhachHang.Size = new System.Drawing.Size(621, 356);
            this.dataGridDanhSachKhachHang.TabIndex = 6;
            this.dataGridDanhSachKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDanhSachKhachHang_CellContentClick);
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.DataPropertyName = "MaKhachHang";
            this.MaKhachHang.HeaderText = "Mã khách hàng";
            this.MaKhachHang.Name = "MaKhachHang";
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Tên khách hàng";
            this.TenKhachHang.Name = "TenKhachHang";
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện thoại";
            this.DienThoai.Name = "DienThoai";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // KhuVuc
            // 
            this.KhuVuc.DataPropertyName = "KhuVuc";
            this.KhuVuc.HeaderText = "Khu vực";
            this.KhuVuc.Name = "KhuVuc";
            // 
            // TichDiem
            // 
            this.TichDiem.DataPropertyName = "TichDiem";
            this.TichDiem.HeaderText = "Tích điểm";
            this.TichDiem.Name = "TichDiem";
            // 
            // XemCT
            // 
            this.XemCT.HeaderText = "";
            this.XemCT.Name = "XemCT";
            this.XemCT.Text = "Xem chi tiết";
            this.XemCT.UseColumnTextForButtonValue = true;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachHang.ForeColor = System.Drawing.Color.Gray;
            this.txtTenKhachHang.Location = new System.Drawing.Point(10, 141);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(223, 25);
            this.txtTenKhachHang.TabIndex = 15;
            this.txtTenKhachHang.Text = "Theo tên khách hàng";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhachHang.ForeColor = System.Drawing.Color.Gray;
            this.txtMaKhachHang.Location = new System.Drawing.Point(10, 106);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(223, 25);
            this.txtMaKhachHang.TabIndex = 14;
            this.txtMaKhachHang.Text = "Theo mã khách hàng";
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
            // panelTimKiem
            // 
            this.panelTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.panelTimKiem.Controls.Add(this.lblTimKiem);
            this.panelTimKiem.Location = new System.Drawing.Point(10, 55);
            this.panelTimKiem.Name = "panelTimKiem";
            this.panelTimKiem.Size = new System.Drawing.Size(223, 30);
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
            // panelThoiGian
            // 
            this.panelThoiGian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.panelThoiGian.Controls.Add(this.checkBoxThoiGian);
            this.panelThoiGian.Controls.Add(this.lblPhanLoaiTheoNhom);
            this.panelThoiGian.ForeColor = System.Drawing.Color.White;
            this.panelThoiGian.Location = new System.Drawing.Point(10, 204);
            this.panelThoiGian.Name = "panelThoiGian";
            this.panelThoiGian.Size = new System.Drawing.Size(223, 30);
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
            // lblPhanLoaiTheoNhom
            // 
            this.lblPhanLoaiTheoNhom.AutoSize = true;
            this.lblPhanLoaiTheoNhom.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhanLoaiTheoNhom.Location = new System.Drawing.Point(9, 4);
            this.lblPhanLoaiTheoNhom.Name = "lblPhanLoaiTheoNhom";
            this.lblPhanLoaiTheoNhom.Size = new System.Drawing.Size(189, 22);
            this.lblPhanLoaiTheoNhom.TabIndex = 2;
            this.lblPhanLoaiTheoNhom.Text = "     Phân loại theo nhóm";
            // 
            // panelMaginMainRight
            // 
            this.panelMaginMainRight.BackColor = System.Drawing.Color.White;
            this.panelMaginMainRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMaginMainRight.Location = new System.Drawing.Point(631, 0);
            this.panelMaginMainRight.Name = "panelMaginMainRight";
            this.panelMaginMainRight.Size = new System.Drawing.Size(10, 356);
            this.panelMaginMainRight.TabIndex = 8;
            // 
            // panelMaginMainLeft
            // 
            this.panelMaginMainLeft.BackColor = System.Drawing.Color.White;
            this.panelMaginMainLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMaginMainLeft.Location = new System.Drawing.Point(0, 0);
            this.panelMaginMainLeft.Name = "panelMaginMainLeft";
            this.panelMaginMainLeft.Size = new System.Drawing.Size(10, 356);
            this.panelMaginMainLeft.TabIndex = 7;
            // 
            // panelDanhSachHoaDonBot
            // 
            this.panelDanhSachHoaDonBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.panelDanhSachHoaDonBot.Controls.Add(this.btnThemKhachHang);
            this.panelDanhSachHoaDonBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDanhSachHoaDonBot.Location = new System.Drawing.Point(0, 411);
            this.panelDanhSachHoaDonBot.Name = "panelDanhSachHoaDonBot";
            this.panelDanhSachHoaDonBot.Size = new System.Drawing.Size(641, 58);
            this.panelDanhSachHoaDonBot.TabIndex = 12;
            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.btnThemKhachHang.BackColor = System.Drawing.Color.Green;
            this.btnThemKhachHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemKhachHang.BorderRadius = 0;
            this.btnThemKhachHang.ButtonText = "Thêm KH";
            this.btnThemKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemKhachHang.DisabledColor = System.Drawing.Color.Gray;
            this.btnThemKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThemKhachHang.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThemKhachHang.Iconimage = global::QuanLyNhaSach.Properties.Resources.plus_3;
            this.btnThemKhachHang.Iconimage_right = null;
            this.btnThemKhachHang.Iconimage_right_Selected = null;
            this.btnThemKhachHang.Iconimage_Selected = null;
            this.btnThemKhachHang.IconMarginLeft = 5;
            this.btnThemKhachHang.IconMarginRight = 0;
            this.btnThemKhachHang.IconRightVisible = true;
            this.btnThemKhachHang.IconRightZoom = 0D;
            this.btnThemKhachHang.IconVisible = true;
            this.btnThemKhachHang.IconZoom = 70D;
            this.btnThemKhachHang.IsTab = false;
            this.btnThemKhachHang.Location = new System.Drawing.Point(284, 11);
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.Normalcolor = System.Drawing.Color.Green;
            this.btnThemKhachHang.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThemKhachHang.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThemKhachHang.selected = false;
            this.btnThemKhachHang.Size = new System.Drawing.Size(118, 42);
            this.btnThemKhachHang.TabIndex = 7;
            this.btnThemKhachHang.Text = "Thêm KH";
            this.btnThemKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThemKhachHang.Textcolor = System.Drawing.Color.White;
            this.btnThemKhachHang.TextFont = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKhachHang.Click += new System.EventHandler(this.btnThemKhachHang_Click);
            // 
            // lblDanhSachKhachHang
            // 
            this.lblDanhSachKhachHang.AutoSize = true;
            this.lblDanhSachKhachHang.Font = new System.Drawing.Font("UTM Avo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(77)))), ((int)(((byte)(91)))));
            this.lblDanhSachKhachHang.Location = new System.Drawing.Point(5, 10);
            this.lblDanhSachKhachHang.Name = "lblDanhSachKhachHang";
            this.lblDanhSachKhachHang.Size = new System.Drawing.Size(243, 28);
            this.lblDanhSachKhachHang.TabIndex = 10;
            this.lblDanhSachKhachHang.Text = "Danh Sách Khách Hàng";
            // 
            // panelDanhSachHoaDon
            // 
            this.panelDanhSachHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDanhSachHoaDon.Controls.Add(this.panelDanhSachHoaDonMain);
            this.panelDanhSachHoaDon.Controls.Add(this.panelDanhSachHoaDonBot);
            this.panelDanhSachHoaDon.Controls.Add(this.panelDanhSachHoaDonTop);
            this.panelDanhSachHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDanhSachHoaDon.Location = new System.Drawing.Point(265, 10);
            this.panelDanhSachHoaDon.Name = "panelDanhSachHoaDon";
            this.panelDanhSachHoaDon.Size = new System.Drawing.Size(643, 471);
            this.panelDanhSachHoaDon.TabIndex = 10;
            // 
            // panelDanhSachHoaDonMain
            // 
            this.panelDanhSachHoaDonMain.Controls.Add(this.dataGridDanhSachKhachHang);
            this.panelDanhSachHoaDonMain.Controls.Add(this.panelMaginMainRight);
            this.panelDanhSachHoaDonMain.Controls.Add(this.panelMaginMainLeft);
            this.panelDanhSachHoaDonMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDanhSachHoaDonMain.Location = new System.Drawing.Point(0, 55);
            this.panelDanhSachHoaDonMain.Name = "panelDanhSachHoaDonMain";
            this.panelDanhSachHoaDonMain.Size = new System.Drawing.Size(641, 356);
            this.panelDanhSachHoaDonMain.TabIndex = 13;
            // 
            // panelDanhSachHoaDonTop
            // 
            this.panelDanhSachHoaDonTop.BackColor = System.Drawing.Color.White;
            this.panelDanhSachHoaDonTop.Controls.Add(this.lblDanhSachKhachHang);
            this.panelDanhSachHoaDonTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDanhSachHoaDonTop.Location = new System.Drawing.Point(0, 0);
            this.panelDanhSachHoaDonTop.Name = "panelDanhSachHoaDonTop";
            this.panelDanhSachHoaDonTop.Size = new System.Drawing.Size(641, 55);
            this.panelDanhSachHoaDonTop.TabIndex = 11;
            // 
            // panelMarginMid
            // 
            this.panelMarginMid.BackColor = System.Drawing.Color.White;
            this.panelMarginMid.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMarginMid.Location = new System.Drawing.Point(255, 10);
            this.panelMarginMid.Name = "panelMarginMid";
            this.panelMarginMid.Size = new System.Drawing.Size(10, 471);
            this.panelMarginMid.TabIndex = 9;
            // 
            // panelLeftTop
            // 
            this.panelLeftTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeftTop.Controls.Add(this.comboBoxPhanLoai);
            this.panelLeftTop.Controls.Add(this.txtTenKhachHang);
            this.panelLeftTop.Controls.Add(this.txtMaKhachHang);
            this.panelLeftTop.Controls.Add(this.btnTimKiem);
            this.panelLeftTop.Controls.Add(this.panelTimKiem);
            this.panelLeftTop.Controls.Add(this.panelThoiGian);
            this.panelLeftTop.Controls.Add(this.lblChonKhachHang);
            this.panelLeftTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeftTop.Location = new System.Drawing.Point(0, 0);
            this.panelLeftTop.Name = "panelLeftTop";
            this.panelLeftTop.Size = new System.Drawing.Size(245, 471);
            this.panelLeftTop.TabIndex = 9;
            // 
            // comboBoxPhanLoai
            // 
            this.comboBoxPhanLoai.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPhanLoai.FormattingEnabled = true;
            this.comboBoxPhanLoai.Location = new System.Drawing.Point(11, 251);
            this.comboBoxPhanLoai.Name = "comboBoxPhanLoai";
            this.comboBoxPhanLoai.Size = new System.Drawing.Size(222, 26);
            this.comboBoxPhanLoai.TabIndex = 16;
            // 
            // lblChonKhachHang
            // 
            this.lblChonKhachHang.AutoSize = true;
            this.lblChonKhachHang.Font = new System.Drawing.Font("UTM Avo", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(77)))), ((int)(((byte)(91)))));
            this.lblChonKhachHang.Location = new System.Drawing.Point(7, 14);
            this.lblChonKhachHang.Name = "lblChonKhachHang";
            this.lblChonKhachHang.Size = new System.Drawing.Size(172, 24);
            this.lblChonKhachHang.TabIndex = 0;
            this.lblChonKhachHang.Text = "Chọn Khách Hàng";
            // 
            // panelTimKiemLeft
            // 
            this.panelTimKiemLeft.BackColor = System.Drawing.Color.White;
            this.panelTimKiemLeft.Controls.Add(this.panelLeftTop);
            this.panelTimKiemLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTimKiemLeft.Location = new System.Drawing.Point(10, 10);
            this.panelTimKiemLeft.Name = "panelTimKiemLeft";
            this.panelTimKiemLeft.Size = new System.Drawing.Size(245, 471);
            this.panelTimKiemLeft.TabIndex = 8;
            // 
            // panelMarginLeft
            // 
            this.panelMarginLeft.BackColor = System.Drawing.Color.White;
            this.panelMarginLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMarginLeft.Location = new System.Drawing.Point(0, 10);
            this.panelMarginLeft.Name = "panelMarginLeft";
            this.panelMarginLeft.Size = new System.Drawing.Size(10, 471);
            this.panelMarginLeft.TabIndex = 6;
            // 
            // panelMarginTop
            // 
            this.panelMarginTop.BackColor = System.Drawing.Color.White;
            this.panelMarginTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMarginTop.Location = new System.Drawing.Point(0, 0);
            this.panelMarginTop.Name = "panelMarginTop";
            this.panelMarginTop.Size = new System.Drawing.Size(908, 10);
            this.panelMarginTop.TabIndex = 7;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 1;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frmDoiTac_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 481);
            this.Controls.Add(this.panelDanhSachHoaDon);
            this.Controls.Add(this.panelMarginMid);
            this.Controls.Add(this.panelTimKiemLeft);
            this.Controls.Add(this.panelMarginLeft);
            this.Controls.Add(this.panelMarginTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoiTac_KhachHang";
            this.Text = "frmDoiTac_KhachHang";
            this.Load += new System.EventHandler(this.frmDoiTac_KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDanhSachKhachHang)).EndInit();
            this.panelTimKiem.ResumeLayout(false);
            this.panelTimKiem.PerformLayout();
            this.panelThoiGian.ResumeLayout(false);
            this.panelThoiGian.PerformLayout();
            this.panelDanhSachHoaDonBot.ResumeLayout(false);
            this.panelDanhSachHoaDon.ResumeLayout(false);
            this.panelDanhSachHoaDonMain.ResumeLayout(false);
            this.panelDanhSachHoaDonTop.ResumeLayout(false);
            this.panelDanhSachHoaDonTop.PerformLayout();
            this.panelLeftTop.ResumeLayout(false);
            this.panelLeftTop.PerformLayout();
            this.panelTimKiemLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridDanhSachKhachHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimKiem;
        private System.Windows.Forms.Panel panelTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Panel panelThoiGian;
        private System.Windows.Forms.Label lblPhanLoaiTheoNhom;
        private System.Windows.Forms.Panel panelMaginMainRight;
        private System.Windows.Forms.Panel panelMaginMainLeft;
        private System.Windows.Forms.Panel panelDanhSachHoaDonBot;
        private System.Windows.Forms.Label lblDanhSachKhachHang;
        private System.Windows.Forms.Panel panelDanhSachHoaDon;
        private System.Windows.Forms.Panel panelDanhSachHoaDonMain;
        private System.Windows.Forms.Panel panelDanhSachHoaDonTop;
        private System.Windows.Forms.Panel panelMarginMid;
        private System.Windows.Forms.Panel panelLeftTop;
        private System.Windows.Forms.Label lblChonKhachHang;
        private System.Windows.Forms.Panel panelTimKiemLeft;
        private System.Windows.Forms.Panel panelMarginLeft;
        private System.Windows.Forms.Panel panelMarginTop;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCheckbox checkBoxThoiGian;
        private System.Windows.Forms.ComboBox comboBoxPhanLoai;
        private Bunifu.Framework.UI.BunifuFlatButton btnThemKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TichDiem;
        private System.Windows.Forms.DataGridViewButtonColumn XemCT;
    }
}