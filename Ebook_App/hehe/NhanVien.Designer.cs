namespace hehe
{
    partial class NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_NV = new DevExpress.XtraGrid.GridControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Sua = new DevExpress.XtraBars.BarButtonItem();
            this.btn_XoaTT = new DevExpress.XtraBars.BarButtonItem();
            this.btn_TaiLai = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem_NTT = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barSubItem_NTT = new DevExpress.XtraBars.BarSubItem();
            this.btn_Xem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem_chinhSua = new DevExpress.XtraBars.BarSubItem();
            this.btn_ThemNT = new DevExpress.XtraBars.BarButtonItem();
            this.btn_SuaNT = new DevExpress.XtraBars.BarButtonItem();
            this.btn_XoaNT = new DevExpress.XtraBars.BarButtonItem();
            this.btn_chinhsuacv = new DevExpress.XtraBars.BarButtonItem();
            this.rb_quanlytintuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.main = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.NTT = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_NV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Email";
            this.gridColumn2.FieldName = "Email";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Họ và tên";
            this.gridColumn3.FieldName = "TenNV";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã nhân viên";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn1.FieldName = "MaNV";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView1.Appearance.EvenRow.Options.UseFont = true;
            this.gridView1.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView1.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gridView1.Appearance.FilterPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView1.Appearance.FilterPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.gc_NV;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Username";
            this.gridColumn4.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn4.FieldName = "UserName";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 94;
            // 
            // gc_NV
            // 
            this.gc_NV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_NV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gc_NV.Location = new System.Drawing.Point(0, 177);
            this.gc_NV.MainView = this.gridView1;
            this.gc_NV.MenuManager = this.ribbonControl1;
            this.gc_NV.Name = "gc_NV";
            this.gc_NV.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gc_NV.Size = new System.Drawing.Size(1042, 622);
            this.gc_NV.TabIndex = 3;
            this.gc_NV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // ribbonControl1
            // 
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
            this.btn_Xem,
            this.ribbonGalleryBarItem1,
            this.barButtonItem2,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barSubItem_chinhSua,
            this.btn_ThemNT,
            this.btn_SuaNT,
            this.btn_XoaNT,
            this.btn_chinhsuacv});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rb_quanlytintuc});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl1.SearchItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this.ribbonControl1.Size = new System.Drawing.Size(1042, 177);
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
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
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
            this.btn_XoaTT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_XoaTT_ItemClick);
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
            this.barEditItem_NTT.Edit = this.repositoryItemComboBox1;
            this.barEditItem_NTT.EditHeight = 30;
            this.barEditItem_NTT.EditWidth = 200;
            this.barEditItem_NTT.Id = 5;
            this.barEditItem_NTT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barEditItem_NTT.ImageOptions.Image")));
            this.barEditItem_NTT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barEditItem_NTT.ImageOptions.LargeImage")));
            this.barEditItem_NTT.Name = "barEditItem_NTT";
            this.barEditItem_NTT.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.Sorted = true;
            // 
            // barSubItem_NTT
            // 
            this.barSubItem_NTT.Caption = "Nhóm tin tức";
            this.barSubItem_NTT.Id = 6;
            this.barSubItem_NTT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem_NTT.ImageOptions.Image")));
            this.barSubItem_NTT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItem_NTT.ImageOptions.LargeImage")));
            this.barSubItem_NTT.Name = "barSubItem_NTT";
            // 
            // btn_Xem
            // 
            this.btn_Xem.Caption = "Xem";
            this.btn_Xem.Id = 7;
            this.btn_Xem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xem.ImageOptions.Image")));
            this.btn_Xem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Xem.ImageOptions.LargeImage")));
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_Xem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Xem_ItemClick);
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
            this.btn_ThemNT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ThemNT_ItemClick);
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
            // btn_chinhsuacv
            // 
            this.btn_chinhsuacv.Caption = "chỉnh sửa chức vụ";
            this.btn_chinhsuacv.Id = 16;
            this.btn_chinhsuacv.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_chinhsuacv.ImageOptions.Image")));
            this.btn_chinhsuacv.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_chinhsuacv.ImageOptions.LargeImage")));
            this.btn_chinhsuacv.Name = "btn_chinhsuacv";
            this.btn_chinhsuacv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_chinhsuacv_ItemClick);
            // 
            // rb_quanlytintuc
            // 
            this.rb_quanlytintuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.main,
            this.NTT,
            this.ribbonPageGroup1});
            this.rb_quanlytintuc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rb_quanlytintuc.ImageOptions.Image")));
            this.rb_quanlytintuc.Name = "rb_quanlytintuc";
            this.rb_quanlytintuc.Text = "Quản lý nhân viên";
            // 
            // main
            // 
            this.main.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("main.ImageOptions.Image")));
            this.main.ItemLinks.Add(this.btnThem);
            this.main.ItemLinks.Add(this.btn_XoaTT);
            this.main.ItemLinks.Add(this.btn_TaiLai);
            this.main.Name = "main";
            this.main.Text = "Chính";
            // 
            // NTT
            // 
            this.NTT.ItemLinks.Add(this.btn_chinhsuacv);
            this.NTT.Name = "NTT";
            this.NTT.Text = "Nhóm tin tức";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Xem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Xem chi tiết";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ảnh nhân viên";
            this.gridColumn5.ColumnEdit = this.repositoryItemPictureEdit1;
            this.gridColumn5.FieldName = "AnhNV";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 94;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 799);
            this.Controls.Add(this.gc_NV);
            this.Controls.Add(this.ribbonControl1);
            this.MinimumSize = new System.Drawing.Size(1060, 846);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_NV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.GridControl gc_NV;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btn_Sua;
        private DevExpress.XtraBars.BarButtonItem btn_XoaTT;
        private DevExpress.XtraBars.BarButtonItem btn_TaiLai;
        private DevExpress.XtraBars.BarEditItem barEditItem_NTT;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarSubItem barSubItem_NTT;
        private DevExpress.XtraBars.BarButtonItem btn_Xem;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarSubItem barSubItem_chinhSua;
        private DevExpress.XtraBars.BarButtonItem btn_ThemNT;
        private DevExpress.XtraBars.BarButtonItem btn_SuaNT;
        private DevExpress.XtraBars.BarButtonItem btn_XoaNT;
        private DevExpress.XtraBars.Ribbon.RibbonPage rb_quanlytintuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup main;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup NTT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btn_chinhsuacv;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
    }
}