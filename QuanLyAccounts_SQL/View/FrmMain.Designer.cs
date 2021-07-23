
using System;

namespace QuanLyAccounts_SQL.View
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiLoadData = new System.Windows.Forms.ToolStripMenuItem();
            this.msiAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.typeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiSaveData = new System.Windows.Forms.ToolStripMenuItem();
            this.msiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grbTK = new System.Windows.Forms.GroupBox();
            this.cbShowPass = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdOff = new System.Windows.Forms.RadioButton();
            this.rdOn = new System.Windows.Forms.RadioButton();
            this.btnMKtusinh = new System.Windows.Forms.Button();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.lblNamSinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.rdSexNu = new System.Windows.Forms.RadioButton();
            this.rdSexNam = new System.Windows.Forms.RadioButton();
            this.lblMK2 = new System.Windows.Forms.Label();
            this.lblMK = new System.Windows.Forms.Label();
            this.txtMK2 = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.bblTK = new System.Windows.Forms.Label();
            this.grbCN = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbContainMenu = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.pnTimkiem = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grbTK.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbCN.SuspendLayout();
            this.grbContainMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.pnTimkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(999, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiLoadData,
            this.msiSaveData,
            this.msiExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // msiLoadData
            // 
            this.msiLoadData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiAccount,
            this.typeAccountToolStripMenuItem});
            this.msiLoadData.Name = "msiLoadData";
            this.msiLoadData.Size = new System.Drawing.Size(233, 34);
            this.msiLoadData.Text = "load data table";
            // 
            // msiAccount
            // 
            this.msiAccount.Name = "msiAccount";
            this.msiAccount.Size = new System.Drawing.Size(218, 34);
            this.msiAccount.Text = "Account";
            this.msiAccount.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // typeAccountToolStripMenuItem
            // 
            this.typeAccountToolStripMenuItem.Name = "typeAccountToolStripMenuItem";
            this.typeAccountToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.typeAccountToolStripMenuItem.Text = "Type account";
            // 
            // msiSaveData
            // 
            this.msiSaveData.Name = "msiSaveData";
            this.msiSaveData.Size = new System.Drawing.Size(233, 34);
            this.msiSaveData.Text = "save data edit";
            this.msiSaveData.Click += new System.EventHandler(this.msiSaveData_Click);
            // 
            // msiExit
            // 
            this.msiExit.Name = "msiExit";
            this.msiExit.Size = new System.Drawing.Size(233, 34);
            this.msiExit.Text = "exit";
            this.msiExit.Click += new System.EventHandler(this.msiExit_Click);
            // 
            // grbTK
            // 
            this.grbTK.BackColor = System.Drawing.SystemColors.Info;
            this.grbTK.Controls.Add(this.cbShowPass);
            this.grbTK.Controls.Add(this.groupBox2);
            this.grbTK.Controls.Add(this.btnMKtusinh);
            this.grbTK.Controls.Add(this.cboYear);
            this.grbTK.Controls.Add(this.lblNamSinh);
            this.grbTK.Controls.Add(this.lblGioiTinh);
            this.grbTK.Controls.Add(this.rdSexNu);
            this.grbTK.Controls.Add(this.rdSexNam);
            this.grbTK.Controls.Add(this.lblMK2);
            this.grbTK.Controls.Add(this.lblMK);
            this.grbTK.Controls.Add(this.txtMK2);
            this.grbTK.Controls.Add(this.txtMK);
            this.grbTK.Controls.Add(this.txtTK);
            this.grbTK.Controls.Add(this.bblTK);
            this.grbTK.Location = new System.Drawing.Point(24, 25);
            this.grbTK.Name = "grbTK";
            this.grbTK.Size = new System.Drawing.Size(339, 353);
            this.grbTK.TabIndex = 5;
            this.grbTK.TabStop = false;
            this.grbTK.Text = "Tài Khoản";
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.Location = new System.Drawing.Point(185, 303);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(148, 24);
            this.cbShowPass.TabIndex = 29;
            this.cbShowPass.Text = "Show Password";
            this.cbShowPass.UseVisualStyleBackColor = true;
            this.cbShowPass.CheckedChanged += new System.EventHandler(this.cbShowPass_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdOff);
            this.groupBox2.Controls.Add(this.rdOn);
            this.groupBox2.Location = new System.Drawing.Point(7, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 63);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trạng Thái";
            // 
            // rdOff
            // 
            this.rdOff.AutoSize = true;
            this.rdOff.Location = new System.Drawing.Point(235, 29);
            this.rdOff.Name = "rdOff";
            this.rdOff.Size = new System.Drawing.Size(56, 24);
            this.rdOff.TabIndex = 28;
            this.rdOff.TabStop = true;
            this.rdOff.Text = "Off";
            this.rdOff.UseVisualStyleBackColor = true;
            // 
            // rdOn
            // 
            this.rdOn.AutoSize = true;
            this.rdOn.Location = new System.Drawing.Point(117, 29);
            this.rdOn.Name = "rdOn";
            this.rdOn.Size = new System.Drawing.Size(55, 24);
            this.rdOn.TabIndex = 27;
            this.rdOn.TabStop = true;
            this.rdOn.Text = "On";
            this.rdOn.UseVisualStyleBackColor = true;
            // 
            // btnMKtusinh
            // 
            this.btnMKtusinh.Location = new System.Drawing.Point(17, 295);
            this.btnMKtusinh.Name = "btnMKtusinh";
            this.btnMKtusinh.Size = new System.Drawing.Size(154, 38);
            this.btnMKtusinh.TabIndex = 20;
            this.btnMKtusinh.Text = "mật khẩu tự sinh";
            this.btnMKtusinh.UseVisualStyleBackColor = true;
            this.btnMKtusinh.Click += new System.EventHandler(this.btnMKtusinh_Click);
            // 
            // cboYear
            // 
            this.cboYear.AllowDrop = true;
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(124, 183);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(173, 28);
            this.cboYear.TabIndex = 16;
            // 
            // lblNamSinh
            // 
            this.lblNamSinh.AutoSize = true;
            this.lblNamSinh.Location = new System.Drawing.Point(13, 183);
            this.lblNamSinh.Name = "lblNamSinh";
            this.lblNamSinh.Size = new System.Drawing.Size(78, 20);
            this.lblNamSinh.TabIndex = 19;
            this.lblNamSinh.Text = "Năm Sinh";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(13, 148);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(71, 20);
            this.lblGioiTinh.TabIndex = 17;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // rdSexNu
            // 
            this.rdSexNu.AutoSize = true;
            this.rdSexNu.Location = new System.Drawing.Point(243, 144);
            this.rdSexNu.Name = "rdSexNu";
            this.rdSexNu.Size = new System.Drawing.Size(54, 24);
            this.rdSexNu.TabIndex = 15;
            this.rdSexNu.TabStop = true;
            this.rdSexNu.Text = "Nữ";
            this.rdSexNu.UseVisualStyleBackColor = true;
            // 
            // rdSexNam
            // 
            this.rdSexNam.AutoSize = true;
            this.rdSexNam.Location = new System.Drawing.Point(124, 144);
            this.rdSexNam.Name = "rdSexNam";
            this.rdSexNam.Size = new System.Drawing.Size(67, 24);
            this.rdSexNam.TabIndex = 14;
            this.rdSexNam.TabStop = true;
            this.rdSexNam.Text = "Nam";
            this.rdSexNam.UseVisualStyleBackColor = true;
            // 
            // lblMK2
            // 
            this.lblMK2.AutoSize = true;
            this.lblMK2.Location = new System.Drawing.Point(13, 109);
            this.lblMK2.Name = "lblMK2";
            this.lblMK2.Size = new System.Drawing.Size(104, 20);
            this.lblMK2.TabIndex = 11;
            this.lblMK2.Text = "Xác nhận MK";
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Location = new System.Drawing.Point(13, 71);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(77, 20);
            this.lblMK.TabIndex = 12;
            this.lblMK.Text = "Mật Khẩu";
            // 
            // txtMK2
            // 
            this.txtMK2.Location = new System.Drawing.Point(124, 106);
            this.txtMK2.Name = "txtMK2";
            this.txtMK2.PasswordChar = '*';
            this.txtMK2.Size = new System.Drawing.Size(173, 26);
            this.txtMK2.TabIndex = 13;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(124, 68);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(173, 26);
            this.txtMK.TabIndex = 10;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(124, 30);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(173, 26);
            this.txtTK.TabIndex = 8;
            // 
            // bblTK
            // 
            this.bblTK.AutoSize = true;
            this.bblTK.Location = new System.Drawing.Point(9, 36);
            this.bblTK.Name = "bblTK";
            this.bblTK.Size = new System.Drawing.Size(80, 20);
            this.bblTK.TabIndex = 9;
            this.bblTK.Text = "Tài Khoản";
            // 
            // grbCN
            // 
            this.grbCN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbCN.Controls.Add(this.btnClear);
            this.grbCN.Controls.Add(this.btnXoa);
            this.grbCN.Controls.Add(this.btnSua);
            this.grbCN.Controls.Add(this.btnThem);
            this.grbCN.Location = new System.Drawing.Point(383, 25);
            this.grbCN.Name = "grbCN";
            this.grbCN.Size = new System.Drawing.Size(156, 353);
            this.grbCN.TabIndex = 22;
            this.grbCN.TabStop = false;
            this.grbCN.Text = "Chức Năng";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(41, 289);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 40);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(41, 212);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 40);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(41, 138);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 40);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(41, 61);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grbContainMenu
            // 
            this.grbContainMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grbContainMenu.Controls.Add(this.grbTK);
            this.grbContainMenu.Controls.Add(this.grbCN);
            this.grbContainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbContainMenu.Location = new System.Drawing.Point(0, 33);
            this.grbContainMenu.Name = "grbContainMenu";
            this.grbContainMenu.Size = new System.Drawing.Size(999, 393);
            this.grbContainMenu.TabIndex = 1;
            this.grbContainMenu.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.dgvAccount);
            this.groupBox1.Controls.Add(this.pnTimkiem);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 426);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(999, 295);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "data";
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccount.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvAccount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvAccount.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvAccount.Location = new System.Drawing.Point(3, 91);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.RowHeadersWidth = 62;
            this.dgvAccount.RowTemplate.Height = 28;
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(993, 201);
            this.dgvAccount.TabIndex = 1;
            this.dgvAccount.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAccount_CellMouseClick);
            // 
            // pnTimkiem
            // 
            this.pnTimkiem.Controls.Add(this.txtTimKiem);
            this.pnTimkiem.Controls.Add(this.lblTimKiem);
            this.pnTimkiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTimkiem.Location = new System.Drawing.Point(3, 22);
            this.pnTimkiem.Name = "pnTimkiem";
            this.pnTimkiem.Size = new System.Drawing.Size(993, 69);
            this.pnTimkiem.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(116, 24);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(214, 26);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyUp);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(25, 28);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(77, 20);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = " Tìm Kiếm";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 721);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbContainMenu);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbTK.ResumeLayout(false);
            this.grbTK.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbCN.ResumeLayout(false);
            this.grbContainMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.pnTimkiem.ResumeLayout(false);
            this.pnTimkiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msiLoadData;
        private System.Windows.Forms.ToolStripMenuItem msiSaveData;
        private System.Windows.Forms.ToolStripMenuItem msiExit;
        private System.Windows.Forms.GroupBox grbTK;
        private System.Windows.Forms.GroupBox grbCN;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdOff;
        private System.Windows.Forms.RadioButton rdOn;
        private System.Windows.Forms.Button btnMKtusinh;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label lblNamSinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton rdSexNu;
        private System.Windows.Forms.RadioButton rdSexNam;
        private System.Windows.Forms.Label lblMK2;
        private System.Windows.Forms.Label lblMK;
        private System.Windows.Forms.TextBox txtMK2;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label bblTK;
        private System.Windows.Forms.GroupBox grbContainMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Panel pnTimkiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.CheckBox cbShowPass;
        private System.Windows.Forms.ToolStripMenuItem msiAccount;
        private System.Windows.Forms.ToolStripMenuItem typeAccountToolStripMenuItem;
    }
}