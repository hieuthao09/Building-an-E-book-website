namespace hehe
{
    partial class Login
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.txt_MatKhau = new DevExpress.XtraEditors.ButtonEdit();
            this.txtTenDangNhap1 = new DesignControl.txtTenDangNhap();
            this.ckb_luudangnhap = new DevExpress.XtraEditors.CheckEdit();
            this.ckb_DangNhapQuanLy = new DevExpress.XtraEditors.CheckEdit();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.pnl_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_luudangnhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_DangNhapQuanLy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_login
            // 
            this.pnl_login.BackColor = System.Drawing.Color.White;
            this.pnl_login.Controls.Add(this.txt_MatKhau);
            this.pnl_login.Controls.Add(this.txtTenDangNhap1);
            this.pnl_login.Controls.Add(this.ckb_luudangnhap);
            this.pnl_login.Controls.Add(this.ckb_DangNhapQuanLy);
            this.pnl_login.Controls.Add(this.linkLabel1);
            this.pnl_login.Controls.Add(this.btn_thoat);
            this.pnl_login.Controls.Add(this.btn_dangnhap);
            this.pnl_login.Controls.Add(this.labelControl2);
            this.pnl_login.Controls.Add(this.labelControl3);
            this.pnl_login.Controls.Add(this.labelControl1);
            this.pnl_login.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pnl_login.Location = new System.Drawing.Point(16, 120);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(424, 441);
            this.pnl_login.TabIndex = 0;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(33, 213);
            this.txt_MatKhau.MaximumSize = new System.Drawing.Size(377, 50);
            this.txt_MatKhau.MinimumSize = new System.Drawing.Size(377, 50);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MatKhau.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.txt_MatKhau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.txt_MatKhau.Properties.UseSystemPasswordChar = true;
            this.txt_MatKhau.Size = new System.Drawing.Size(377, 42);
            this.txt_MatKhau.TabIndex = 9;
            this.txt_MatKhau.Tag = "hide";
            this.txt_MatKhau.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txt_MatKhau_ButtonPressed);
            this.txt_MatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MatKhau_KeyPress);
            this.txt_MatKhau.Leave += new System.EventHandler(this.txt_MatKhau_Leave);
            // 
            // txtTenDangNhap1
            // 
            this.txtTenDangNhap1.Location = new System.Drawing.Point(33, 117);
            this.txtTenDangNhap1.MaximumSize = new System.Drawing.Size(377, 50);
            this.txtTenDangNhap1.MinimumSize = new System.Drawing.Size(377, 50);
            this.txtTenDangNhap1.Name = "txtTenDangNhap1";
            this.txtTenDangNhap1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenDangNhap1.Properties.Appearance.Options.UseFont = true;
            this.txtTenDangNhap1.Size = new System.Drawing.Size(377, 28);
            this.txtTenDangNhap1.TabIndex = 8;
            this.txtTenDangNhap1.thoadk = false;
            // 
            // ckb_luudangnhap
            // 
            this.ckb_luudangnhap.Location = new System.Drawing.Point(33, 328);
            this.ckb_luudangnhap.Name = "ckb_luudangnhap";
            this.ckb_luudangnhap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckb_luudangnhap.Properties.Appearance.Options.UseFont = true;
            this.ckb_luudangnhap.Properties.Caption = "Lưu đăng nhập";
            this.ckb_luudangnhap.Size = new System.Drawing.Size(155, 24);
            this.ckb_luudangnhap.TabIndex = 6;
            this.ckb_luudangnhap.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // ckb_DangNhapQuanLy
            // 
            this.ckb_DangNhapQuanLy.Location = new System.Drawing.Point(278, 328);
            this.ckb_DangNhapQuanLy.Name = "ckb_DangNhapQuanLy";
            this.ckb_DangNhapQuanLy.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckb_DangNhapQuanLy.Properties.Appearance.Options.UseFont = true;
            this.ckb_DangNhapQuanLy.Properties.Caption = "Đối với quản lý";
            this.ckb_DangNhapQuanLy.Size = new System.Drawing.Size(132, 24);
            this.ckb_DangNhapQuanLy.TabIndex = 6;
            this.ckb_DangNhapQuanLy.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.linkLabel1.Location = new System.Drawing.Point(30, 282);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(115, 18);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quên mật khẩu?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_thoat
            // 
            this.btn_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_thoat.Location = new System.Drawing.Point(33, 368);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(173, 44);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.BackColor = System.Drawing.Color.Blue;
            this.btn_dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_dangnhap.ForeColor = System.Drawing.Color.White;
            this.btn_dangnhap.Location = new System.Drawing.Point(237, 368);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(173, 44);
            this.btn_dangnhap.TabIndex = 4;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = false;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(33, 185);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 22);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mật khẩu:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(130, 16);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(204, 40);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "ĐĂNG NHẬP";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(33, 80);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(126, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên đăng nhập:";
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "show_32x32.png");
            this.imageCollection1.Images.SetKeyName(1, "hide_32x32.png");
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.White;
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.Controls.Add(this.pnl_login);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(820, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(462, 703);
            this.sidePanel1.TabIndex = 1;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::hehe.Properties.Resources.desktop_wallpaper_books_animated_book_design;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 703);
            this.Controls.Add(this.sidePanel1);
            this.MaximumSize = new System.Drawing.Size(1300, 750);
            this.MinimumSize = new System.Drawing.Size(1300, 750);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_luudangnhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_DangNhapQuanLy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_login;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_dangnhap;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private DevExpress.XtraEditors.CheckEdit ckb_DangNhapQuanLy;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DesignControl.txtTenDangNhap txtTenDangNhap1;
        private DevExpress.XtraEditors.CheckEdit ckb_luudangnhap;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.ButtonEdit txt_MatKhau;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}

