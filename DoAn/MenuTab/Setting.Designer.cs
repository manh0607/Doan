namespace DoAn.MenuTab
{
    partial class Setting
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
            this.dataGridViewNV = new System.Windows.Forms.DataGridView();
            this.txtUserNV = new System.Windows.Forms.TextBox();
            this.txtNameNV = new System.Windows.Forms.TextBox();
            this.txtPassNV = new System.Windows.Forms.TextBox();
            this.BtnThem = new FontAwesome.Sharp.IconButton();
            this.BtnSua = new FontAwesome.Sharp.IconButton();
            this.BtnXoa = new FontAwesome.Sharp.IconButton();
            this.BtnHuy = new FontAwesome.Sharp.IconButton();
            this.txtSttNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNV
            // 
            this.dataGridViewNV.AllowUserToAddRows = false;
            this.dataGridViewNV.AllowUserToDeleteRows = false;
            this.dataGridViewNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNV.Location = new System.Drawing.Point(470, 82);
            this.dataGridViewNV.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewNV.Name = "dataGridViewNV";
            this.dataGridViewNV.ReadOnly = true;
            this.dataGridViewNV.RowHeadersWidth = 51;
            this.dataGridViewNV.Size = new System.Drawing.Size(696, 261);
            this.dataGridViewNV.TabIndex = 0;
            this.dataGridViewNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNV_CellClick);
            // 
            // txtUserNV
            // 
            this.txtUserNV.Location = new System.Drawing.Point(140, 92);
            this.txtUserNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserNV.Name = "txtUserNV";
            this.txtUserNV.Size = new System.Drawing.Size(213, 22);
            this.txtUserNV.TabIndex = 1;
            // 
            // txtNameNV
            // 
            this.txtNameNV.Location = new System.Drawing.Point(140, 123);
            this.txtNameNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameNV.Name = "txtNameNV";
            this.txtNameNV.Size = new System.Drawing.Size(213, 22);
            this.txtNameNV.TabIndex = 2;
            // 
            // txtPassNV
            // 
            this.txtPassNV.Location = new System.Drawing.Point(140, 161);
            this.txtPassNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassNV.Name = "txtPassNV";
            this.txtPassNV.Size = new System.Drawing.Size(213, 22);
            this.txtPassNV.TabIndex = 3;
            // 
            // BtnThem
            // 
            this.BtnThem.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnThem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnThem.IconColor = System.Drawing.Color.Black;
            this.BtnThem.IconSize = 16;
            this.BtnThem.Location = new System.Drawing.Point(21, 214);
            this.BtnThem.Margin = new System.Windows.Forms.Padding(4);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Rotation = 0D;
            this.BtnThem.Size = new System.Drawing.Size(94, 48);
            this.BtnThem.TabIndex = 4;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnSua.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnSua.IconColor = System.Drawing.Color.Black;
            this.BtnSua.IconSize = 16;
            this.BtnSua.Location = new System.Drawing.Point(188, 214);
            this.BtnSua.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Rotation = 0D;
            this.BtnSua.Size = new System.Drawing.Size(94, 48);
            this.BtnSua.TabIndex = 5;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnXoa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnXoa.IconColor = System.Drawing.Color.Black;
            this.BtnXoa.IconSize = 16;
            this.BtnXoa.Location = new System.Drawing.Point(21, 295);
            this.BtnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Rotation = 0D;
            this.BtnXoa.Size = new System.Drawing.Size(89, 48);
            this.BtnXoa.TabIndex = 6;
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
            this.BtnHuy.Location = new System.Drawing.Point(188, 295);
            this.BtnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.BtnHuy.Name = "BtnHuy";
            this.BtnHuy.Rotation = 0D;
            this.BtnHuy.Size = new System.Drawing.Size(94, 48);
            this.BtnHuy.TabIndex = 7;
            this.BtnHuy.Text = "Hủy";
            this.BtnHuy.UseVisualStyleBackColor = true;
            this.BtnHuy.Click += new System.EventHandler(this.BtnHuy_Click);
            // 
            // txtSttNV
            // 
            this.txtSttNV.Location = new System.Drawing.Point(140, 58);
            this.txtSttNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtSttNV.Name = "txtSttNV";
            this.txtSttNV.ReadOnly = true;
            this.txtSttNV.Size = new System.Drawing.Size(213, 22);
            this.txtSttNV.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "STT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tài khoản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tên NV";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 163);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Mật khẩu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(466, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(240, 24);
            this.label9.TabIndex = 29;
            this.label9.Text = "Quản lý thông tin nhân viên";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 392);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSttNV);
            this.Controls.Add(this.BtnHuy);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.txtPassNV);
            this.Controls.Add(this.txtNameNV);
            this.Controls.Add(this.txtUserNV);
            this.Controls.Add(this.dataGridViewNV);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Setting";
            this.Text = "Thiết lập nhân viên";
            this.Load += new System.EventHandler(this.Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNV;
        private System.Windows.Forms.TextBox txtUserNV;
        private System.Windows.Forms.TextBox txtNameNV;
        private System.Windows.Forms.TextBox txtPassNV;
        private FontAwesome.Sharp.IconButton BtnThem;
        private FontAwesome.Sharp.IconButton BtnSua;
        private FontAwesome.Sharp.IconButton BtnXoa;
        private FontAwesome.Sharp.IconButton BtnHuy;
        private System.Windows.Forms.TextBox txtSttNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}