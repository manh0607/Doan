﻿namespace DoAn.MenuTab
{
    partial class BanHang
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
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiasp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtiensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvsanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamgiasp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttongcongtiensp = new System.Windows.Forms.TextBox();
            this.txtthanhtoan = new System.Windows.Forms.TextBox();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.txtsohd = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtsoluongsp = new System.Windows.Forms.TextBox();
            this.txtdongiasp = new System.Windows.Forms.TextBox();
            this.txtgiamphantramsp = new System.Windows.Forms.TextBox();
            this.txttiensp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxdonvisp = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnexit = new FontAwesome.Sharp.IconButton();
            this.btnhuyHD = new FontAwesome.Sharp.IconButton();
            this.btnthanhtoan = new FontAwesome.Sharp.IconButton();
            this.btnsua = new FontAwesome.Sharp.IconButton();
            this.btnthem = new FontAwesome.Sharp.IconButton();
            this.btnxoa = new FontAwesome.Sharp.IconButton();
            this.btnhuy = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxloaisp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(120, 30);
            this.txtmakh.Margin = new System.Windows.Forms.Padding(4);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(187, 22);
            this.txtmakh.TabIndex = 0;
            this.txtmakh.TextChanged += new System.EventHandler(this.txtmakh_TextChanged);
            // 
            // txttenkh
            // 
            this.txttenkh.Location = new System.Drawing.Point(316, 30);
            this.txttenkh.Margin = new System.Windows.Forms.Padding(4);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(267, 22);
            this.txttenkh.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.soluongsp,
            this.dongiasp,
            this.thanhtiensp,
            this.dvsanpham,
            this.loaisp,
            this.giamgiasp});
            this.dataGridView1.Location = new System.Drawing.Point(16, 84);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(692, 334);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // masp
            // 
            this.masp.HeaderText = "Mã hàng";
            this.masp.MinimumWidth = 6;
            this.masp.Name = "masp";
            this.masp.ReadOnly = true;
            this.masp.Width = 125;
            // 
            // tensp
            // 
            this.tensp.HeaderText = "Tên hàng";
            this.tensp.MinimumWidth = 6;
            this.tensp.Name = "tensp";
            this.tensp.ReadOnly = true;
            this.tensp.Width = 125;
            // 
            // soluongsp
            // 
            this.soluongsp.HeaderText = "SL";
            this.soluongsp.MinimumWidth = 6;
            this.soluongsp.Name = "soluongsp";
            this.soluongsp.ReadOnly = true;
            this.soluongsp.Width = 125;
            // 
            // dongiasp
            // 
            this.dongiasp.HeaderText = "Đơn giá";
            this.dongiasp.MinimumWidth = 6;
            this.dongiasp.Name = "dongiasp";
            this.dongiasp.ReadOnly = true;
            this.dongiasp.Width = 125;
            // 
            // thanhtiensp
            // 
            this.thanhtiensp.HeaderText = "Thành tiền";
            this.thanhtiensp.MinimumWidth = 6;
            this.thanhtiensp.Name = "thanhtiensp";
            this.thanhtiensp.ReadOnly = true;
            this.thanhtiensp.Width = 125;
            // 
            // dvsanpham
            // 
            this.dvsanpham.HeaderText = "Đơn vị";
            this.dvsanpham.MinimumWidth = 6;
            this.dvsanpham.Name = "dvsanpham";
            this.dvsanpham.ReadOnly = true;
            this.dvsanpham.Width = 125;
            // 
            // loaisp
            // 
            this.loaisp.HeaderText = "Loại";
            this.loaisp.MinimumWidth = 6;
            this.loaisp.Name = "loaisp";
            this.loaisp.ReadOnly = true;
            this.loaisp.Width = 125;
            // 
            // giamgiasp
            // 
            this.giamgiasp.HeaderText = "Giảm giá";
            this.giamgiasp.MinimumWidth = 6;
            this.giamgiasp.Name = "giamgiasp";
            this.giamgiasp.ReadOnly = true;
            this.giamgiasp.Width = 125;
            // 
            // txttongcongtiensp
            // 
            this.txttongcongtiensp.Location = new System.Drawing.Point(185, 441);
            this.txttongcongtiensp.Margin = new System.Windows.Forms.Padding(4);
            this.txttongcongtiensp.Name = "txttongcongtiensp";
            this.txttongcongtiensp.Size = new System.Drawing.Size(187, 22);
            this.txttongcongtiensp.TabIndex = 3;
            this.txttongcongtiensp.TextChanged += new System.EventHandler(this.txttongcongtiensp_TextChanged);
            // 
            // txtthanhtoan
            // 
            this.txtthanhtoan.Location = new System.Drawing.Point(185, 501);
            this.txtthanhtoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtthanhtoan.Name = "txtthanhtoan";
            this.txtthanhtoan.Size = new System.Drawing.Size(187, 22);
            this.txtthanhtoan.TabIndex = 8;
            this.txtthanhtoan.TextChanged += new System.EventHandler(this.txtthanhtoan_TextChanged);
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(861, 85);
            this.txtmasp.Margin = new System.Windows.Forms.Padding(4);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(311, 22);
            this.txtmasp.TabIndex = 10;
            this.txtmasp.TextChanged += new System.EventHandler(this.txtmasp_TextChanged);
            this.txtmasp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmasp_KeyDown);
            // 
            // txtsohd
            // 
            this.txtsohd.Location = new System.Drawing.Point(844, 30);
            this.txtsohd.Margin = new System.Windows.Forms.Padding(4);
            this.txtsohd.Name = "txtsohd";
            this.txtsohd.ReadOnly = true;
            this.txtsohd.Size = new System.Drawing.Size(328, 22);
            this.txtsohd.TabIndex = 11;
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(737, 115);
            this.txttensp.Margin = new System.Windows.Forms.Padding(4);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(433, 22);
            this.txttensp.TabIndex = 12;
            this.txttensp.TextChanged += new System.EventHandler(this.txttensp_TextChanged_1);
            this.txttensp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttensp_KeyDown);
            // 
            // txtsoluongsp
            // 
            this.txtsoluongsp.Location = new System.Drawing.Point(840, 162);
            this.txtsoluongsp.Margin = new System.Windows.Forms.Padding(4);
            this.txtsoluongsp.Name = "txtsoluongsp";
            this.txtsoluongsp.Size = new System.Drawing.Size(100, 22);
            this.txtsoluongsp.TabIndex = 13;
            this.txtsoluongsp.TextChanged += new System.EventHandler(this.txtsoluongsp_TextChanged);
            this.txtsoluongsp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoluongsp_KeyPress);
            // 
            // txtdongiasp
            // 
            this.txtdongiasp.Location = new System.Drawing.Point(840, 194);
            this.txtdongiasp.Margin = new System.Windows.Forms.Padding(4);
            this.txtdongiasp.Name = "txtdongiasp";
            this.txtdongiasp.ReadOnly = true;
            this.txtdongiasp.Size = new System.Drawing.Size(187, 22);
            this.txtdongiasp.TabIndex = 14;
            this.txtdongiasp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdongiasp_KeyPress);
            // 
            // txtgiamphantramsp
            // 
            this.txtgiamphantramsp.Location = new System.Drawing.Point(840, 226);
            this.txtgiamphantramsp.Margin = new System.Windows.Forms.Padding(4);
            this.txtgiamphantramsp.Name = "txtgiamphantramsp";
            this.txtgiamphantramsp.Size = new System.Drawing.Size(187, 22);
            this.txtgiamphantramsp.TabIndex = 15;
            // 
            // txttiensp
            // 
            this.txttiensp.Location = new System.Drawing.Point(840, 258);
            this.txttiensp.Margin = new System.Windows.Forms.Padding(4);
            this.txttiensp.Name = "txttiensp";
            this.txttiensp.ReadOnly = true;
            this.txttiensp.Size = new System.Drawing.Size(187, 22);
            this.txttiensp.TabIndex = 16;
            this.txttiensp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttiensp_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "SĐT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 443);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tổng cộng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 498);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Thanh toán";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(724, 85);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Mã sản phẩm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(724, 164);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 36;
            this.label10.Text = "Số lượng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(723, 199);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "Đơn giá";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(724, 231);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 20);
            this.label12.TabIndex = 38;
            this.label12.Text = "- %";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(721, 263);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 20);
            this.label13.TabIndex = 39;
            this.label13.Text = "Thành tiền";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(720, 28);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 20);
            this.label14.TabIndex = 40;
            this.label14.Text = "Số hóa đơn";
            // 
            // comboBoxdonvisp
            // 
            this.comboBoxdonvisp.FormattingEnabled = true;
            this.comboBoxdonvisp.Location = new System.Drawing.Point(949, 161);
            this.comboBoxdonvisp.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxdonvisp.Name = "comboBoxdonvisp";
            this.comboBoxdonvisp.Size = new System.Drawing.Size(77, 24);
            this.comboBoxdonvisp.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1036, 263);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 20);
            this.label15.TabIndex = 43;
            this.label15.Text = "VNĐ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(399, 445);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 18);
            this.label16.TabIndex = 44;
            this.label16.Text = "VNĐ";
            // 
            // btnexit
            // 
            this.btnexit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnexit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnexit.IconColor = System.Drawing.Color.Black;
            this.btnexit.IconSize = 16;
            this.btnexit.Location = new System.Drawing.Point(1067, 548);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Rotation = 0D;
            this.btnexit.Size = new System.Drawing.Size(103, 43);
            this.btnexit.TabIndex = 26;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnhuyHD
            // 
            this.btnhuyHD.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnhuyHD.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnhuyHD.IconColor = System.Drawing.Color.Black;
            this.btnhuyHD.IconSize = 16;
            this.btnhuyHD.Location = new System.Drawing.Point(949, 548);
            this.btnhuyHD.Margin = new System.Windows.Forms.Padding(4);
            this.btnhuyHD.Name = "btnhuyHD";
            this.btnhuyHD.Rotation = 0D;
            this.btnhuyHD.Size = new System.Drawing.Size(103, 43);
            this.btnhuyHD.TabIndex = 25;
            this.btnhuyHD.Text = "Hủy HĐ";
            this.btnhuyHD.UseVisualStyleBackColor = true;
            this.btnhuyHD.Click += new System.EventHandler(this.btnhuyHD_Click);
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthanhtoan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnthanhtoan.IconColor = System.Drawing.Color.Black;
            this.btnthanhtoan.IconSize = 16;
            this.btnthanhtoan.Location = new System.Drawing.Point(728, 389);
            this.btnthanhtoan.Margin = new System.Windows.Forms.Padding(4);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Rotation = 0D;
            this.btnthanhtoan.Size = new System.Drawing.Size(435, 95);
            this.btnthanhtoan.TabIndex = 24;
            this.btnthanhtoan.Text = "Thanh toán";
            this.btnthanhtoan.UseVisualStyleBackColor = true;
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // btnsua
            // 
            this.btnsua.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnsua.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnsua.IconColor = System.Drawing.Color.Black;
            this.btnsua.IconSize = 16;
            this.btnsua.Location = new System.Drawing.Point(839, 302);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Rotation = 0D;
            this.btnsua.Size = new System.Drawing.Size(103, 68);
            this.btnsua.TabIndex = 23;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnthem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnthem.IconColor = System.Drawing.Color.Black;
            this.btnthem.IconSize = 20;
            this.btnthem.Location = new System.Drawing.Point(728, 302);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Rotation = 0D;
            this.btnthem.Size = new System.Drawing.Size(103, 68);
            this.btnthem.TabIndex = 22;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnxoa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnxoa.IconColor = System.Drawing.Color.Black;
            this.btnxoa.IconSize = 16;
            this.btnxoa.Location = new System.Drawing.Point(949, 302);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Rotation = 0D;
            this.btnxoa.Size = new System.Drawing.Size(103, 68);
            this.btnxoa.TabIndex = 21;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnhuy.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnhuy.IconColor = System.Drawing.Color.Black;
            this.btnhuy.IconSize = 16;
            this.btnhuy.Location = new System.Drawing.Point(1060, 302);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Rotation = 0D;
            this.btnhuy.Size = new System.Drawing.Size(103, 68);
            this.btnhuy.TabIndex = 20;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(399, 506);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 18);
            this.label8.TabIndex = 47;
            this.label8.Text = "VNĐ";
            // 
            // comboBoxloaisp
            // 
            this.comboBoxloaisp.FormattingEnabled = true;
            this.comboBoxloaisp.Location = new System.Drawing.Point(1040, 161);
            this.comboBoxloaisp.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxloaisp.Name = "comboBoxloaisp";
            this.comboBoxloaisp.Size = new System.Drawing.Size(121, 24);
            this.comboBoxloaisp.TabIndex = 49;
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 604);
            this.Controls.Add(this.comboBoxloaisp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBoxdonvisp);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnhuyHD);
            this.Controls.Add(this.btnthanhtoan);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.txttiensp);
            this.Controls.Add(this.txtgiamphantramsp);
            this.Controls.Add(this.txtdongiasp);
            this.Controls.Add(this.txtsoluongsp);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.txtsohd);
            this.Controls.Add(this.txtmasp);
            this.Controls.Add(this.txtthanhtoan);
            this.Controls.Add(this.txttongcongtiensp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txttenkh);
            this.Controls.Add(this.txtmakh);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BanHang";
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.BanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.TextBox txttongcongtiensp;
        private System.Windows.Forms.TextBox txtthanhtoan;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.TextBox txtsohd;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtsoluongsp;
        private System.Windows.Forms.TextBox txtdongiasp;
        private System.Windows.Forms.TextBox txtgiamphantramsp;
        private System.Windows.Forms.TextBox txttiensp;
        private FontAwesome.Sharp.IconButton btnhuy;
        private FontAwesome.Sharp.IconButton btnxoa;
        private FontAwesome.Sharp.IconButton btnthem;
        private FontAwesome.Sharp.IconButton btnsua;
        private FontAwesome.Sharp.IconButton btnthanhtoan;
        private FontAwesome.Sharp.IconButton btnhuyHD;
        private FontAwesome.Sharp.IconButton btnexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxdonvisp;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxloaisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongiasp;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtiensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvsanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamgiasp;
    }
}