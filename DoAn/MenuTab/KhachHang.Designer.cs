namespace DoAn.MenuTab
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
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridViewKH = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdkh = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtsđtkh = new System.Windows.Forms.TextBox();
            this.txtdiachikh = new System.Windows.Forms.TextBox();
            this.txtemailkh = new System.Windows.Forms.TextBox();
            this.BtnThem = new FontAwesome.Sharp.IconButton();
            this.BtnXoa = new FontAwesome.Sharp.IconButton();
            this.BtnHuy = new FontAwesome.Sharp.IconButton();
            this.BtnSua = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(449, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(256, 24);
            this.label11.TabIndex = 32;
            this.label11.Text = "Quản lý thông tin khách hàng";
            // 
            // dataGridViewKH
            // 
            this.dataGridViewKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKH.Location = new System.Drawing.Point(453, 57);
            this.dataGridViewKH.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewKH.Name = "dataGridViewKH";
            this.dataGridViewKH.RowHeadersWidth = 51;
            this.dataGridViewKH.Size = new System.Drawing.Size(722, 308);
            this.dataGridViewKH.TabIndex = 33;
            this.dataGridViewKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKH_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "IDKH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tên KH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "SĐT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Email";
            // 
            // txtIdkh
            // 
            this.txtIdkh.Location = new System.Drawing.Point(148, 57);
            this.txtIdkh.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdkh.Name = "txtIdkh";
            this.txtIdkh.ReadOnly = true;
            this.txtIdkh.Size = new System.Drawing.Size(213, 22);
            this.txtIdkh.TabIndex = 39;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(148, 93);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(213, 22);
            this.txtTenKH.TabIndex = 40;
            // 
            // txtsđtkh
            // 
            this.txtsđtkh.Location = new System.Drawing.Point(148, 126);
            this.txtsđtkh.Margin = new System.Windows.Forms.Padding(4);
            this.txtsđtkh.Name = "txtsđtkh";
            this.txtsđtkh.Size = new System.Drawing.Size(213, 22);
            this.txtsđtkh.TabIndex = 41;
            // 
            // txtdiachikh
            // 
            this.txtdiachikh.Location = new System.Drawing.Point(148, 158);
            this.txtdiachikh.Margin = new System.Windows.Forms.Padding(4);
            this.txtdiachikh.Name = "txtdiachikh";
            this.txtdiachikh.Size = new System.Drawing.Size(213, 22);
            this.txtdiachikh.TabIndex = 42;
            // 
            // txtemailkh
            // 
            this.txtemailkh.Location = new System.Drawing.Point(148, 191);
            this.txtemailkh.Margin = new System.Windows.Forms.Padding(4);
            this.txtemailkh.Name = "txtemailkh";
            this.txtemailkh.Size = new System.Drawing.Size(213, 22);
            this.txtemailkh.TabIndex = 43;
            // 
            // BtnThem
            // 
            this.BtnThem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnThem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnThem.IconColor = System.Drawing.Color.Black;
            this.BtnThem.IconSize = 16;
            this.BtnThem.Location = new System.Drawing.Point(17, 234);
            this.BtnThem.Margin = new System.Windows.Forms.Padding(4);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Rotation = 0D;
            this.BtnThem.Size = new System.Drawing.Size(94, 48);
            this.BtnThem.TabIndex = 44;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnXoa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnXoa.IconColor = System.Drawing.Color.Black;
            this.BtnXoa.IconSize = 16;
            this.BtnXoa.Location = new System.Drawing.Point(163, 234);
            this.BtnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Rotation = 0D;
            this.BtnXoa.Size = new System.Drawing.Size(89, 48);
            this.BtnXoa.TabIndex = 45;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnHuy
            // 
            this.BtnHuy.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnHuy.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnHuy.IconColor = System.Drawing.Color.Black;
            this.BtnHuy.IconSize = 16;
            this.BtnHuy.Location = new System.Drawing.Point(158, 317);
            this.BtnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.BtnHuy.Name = "BtnHuy";
            this.BtnHuy.Rotation = 0D;
            this.BtnHuy.Size = new System.Drawing.Size(94, 48);
            this.BtnHuy.TabIndex = 46;
            this.BtnHuy.Text = "Hủy";
            this.BtnHuy.UseVisualStyleBackColor = true;
            this.BtnHuy.Click += new System.EventHandler(this.BtnHuy_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnSua.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnSua.IconColor = System.Drawing.Color.Black;
            this.BtnSua.IconSize = 16;
            this.BtnSua.Location = new System.Drawing.Point(13, 317);
            this.BtnSua.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Rotation = 0D;
            this.BtnSua.Size = new System.Drawing.Size(94, 48);
            this.BtnSua.TabIndex = 47;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 397);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.BtnHuy);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.txtemailkh);
            this.Controls.Add(this.txtdiachikh);
            this.Controls.Add(this.txtsđtkh);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtIdkh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewKH);
            this.Controls.Add(this.label11);
            this.Name = "KhachHang";
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridViewKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdkh;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtsđtkh;
        private System.Windows.Forms.TextBox txtdiachikh;
        private System.Windows.Forms.TextBox txtemailkh;
        private FontAwesome.Sharp.IconButton BtnThem;
        private FontAwesome.Sharp.IconButton BtnXoa;
        private FontAwesome.Sharp.IconButton BtnHuy;
        private FontAwesome.Sharp.IconButton BtnSua;
    }
}