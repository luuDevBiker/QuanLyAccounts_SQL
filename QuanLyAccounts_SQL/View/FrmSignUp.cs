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

namespace QuanLyAccounts_SQL.View
{
    public partial class FrmSignUp : Form
    {
        public FrmSignUp()
        {
            InitializeComponent();
            loadYear();
        }
        #region Declare valiable

        private IConnetionSQL _IConn = new ConnetionServices();
        private IFormLoad _IFormLoad = new FormLoad();
        private string _strConnet;
        #endregion
        #region  validate Form Load 
        // lấy đường dẫn connection 
        public void senderConnection(string conn)
        {
            _strConnet = conn;
        }
        // hiện thi mật khẩu 
        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txtMK.PasswordChar = txtMK2.PasswordChar = '\0';
            }
            else
            {
                txtMK.PasswordChar = txtMK2.PasswordChar = '*';
            }
        }
        // validate thong tin tài khoản
        bool checkAcc()
        {
            bool status = false;
            //
            // check text
            //
            // lấy danh sách tài khoản để kiểm tra tài khoản tồn tại chưa
            string strSelect = "SELECT * FROM Account ";// đây là chuỗi select vào SQL lấy ra tất cả các bản ghi trong table Account
            // kiểm tra xem table tên là AllAccounts đã tồn tại trong dataset chưa nếu chưa thì dùng resultsDataset(có 3 tham số) để fill vào
            if (!_IConn.resultsDataset().Tables.Contains("AllAccounts"))
            {
                _IConn.resultsDataSet(_strConnet, strSelect, "AllAccounts");
            }
            // xác định xem đã có tài khoản tồn tại trong server chưa nếu đã tồn tại thì câu lệnh truy vấn sẽ trả về tài khoản đó
            DataRow[] row = _IConn.resultsDataset().Tables["AllAccounts"].Select("User_Acc = '" + txtTK.Text + "'");
            // nếu độ dài mạng row lớn hơn 0 tức là đã có tài khoản tồn tại ==> xuất ra thông báo
            if (row.Length > 0)
            {
                MessageBox.Show("Tài khoản đã tồn tại.", "Thông báo.");
                status = true;
            }

            if (status == true)
            {
                return false;
            }
            // check length of Account and Password with a length greater than 6
            if (txtTK.Text.Length < 6 || txtMK.Text.Length < 6)
            {
                MessageBox.Show("Tài khoản phải lớn hơn 8 ký tự \n Mật khẩu phải lớn hơn 8 ký tự.");
                return false;
            }
            // check duplication of password with confilm password
            if (txtMK.Text != txtMK2.Text)
            {
                MessageBox.Show("Mật khẩu không khớp");
                return false;
            }
            // check status radio sex
            if (rdSexNam.Checked == false && rdSexNu.Checked == false)
            {
                MessageBox.Show("Chưa chọn giới tính .");
                return false;
            }
            return true;
        }
        // đổ danh sách năm sinh
        void loadYear()
        {
            _IFormLoad.resultsListYear().ForEach(x => cboYear.Items.Add(x));
            cboYear.SelectedIndex = 25;
        }
        #endregion
        // tạo mật khẩu tự sinh
        private void btnMKtusinh_Click(object sender, EventArgs e)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";//String char for random password

            var random = new Random();
            // set string password random none repeat have length equals 6
            var randomString = new string(Enumerable.Repeat(chars, 8)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            // set value for textbox
            txtMK.Text = randomString;
            txtMK2.Text = randomString;
        }
        // link lable click
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }
        // button đăng nhập
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (checkAcc() ==  false)// validate form 
            {
                return;
            }
            var tableAccounts = _IConn.resultsDataset().Tables["AllAccounts"];
            // tạo ra một hàng mới và gán giá trị cho hàng mới 
            var newRow = tableAccounts.NewRow();
            newRow[1] = txtTK.Text;
            newRow[2] = txtMK.Text;
            newRow[3] = rdSexNam.Checked == true ? 1 : 0;
            newRow[4] = Convert.ToInt32(cboYear.Text);
            newRow[5] = 1;
            // thêm hàng mới vào datagridview 
            _IConn.resultsDataset().Tables["AllAccounts"].Rows.Add(newRow);
            _IConn.seveData("AllAccounts");
            btnDangNhap_Click(null , null );
        }
    }
}
