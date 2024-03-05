namespace hehe
{
    partial class KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            this.gc_kh = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Sua = new DevExpress.XtraBars.BarButtonItem();
            this.btn_XoaTT = new DevExpress.XtraBars.BarButtonItem();
            this.btn_TaiLai = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem_NTT = new DevExpress.XtraBars.BarEditItem();
            this.barSubItem_NTT = new DevExpress.XtraBars.BarSubItem();
            this.btn_Export = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem_chinhSua = new DevExpress.XtraBars.BarSubItem();
            this.btn_ThemNT = new DevExpress.XtraBars.BarButtonItem();
            this.btn_SuaNT = new DevExpress.XtraBars.BarButtonItem();
            this.btn_XoaNT = new DevExpress.XtraBars.BarButtonItem();
            this.btn_YeuThic = new DevExpress.XtraBars.BarButtonItem();
            this.barListItem1 = new DevExpress.XtraBars.BarListItem();
            this.barSubItemTL = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem_NXB = new DevExpress.XtraBars.BarSubItem();
            this.btn_ChinhSuaNXB = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DanhGia = new DevExpress.XtraBars.BarButtonItem();
            this.rb_quanlyKhachHang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.main = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gc_kh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_kh
            // 
            this.gc_kh.DataMember = "KHACHHANG";
            this.gc_kh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_kh.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gc_kh.Location = new System.Drawing.Point(0, 177);
            this.gc_kh.MainView = this.gridView1;
            this.gc_kh.Margin = new System.Windows.Forms.Padding(4);
            this.gc_kh.Name = "gc_kh";
            this.gc_kh.Size = new System.Drawing.Size(971, 576);
            this.gc_kh.TabIndex = 1;
            this.gc_kh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colTENKH,
            this.colSDT,
            this.colEMAIL,
            this.colDIACHI});
            this.gridView1.GridControl = this.gc_kh;
            this.gridView1.Name = "gridView1";
            // 
            // colMAKH
            // 
            this.colMAKH.Caption = "Mã khách hàng";
            this.colMAKH.FieldName = "MaKH";
            this.colMAKH.MinWidth = 25;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 0;
            this.colMAKH.Width = 94;
            // 
            // colTENKH
            // 
            this.colTENKH.Caption = "Tên khách hàng";
            this.colTENKH.FieldName = "TenKH";
            this.colTENKH.MinWidth = 25;
            this.colTENKH.Name = "colTENKH";
            this.colTENKH.Visible = true;
            this.colTENKH.VisibleIndex = 1;
            this.colTENKH.Width = 94;
            // 
            // colSDT
            // 
            this.colSDT.Caption = "Số điện thoại";
            this.colSDT.FieldName = "Sdt";
            this.colSDT.MinWidth = 25;
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 2;
            this.colSDT.Width = 94;
            // 
            // colEMAIL
            // 
            this.colEMAIL.Caption = "Email";
            this.colEMAIL.FieldName = "Email";
            this.colEMAIL.MinWidth = 25;
            this.colEMAIL.Name = "colEMAIL";
            this.colEMAIL.Visible = true;
            this.colEMAIL.VisibleIndex = 3;
            this.colEMAIL.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DiaChi";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 94;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(89);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnThem,
            this.btn_Sua,
            this.btn_XoaTT,
            this.btn_TaiLai,
            this.barEditItem_NTT,
            this.barSubItem_NTT,
            this.btn_Export,
            this.ribbonGalleryBarItem1,
            this.barButtonItem2,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barSubItem_chinhSua,
            this.btn_ThemNT,
            this.btn_SuaNT,
            this.btn_XoaNT,
            this.btn_YeuThic,
            this.barListItem1,
            this.barSubItemTL,
            this.barSubItem_NXB,
            this.btn_ChinhSuaNXB,
            this.btn_DanhGia,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(10);
            this.ribbonControl1.MaxItemId = 23;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 1006;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rb_quanlyKhachHang});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl1.SearchItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this.ribbonControl1.Size = new System.Drawing.Size(971, 177);
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Description = "Thêm tin tức";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ItemAppearance.Normal.Options.UseFont = true;
            this.btnThem.LargeWidth = 100;
            this.btnThem.Name = "btnThem";
            this.btnThem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Caption = "Sửa";
            this.btn_Sua.Id = 2;
            this.btn_Sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.ImageOptions.Image")));
            this.btn_Sua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Sua.ImageOptions.LargeImage")));
            this.btn_Sua.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.ItemAppearance.Hovered.Options.UseFont = true;
            this.btn_Sua.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_Sua.ItemInMenuAppearance.Hovered.BackColor = System.Drawing.Color.Transparent;
            this.btn_Sua.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.ItemInMenuAppearance.Hovered.Options.UseBackColor = true;
            this.btn_Sua.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.btn_Sua.ItemInMenuAppearance.Normal.BackColor = System.Drawing.Color.Transparent;
            this.btn_Sua.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.ItemInMenuAppearance.Normal.Options.UseBackColor = true;
            this.btn_Sua.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_XoaTT
            // 
            this.btn_XoaTT.Caption = "Xóa";
            this.btn_XoaTT.Id = 3;
            this.btn_XoaTT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaTT.ImageOptions.Image")));
            this.btn_XoaTT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_XoaTT.ImageOptions.LargeImage")));
            this.btn_XoaTT.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_XoaTT.ItemAppearance.Hovered.Options.UseFont = true;
            this.btn_XoaTT.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_XoaTT.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_XoaTT.ItemInMenuAppearance.Hovered.BackColor = System.Drawing.Color.Silver;
            this.btn_XoaTT.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_XoaTT.ItemInMenuAppearance.Hovered.Options.UseBackColor = true;
            this.btn_XoaTT.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.btn_XoaTT.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_XoaTT.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btn_XoaTT.Name = "btn_XoaTT";
            // 
            // btn_TaiLai
            // 
            this.btn_TaiLai.Caption = "Tải lại";
            this.btn_TaiLai.Id = 4;
            this.btn_TaiLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_TaiLai.ImageOptions.Image")));
            this.btn_TaiLai.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_TaiLai.ImageOptions.LargeImage")));
            this.btn_TaiLai.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TaiLai.ItemAppearance.Hovered.Options.UseFont = true;
            this.btn_TaiLai.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TaiLai.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_TaiLai.ItemInMenuAppearance.Hovered.BackColor = System.Drawing.Color.Silver;
            this.btn_TaiLai.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TaiLai.ItemInMenuAppearance.Hovered.Options.UseBackColor = true;
            this.btn_TaiLai.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.btn_TaiLai.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TaiLai.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btn_TaiLai.Name = "btn_TaiLai";
            this.btn_TaiLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_TaiLai_ItemClick);
            // 
            // barEditItem_NTT
            // 
            this.barEditItem_NTT.Caption = "Nhóm tin tức:  ";
            this.barEditItem_NTT.CausesValidation = true;
            this.barEditItem_NTT.Edit = null;
            this.barEditItem_NTT.EditHeight = 30;
            this.barEditItem_NTT.EditWidth = 200;
            this.barEditItem_NTT.Id = 5;
            this.barEditItem_NTT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barEditItem_NTT.ImageOptions.Image")));
            this.barEditItem_NTT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barEditItem_NTT.ImageOptions.LargeImage")));
            this.barEditItem_NTT.Name = "barEditItem_NTT";
            this.barEditItem_NTT.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barSubItem_NTT
            // 
            this.barSubItem_NTT.Caption = "Nhóm tin tức";
            this.barSubItem_NTT.Id = 6;
            this.barSubItem_NTT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem_NTT.ImageOptions.Image")));
            this.barSubItem_NTT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItem_NTT.ImageOptions.LargeImage")));
            this.barSubItem_NTT.Name = "barSubItem_NTT";
            // 
            // btn_Export
            // 
            this.btn_Export.Caption = "Excel";
            this.btn_Export.Id = 7;
            this.btn_Export.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Export.ImageOptions.Image")));
            this.btn_Export.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Export.ImageOptions.LargeImage")));
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_Export.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Export_ItemClick);
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1";
            // 
            // 
            // 
            this.ribbonGalleryBarItem1.Gallery.ShowItemText = true;
            this.ribbonGalleryBarItem1.Id = 8;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Thêm";
            this.barButtonItem2.Id = 9;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Xóa";
            this.barButtonItem5.Id = 10;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Sửa";
            this.barButtonItem6.Id = 11;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barSubItem_chinhSua
            // 
            this.barSubItem_chinhSua.Caption = "Chỉnh sửa chức vụ";
            this.barSubItem_chinhSua.Id = 12;
            this.barSubItem_chinhSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem_chinhSua.ImageOptions.Image")));
            this.barSubItem_chinhSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItem_chinhSua.ImageOptions.LargeImage")));
            this.barSubItem_chinhSua.Name = "barSubItem_chinhSua";
            // 
            // btn_ThemNT
            // 
            this.btn_ThemNT.Caption = "Thêm";
            this.btn_ThemNT.Id = 13;
            this.btn_ThemNT.Name = "btn_ThemNT";
            // 
            // btn_SuaNT
            // 
            this.btn_SuaNT.Caption = "Sửa";
            this.btn_SuaNT.Id = 14;
            this.btn_SuaNT.Name = "btn_SuaNT";
            // 
            // btn_XoaNT
            // 
            this.btn_XoaNT.Caption = "Xóa";
            this.btn_XoaNT.Id = 15;
            this.btn_XoaNT.Name = "btn_XoaNT";
            // 
            // btn_YeuThic
            // 
            this.btn_YeuThic.Caption = "Yêu Thích";
            this.btn_YeuThic.Id = 16;
            this.btn_YeuThic.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_YeuThic.ImageOptions.Image")));
            this.btn_YeuThic.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_YeuThic.ImageOptions.LargeImage")));
            this.btn_YeuThic.Name = "btn_YeuThic";
            // 
            // barListItem1
            // 
            this.barListItem1.Caption = "barListItem1";
            this.barListItem1.Id = 17;
            this.barListItem1.Name = "barListItem1";
            // 
            // barSubItemTL
            // 
            this.barSubItemTL.Caption = "Thể loại";
            this.barSubItemTL.Id = 18;
            this.barSubItemTL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItemTL.ImageOptions.Image")));
            this.barSubItemTL.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItemTL.ImageOptions.LargeImage")));
            this.barSubItemTL.Name = "barSubItemTL";
            // 
            // barSubItem_NXB
            // 
            this.barSubItem_NXB.Caption = "Nhà xuất bản";
            this.barSubItem_NXB.Id = 19;
            this.barSubItem_NXB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem_NXB.ImageOptions.Image")));
            this.barSubItem_NXB.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItem_NXB.ImageOptions.LargeImage")));
            this.barSubItem_NXB.Name = "barSubItem_NXB";
            // 
            // btn_ChinhSuaNXB
            // 
            this.btn_ChinhSuaNXB.Caption = "barButtonItem1";
            this.btn_ChinhSuaNXB.Id = 20;
            this.btn_ChinhSuaNXB.Name = "btn_ChinhSuaNXB";
            // 
            // btn_DanhGia
            // 
            this.btn_DanhGia.Caption = "Đánh giá";
            this.btn_DanhGia.Id = 21;
            this.btn_DanhGia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DanhGia.ImageOptions.Image")));
            this.btn_DanhGia.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DanhGia.ImageOptions.LargeImage")));
            this.btn_DanhGia.Name = "btn_DanhGia";
            // 
            // rb_quanlyKhachHang
            // 
            this.rb_quanlyKhachHang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.main,
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.rb_quanlyKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rb_quanlyKhachHang.ImageOptions.Image")));
            this.rb_quanlyKhachHang.Name = "rb_quanlyKhachHang";
            this.rb_quanlyKhachHang.Text = "Quản lý sách";
            // 
            // main
            // 
            this.main.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("main.ImageOptions.Image")));
            this.main.ItemLinks.Add(this.btn_TaiLai);
            this.main.ItemLinks.Add(this.barButtonItem1);
            this.main.Name = "main";
            this.main.Text = "Chính";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Export);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Xem chi tiết";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Xóa";
            this.barButtonItem1.Id = 22;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 753);
            this.Controls.Add(this.gc_kh);
            this.Controls.Add(this.ribbonControl1);
            this.MinimumSize = new System.Drawing.Size(989, 800);
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_kh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gc_kh;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btn_Sua;
        private DevExpress.XtraBars.BarButtonItem btn_XoaTT;
        private DevExpress.XtraBars.BarButtonItem btn_TaiLai;
        private DevExpress.XtraBars.BarEditItem barEditItem_NTT;
        private DevExpress.XtraBars.BarSubItem barSubItem_NTT;
        private DevExpress.XtraBars.BarButtonItem btn_Export;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarSubItem barSubItem_chinhSua;
        private DevExpress.XtraBars.BarButtonItem btn_ThemNT;
        private DevExpress.XtraBars.BarButtonItem btn_SuaNT;
        private DevExpress.XtraBars.BarButtonItem btn_XoaNT;
        private DevExpress.XtraBars.BarButtonItem btn_YeuThic;
        private DevExpress.XtraBars.BarListItem barListItem1;
        private DevExpress.XtraBars.BarSubItem barSubItemTL;
        private DevExpress.XtraBars.BarSubItem barSubItem_NXB;
        private DevExpress.XtraBars.BarButtonItem btn_ChinhSuaNXB;
        private DevExpress.XtraBars.BarButtonItem btn_DanhGia;
        private DevExpress.XtraBars.Ribbon.RibbonPage rb_quanlyKhachHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup main;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}