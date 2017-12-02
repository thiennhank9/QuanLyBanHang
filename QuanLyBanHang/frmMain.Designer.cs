namespace QuanLyBanHang
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLapHDBH = new DevExpress.XtraBars.BarButtonItem();
            this.btnXemHDBH = new DevExpress.XtraBars.BarButtonItem();
            this.btnLapHDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnXemHDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnXemTinhTrang = new DevExpress.XtraBars.BarButtonItem();
            this.btnLapPhieuThu = new DevExpress.XtraBars.BarButtonItem();
            this.btnLapPhieuChi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXemThuChi = new DevExpress.XtraBars.BarButtonItem();
            this.rbNghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbGrBanHang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbGrDatHang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbGrKhoHang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbGrThuChi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbTroGiup = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.skinApp = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnLapHDBH,
            this.btnXemHDBH,
            this.btnLapHDDH,
            this.btnXemHDDH,
            this.btnNhapKho,
            this.btnXuatKho,
            this.btnXemTinhTrang,
            this.btnLapPhieuThu,
            this.btnLapPhieuChi,
            this.btnXemThuChi});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 12;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbNghiepVu,
            this.rbHeThong,
            this.rbTroGiup});
            this.ribbon.Size = new System.Drawing.Size(1106, 147);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnLapHDBH
            // 
            this.btnLapHDBH.Caption = "Lập hóa đơn mới";
            this.btnLapHDBH.Glyph = global::QuanLyBanHang.Properties.Resources.newsales_16x16;
            this.btnLapHDBH.Id = 1;
            this.btnLapHDBH.LargeGlyph = global::QuanLyBanHang.Properties.Resources.newsales_32x32;
            this.btnLapHDBH.Name = "btnLapHDBH";
            // 
            // btnXemHDBH
            // 
            this.btnXemHDBH.Caption = "Xem các hóa đơn";
            this.btnXemHDBH.Glyph = global::QuanLyBanHang.Properties.Resources.sales_16x16;
            this.btnXemHDBH.Id = 2;
            this.btnXemHDBH.LargeGlyph = global::QuanLyBanHang.Properties.Resources.sales_32x32;
            this.btnXemHDBH.Name = "btnXemHDBH";
            // 
            // btnLapHDDH
            // 
            this.btnLapHDDH.Caption = "Lập hóa đơn mới";
            this.btnLapHDDH.Glyph = global::QuanLyBanHang.Properties.Resources.newproducts_16x16;
            this.btnLapHDDH.Id = 4;
            this.btnLapHDDH.LargeGlyph = global::QuanLyBanHang.Properties.Resources.newproducts_32x32;
            this.btnLapHDDH.Name = "btnLapHDDH";
            // 
            // btnXemHDDH
            // 
            this.btnXemHDDH.Caption = "Xem các hóa đơn";
            this.btnXemHDDH.Glyph = global::QuanLyBanHang.Properties.Resources.products_16x16;
            this.btnXemHDDH.Id = 5;
            this.btnXemHDDH.LargeGlyph = global::QuanLyBanHang.Properties.Resources.products_32x32;
            this.btnXemHDDH.Name = "btnXemHDDH";
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.Caption = "Nhập kho";
            this.btnNhapKho.Glyph = global::QuanLyBanHang.Properties.Resources.changeview_16x16;
            this.btnNhapKho.Id = 6;
            this.btnNhapKho.Name = "btnNhapKho";
            // 
            // btnXuatKho
            // 
            this.btnXuatKho.Caption = "Xuất kho";
            this.btnXuatKho.Glyph = global::QuanLyBanHang.Properties.Resources.resetchanges_16x16;
            this.btnXuatKho.Id = 7;
            this.btnXuatKho.Name = "btnXuatKho";
            // 
            // btnXemTinhTrang
            // 
            this.btnXemTinhTrang.Caption = "Xem tình trạng";
            this.btnXemTinhTrang.Glyph = global::QuanLyBanHang.Properties.Resources.printpreview_16x16;
            this.btnXemTinhTrang.Id = 8;
            this.btnXemTinhTrang.LargeGlyph = global::QuanLyBanHang.Properties.Resources.printpreview_32x32;
            this.btnXemTinhTrang.Name = "btnXemTinhTrang";
            // 
            // btnLapPhieuThu
            // 
            this.btnLapPhieuThu.Caption = "Lập phiếu thu";
            this.btnLapPhieuThu.Glyph = global::QuanLyBanHang.Properties.Resources.printsortdesc_16x16;
            this.btnLapPhieuThu.Id = 9;
            this.btnLapPhieuThu.Name = "btnLapPhieuThu";
            // 
            // btnLapPhieuChi
            // 
            this.btnLapPhieuChi.Caption = "Lập phiếu chi";
            this.btnLapPhieuChi.Glyph = global::QuanLyBanHang.Properties.Resources.printsortasc_16x16;
            this.btnLapPhieuChi.Id = 10;
            this.btnLapPhieuChi.Name = "btnLapPhieuChi";
            // 
            // btnXemThuChi
            // 
            this.btnXemThuChi.Caption = "Xem tình trạng thu chi";
            this.btnXemThuChi.Glyph = global::QuanLyBanHang.Properties.Resources.low_16x16;
            this.btnXemThuChi.Id = 11;
            this.btnXemThuChi.LargeGlyph = global::QuanLyBanHang.Properties.Resources.low_32x32;
            this.btnXemThuChi.Name = "btnXemThuChi";
            // 
            // rbNghiepVu
            // 
            this.rbNghiepVu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbGrBanHang,
            this.rbGrDatHang,
            this.rbGrKhoHang,
            this.rbGrThuChi});
            this.rbNghiepVu.Name = "rbNghiepVu";
            this.rbNghiepVu.Text = "Nghiệp vụ";
            // 
            // rbGrBanHang
            // 
            this.rbGrBanHang.ItemLinks.Add(this.btnLapHDBH);
            this.rbGrBanHang.ItemLinks.Add(this.btnXemHDBH);
            this.rbGrBanHang.Name = "rbGrBanHang";
            this.rbGrBanHang.Text = "Bán hàng";
            // 
            // rbGrDatHang
            // 
            this.rbGrDatHang.ItemLinks.Add(this.btnLapHDDH);
            this.rbGrDatHang.ItemLinks.Add(this.btnXemHDDH);
            this.rbGrDatHang.Name = "rbGrDatHang";
            this.rbGrDatHang.Text = "Đặt hàng";
            // 
            // rbGrKhoHang
            // 
            this.rbGrKhoHang.ItemLinks.Add(this.btnNhapKho);
            this.rbGrKhoHang.ItemLinks.Add(this.btnXuatKho);
            this.rbGrKhoHang.ItemLinks.Add(this.btnXemTinhTrang);
            this.rbGrKhoHang.Name = "rbGrKhoHang";
            this.rbGrKhoHang.Text = "Kho hàng";
            // 
            // rbGrThuChi
            // 
            this.rbGrThuChi.ItemLinks.Add(this.btnLapPhieuThu);
            this.rbGrThuChi.ItemLinks.Add(this.btnLapPhieuChi);
            this.rbGrThuChi.ItemLinks.Add(this.btnXemThuChi);
            this.rbGrThuChi.Name = "rbGrThuChi";
            this.rbGrThuChi.Text = "Thu Chi";
            // 
            // rbHeThong
            // 
            this.rbHeThong.Name = "rbHeThong";
            this.rbHeThong.Text = "Hệ thống";
            // 
            // rbTroGiup
            // 
            this.rbTroGiup.Name = "rbTroGiup";
            this.rbTroGiup.Text = "Trợ giúp";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 610);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1106, 23);
            // 
            // skinApp
            // 
            this.skinApp.LookAndFeel.SkinName = "Office 2013";
            this.skinApp.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 633);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản lý bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbNghiepVu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbGrBanHang;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.LookAndFeel.DefaultLookAndFeel skinApp;
        private DevExpress.XtraBars.BarButtonItem btnLapHDBH;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbTroGiup;
        private DevExpress.XtraBars.BarButtonItem btnXemHDBH;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbGrDatHang;
        private DevExpress.XtraBars.BarButtonItem btnLapHDDH;
        private DevExpress.XtraBars.BarButtonItem btnXemHDDH;
        private DevExpress.XtraBars.BarButtonItem btnNhapKho;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbGrKhoHang;
        private DevExpress.XtraBars.BarButtonItem btnXuatKho;
        private DevExpress.XtraBars.BarButtonItem btnXemTinhTrang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbGrThuChi;
        private DevExpress.XtraBars.BarButtonItem btnLapPhieuThu;
        private DevExpress.XtraBars.BarButtonItem btnLapPhieuChi;
        private DevExpress.XtraBars.BarButtonItem btnXemThuChi;
    }
}