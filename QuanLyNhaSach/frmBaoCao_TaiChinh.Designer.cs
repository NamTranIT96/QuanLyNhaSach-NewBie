namespace QuanLyNhaSach
{
    partial class frmBaoCao_TaiChinh
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelMoiQuanTam = new System.Windows.Forms.Panel();
            this.lblMoiQuanTam = new System.Windows.Forms.Label();
            this.panelThoiGian = new System.Windows.Forms.Panel();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.panelMarginMid = new System.Windows.Forms.Panel();
            this.panelLeftTop = new System.Windows.Forms.Panel();
            this.panelTG = new System.Windows.Forms.Panel();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.btnTimKiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.radioGroupMoiQuanTam = new DevExpress.XtraEditors.RadioGroup();
            this.panelTimKiemLeft = new System.Windows.Forms.Panel();
            this.panelMarginLeft = new System.Windows.Forms.Panel();
            this.panelMarginTop = new System.Windows.Forms.Panel();
            this.panelMoiQuanTam.SuspendLayout();
            this.panelThoiGian.SuspendLayout();
            this.panelLeftTop.SuspendLayout();
            this.panelTG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupMoiQuanTam.Properties)).BeginInit();
            this.panelTimKiemLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(228, 10);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(580, 477);
            this.panelMain.TabIndex = 15;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelMoiQuanTam
            // 
            this.panelMoiQuanTam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.panelMoiQuanTam.Controls.Add(this.lblMoiQuanTam);
            this.panelMoiQuanTam.Location = new System.Drawing.Point(10, 51);
            this.panelMoiQuanTam.Name = "panelMoiQuanTam";
            this.panelMoiQuanTam.Size = new System.Drawing.Size(181, 30);
            this.panelMoiQuanTam.TabIndex = 1;
            // 
            // lblMoiQuanTam
            // 
            this.lblMoiQuanTam.AutoSize = true;
            this.lblMoiQuanTam.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoiQuanTam.ForeColor = System.Drawing.Color.White;
            this.lblMoiQuanTam.Location = new System.Drawing.Point(12, 4);
            this.lblMoiQuanTam.Name = "lblMoiQuanTam";
            this.lblMoiQuanTam.Size = new System.Drawing.Size(112, 22);
            this.lblMoiQuanTam.TabIndex = 2;
            this.lblMoiQuanTam.Text = "Loại báo cáo";
            // 
            // panelThoiGian
            // 
            this.panelThoiGian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.panelThoiGian.Controls.Add(this.lblThoiGian);
            this.panelThoiGian.ForeColor = System.Drawing.Color.White;
            this.panelThoiGian.Location = new System.Drawing.Point(9, 214);
            this.panelThoiGian.Name = "panelThoiGian";
            this.panelThoiGian.Size = new System.Drawing.Size(182, 30);
            this.panelThoiGian.TabIndex = 3;
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.Location = new System.Drawing.Point(12, 4);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(124, 22);
            this.lblThoiGian.TabIndex = 2;
            this.lblThoiGian.Text = "Chọn thời gian";
            // 
            // panelMarginMid
            // 
            this.panelMarginMid.BackColor = System.Drawing.Color.White;
            this.panelMarginMid.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMarginMid.Location = new System.Drawing.Point(218, 10);
            this.panelMarginMid.Name = "panelMarginMid";
            this.panelMarginMid.Size = new System.Drawing.Size(10, 477);
            this.panelMarginMid.TabIndex = 14;
            // 
            // panelLeftTop
            // 
            this.panelLeftTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeftTop.Controls.Add(this.panelTG);
            this.panelLeftTop.Controls.Add(this.btnTimKiem);
            this.panelLeftTop.Controls.Add(this.radioGroupMoiQuanTam);
            this.panelLeftTop.Controls.Add(this.panelMoiQuanTam);
            this.panelLeftTop.Controls.Add(this.panelThoiGian);
            this.panelLeftTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeftTop.Location = new System.Drawing.Point(0, 0);
            this.panelLeftTop.Name = "panelLeftTop";
            this.panelLeftTop.Size = new System.Drawing.Size(208, 477);
            this.panelLeftTop.TabIndex = 9;
            // 
            // panelTG
            // 
            this.panelTG.Controls.Add(this.dateTime);
            this.panelTG.Location = new System.Drawing.Point(9, 250);
            this.panelTG.Name = "panelTG";
            this.panelTG.Size = new System.Drawing.Size(182, 116);
            this.panelTG.TabIndex = 16;
            // 
            // dateTime
            // 
            this.dateTime.CustomFormat = "MM/yyyy";
            this.dateTime.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime.Location = new System.Drawing.Point(16, 13);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(120, 25);
            this.dateTime.TabIndex = 12;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.BorderRadius = 0;
            this.btnTimKiem.ButtonText = "Xem";
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
            this.btnTimKiem.Location = new System.Drawing.Point(65, 411);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(173)))), ((int)(((byte)(206)))));
            this.btnTimKiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTimKiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimKiem.selected = false;
            this.btnTimKiem.Size = new System.Drawing.Size(80, 35);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Xem";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimKiem.Textcolor = System.Drawing.Color.White;
            this.btnTimKiem.TextFont = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // radioGroupMoiQuanTam
            // 
            this.radioGroupMoiQuanTam.Location = new System.Drawing.Point(15, 87);
            this.radioGroupMoiQuanTam.Name = "radioGroupMoiQuanTam";
            this.radioGroupMoiQuanTam.Properties.Appearance.Font = new System.Drawing.Font("UTM Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroupMoiQuanTam.Properties.Appearance.Options.UseFont = true;
            this.radioGroupMoiQuanTam.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroupMoiQuanTam.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Theo tháng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Theo quý"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Theo năm")});
            this.radioGroupMoiQuanTam.Size = new System.Drawing.Size(176, 100);
            this.radioGroupMoiQuanTam.TabIndex = 14;
            // 
            // panelTimKiemLeft
            // 
            this.panelTimKiemLeft.BackColor = System.Drawing.Color.White;
            this.panelTimKiemLeft.Controls.Add(this.panelLeftTop);
            this.panelTimKiemLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTimKiemLeft.Location = new System.Drawing.Point(10, 10);
            this.panelTimKiemLeft.Name = "panelTimKiemLeft";
            this.panelTimKiemLeft.Size = new System.Drawing.Size(208, 477);
            this.panelTimKiemLeft.TabIndex = 13;
            // 
            // panelMarginLeft
            // 
            this.panelMarginLeft.BackColor = System.Drawing.Color.White;
            this.panelMarginLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMarginLeft.Location = new System.Drawing.Point(0, 10);
            this.panelMarginLeft.Name = "panelMarginLeft";
            this.panelMarginLeft.Size = new System.Drawing.Size(10, 477);
            this.panelMarginLeft.TabIndex = 11;
            // 
            // panelMarginTop
            // 
            this.panelMarginTop.BackColor = System.Drawing.Color.White;
            this.panelMarginTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMarginTop.Location = new System.Drawing.Point(0, 0);
            this.panelMarginTop.Name = "panelMarginTop";
            this.panelMarginTop.Size = new System.Drawing.Size(808, 10);
            this.panelMarginTop.TabIndex = 12;
            // 
            // frmBaoCao_TaiChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 487);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMarginMid);
            this.Controls.Add(this.panelTimKiemLeft);
            this.Controls.Add(this.panelMarginLeft);
            this.Controls.Add(this.panelMarginTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBaoCao_TaiChinh";
            this.Text = "frmBaoCao_ThuChi";
            this.panelMoiQuanTam.ResumeLayout(false);
            this.panelMoiQuanTam.PerformLayout();
            this.panelThoiGian.ResumeLayout(false);
            this.panelThoiGian.PerformLayout();
            this.panelLeftTop.ResumeLayout(false);
            this.panelTG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupMoiQuanTam.Properties)).EndInit();
            this.panelTimKiemLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelMarginMid;
        private System.Windows.Forms.Panel panelTimKiemLeft;
        private System.Windows.Forms.Panel panelLeftTop;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimKiem;
        private DevExpress.XtraEditors.RadioGroup radioGroupMoiQuanTam;
        private System.Windows.Forms.Panel panelMoiQuanTam;
        private System.Windows.Forms.Label lblMoiQuanTam;
        private System.Windows.Forms.Panel panelThoiGian;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Panel panelMarginLeft;
        private System.Windows.Forms.Panel panelMarginTop;
        private System.Windows.Forms.Panel panelTG;
        private System.Windows.Forms.DateTimePicker dateTime;
    }
}