
namespace QuanLyAccounts_SQL.View
{
    partial class FrmBackkPasss
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
            this.grbDatLaiMatKhau = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtMK2 = new System.Windows.Forms.TextBox();
            this.txtMK1 = new System.Windows.Forms.TextBox();
            this.lblAcceptMK = new System.Windows.Forms.Label();
            this.txtTkReset = new System.Windows.Forms.TextBox();
            this.lblMK = new System.Windows.Forms.Label();
            this.lblTKbackPass = new System.Windows.Forms.Label();
            this.grbTim = new System.Windows.Forms.GroupBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTKBackPack = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblNamSinh = new System.Windows.Forms.Label();
            this.lblTK = new System.Windows.Forms.Label();
            this.grbDatLaiMatKhau.SuspendLayout();
            this.grbTim.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatLaiMatKhau
            // 
            this.grbDatLaiMatKhau.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.grbDatLaiMatKhau.Controls.Add(this.grbTim);
            this.grbDatLaiMatKhau.Controls.Add(this.btnSua);
            this.grbDatLaiMatKhau.Controls.Add(this.txtMK2);
            this.grbDatLaiMatKhau.Controls.Add(this.txtMK1);
            this.grbDatLaiMatKhau.Controls.Add(this.lblAcceptMK);
            this.grbDatLaiMatKhau.Controls.Add(this.txtTkReset);
            this.grbDatLaiMatKhau.Controls.Add(this.lblMK);
            this.grbDatLaiMatKhau.Controls.Add(this.lblTKbackPass);
            this.grbDatLaiMatKhau.Location = new System.Drawing.Point(-1, -1);
            this.grbDatLaiMatKhau.Name = "grbDatLaiMatKhau";
            this.grbDatLaiMatKhau.Size = new System.Drawing.Size(398, 265);
            this.grbDatLaiMatKhau.TabIndex = 101;
            this.grbDatLaiMatKhau.TabStop = false;
            this.grbDatLaiMatKhau.Text = "Đặt lại mật khẩu";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(274, 182);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 32);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtMK2
            // 
            this.txtMK2.Location = new System.Drawing.Point(135, 126);
            this.txtMK2.Name = "txtMK2";
            this.txtMK2.Size = new System.Drawing.Size(214, 26);
            this.txtMK2.TabIndex = 3;
            // 
            // txtMK1
            // 
            this.txtMK1.Location = new System.Drawing.Point(135, 81);
            this.txtMK1.Name = "txtMK1";
            this.txtMK1.Size = new System.Drawing.Size(214, 26);
            this.txtMK1.TabIndex = 2;
            // 
            // lblAcceptMK
            // 
            this.lblAcceptMK.AutoSize = true;
            this.lblAcceptMK.Location = new System.Drawing.Point(24, 129);
            this.lblAcceptMK.Name = "lblAcceptMK";
            this.lblAcceptMK.Size = new System.Drawing.Size(109, 20);
            this.lblAcceptMK.TabIndex = 1;
            this.lblAcceptMK.Text = "N.lại Mật khẩu";
            // 
            // txtTkReset
            // 
            this.txtTkReset.Location = new System.Drawing.Point(135, 37);
            this.txtTkReset.Name = "txtTkReset";
            this.txtTkReset.Size = new System.Drawing.Size(214, 26);
            this.txtTkReset.TabIndex = 1;
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Location = new System.Drawing.Point(24, 84);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(75, 20);
            this.lblMK.TabIndex = 1;
            this.lblMK.Text = "Mật khẩu";
            // 
            // lblTKbackPass
            // 
            this.lblTKbackPass.AutoSize = true;
            this.lblTKbackPass.Location = new System.Drawing.Point(24, 40);
            this.lblTKbackPass.Name = "lblTKbackPass";
            this.lblTKbackPass.Size = new System.Drawing.Size(105, 20);
            this.lblTKbackPass.TabIndex = 1;
            this.lblTKbackPass.Text = "Tên tài khoản";
            // 
            // grbTim
            // 
            this.grbTim.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grbTim.Controls.Add(this.cbSex);
            this.grbTim.Controls.Add(this.cbYear);
            this.grbTim.Controls.Add(this.btnTim);
            this.grbTim.Controls.Add(this.txtTKBackPack);
            this.grbTim.Controls.Add(this.lblSex);
            this.grbTim.Controls.Add(this.lblNamSinh);
            this.grbTim.Controls.Add(this.lblTK);
            this.grbTim.Location = new System.Drawing.Point(0, 0);
            this.grbTim.Name = "grbTim";
            this.grbTim.Size = new System.Drawing.Size(398, 265);
            this.grbTim.TabIndex = 0;
            this.grbTim.TabStop = false;
            this.grbTim.Text = "Tìm tài khoản";
            // 
            // cbSex
            // 
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbSex.Location = new System.Drawing.Point(135, 126);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(214, 28);
            this.cbSex.TabIndex = 3;
            // 
            // cbYear
            // 
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(135, 81);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(214, 28);
            this.cbYear.TabIndex = 2;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(274, 182);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 32);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTKBackPack
            // 
            this.txtTKBackPack.Location = new System.Drawing.Point(135, 37);
            this.txtTKBackPack.Name = "txtTKBackPack";
            this.txtTKBackPack.Size = new System.Drawing.Size(214, 26);
            this.txtTKBackPack.TabIndex = 1;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(24, 130);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(67, 20);
            this.lblSex.TabIndex = 100;
            this.lblSex.Text = "Giới tính";
            // 
            // lblNamSinh
            // 
            this.lblNamSinh.AutoSize = true;
            this.lblNamSinh.Location = new System.Drawing.Point(24, 84);
            this.lblNamSinh.Name = "lblNamSinh";
            this.lblNamSinh.Size = new System.Drawing.Size(75, 20);
            this.lblNamSinh.TabIndex = 100;
            this.lblNamSinh.Text = "Năm sinh";
            // 
            // lblTK
            // 
            this.lblTK.AutoSize = true;
            this.lblTK.Location = new System.Drawing.Point(24, 40);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(105, 20);
            this.lblTK.TabIndex = 100;
            this.lblTK.Text = "Tên tài khoản";
            // 
            // FrmBackkPasss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(399, 263);
            this.Controls.Add(this.grbDatLaiMatKhau);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBackkPasss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBackkPasss";
            this.grbDatLaiMatKhau.ResumeLayout(false);
            this.grbDatLaiMatKhau.PerformLayout();
            this.grbTim.ResumeLayout(false);
            this.grbTim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatLaiMatKhau;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtMK2;
        private System.Windows.Forms.TextBox txtMK1;
        private System.Windows.Forms.Label lblAcceptMK;
        private System.Windows.Forms.TextBox txtTkReset;
        private System.Windows.Forms.Label lblMK;
        private System.Windows.Forms.Label lblTKbackPass;
        private System.Windows.Forms.GroupBox grbTim;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTKBackPack;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblNamSinh;
        private System.Windows.Forms.Label lblTK;
    }
}