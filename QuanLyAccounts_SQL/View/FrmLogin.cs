using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyAccounts_SQL.IServices;
using QuanLyAccounts_SQL.Services;
using QuanLyAccounts_SQL.View;

namespace QuanLyAccounts_SQL
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private IConnetionSQL _IConnSQL = new ConnetionServices();
        private string _strConn = @"Data Source=LAPTOP-59GTB0PL\SQLEXPRESS;"+
                                   "Initial Catalog=QuanLyAccounts;"+
                                   "Persist Security Info=True;"+
                                   "User ID=luudev;"+
                                   "Password=1234";
        #region Form events

        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string strSelect = "SELECT * " +
                               "FROM Account " +
                               "WHERE User_Acc = '"+txtAcc.Text+"' AND Pass_Acc = '"+txtPass.Text+"'";
            var tableAccLogin = _IConnSQL.resultsDataSet(_strConn, strSelect, "AccLogin").Tables["AccLogin"];
            if (tableAccLogin.Rows.Count > 0)
            {
                if (Convert.ToBoolean(tableAccLogin.Rows[0].ItemArray[5].ToString()))
                {
                    FrmMain frmMain = new FrmMain();
                    frmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản của bạn đang bị khóa vui lòng liên hệ Admin để kick hoạy tài khoản");
                }
            }
            else
            {
                MessageBox.Show("Tài khoản mật khẩu không đúng . \n Vui lòng kiểm tra lại .");
            }
        }
        private void llbDangKy_Click(object sender, EventArgs e)
        {
            FrmSignUp frmSignUp = new FrmSignUp();
            frmSignUp.Show();
            frmSignUp.senderConnection(_strConn);
            this.Hide();
        }
        private void llbQuenMK_Click(object sender, EventArgs e)
        {
            FrmBackkPasss frmBackkPasss = new FrmBackkPasss();
            frmBackkPasss.senderStringConnect(_strConn);
            frmBackkPasss.Show();
            this.Hide();
        }
        #endregion
        #region Form method

        #endregion
        #region Form Load method

        void resultsStringConn(string strConn)
        {
            _strConn = strConn;
        }

        #endregion

    }
}
