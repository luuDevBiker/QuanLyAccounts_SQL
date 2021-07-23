using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyAccounts_SQL.IServices;
using QuanLyAccounts_SQL.Services;

namespace QuanLyAccounts_SQL.View
{
    public partial class FrmBackkPasss : Form
    {
        public FrmBackkPasss()
        {
            InitializeComponent();
            loadYear();
            cbSex.SelectedIndex = 0;
        }

        private IConnetionSQL _IConn = new ConnetionServices();
        private IFormLoad _IForm = new FormLoad();
        private string _strConn;
        private DataTable _dtTable = new DataTable();
        #region Button Form method
        private void btnTim_Click(object sender, EventArgs e)
        {
            int sex = cbSex.Text == "Nam" ? 0 : 1;
            string strselect = "SELECT * FROM Account WHERE User_Acc = '" + txtTKBackPack.Text + "' AND YearOfBirth_Acc = " +
                               int.Parse(cbYear.Text) + " AND Sex_Acc = " + sex ;
            _dtTable = 
                _IConn.resultsDataSet(_strConn, strselect, "AccLosePass").Tables["AccLosePass"];
            if (_dtTable.Rows.Count==0)
            {
                MessageBox.Show("Không tìm thấy tài khoản - hãy kiểm tra lại thông tin.");
                return;
            }
            txtTkReset.Text = txtTKBackPack.Text;
            txtTkReset.ReadOnly = true;
            grbTim.Hide();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (validateForm() == false)
            {
                return;
            }
            _dtTable.Rows[0].BeginEdit();

            _dtTable.Rows[0]["ID_Acc"] = _dtTable.Rows[0].ItemArray[0].ToString();
            _dtTable.Rows[0]["User_Acc"] = _dtTable.Rows[0].ItemArray[1].ToString(); ;
            _dtTable.Rows[0]["Pass_Acc"] = txtMK1.Text;
            _dtTable.Rows[0]["Sex_Acc"] = _dtTable.Rows[0].ItemArray[3].ToString(); ;
            _dtTable.Rows[0]["YearOfBirth_Acc"] = _dtTable.Rows[0].ItemArray[4].ToString();
            _dtTable.Rows[0]["Status_Acc"] = _dtTable.Rows[0].ItemArray[5].ToString();
            _dtTable.Rows[0].EndEdit();

            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }
        #endregion

        #region Form Load Method
        public void loadYear()
        {
            _IForm.resultsListYear().ForEach(x => cbYear.Items.Add(x));
            cbYear.SelectedIndex = 20;
        }
        public void senderStringConnect(string strConn)
        {
            _strConn = strConn;
        }

        bool validateForm()
        {
            if (txtMK1.Text != txtMK2.Text)
            {
                MessageBox.Show("Mật khẩu không khớp vui lòng kiểm tra lại.", "Thông Báo");
                return false;
            }

            return true;
        }
        #endregion
    }
}
