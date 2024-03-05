namespace hehe
{
    partial class TheLoai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheLoai));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.rdo_Them = new System.Windows.Forms.RadioButton();
            this.bnt_xoa = new System.Windows.Forms.PictureBox();
            this.btn_luu = new System.Windows.Forms.PictureBox();
            this.txt_tentl = new DevExpress.XtraEditors.TextEdit();
            this.txt_matl = new DevExpress.XtraEditors.TextEdit();
            this.gc_theloai = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMATL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_xoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_luu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tentl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_matl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_theloai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.BackColor = System.Drawing.Color.White;
            this.layoutControl1.Controls.Add(this.rdo_Them);
            this.layoutControl1.Controls.Add(this.bnt_xoa);
            this.layoutControl1.Controls.Add(this.btn_luu);
            this.layoutControl1.Controls.Add(this.txt_tentl);
            this.layoutControl1.Controls.Add(this.txt_matl);
            this.layoutControl1.Controls.Add(this.gc_theloai);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(818, 356);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // rdo_Them
            // 
            this.rdo_Them.Location = new System.Drawing.Point(468, 224);
            this.rdo_Them.Name = "rdo_Them";
            this.rdo_Them.Size = new System.Drawing.Size(330, 31);
            this.rdo_Them.TabIndex = 4;
            this.rdo_Them.Text = "Thêm";
            this.rdo_Them.UseVisualStyleBackColor = true;
            // 
            // bnt_xoa
            // 
            this.bnt_xoa.Image = ((System.Drawing.Image)(resources.GetObject("bnt_xoa.Image")));
            this.bnt_xoa.Location = new System.Drawing.Point(458, 285);
            this.bnt_xoa.Name = "bnt_xoa";
            this.bnt_xoa.Size = new System.Drawing.Size(166, 51);
            this.bnt_xoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnt_xoa.TabIndex = 1;
            this.bnt_xoa.TabStop = false;
            this.bnt_xoa.Click += new System.EventHandler(this.bnt_xoa_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_luu.Image")));
            this.btn_luu.Location = new System.Drawing.Point(644, 285);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Padding = new System.Windows.Forms.Padding(10);
            this.btn_luu.Size = new System.Drawing.Size(154, 51);
            this.btn_luu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_luu.TabIndex = 1;
            this.btn_luu.TabStop = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // txt_tentl
            // 
            this.txt_tentl.Location = new System.Drawing.Point(553, 162);
            this.txt_tentl.Name = "txt_tentl";
            this.txt_tentl.Size = new System.Drawing.Size(235, 22);
            this.txt_tentl.StyleController = this.layoutControl1;
            this.txt_tentl.TabIndex = 3;
            // 
            // txt_matl
            // 
            this.txt_matl.Location = new System.Drawing.Point(553, 60);
            this.txt_matl.Name = "txt_matl";
            this.txt_matl.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txt_matl.Properties.Appearance.Options.UseBackColor = true;
            this.txt_matl.Properties.ReadOnly = true;
            this.txt_matl.Size = new System.Drawing.Size(235, 22);
            this.txt_matl.StyleController = this.layoutControl1;
            this.txt_matl.TabIndex = 2;
            // 
            // gc_theloai
            // 
            this.gc_theloai.DataMember = "THELOAI";
            this.gc_theloai.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gc_theloai.Location = new System.Drawing.Point(12, 12);
            this.gc_theloai.MainView = this.gridView1;
            this.gc_theloai.Margin = new System.Windows.Forms.Padding(4);
            this.gc_theloai.MinimumSize = new System.Drawing.Size(0, 200);
            this.gc_theloai.Name = "gc_theloai";
            this.gc_theloai.Size = new System.Drawing.Size(434, 332);
            this.gc_theloai.TabIndex = 0;
            this.gc_theloai.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMATL,
            this.colTENTL});
            this.gridView1.GridControl = this.gc_theloai;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // colMATL
            // 
            this.colMATL.FieldName = "MaTL";
            this.colMATL.MinWidth = 25;
            this.colMATL.Name = "colMATL";
            this.colMATL.Visible = true;
            this.colMATL.VisibleIndex = 0;
            this.colMATL.Width = 94;
            // 
            // colTENTL
            // 
            this.colTENTL.FieldName = "TenTL";
            this.colTENTL.MinWidth = 25;
            this.colTENTL.Name = "colTENTL";
            this.colTENTL.Visible = true;
            this.colTENTL.VisibleIndex = 1;
            this.colTENTL.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem3,
            this.layoutControlItem7,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(818, 356);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gc_theloai;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(438, 336);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txt_matl;
            this.layoutControlItem4.Location = new System.Drawing.Point(438, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 50, 50);
            this.layoutControlItem4.Size = new System.Drawing.Size(360, 122);
            this.layoutControlItem4.Text = "Mã thể loại:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(73, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txt_tentl;
            this.layoutControlItem5.Location = new System.Drawing.Point(438, 122);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 30, 30);
            this.layoutControlItem5.Size = new System.Drawing.Size(360, 82);
            this.layoutControlItem5.Text = "Tên thể loại:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(73, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.bnt_xoa;
            this.layoutControlItem3.Location = new System.Drawing.Point(438, 265);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem3.Size = new System.Drawing.Size(186, 71);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.rdo_Them;
            this.layoutControlItem7.Location = new System.Drawing.Point(438, 204);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 10, 10, 20);
            this.layoutControlItem7.Size = new System.Drawing.Size(360, 61);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btn_luu;
            this.layoutControlItem6.Location = new System.Drawing.Point(624, 265);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem6.Size = new System.Drawing.Size(174, 71);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // TheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 356);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TheLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thể loại";
            this.Load += new System.EventHandler(this.TheLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnt_xoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_luu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tentl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_matl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_theloai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gc_theloai;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMATL;
        private DevExpress.XtraGrid.Columns.GridColumn colTENTL;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txt_tentl;
        private DevExpress.XtraEditors.TextEdit txt_matl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.PictureBox btn_luu;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.PictureBox bnt_xoa;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.RadioButton rdo_Them;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}