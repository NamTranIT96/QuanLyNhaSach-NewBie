namespace QuanLyNhaSach
{
    partial class frmGiaoDich_NhapHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNumBerKhachThanhToan = new System.Windows.Forms.TextBox();
            this.txtNumberGiamGia = new System.Windows.Forms.TextBox();
            this.btnSearchKhachHang = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblNhaCungCap = new System.Windows.Forms.Label();
            this.txtTimNhaCC = new System.Windows.Forms.TextBox();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.lblNumberTienThuaTraKhach = new System.Windows.Forms.Label();
            this.lblNumberKhachCanTra = new System.Windows.Forms.Label();
            this.lblNumberTongTienHang = new System.Windows.Forms.Label();
            this.timerForHoaDon = new System.Windows.Forms.Timer(this.components);
            this.panelMarginMid = new System.Windows.Forms.Panel();
            this.panelMarginLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThemHangHoaVaoDanhSach = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.panelMidBot = new System.Windows.Forms.Panel();
            this.btnLamMoiHoaDon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTongTienHang = new System.Windows.Forms.Label();
            this.btnhoadonRight = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelMidTop = new System.Windows.Forms.Panel();
            this.txtGhiChu = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblTienThuaTraKhach = new System.Windows.Forms.Label();
            this.lblKhachThanhToan = new System.Windows.Forms.Label();
            this.lblKhachCanTra = new System.Windows.Forms.Label();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelRightMain = new System.Windows.Forms.Panel();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.panelRightBot = new System.Windows.Forms.Panel();
            this.btnThanhToan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelRightTop = new System.Windows.Forms.Panel();
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMainMid = new System.Windows.Forms.Panel();
            this.dataGridDanhSachHangHoa_NhapHang = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.MaHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchKhachHang)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            this.panelMidBot.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelRightMain.SuspendLayout();
            this.panelRightBot.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelMainMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDanhSachHangHoa_NhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumBerKhachThanhToan
            // 
            this.txtNumBerKhachThanhToan.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumBerKhachThanhToan.Location = new System.Drawing.Point(191, 243);
            this.txtNumBerKhachThanhToan.Name = "txtNumBerKhachThanhToan";
            this.txtNumBerKhachThanhToan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumBerKhachThanhToan.Size = new System.Drawing.Size(150, 25);
            this.txtNumBerKhachThanhToan.TabIndex = 22;
            this.txtNumBerKhachThanhToan.Text = "0";
            this.txtNumBerKhachThanhToan.Click += new System.EventHandler(this.txtNumBerKhachThanhToan_Click);
            this.txtNumBerKhachThanhToan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumBerKhachThanhToan_KeyPress);
            this.txtNumBerKhachThanhToan.Leave += new System.EventHandler(this.txtNumBerKhachThanhToan_Leave);
            // 
            // txtNumberGiamGia
            // 
            this.txtNumberGiamGia.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberGiamGia.Location = new System.Drawing.Point(191, 175);
            this.txtNumberGiamGia.Name = "txtNumberGiamGia";
            this.txtNumberGiamGia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumberGiamGia.Size = new System.Drawing.Size(150, 25);
            this.txtNumberGiamGia.TabIndex = 21;
            this.txtNumberGiamGia.Text = "0";
            this.txtNumberGiamGia.Click += new System.EventHandler(this.txtNumberGiamGia_Click);
            this.txtNumberGiamGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberGiamGia_KeyPress);
            // 
            // btnSearchKhachHang
            // 
            this.btnSearchKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSearchKhachHang.Image = global::QuanLyNhaSach.Properties.Resources.search;
            this.btnSearchKhachHang.ImageActive = null;
            this.btnSearchKhachHang.Location = new System.Drawing.Point(304, 41);
            this.btnSearchKhachHang.Name = "btnSearchKhachHang";
            this.btnSearchKhachHang.Size = new System.Drawing.Size(37, 25);
            this.btnSearchKhachHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearchKhachHang.TabIndex = 20;
            this.btnSearchKhachHang.TabStop = false;
            this.btnSearchKhachHang.Zoom = 10;
            // 
            // lblNhaCungCap
            // 
            this.lblNhaCungCap.AutoSize = true;
            this.lblNhaCungCap.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaCungCap.Location = new System.Drawing.Point(5, 45);
            this.lblNhaCungCap.Name = "lblNhaCungCap";
            this.lblNhaCungCap.Size = new System.Drawing.Size(98, 17);
            this.lblNhaCungCap.TabIndex = 19;
            this.lblNhaCungCap.Text = "Nhà cung cấp :";
            // 
            // txtTimNhaCC
            // 
            this.txtTimNhaCC.BackColor = System.Drawing.Color.White;
            this.txtTimNhaCC.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimNhaCC.ForeColor = System.Drawing.Color.Black;
            this.txtTimNhaCC.Location = new System.Drawing.Point(105, 41);
            this.txtTimNhaCC.Name = "txtTimNhaCC";
            this.txtTimNhaCC.Size = new System.Drawing.Size(200, 25);
            this.txtTimNhaCC.TabIndex = 4;
            this.txtTimNhaCC.Text = "Tìm nhà cung cấp";
            this.txtTimNhaCC.Enter += new System.EventHandler(this.txtTimNhaCC_Enter);
            this.txtTimNhaCC.Leave += new System.EventHandler(this.txtTimNhaCC_Leave);
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhanVien.Location = new System.Drawing.Point(71, 8);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(105, 17);
            this.lblTenNhanVien.TabIndex = 18;
            this.lblTenNhanVien.Text = "Trần Hoàng Nam";
            // 
            // lblNumberTienThuaTraKhach
            // 
            this.lblNumberTienThuaTraKhach.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberTienThuaTraKhach.Location = new System.Drawing.Point(179, 279);
            this.lblNumberTienThuaTraKhach.Name = "lblNumberTienThuaTraKhach";
            this.lblNumberTienThuaTraKhach.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNumberTienThuaTraKhach.Size = new System.Drawing.Size(165, 18);
            this.lblNumberTienThuaTraKhach.TabIndex = 17;
            this.lblNumberTienThuaTraKhach.Text = "0";
            // 
            // lblNumberKhachCanTra
            // 
            this.lblNumberKhachCanTra.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberKhachCanTra.Location = new System.Drawing.Point(176, 210);
            this.lblNumberKhachCanTra.Name = "lblNumberKhachCanTra";
            this.lblNumberKhachCanTra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNumberKhachCanTra.Size = new System.Drawing.Size(168, 18);
            this.lblNumberKhachCanTra.TabIndex = 15;
            this.lblNumberKhachCanTra.Text = "0";
            this.lblNumberKhachCanTra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNumberTongTienHang
            // 
            this.lblNumberTongTienHang.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberTongTienHang.Location = new System.Drawing.Point(176, 141);
            this.lblNumberTongTienHang.Name = "lblNumberTongTienHang";
            this.lblNumberTongTienHang.Size = new System.Drawing.Size(168, 18);
            this.lblNumberTongTienHang.TabIndex = 13;
            this.lblNumberTongTienHang.Text = "0";
            this.lblNumberTongTienHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerForHoaDon
            // 
            this.timerForHoaDon.Interval = 1000;
            this.timerForHoaDon.Tick += new System.EventHandler(this.timerForHoaDon_Tick);
            // 
            // panelMarginMid
            // 
            this.panelMarginMid.BackColor = System.Drawing.Color.White;
            this.panelMarginMid.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMarginMid.Location = new System.Drawing.Point(681, 60);
            this.panelMarginMid.Name = "panelMarginMid";
            this.panelMarginMid.Size = new System.Drawing.Size(10, 477);
            this.panelMarginMid.TabIndex = 12;
            // 
            // panelMarginLeft
            // 
            this.panelMarginLeft.BackColor = System.Drawing.Color.White;
            this.panelMarginLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMarginLeft.Location = new System.Drawing.Point(0, 10);
            this.panelMarginLeft.Name = "panelMarginLeft";
            this.panelMarginLeft.Size = new System.Drawing.Size(11, 527);
            this.panelMarginLeft.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 10);
            this.panel1.TabIndex = 13;
            // 
            // bunifuDragControl
            // 
            this.bunifuDragControl.Fixed = true;
            this.bunifuDragControl.Horizontal = true;
            this.bunifuDragControl.TargetControl = this.panelTop;
            this.bunifuDragControl.Vertical = true;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.panelTop.Controls.Add(this.numSoLuong);
            this.panelTop.Controls.Add(this.btnThemHangHoaVaoDanhSach);
            this.panelTop.Controls.Add(this.pictureBoxSearch);
            this.panelTop.Controls.Add(this.txtBoxSearch);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(11, 10);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1043, 50);
            this.panelTop.TabIndex = 7;
            // 
            // numSoLuong
            // 
            this.numSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numSoLuong.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoLuong.Location = new System.Drawing.Point(411, 14);
            this.numSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(58, 25);
            this.numSoLuong.TabIndex = 2;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThemHangHoaVaoDanhSach
            // 
            this.btnThemHangHoaVaoDanhSach.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnThemHangHoaVaoDanhSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnThemHangHoaVaoDanhSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemHangHoaVaoDanhSach.BorderRadius = 0;
            this.btnThemHangHoaVaoDanhSach.ButtonText = "  Thêm";
            this.btnThemHangHoaVaoDanhSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemHangHoaVaoDanhSach.DisabledColor = System.Drawing.Color.Gray;
            this.btnThemHangHoaVaoDanhSach.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThemHangHoaVaoDanhSach.Iconimage = null;
            this.btnThemHangHoaVaoDanhSach.Iconimage_right = null;
            this.btnThemHangHoaVaoDanhSach.Iconimage_right_Selected = null;
            this.btnThemHangHoaVaoDanhSach.Iconimage_Selected = null;
            this.btnThemHangHoaVaoDanhSach.IconMarginLeft = 0;
            this.btnThemHangHoaVaoDanhSach.IconMarginRight = 0;
            this.btnThemHangHoaVaoDanhSach.IconRightVisible = true;
            this.btnThemHangHoaVaoDanhSach.IconRightZoom = 0D;
            this.btnThemHangHoaVaoDanhSach.IconVisible = true;
            this.btnThemHangHoaVaoDanhSach.IconZoom = 60D;
            this.btnThemHangHoaVaoDanhSach.IsTab = false;
            this.btnThemHangHoaVaoDanhSach.Location = new System.Drawing.Point(495, 13);
            this.btnThemHangHoaVaoDanhSach.Name = "btnThemHangHoaVaoDanhSach";
            this.btnThemHangHoaVaoDanhSach.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnThemHangHoaVaoDanhSach.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnThemHangHoaVaoDanhSach.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThemHangHoaVaoDanhSach.selected = false;
            this.btnThemHangHoaVaoDanhSach.Size = new System.Drawing.Size(54, 28);
            this.btnThemHangHoaVaoDanhSach.TabIndex = 3;
            this.btnThemHangHoaVaoDanhSach.Text = "  Thêm";
            this.btnThemHangHoaVaoDanhSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemHangHoaVaoDanhSach.Textcolor = System.Drawing.Color.White;
            this.btnThemHangHoaVaoDanhSach.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHangHoaVaoDanhSach.Click += new System.EventHandler(this.btnThemHangHoaVaoDanhSach_Click);
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.BackColor = System.Drawing.Color.White;
            this.pictureBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSearch.Image = global::QuanLyNhaSach.Properties.Resources.search;
            this.pictureBoxSearch.Location = new System.Drawing.Point(13, 12);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(28, 28);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSearch.TabIndex = 2;
            this.pictureBoxSearch.TabStop = false;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Font = new System.Drawing.Font("UTM Avo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxSearch.Location = new System.Drawing.Point(40, 12);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(356, 28);
            this.txtBoxSearch.TabIndex = 1;
            this.txtBoxSearch.Text = "Tìm mặt hàng";
            this.txtBoxSearch.Enter += new System.EventHandler(this.txtBoxSearch_Enter);
            this.txtBoxSearch.Leave += new System.EventHandler(this.txtBoxSearch_Leave);
            // 
            // panelMidBot
            // 
            this.panelMidBot.Controls.Add(this.btnLamMoiHoaDon);
            this.panelMidBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMidBot.Location = new System.Drawing.Point(0, 418);
            this.panelMidBot.Name = "panelMidBot";
            this.panelMidBot.Size = new System.Drawing.Size(670, 59);
            this.panelMidBot.TabIndex = 2;
            // 
            // btnLamMoiHoaDon
            // 
            this.btnLamMoiHoaDon.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.btnLamMoiHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.btnLamMoiHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLamMoiHoaDon.BorderRadius = 0;
            this.btnLamMoiHoaDon.ButtonText = "Làm mới";
            this.btnLamMoiHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoiHoaDon.DisabledColor = System.Drawing.Color.Gray;
            this.btnLamMoiHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLamMoiHoaDon.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLamMoiHoaDon.Iconimage = global::QuanLyNhaSach.Properties.Resources.giaodich_3;
            this.btnLamMoiHoaDon.Iconimage_right = null;
            this.btnLamMoiHoaDon.Iconimage_right_Selected = null;
            this.btnLamMoiHoaDon.Iconimage_Selected = null;
            this.btnLamMoiHoaDon.IconMarginLeft = 5;
            this.btnLamMoiHoaDon.IconMarginRight = 0;
            this.btnLamMoiHoaDon.IconRightVisible = true;
            this.btnLamMoiHoaDon.IconRightZoom = 0D;
            this.btnLamMoiHoaDon.IconVisible = true;
            this.btnLamMoiHoaDon.IconZoom = 70D;
            this.btnLamMoiHoaDon.IsTab = false;
            this.btnLamMoiHoaDon.Location = new System.Drawing.Point(287, 14);
            this.btnLamMoiHoaDon.Name = "btnLamMoiHoaDon";
            this.btnLamMoiHoaDon.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.btnLamMoiHoaDon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLamMoiHoaDon.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLamMoiHoaDon.selected = false;
            this.btnLamMoiHoaDon.Size = new System.Drawing.Size(109, 42);
            this.btnLamMoiHoaDon.TabIndex = 4;
            this.btnLamMoiHoaDon.Text = "Làm mới";
            this.btnLamMoiHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLamMoiHoaDon.Textcolor = System.Drawing.Color.White;
            this.btnLamMoiHoaDon.TextFont = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblTongTienHang
            // 
            this.lblTongTienHang.AutoSize = true;
            this.lblTongTienHang.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienHang.Location = new System.Drawing.Point(5, 141);
            this.lblTongTienHang.Name = "lblTongTienHang";
            this.lblTongTienHang.Size = new System.Drawing.Size(105, 18);
            this.lblTongTienHang.TabIndex = 7;
            this.lblTongTienHang.Text = "Tổng tiền hàng";
            // 
            // btnhoadonRight
            // 
            this.btnhoadonRight.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.btnhoadonRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.btnhoadonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhoadonRight.BorderRadius = 0;
            this.btnhoadonRight.ButtonText = "      Hóa đơn";
            this.btnhoadonRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhoadonRight.DisabledColor = System.Drawing.Color.Gray;
            this.btnhoadonRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnhoadonRight.Iconcolor = System.Drawing.Color.Transparent;
            this.btnhoadonRight.Iconimage = null;
            this.btnhoadonRight.Iconimage_right = null;
            this.btnhoadonRight.Iconimage_right_Selected = null;
            this.btnhoadonRight.Iconimage_Selected = null;
            this.btnhoadonRight.IconMarginLeft = 0;
            this.btnhoadonRight.IconMarginRight = 0;
            this.btnhoadonRight.IconRightVisible = true;
            this.btnhoadonRight.IconRightZoom = 0D;
            this.btnhoadonRight.IconVisible = true;
            this.btnhoadonRight.IconZoom = 90D;
            this.btnhoadonRight.IsTab = false;
            this.btnhoadonRight.Location = new System.Drawing.Point(41, 91);
            this.btnhoadonRight.Name = "btnhoadonRight";
            this.btnhoadonRight.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.btnhoadonRight.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.btnhoadonRight.OnHoverTextColor = System.Drawing.Color.White;
            this.btnhoadonRight.selected = false;
            this.btnhoadonRight.Size = new System.Drawing.Size(98, 30);
            this.btnhoadonRight.TabIndex = 6;
            this.btnhoadonRight.Text = "      Hóa đơn";
            this.btnhoadonRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhoadonRight.Textcolor = System.Drawing.Color.White;
            this.btnhoadonRight.TextFont = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panelMidTop
            // 
            this.panelMidTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMidTop.Location = new System.Drawing.Point(0, 0);
            this.panelMidTop.Name = "panelMidTop";
            this.panelMidTop.Size = new System.Drawing.Size(670, 10);
            this.panelMidTop.TabIndex = 1;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGhiChu.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.ForeColor = System.Drawing.Color.Black;
            this.txtGhiChu.HintForeColor = System.Drawing.Color.Black;
            this.txtGhiChu.HintText = "Ghi chú";
            this.txtGhiChu.isPassword = false;
            this.txtGhiChu.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtGhiChu.LineIdleColor = System.Drawing.Color.Gray;
            this.txtGhiChu.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtGhiChu.LineThickness = 1;
            this.txtGhiChu.Location = new System.Drawing.Point(8, 318);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(333, 27);
            this.txtGhiChu.TabIndex = 12;
            this.txtGhiChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblTienThuaTraKhach
            // 
            this.lblTienThuaTraKhach.AutoSize = true;
            this.lblTienThuaTraKhach.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienThuaTraKhach.Location = new System.Drawing.Point(4, 279);
            this.lblTienThuaTraKhach.Name = "lblTienThuaTraKhach";
            this.lblTienThuaTraKhach.Size = new System.Drawing.Size(66, 18);
            this.lblTienThuaTraKhach.TabIndex = 11;
            this.lblTienThuaTraKhach.Text = "Tiền thừa";
            // 
            // lblKhachThanhToan
            // 
            this.lblKhachThanhToan.AutoSize = true;
            this.lblKhachThanhToan.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachThanhToan.Location = new System.Drawing.Point(4, 246);
            this.lblKhachThanhToan.Name = "lblKhachThanhToan";
            this.lblKhachThanhToan.Size = new System.Drawing.Size(150, 18);
            this.lblKhachThanhToan.TabIndex = 10;
            this.lblKhachThanhToan.Text = "Tiền trả nhà cung cấp";
            // 
            // lblKhachCanTra
            // 
            this.lblKhachCanTra.AutoSize = true;
            this.lblKhachCanTra.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachCanTra.Location = new System.Drawing.Point(5, 210);
            this.lblKhachCanTra.Name = "lblKhachCanTra";
            this.lblKhachCanTra.Size = new System.Drawing.Size(153, 18);
            this.lblKhachCanTra.TabIndex = 9;
            this.lblKhachCanTra.Text = "Cần trả nhà cung cấp";
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiamGia.Location = new System.Drawing.Point(5, 175);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(68, 18);
            this.lblGiamGia.TabIndex = 8;
            this.lblGiamGia.Text = "Giảm giá";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-5, 103);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(346, 35);
            this.bunifuSeparator1.TabIndex = 3;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.Location = new System.Drawing.Point(194, 8);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblThoiGian.Size = new System.Drawing.Size(74, 17);
            this.lblThoiGian.TabIndex = 2;
            this.lblThoiGian.Text = "10/10/2017";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 1;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.panelRightMain);
            this.panelRight.Controls.Add(this.panelRightBot);
            this.panelRight.Controls.Add(this.panelRightTop);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(691, 60);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(363, 477);
            this.panelRight.TabIndex = 9;
            // 
            // panelRightMain
            // 
            this.panelRightMain.BackColor = System.Drawing.Color.White;
            this.panelRightMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRightMain.Controls.Add(this.txtNumBerKhachThanhToan);
            this.panelRightMain.Controls.Add(this.txtNumberGiamGia);
            this.panelRightMain.Controls.Add(this.btnSearchKhachHang);
            this.panelRightMain.Controls.Add(this.lblNhaCungCap);
            this.panelRightMain.Controls.Add(this.txtTimNhaCC);
            this.panelRightMain.Controls.Add(this.lblTenNhanVien);
            this.panelRightMain.Controls.Add(this.lblNumberTienThuaTraKhach);
            this.panelRightMain.Controls.Add(this.lblNumberKhachCanTra);
            this.panelRightMain.Controls.Add(this.lblNumberTongTienHang);
            this.panelRightMain.Controls.Add(this.txtGhiChu);
            this.panelRightMain.Controls.Add(this.lblTienThuaTraKhach);
            this.panelRightMain.Controls.Add(this.lblKhachThanhToan);
            this.panelRightMain.Controls.Add(this.lblKhachCanTra);
            this.panelRightMain.Controls.Add(this.lblGiamGia);
            this.panelRightMain.Controls.Add(this.lblTongTienHang);
            this.panelRightMain.Controls.Add(this.btnhoadonRight);
            this.panelRightMain.Controls.Add(this.bunifuSeparator1);
            this.panelRightMain.Controls.Add(this.lblThoiGian);
            this.panelRightMain.Controls.Add(this.lblNhanVien);
            this.panelRightMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightMain.Location = new System.Drawing.Point(0, 10);
            this.panelRightMain.Name = "panelRightMain";
            this.panelRightMain.Size = new System.Drawing.Size(363, 408);
            this.panelRightMain.TabIndex = 3;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.Location = new System.Drawing.Point(5, 8);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(69, 17);
            this.lblNhanVien.TabIndex = 0;
            this.lblNhanVien.Text = "Nhân viên:";
            // 
            // panelRightBot
            // 
            this.panelRightBot.BackColor = System.Drawing.Color.White;
            this.panelRightBot.Controls.Add(this.btnThanhToan);
            this.panelRightBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRightBot.Location = new System.Drawing.Point(0, 418);
            this.panelRightBot.Name = "panelRightBot";
            this.panelRightBot.Size = new System.Drawing.Size(363, 59);
            this.panelRightBot.TabIndex = 4;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.btnThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThanhToan.BorderRadius = 0;
            this.btnThanhToan.ButtonText = "   Thanh toán";
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.DisabledColor = System.Drawing.Color.Gray;
            this.btnThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThanhToan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThanhToan.Iconimage = null;
            this.btnThanhToan.Iconimage_right = null;
            this.btnThanhToan.Iconimage_right_Selected = null;
            this.btnThanhToan.Iconimage_Selected = null;
            this.btnThanhToan.IconMarginLeft = 0;
            this.btnThanhToan.IconMarginRight = 0;
            this.btnThanhToan.IconRightVisible = true;
            this.btnThanhToan.IconRightZoom = 0D;
            this.btnThanhToan.IconVisible = true;
            this.btnThanhToan.IconZoom = 90D;
            this.btnThanhToan.IsTab = false;
            this.btnThanhToan.Location = new System.Drawing.Point(127, 8);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.btnThanhToan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThanhToan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThanhToan.selected = false;
            this.btnThanhToan.Size = new System.Drawing.Size(122, 42);
            this.btnThanhToan.TabIndex = 6;
            this.btnThanhToan.Text = "   Thanh toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Textcolor = System.Drawing.Color.White;
            this.btnThanhToan.TextFont = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panelRightTop
            // 
            this.panelRightTop.BackColor = System.Drawing.Color.White;
            this.panelRightTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRightTop.Location = new System.Drawing.Point(0, 0);
            this.panelRightTop.Name = "panelRightTop";
            this.panelRightTop.Size = new System.Drawing.Size(363, 10);
            this.panelRightTop.TabIndex = 2;
            // 
            // doubleBitmapControl1
            // 
            this.doubleBitmapControl1.Location = new System.Drawing.Point(43, 0);
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            this.doubleBitmapControl1.Size = new System.Drawing.Size(0, 0);
            this.doubleBitmapControl1.TabIndex = 8;
            this.doubleBitmapControl1.Text = "doubleBitmapControl1";
            this.doubleBitmapControl1.Visible = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.panelMainMid);
            this.panelMain.Controls.Add(this.panelMidBot);
            this.panelMain.Controls.Add(this.panelMidTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(11, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(670, 477);
            this.panelMain.TabIndex = 10;
            // 
            // panelMainMid
            // 
            this.panelMainMid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMainMid.Controls.Add(this.dataGridDanhSachHangHoa_NhapHang);
            this.panelMainMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainMid.Location = new System.Drawing.Point(0, 10);
            this.panelMainMid.Name = "panelMainMid";
            this.panelMainMid.Size = new System.Drawing.Size(670, 408);
            this.panelMainMid.TabIndex = 4;
            // 
            // dataGridDanhSachHangHoa_NhapHang
            // 
            this.dataGridDanhSachHangHoa_NhapHang.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridDanhSachHangHoa_NhapHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridDanhSachHangHoa_NhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDanhSachHangHoa_NhapHang.BackgroundColor = System.Drawing.Color.White;
            this.dataGridDanhSachHangHoa_NhapHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDanhSachHangHoa_NhapHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDanhSachHangHoa_NhapHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridDanhSachHangHoa_NhapHang.ColumnHeadersHeight = 30;
            this.dataGridDanhSachHangHoa_NhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridDanhSachHangHoa_NhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHangHoa,
            this.TenHangHoa,
            this.DonVi,
            this.SoLuong,
            this.GiaHangHoa,
            this.TongCong,
            this.btnXoa});
            this.dataGridDanhSachHangHoa_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDanhSachHangHoa_NhapHang.DoubleBuffered = true;
            this.dataGridDanhSachHangHoa_NhapHang.EnableHeadersVisualStyles = false;
            this.dataGridDanhSachHangHoa_NhapHang.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.dataGridDanhSachHangHoa_NhapHang.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridDanhSachHangHoa_NhapHang.Location = new System.Drawing.Point(0, 0);
            this.dataGridDanhSachHangHoa_NhapHang.Name = "dataGridDanhSachHangHoa_NhapHang";
            this.dataGridDanhSachHangHoa_NhapHang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridDanhSachHangHoa_NhapHang.RowHeadersVisible = false;
            this.dataGridDanhSachHangHoa_NhapHang.Size = new System.Drawing.Size(668, 406);
            this.dataGridDanhSachHangHoa_NhapHang.TabIndex = 3;
            // 
            // MaHangHoa
            // 
            this.MaHangHoa.DataPropertyName = "maHangHoa";
            this.MaHangHoa.FillWeight = 60F;
            this.MaHangHoa.HeaderText = "Mã hàng hóa";
            this.MaHangHoa.Name = "MaHangHoa";
            this.MaHangHoa.ReadOnly = true;
            this.MaHangHoa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TenHangHoa
            // 
            this.TenHangHoa.DataPropertyName = "tenHangHoa";
            this.TenHangHoa.FillWeight = 90.89661F;
            this.TenHangHoa.HeaderText = "Tên Hàng Hóa";
            this.TenHangHoa.Name = "TenHangHoa";
            this.TenHangHoa.ReadOnly = true;
            this.TenHangHoa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DonVi
            // 
            this.DonVi.DataPropertyName = "donViTinh";
            this.DonVi.FillWeight = 37.50919F;
            this.DonVi.HeaderText = "Đơn vị tính";
            this.DonVi.Name = "DonVi";
            this.DonVi.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "soLuong";
            this.SoLuong.FillWeight = 37.50919F;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // GiaHangHoa
            // 
            this.GiaHangHoa.DataPropertyName = "giaTien";
            this.GiaHangHoa.FillWeight = 37.50919F;
            this.GiaHangHoa.HeaderText = "Giá tiền";
            this.GiaHangHoa.Name = "GiaHangHoa";
            this.GiaHangHoa.ReadOnly = true;
            // 
            // TongCong
            // 
            this.TongCong.DataPropertyName = "tongCong";
            this.TongCong.FillWeight = 37.50919F;
            this.TongCong.HeaderText = "Tổng cộng";
            this.TongCong.Name = "TongCong";
            this.TongCong.ReadOnly = true;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btnXoa.FillWeight = 50F;
            this.btnXoa.HeaderText = "";
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseColumnTextForButtonValue = true;
            this.btnXoa.Width = 50;
            // 
            // frmGiaoDich_NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 537);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMarginMid);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.doubleBitmapControl1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMarginLeft);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGiaoDich_NhapHang";
            this.Text = "frmGiaoDich_NhapHang";
            this.Load += new System.EventHandler(this.frmGiaoDich_NhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchKhachHang)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            this.panelMidBot.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRightMain.ResumeLayout(false);
            this.panelRightMain.PerformLayout();
            this.panelRightBot.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMainMid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDanhSachHangHoa_NhapHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumBerKhachThanhToan;
        private System.Windows.Forms.TextBox txtNumberGiamGia;
        private Bunifu.Framework.UI.BunifuImageButton btnSearchKhachHang;
        private System.Windows.Forms.Label lblNhaCungCap;
        private System.Windows.Forms.TextBox txtTimNhaCC;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Label lblNumberTienThuaTraKhach;
        private System.Windows.Forms.Label lblNumberKhachCanTra;
        private System.Windows.Forms.Label lblNumberTongTienHang;
        private System.Windows.Forms.Timer timerForHoaDon;
        private System.Windows.Forms.Panel panelMarginMid;
        private System.Windows.Forms.Panel panelMarginLeft;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private Bunifu.Framework.UI.BunifuFlatButton btnThemHangHoaVaoDanhSach;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Panel panelMidBot;
        private Bunifu.Framework.UI.BunifuFlatButton btnLamMoiHoaDon;
        private System.Windows.Forms.Label lblTongTienHang;
        private Bunifu.Framework.UI.BunifuFlatButton btnhoadonRight;
        private System.Windows.Forms.Panel panelMidTop;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtGhiChu;
        private System.Windows.Forms.Label lblTienThuaTraKhach;
        private System.Windows.Forms.Label lblKhachThanhToan;
        private System.Windows.Forms.Label lblKhachCanTra;
        private System.Windows.Forms.Label lblGiamGia;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label lblThoiGian;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelRightMain;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Panel panelRightBot;
        private Bunifu.Framework.UI.BunifuFlatButton btnThanhToan;
        private System.Windows.Forms.Panel panelRightTop;
        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
        private System.Windows.Forms.Panel panelMain;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridDanhSachHangHoa_NhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongCong;
        private System.Windows.Forms.DataGridViewButtonColumn btnXoa;
        private System.Windows.Forms.Panel panelMainMid;
    }
}