namespace QuanLyNhaSach
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBoxShop = new System.Windows.Forms.PictureBox();
            this.panelBottomInTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.lblTenPhanMem = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblWarningPassword = new System.Windows.Forms.Label();
            this.lblWarningUserName = new System.Windows.Forms.Label();
            this.btnDangNhap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxUserName = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.txtBoxPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtBoxUserName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShop)).BeginInit();
            this.panelBottomInTop.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserName)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelTop.Controls.Add(this.pictureBoxShop);
            this.panelTop.Controls.Add(this.panelBottomInTop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(443, 157);
            this.panelTop.TabIndex = 1;
            // 
            // pictureBoxShop
            // 
            this.pictureBoxShop.Image = global::QuanLyNhaSach.Properties.Resources.cart3;
            this.pictureBoxShop.Location = new System.Drawing.Point(-1, 56);
            this.pictureBoxShop.Name = "pictureBoxShop";
            this.pictureBoxShop.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShop.TabIndex = 0;
            this.pictureBoxShop.TabStop = false;
            // 
            // panelBottomInTop
            // 
            this.panelBottomInTop.BackColor = System.Drawing.Color.White;
            this.panelBottomInTop.Controls.Add(this.label2);
            this.panelBottomInTop.Controls.Add(this.labelClose);
            this.panelBottomInTop.Controls.Add(this.lblTenPhanMem);
            this.panelBottomInTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBottomInTop.Location = new System.Drawing.Point(0, 0);
            this.panelBottomInTop.Name = "panelBottomInTop";
            this.panelBottomInTop.Size = new System.Drawing.Size(443, 112);
            this.panelBottomInTop.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Avo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhóm 14";
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.Location = new System.Drawing.Point(415, 5);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(22, 23);
            this.labelClose.TabIndex = 1;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // lblTenPhanMem
            // 
            this.lblTenPhanMem.AutoSize = true;
            this.lblTenPhanMem.Font = new System.Drawing.Font("UTM Avo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhanMem.Location = new System.Drawing.Point(50, 25);
            this.lblTenPhanMem.Name = "lblTenPhanMem";
            this.lblTenPhanMem.Size = new System.Drawing.Size(339, 29);
            this.lblTenPhanMem.TabIndex = 0;
            this.lblTenPhanMem.Text = "PHẦN MỀM QUẢN LÝ NHÀ SÁCH";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelMain.Controls.Add(this.lblWarningPassword);
            this.panelMain.Controls.Add(this.lblWarningUserName);
            this.panelMain.Controls.Add(this.btnDangNhap);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.pictureBoxPassword);
            this.panelMain.Controls.Add(this.pictureBoxUserName);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.bunifuCheckbox1);
            this.panelMain.Controls.Add(this.txtBoxPassword);
            this.panelMain.Controls.Add(this.txtBoxUserName);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 157);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(443, 292);
            this.panelMain.TabIndex = 2;
            // 
            // lblWarningPassword
            // 
            this.lblWarningPassword.AutoSize = true;
            this.lblWarningPassword.ForeColor = System.Drawing.Color.Lime;
            this.lblWarningPassword.Location = new System.Drawing.Point(114, 162);
            this.lblWarningPassword.Name = "lblWarningPassword";
            this.lblWarningPassword.Size = new System.Drawing.Size(106, 13);
            this.lblWarningPassword.TabIndex = 11;
            this.lblWarningPassword.Text = "Chưa nhập mật khẩu";
            this.lblWarningPassword.Visible = false;
            // 
            // lblWarningUserName
            // 
            this.lblWarningUserName.AutoSize = true;
            this.lblWarningUserName.ForeColor = System.Drawing.Color.Lime;
            this.lblWarningUserName.Location = new System.Drawing.Point(114, 101);
            this.lblWarningUserName.Name = "lblWarningUserName";
            this.lblWarningUserName.Size = new System.Drawing.Size(132, 13);
            this.lblWarningUserName.TabIndex = 10;
            this.lblWarningUserName.Text = "Chưa nhập tên đăng nhập";
            this.lblWarningUserName.Visible = false;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.btnDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDangNhap.BorderRadius = 0;
            this.btnDangNhap.ButtonText = "Đăng Nhập";
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.DisabledColor = System.Drawing.Color.Gray;
            this.btnDangNhap.Font = new System.Drawing.Font("UTM Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDangNhap.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.Iconimage")));
            this.btnDangNhap.Iconimage_right = null;
            this.btnDangNhap.Iconimage_right_Selected = null;
            this.btnDangNhap.Iconimage_Selected = null;
            this.btnDangNhap.IconMarginLeft = 0;
            this.btnDangNhap.IconMarginRight = 0;
            this.btnDangNhap.IconRightVisible = false;
            this.btnDangNhap.IconRightZoom = 0D;
            this.btnDangNhap.IconVisible = true;
            this.btnDangNhap.IconZoom = 100D;
            this.btnDangNhap.IsTab = false;
            this.btnDangNhap.Location = new System.Drawing.Point(184, 231);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.btnDangNhap.OnHovercolor = System.Drawing.Color.DarkGreen;
            this.btnDangNhap.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDangNhap.selected = false;
            this.btnDangNhap.Size = new System.Drawing.Size(129, 36);
            this.btnDangNhap.TabIndex = 9;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangNhap.Textcolor = System.Drawing.Color.White;
            this.btnDangNhap.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Avo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(82, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "ĐĂNG NHẬP VÀO HỆ THỐNG";
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Image = global::QuanLyNhaSach.Properties.Resources.pass;
            this.pictureBoxPassword.Location = new System.Drawing.Point(45, 122);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPassword.TabIndex = 7;
            this.pictureBoxPassword.TabStop = false;
            // 
            // pictureBoxUserName
            // 
            this.pictureBoxUserName.Image = global::QuanLyNhaSach.Properties.Resources.user;
            this.pictureBoxUserName.Location = new System.Drawing.Point(45, 60);
            this.pictureBoxUserName.Name = "pictureBoxUserName";
            this.pictureBoxUserName.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUserName.TabIndex = 6;
            this.pictureBoxUserName.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(150, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ghi Nhớ Đăng Nhập";
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(124, 194);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 4;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.txtBoxPassword.BorderColorIdle = System.Drawing.Color.White;
            this.txtBoxPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.txtBoxPassword.BorderThickness = 3;
            this.txtBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxPassword.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.ForeColor = System.Drawing.Color.White;
            this.txtBoxPassword.isPassword = true;
            this.txtBoxPassword.Location = new System.Drawing.Point(111, 119);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(282, 38);
            this.txtBoxPassword.TabIndex = 3;
            this.txtBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.txtBoxUserName.BorderColorIdle = System.Drawing.Color.White;
            this.txtBoxUserName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.txtBoxUserName.BorderThickness = 3;
            this.txtBoxUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxUserName.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUserName.ForeColor = System.Drawing.Color.White;
            this.txtBoxUserName.isPassword = false;
            this.txtBoxUserName.Location = new System.Drawing.Point(111, 57);
            this.txtBoxUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(282, 38);
            this.txtBoxUserName.TabIndex = 2;
            this.txtBoxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelBottomInTop;
            this.bunifuDragControl1.Vertical = true;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 449);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDangNhap";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShop)).EndInit();
            this.panelBottomInTop.ResumeLayout(false);
            this.panelBottomInTop.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottomInTop;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBoxShop;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBoxUserName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBoxPassword;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private System.Windows.Forms.Label lblTenPhanMem;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.PictureBox pictureBoxUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btnDangNhap;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label lblWarningPassword;
        private System.Windows.Forms.Label lblWarningUserName;
    }
}