
namespace QuanLyAccounts_SQL
{
    partial class FrmLogin
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
            this.pbDangNhap = new System.Windows.Forms.GroupBox();
            this.llbDangKy = new System.Windows.Forms.LinkLabel();
            this.llbQuenMK = new System.Windows.Forms.LinkLabel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblMK = new System.Windows.Forms.Label();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.lblTK = new System.Windows.Forms.Label();
            this.pbDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbDangNhap
            // 
            this.pbDangNhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbDangNhap.Controls.Add(this.llbDangKy);
            this.pbDangNhap.Controls.Add(this.llbQuenMK);
            this.pbDangNhap.Controls.Add(this.btnDangNhap);
            this.pbDangNhap.Controls.Add(this.txtPass);
            this.pbDangNhap.Controls.Add(this.lblMK);
            this.pbDangNhap.Controls.Add(this.txtAcc);
            this.pbDangNhap.Controls.Add(this.lblTK);
            this.pbDangNhap.Location = new System.Drawing.Point(18, 15);
            this.pbDangNhap.Name = "pbDangNhap";
            this.pbDangNhap.Size = new System.Drawing.Size(354, 337);
            this.pbDangNhap.TabIndex = 1;
            this.pbDangNhap.TabStop = false;
            this.pbDangNhap.Text = "Đăng Nhập";
            // 
            // llbDangKy
            // 
            this.llbDangKy.AutoSize = true;
            this.llbDangKy.Location = new System.Drawing.Point(198, 224);
            this.llbDangKy.Name = "llbDangKy";
            this.llbDangKy.Size = new System.Drawing.Size(69, 20);
            this.llbDangKy.TabIndex = 4;
            this.llbDangKy.TabStop = true;
            this.llbDangKy.Text = "Đăng Ký";
            this.llbDangKy.Click += new System.EventHandler(this.llbDangKy_Click);
            // 
            // llbQuenMK
            // 
            this.llbQuenMK.AutoSize = true;
            this.llbQuenMK.Location = new System.Drawing.Point(198, 177);
            this.llbQuenMK.Name = "llbQuenMK";
            this.llbQuenMK.Size = new System.Drawing.Size(118, 20);
            this.llbQuenMK.TabIndex = 3;
            this.llbQuenMK.TabStop = true;
            this.llbQuenMK.Text = "Quên mật khẩu";
            this.llbQuenMK.Click += new System.EventHandler(this.llbQuenMK_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(202, 264);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(127, 32);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(139, 98);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(190, 26);
            this.txtPass.TabIndex = 1;
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Location = new System.Drawing.Point(22, 101);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(77, 20);
            this.lblMK.TabIndex = 0;
            this.lblMK.Text = "Mật Khẩu";
            // 
            // txtAcc
            // 
            this.txtAcc.Location = new System.Drawing.Point(139, 44);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Size = new System.Drawing.Size(190, 26);
            this.txtAcc.TabIndex = 0;
            // 
            // lblTK
            // 
            this.lblTK.AutoSize = true;
            this.lblTK.Location = new System.Drawing.Point(22, 47);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(80, 20);
            this.lblTK.TabIndex = 0;
            this.lblTK.Text = "Tài Khoản";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(388, 364);
            this.Controls.Add(this.pbDangNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDangNhap_FormClosing);
            this.pbDangNhap.ResumeLayout(false);
            this.pbDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pbDangNhap;
        private System.Windows.Forms.LinkLabel llbDangKy;
        private System.Windows.Forms.LinkLabel llbQuenMK;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblMK;
        private System.Windows.Forms.TextBox txtAcc;
        private System.Windows.Forms.Label lblTK;
    }
}