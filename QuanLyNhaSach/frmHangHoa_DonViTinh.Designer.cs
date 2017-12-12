namespace QuanLyNhaSach
{
    partial class frmHangHoa_DonViTinh
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
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelTopLot = new System.Windows.Forms.Panel();
            this.labelThemMoiDonViTinh = new System.Windows.Forms.Label();
            this.btnX = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnThem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.txtBoxThemDonViTinh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDanhSachDonViTinh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelRightlot = new System.Windows.Forms.Panel();
            this.panelLeftLot = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelTopLot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnX)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTopLot;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelTopLot
            // 
            this.panelTopLot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(77)))), ((int)(((byte)(91)))));
            this.panelTopLot.Controls.Add(this.labelThemMoiDonViTinh);
            this.panelTopLot.Controls.Add(this.btnX);
            this.panelTopLot.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopLot.Location = new System.Drawing.Point(3, 0);
            this.panelTopLot.Name = "panelTopLot";
            this.panelTopLot.Size = new System.Drawing.Size(284, 37);
            this.panelTopLot.TabIndex = 15;
            // 
            // labelThemMoiDonViTinh
            // 
            this.labelThemMoiDonViTinh.AutoSize = true;
            this.labelThemMoiDonViTinh.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThemMoiDonViTinh.ForeColor = System.Drawing.Color.White;
            this.labelThemMoiDonViTinh.Location = new System.Drawing.Point(6, 9);
            this.labelThemMoiDonViTinh.Name = "labelThemMoiDonViTinh";
            this.labelThemMoiDonViTinh.Size = new System.Drawing.Size(149, 19);
            this.labelThemMoiDonViTinh.TabIndex = 17;
            this.labelThemMoiDonViTinh.Text = "Thêm mới đơn vị tính";
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Transparent;
            this.btnX.Image = global::QuanLyNhaSach.Properties.Resources.iconX_2;
            this.btnX.ImageActive = null;
            this.btnX.Location = new System.Drawing.Point(249, 11);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(20, 20);
            this.btnX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnX.TabIndex = 2;
            this.btnX.TabStop = false;
            this.btnX.Zoom = 10;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnThem
            // 
            this.btnThem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.btnThem.BackColor = System.Drawing.Color.Green;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.BorderRadius = 0;
            this.btnThem.ButtonText = "Thêm";
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.DisabledColor = System.Drawing.Color.Gray;
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThem.Iconimage = global::QuanLyNhaSach.Properties.Resources.plus_3;
            this.btnThem.Iconimage_right = null;
            this.btnThem.Iconimage_right_Selected = null;
            this.btnThem.Iconimage_Selected = null;
            this.btnThem.IconMarginLeft = 5;
            this.btnThem.IconMarginRight = 0;
            this.btnThem.IconRightVisible = true;
            this.btnThem.IconRightZoom = 0D;
            this.btnThem.IconVisible = true;
            this.btnThem.IconZoom = 60D;
            this.btnThem.IsTab = false;
            this.btnThem.Location = new System.Drawing.Point(98, 166);
            this.btnThem.Name = "btnThem";
            this.btnThem.Normalcolor = System.Drawing.Color.Green;
            this.btnThem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThem.selected = false;
            this.btnThem.Size = new System.Drawing.Size(99, 42);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.Textcolor = System.Drawing.Color.White;
            this.btnThem.TextFont = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.txtBoxThemDonViTinh);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.comboBoxDanhSachDonViTinh);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.btnThem);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(3, 37);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(284, 233);
            this.panelMain.TabIndex = 18;
            // 
            // txtBoxThemDonViTinh
            // 
            this.txtBoxThemDonViTinh.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxThemDonViTinh.Location = new System.Drawing.Point(44, 125);
            this.txtBoxThemDonViTinh.Name = "txtBoxThemDonViTinh";
            this.txtBoxThemDonViTinh.Size = new System.Drawing.Size(204, 25);
            this.txtBoxThemDonViTinh.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Thêm mới đơn vị tính:";
            // 
            // comboBoxDanhSachDonViTinh
            // 
            this.comboBoxDanhSachDonViTinh.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDanhSachDonViTinh.FormattingEnabled = true;
            this.comboBoxDanhSachDonViTinh.Location = new System.Drawing.Point(44, 49);
            this.comboBoxDanhSachDonViTinh.Name = "comboBoxDanhSachDonViTinh";
            this.comboBoxDanhSachDonViTinh.Size = new System.Drawing.Size(204, 26);
            this.comboBoxDanhSachDonViTinh.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Danh sách đơn vị tính đã có:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(77)))), ((int)(((byte)(91)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 10);
            this.panel1.TabIndex = 8;
            // 
            // panelRightlot
            // 
            this.panelRightlot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(77)))), ((int)(((byte)(91)))));
            this.panelRightlot.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightlot.Location = new System.Drawing.Point(287, 0);
            this.panelRightlot.Name = "panelRightlot";
            this.panelRightlot.Size = new System.Drawing.Size(3, 270);
            this.panelRightlot.TabIndex = 17;
            // 
            // panelLeftLot
            // 
            this.panelLeftLot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(77)))), ((int)(((byte)(91)))));
            this.panelLeftLot.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftLot.Location = new System.Drawing.Point(0, 0);
            this.panelLeftLot.Name = "panelLeftLot";
            this.panelLeftLot.Size = new System.Drawing.Size(3, 270);
            this.panelLeftLot.TabIndex = 16;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frmHangHoa_DonViTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 270);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTopLot);
            this.Controls.Add(this.panelRightlot);
            this.Controls.Add(this.panelLeftLot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHangHoa_DonViTinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHangHoa_DonViTinh";
            this.Load += new System.EventHandler(this.frmHangHoa_DonViTinh_Load);
            this.panelTopLot.ResumeLayout(false);
            this.panelTopLot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnX)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panelTopLot;
        private System.Windows.Forms.Label labelThemMoiDonViTinh;
        private Bunifu.Framework.UI.BunifuImageButton btnX;
        private Bunifu.Framework.UI.BunifuFlatButton btnThem;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox txtBoxThemDonViTinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDanhSachDonViTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelRightlot;
        private System.Windows.Forms.Panel panelLeftLot;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}