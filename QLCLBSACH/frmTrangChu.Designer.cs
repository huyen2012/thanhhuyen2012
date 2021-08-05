
namespace QLCLBSACH
{
    partial class frmTrangChu
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
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.tabTrangChu = new System.Windows.Forms.TabControl();
            this.tabpageTK = new System.Windows.Forms.TabPage();
            this.grpTK = new System.Windows.Forms.GroupBox();
            this.cboTKngonngu = new System.Windows.Forms.ComboBox();
            this.cboTKtheloai = new System.Windows.Forms.ComboBox();
            this.txtTKnxb = new System.Windows.Forms.TextBox();
            this.txtTKtacgia = new System.Windows.Forms.TextBox();
            this.txtTKsach = new System.Windows.Forms.TextBox();
            this.chkTKngonngu = new System.Windows.Forms.CheckBox();
            this.chkTKnxb = new System.Windows.Forms.CheckBox();
            this.chkTKtheloai = new System.Windows.Forms.CheckBox();
            this.chkTKtacgia = new System.Windows.Forms.CheckBox();
            this.chkTKsach = new System.Windows.Forms.CheckBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.DataGrid_TimKiem = new System.Windows.Forms.DataGridView();
            this.tabpageMuon = new System.Windows.Forms.TabPage();
            this.tabpageTra = new System.Windows.Forms.TabPage();
            this.tabTrangChu.SuspendLayout();
            this.tabpageTK.SuspendLayout();
            this.grpTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_TimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangXuat.Location = new System.Drawing.Point(1105, 565);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(135, 33);
            this.btnDangXuat.TabIndex = 0;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // tabTrangChu
            // 
            this.tabTrangChu.Controls.Add(this.tabpageTK);
            this.tabTrangChu.Controls.Add(this.tabpageMuon);
            this.tabTrangChu.Controls.Add(this.tabpageTra);
            this.tabTrangChu.Location = new System.Drawing.Point(12, 2);
            this.tabTrangChu.Name = "tabTrangChu";
            this.tabTrangChu.SelectedIndex = 0;
            this.tabTrangChu.Size = new System.Drawing.Size(1232, 557);
            this.tabTrangChu.TabIndex = 1;
            // 
            // tabpageTK
            // 
            this.tabpageTK.Controls.Add(this.grpTK);
            this.tabpageTK.Controls.Add(this.btnTimKiem);
            this.tabpageTK.Controls.Add(this.DataGrid_TimKiem);
            this.tabpageTK.Location = new System.Drawing.Point(4, 29);
            this.tabpageTK.Name = "tabpageTK";
            this.tabpageTK.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageTK.Size = new System.Drawing.Size(1224, 524);
            this.tabpageTK.TabIndex = 2;
            this.tabpageTK.Text = "Tìm kiếm";
            this.tabpageTK.UseVisualStyleBackColor = true;
            this.tabpageTK.Click += new System.EventHandler(this.tabpageTK_Click);
            // 
            // grpTK
            // 
            this.grpTK.Controls.Add(this.cboTKngonngu);
            this.grpTK.Controls.Add(this.cboTKtheloai);
            this.grpTK.Controls.Add(this.txtTKnxb);
            this.grpTK.Controls.Add(this.txtTKtacgia);
            this.grpTK.Controls.Add(this.txtTKsach);
            this.grpTK.Controls.Add(this.chkTKngonngu);
            this.grpTK.Controls.Add(this.chkTKnxb);
            this.grpTK.Controls.Add(this.chkTKtheloai);
            this.grpTK.Controls.Add(this.chkTKtacgia);
            this.grpTK.Controls.Add(this.chkTKsach);
            this.grpTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTK.Location = new System.Drawing.Point(6, 66);
            this.grpTK.Name = "grpTK";
            this.grpTK.Size = new System.Drawing.Size(572, 282);
            this.grpTK.TabIndex = 37;
            this.grpTK.TabStop = false;
            this.grpTK.Text = "Tìm kiếm theo";
            // 
            // cboTKngonngu
            // 
            this.cboTKngonngu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTKngonngu.FormattingEnabled = true;
            this.cboTKngonngu.Location = new System.Drawing.Point(210, 217);
            this.cboTKngonngu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboTKngonngu.Name = "cboTKngonngu";
            this.cboTKngonngu.Size = new System.Drawing.Size(319, 33);
            this.cboTKngonngu.TabIndex = 45;
            // 
            // cboTKtheloai
            // 
            this.cboTKtheloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTKtheloai.FormattingEnabled = true;
            this.cboTKtheloai.Location = new System.Drawing.Point(210, 131);
            this.cboTKtheloai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboTKtheloai.Name = "cboTKtheloai";
            this.cboTKtheloai.Size = new System.Drawing.Size(319, 33);
            this.cboTKtheloai.TabIndex = 46;
            // 
            // txtTKnxb
            // 
            this.txtTKnxb.Location = new System.Drawing.Point(210, 174);
            this.txtTKnxb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTKnxb.Name = "txtTKnxb";
            this.txtTKnxb.Size = new System.Drawing.Size(319, 30);
            this.txtTKnxb.TabIndex = 42;
            // 
            // txtTKtacgia
            // 
            this.txtTKtacgia.Location = new System.Drawing.Point(210, 87);
            this.txtTKtacgia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTKtacgia.Name = "txtTKtacgia";
            this.txtTKtacgia.Size = new System.Drawing.Size(319, 30);
            this.txtTKtacgia.TabIndex = 43;
            // 
            // txtTKsach
            // 
            this.txtTKsach.Location = new System.Drawing.Point(210, 44);
            this.txtTKsach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTKsach.Name = "txtTKsach";
            this.txtTKsach.Size = new System.Drawing.Size(319, 30);
            this.txtTKsach.TabIndex = 44;
            // 
            // chkTKngonngu
            // 
            this.chkTKngonngu.AutoSize = true;
            this.chkTKngonngu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkTKngonngu.Location = new System.Drawing.Point(26, 219);
            this.chkTKngonngu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkTKngonngu.Name = "chkTKngonngu";
            this.chkTKngonngu.Size = new System.Drawing.Size(123, 29);
            this.chkTKngonngu.TabIndex = 37;
            this.chkTKngonngu.Text = "Ngôn ngữ";
            this.chkTKngonngu.UseVisualStyleBackColor = true;
            // 
            // chkTKnxb
            // 
            this.chkTKnxb.AutoSize = true;
            this.chkTKnxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkTKnxb.Location = new System.Drawing.Point(26, 176);
            this.chkTKnxb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkTKnxb.Name = "chkTKnxb";
            this.chkTKnxb.Size = new System.Drawing.Size(160, 29);
            this.chkTKnxb.TabIndex = 38;
            this.chkTKnxb.Text = "Nhà xuất bản:";
            this.chkTKnxb.UseVisualStyleBackColor = true;
            // 
            // chkTKtheloai
            // 
            this.chkTKtheloai.AutoSize = true;
            this.chkTKtheloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkTKtheloai.Location = new System.Drawing.Point(26, 133);
            this.chkTKtheloai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkTKtheloai.Name = "chkTKtheloai";
            this.chkTKtheloai.Size = new System.Drawing.Size(108, 29);
            this.chkTKtheloai.TabIndex = 39;
            this.chkTKtheloai.Text = "Thể loại";
            this.chkTKtheloai.UseVisualStyleBackColor = true;
            // 
            // chkTKtacgia
            // 
            this.chkTKtacgia.AutoSize = true;
            this.chkTKtacgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkTKtacgia.Location = new System.Drawing.Point(26, 89);
            this.chkTKtacgia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkTKtacgia.Name = "chkTKtacgia";
            this.chkTKtacgia.Size = new System.Drawing.Size(109, 29);
            this.chkTKtacgia.TabIndex = 40;
            this.chkTKtacgia.Text = "Tác giả:";
            this.chkTKtacgia.UseVisualStyleBackColor = true;
            // 
            // chkTKsach
            // 
            this.chkTKsach.AutoSize = true;
            this.chkTKsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkTKsach.Location = new System.Drawing.Point(26, 46);
            this.chkTKsach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkTKsach.Name = "chkTKsach";
            this.chkTKsach.Size = new System.Drawing.Size(126, 29);
            this.chkTKsach.TabIndex = 41;
            this.chkTKsach.Text = "Tên sách:";
            this.chkTKsach.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.Location = new System.Drawing.Point(430, 354);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(148, 38);
            this.btnTimKiem.TabIndex = 31;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // DataGrid_TimKiem
            // 
            this.DataGrid_TimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_TimKiem.Location = new System.Drawing.Point(636, 77);
            this.DataGrid_TimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGrid_TimKiem.Name = "DataGrid_TimKiem";
            this.DataGrid_TimKiem.RowHeadersWidth = 62;
            this.DataGrid_TimKiem.Size = new System.Drawing.Size(569, 315);
            this.DataGrid_TimKiem.TabIndex = 23;
            // 
            // tabpageMuon
            // 
            this.tabpageMuon.Location = new System.Drawing.Point(4, 29);
            this.tabpageMuon.Name = "tabpageMuon";
            this.tabpageMuon.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageMuon.Size = new System.Drawing.Size(1224, 524);
            this.tabpageMuon.TabIndex = 3;
            this.tabpageMuon.Text = "Mượn sách";
            this.tabpageMuon.UseVisualStyleBackColor = true;
            // 
            // tabpageTra
            // 
            this.tabpageTra.Location = new System.Drawing.Point(4, 29);
            this.tabpageTra.Name = "tabpageTra";
            this.tabpageTra.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageTra.Size = new System.Drawing.Size(1224, 524);
            this.tabpageTra.TabIndex = 4;
            this.tabpageTra.Text = "Trả sách";
            this.tabpageTra.UseVisualStyleBackColor = true;
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 610);
            this.Controls.Add(this.tabTrangChu);
            this.Controls.Add(this.btnDangXuat);
            this.Name = "frmTrangChu";
            this.Text = "TRANG CHỦ";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.tabTrangChu.ResumeLayout(false);
            this.tabpageTK.ResumeLayout(false);
            this.grpTK.ResumeLayout(false);
            this.grpTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_TimKiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.TabControl tabTrangChu;
        private System.Windows.Forms.TabPage tabpageTK;
        private System.Windows.Forms.TabPage tabpageMuon;
        private System.Windows.Forms.TabPage tabpageTra;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView DataGrid_TimKiem;
        private System.Windows.Forms.GroupBox grpTK;
        private System.Windows.Forms.ComboBox cboTKngonngu;
        private System.Windows.Forms.ComboBox cboTKtheloai;
        private System.Windows.Forms.TextBox txtTKnxb;
        private System.Windows.Forms.TextBox txtTKtacgia;
        private System.Windows.Forms.TextBox txtTKsach;
        private System.Windows.Forms.CheckBox chkTKngonngu;
        private System.Windows.Forms.CheckBox chkTKnxb;
        private System.Windows.Forms.CheckBox chkTKtheloai;
        private System.Windows.Forms.CheckBox chkTKtacgia;
        private System.Windows.Forms.CheckBox chkTKsach;
    }
}