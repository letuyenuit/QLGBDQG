namespace QLGiaiBongDa.GUI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiBong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCauThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuyDinhDoiBong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTranDau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLTranDau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBanThang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaiBanThang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKetQuaThiDau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBangXepHang = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuDanhMuc,
            this.mnuTranDau,
            this.mnuThongKe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1390, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangXuat});
            this.mnuHeThong.Image = ((System.Drawing.Image)(resources.GetObject("mnuHeThong.Image")));
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(126, 29);
            this.mnuHeThong.Text = "Hệ Thống";
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("mnuDangXuat.Image")));
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(198, 34);
            this.mnuDangXuat.Text = "Đăng Xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDoiBong,
            this.mnuCauThu,
            this.mnuSan,
            this.mnuTaiKhoan,
            this.mnuQuyDinhDoiBong});
            this.mnuDanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("mnuDanhMuc.Image")));
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(129, 29);
            this.mnuDanhMuc.Text = "Danh Mục";
            // 
            // mnuDoiBong
            // 
            this.mnuDoiBong.Image = ((System.Drawing.Image)(resources.GetObject("mnuDoiBong.Image")));
            this.mnuDoiBong.Name = "mnuDoiBong";
            this.mnuDoiBong.Size = new System.Drawing.Size(269, 34);
            this.mnuDoiBong.Text = "Đội Bóng";
            this.mnuDoiBong.Click += new System.EventHandler(this.mnuDoiBong_Click);
            // 
            // mnuCauThu
            // 
            this.mnuCauThu.Image = ((System.Drawing.Image)(resources.GetObject("mnuCauThu.Image")));
            this.mnuCauThu.Name = "mnuCauThu";
            this.mnuCauThu.Size = new System.Drawing.Size(269, 34);
            this.mnuCauThu.Text = "Cầu Thủ";
            this.mnuCauThu.Click += new System.EventHandler(this.mnuCauThu_Click);
            // 
            // mnuSan
            // 
            this.mnuSan.Image = ((System.Drawing.Image)(resources.GetObject("mnuSan.Image")));
            this.mnuSan.Name = "mnuSan";
            this.mnuSan.Size = new System.Drawing.Size(269, 34);
            this.mnuSan.Text = "Sân";
            this.mnuSan.Click += new System.EventHandler(this.mnuSan_Click);
            // 
            // mnuTaiKhoan
            // 
            this.mnuTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("mnuTaiKhoan.Image")));
            this.mnuTaiKhoan.Name = "mnuTaiKhoan";
            this.mnuTaiKhoan.Size = new System.Drawing.Size(269, 34);
            this.mnuTaiKhoan.Text = "Tài Khoản";
            this.mnuTaiKhoan.Click += new System.EventHandler(this.mnuTaiKhoan_Click);
            // 
            // mnuQuyDinhDoiBong
            // 
            this.mnuQuyDinhDoiBong.Image = ((System.Drawing.Image)(resources.GetObject("mnuQuyDinhDoiBong.Image")));
            this.mnuQuyDinhDoiBong.Name = "mnuQuyDinhDoiBong";
            this.mnuQuyDinhDoiBong.Size = new System.Drawing.Size(269, 34);
            this.mnuQuyDinhDoiBong.Text = "Quy Định Đội Bóng";
            this.mnuQuyDinhDoiBong.Click += new System.EventHandler(this.mnuQuyDinhDoiBong_Click);
            // 
            // mnuTranDau
            // 
            this.mnuTranDau.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQLTranDau,
            this.mnuBanThang,
            this.mnuLoaiBanThang,
            this.mnuKetQuaThiDau});
            this.mnuTranDau.Image = ((System.Drawing.Image)(resources.GetObject("mnuTranDau.Image")));
            this.mnuTranDau.Name = "mnuTranDau";
            this.mnuTranDau.Size = new System.Drawing.Size(117, 29);
            this.mnuTranDau.Text = "Trận Đấu";
            // 
            // mnuQLTranDau
            // 
            this.mnuQLTranDau.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLTranDau.Image")));
            this.mnuQLTranDau.Name = "mnuQLTranDau";
            this.mnuQLTranDau.Size = new System.Drawing.Size(242, 34);
            this.mnuQLTranDau.Text = "Lịch Thi Đấu";
            this.mnuQLTranDau.Click += new System.EventHandler(this.mnuQLTranDau_Click);
            // 
            // mnuBanThang
            // 
            this.mnuBanThang.Image = ((System.Drawing.Image)(resources.GetObject("mnuBanThang.Image")));
            this.mnuBanThang.Name = "mnuBanThang";
            this.mnuBanThang.Size = new System.Drawing.Size(242, 34);
            this.mnuBanThang.Text = "Bàn Thắng";
            this.mnuBanThang.Click += new System.EventHandler(this.mnuBanThang_Click);
            // 
            // mnuLoaiBanThang
            // 
            this.mnuLoaiBanThang.Image = ((System.Drawing.Image)(resources.GetObject("mnuLoaiBanThang.Image")));
            this.mnuLoaiBanThang.Name = "mnuLoaiBanThang";
            this.mnuLoaiBanThang.Size = new System.Drawing.Size(242, 34);
            this.mnuLoaiBanThang.Text = "Loại Bàn Thắng";
            this.mnuLoaiBanThang.Click += new System.EventHandler(this.mnuLoaiBanThang_Click);
            // 
            // mnuKetQuaThiDau
            // 
            this.mnuKetQuaThiDau.Image = ((System.Drawing.Image)(resources.GetObject("mnuKetQuaThiDau.Image")));
            this.mnuKetQuaThiDau.Name = "mnuKetQuaThiDau";
            this.mnuKetQuaThiDau.Size = new System.Drawing.Size(242, 34);
            this.mnuKetQuaThiDau.Text = "Kết Quả Thi Đấu";
            this.mnuKetQuaThiDau.Click += new System.EventHandler(this.mnuKetQuaThiDau_Click);
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBangXepHang});
            this.mnuThongKe.Image = ((System.Drawing.Image)(resources.GetObject("mnuThongKe.Image")));
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Size = new System.Drawing.Size(123, 29);
            this.mnuThongKe.Text = "Thống Kê";
            // 
            // mnuBangXepHang
            // 
            this.mnuBangXepHang.Image = ((System.Drawing.Image)(resources.GetObject("mnuBangXepHang.Image")));
            this.mnuBangXepHang.Name = "mnuBangXepHang";
            this.mnuBangXepHang.Size = new System.Drawing.Size(270, 34);
            this.mnuBangXepHang.Text = "Bảng Xếp Hạng";
            this.mnuBangXepHang.Click += new System.EventHandler(this.mnuBangXepHang_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_module_32.png");
            this.imageList1.Images.SetKeyName(1, "icons8_logout_rounded_left_32.png");
            this.imageList1.Images.SetKeyName(2, "icons8_network_care_32.png");
            this.imageList1.Images.SetKeyName(3, "icons8_web_analytics_32.png");
            this.imageList1.Images.SetKeyName(4, "icons8_football_goal_32.png");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1390, 841);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ GIẢI BÓNG ĐÁ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiBong;
        private System.Windows.Forms.ToolStripMenuItem mnuCauThu;
        private System.Windows.Forms.ToolStripMenuItem mnuSan;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnuBangXepHang;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem mnuQuyDinhDoiBong;
        private System.Windows.Forms.ToolStripMenuItem mnuTranDau;
        private System.Windows.Forms.ToolStripMenuItem mnuQLTranDau;
        private System.Windows.Forms.ToolStripMenuItem mnuBanThang;
        private System.Windows.Forms.ToolStripMenuItem mnuLoaiBanThang;
        private System.Windows.Forms.ToolStripMenuItem mnuKetQuaThiDau;
    }
}

