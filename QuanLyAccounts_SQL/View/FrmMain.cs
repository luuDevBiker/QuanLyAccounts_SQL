using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyAccounts_SQL.IServices;
using QuanLyAccounts_SQL.Services;

namespace QuanLyAccounts_SQL.View
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            loadYear();
            resetForm("AllAccounts");
        }

        #region  declare variable
        private IFormLoad _IFormLoad = new FormLoad();
        private string _strConnet = @"Data Source=LAPTOP-59GTB0PL\SQLEXPRESS;Initial Catalog=QuanLyAccounts;Persist Security Info=True;User ID=luudev;Password=1234";
        private IConnetionSQL _IConn = new ConnetionServices();
        private bool _status = false;// biến trạng thái lưu giữ trạng thái thay đổi của dữ liệu đã bị thay đổi = true / chưa bị thay đổi = false
        private int _idx;// vị trí của dòng đang được select 
        #endregion
        #region button menustrip
        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strSelect = "SELECT * FROM Account ";// đây là chuỗi select vào SQL lấy ra tất cả các bản ghi trong table Account
            // kiểm tra xem table tên là AllAccounts đã tồn tại trong dataset chưa nếu chưa thì dùng resultsDataset(có 3 tham số) để fill vào
            if (!_IConn.resultsDataset().Tables.Contains("AllAccounts"))
            {
                _IConn.resultsDataSet(_strConnet, strSelect, "AllAccounts");
            }
            //đổ table có tên là AllAcounts vào DataGridView
            dgvAccount.DataSource = _IConn.resultsDataset().Tables["AllAccounts"];
        }
        // menu strip exit đóng chương trình
        private void msiExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void msiSaveData_Click(object sender, EventArgs e)
        {
            _IConn.seveData("AllAccounts");
        }
        #endregion
        #region Form Validate method
        // hàm tìm kiếm account 
        private bool tus = false;
        void findAccounts()
        {
            // kiểm tra xem dataset đã được mở chưa nếu chưa mở thì sẽ không thể thêm được
            if (_IConn.resultsDataset().Tables.Contains("AccountsMember"))
            {
                _IConn.resultsDataset().Tables.Remove("AccountsMember");
            }
            _IConn.resultsDataSet(_strConnet,
                "SELECT  *  FROM dbo.Account WHERE User_Acc LIKE '%" + txtTimKiem.Text + "%'", "AccountsMember");
            dgvAccount.DataSource = _IConn.resultsDataset().Tables["AccountsMember"];

        }
        // validate thong tin tài khoản
        bool checkAcc()
        {
            bool status = false;
            //
            // check text
            //
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
        //reset lại giá trị mặc định cho form xóa hết tất cả các dữ liệu nhập vào
        void resetForm(string namTable)// nameTable được dùng để xác định table đang được chỉnh sửa trong trường hợp có nhiều table
        {
            txtTK.Text = default;
            txtMK.Text = default;
            txtMK2.Text = default;
            cboYear.SelectedIndex = 25;
            rdOff.Checked = rdOn.Checked = false;
            rdSexNam.Checked = rdSexNu.Checked = false;
            btnSua.Enabled = btnXoa.Enabled = false;
            dgvAccount.DataSource = default;
            dgvAccount.DataSource = _IConn.resultsDataset().Tables[namTable];
        }
        // lấy giá trị của account ở datagridview đổ lên các textbox
        private void dgvAccount_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _idx = e.RowIndex;// gán giá trị vị trí dòng đang được chọn
            // bật chức năng click của 2 button sửa xóa
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            // đổ giá trị từ dòng đucowj chọn lên các ô textbox
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAccount.Rows[e.RowIndex];
                txtTK.Text = row.Cells[1].Value.ToString();
                txtMK.Text = txtMK2.Text = row.Cells[2].Value.ToString();
                if (Convert.ToBoolean(row.Cells[3].Value.ToString()))
                {
                    rdSexNam.Checked = true;
                }
                else
                {
                    rdSexNu.Checked = true;
                }

                cboYear.Text = row.Cells[4].Value.ToString();
                if (Convert.ToBoolean(row.Cells[5].Value.ToString()))
                {
                    rdOn.Checked = true;
                }
                else
                {
                    rdOff.Checked = true;
                }
            }
        }
        // sự kiện đóng form
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult results;
            // kiểm tra xem dữ liệu đã bị thay đổi hay chưa nếu thay đổi rồi thì hỏi xem trước khi thoát có muốn lưu không
            if (_status)
            {
                results = MessageBox.Show("lưu file và thoát chương trình ? ", "Cảnh Báo",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (results == DialogResult.Yes)
                {
                    _IConn.seveData("AllAccounts");
                    Environment.Exit(1);
                }
                else if (results == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                Environment.Exit(1);
            }
        }
        // đổ danh sách năm sinh
        void loadYear()
        {
            _IFormLoad.resultsListYear().ForEach(x => cboYear.Items.Add(x));
            cboYear.SelectedIndex = 25;
        }
        #endregion
        #region button events
        // button [clear] xóa reset lại form 
        private void btnClear_Click(object sender, EventArgs e)
        {
            resetForm("AllAccounts");
        }
        // checkbox [show Pass] hiện thị hoặc ẩn mật khẩu
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
        // lọc tất cả các tài khoản có tên tài khoản gần giống text nhập vào textbox
        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            findAccounts();
        }

        // button thêm click event
        private void btnThem_Click(object sender, EventArgs e)
        {
            // kiểm tra xem dataset đã được mở chưa nếu chưa mở thì sẽ không thể thêm được
            if (!_IConn.resultsDataset().Tables.Contains("AllAccounts"))
            {
                // gọi đến menu strip loaddataaccount để lấy danh sách tài khoản
                accountToolStripMenuItem_Click(null, null);
            }
            // validate form
            if (checkAcc() == false)
            {
                return;
            }
            // sau khi đã validate form xác định table muốn thêm dữ liệu
            var tableAccounts = _IConn.resultsDataset().Tables["AllAccounts"];
            // tạo ra một hàng mới và gán giá trị cho hàng mới 
            var newRow = tableAccounts.NewRow();
            newRow[1] = txtTK.Text;
            newRow[2] = txtMK.Text;
            newRow[3] = rdSexNam.Checked == true ? 1 : 0;
            newRow[4] = Convert.ToInt32(cboYear.Text);
            newRow[5] = rdOn.Checked == true ? 1 : 0;
            // thêm hàng mới vào datagridview 
            _IConn.resultsDataset().Tables["AllAccounts"].Rows.Add(newRow);
            // reset lại form
            resetForm("AllAccounts");
            // gắn lại biến trạng thái
            _status = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // xác định hàng đang được chọn thông qua _idx
            var rowUpdate = _IConn.resultsDataset().Tables["AllAccounts"].Rows[_idx];
            // đánh dấu bắt đầu chỉnh sửa thông tin của hàng đang chọn
            rowUpdate.BeginEdit();
            rowUpdate[2] = txtMK.Text;
            rowUpdate[3] = rdSexNam.Checked == true ? 1 : 0;
            rowUpdate[4] = Convert.ToInt32(cboYear.Text);
            rowUpdate[5] = rdOn.Checked == true ? 1 : 0;
            // đánh dấu kết thúc việc thay đổi
            rowUpdate.EndEdit();
            // reset lại form
            resetForm("AllAccounts");
            // gắn lại biến trạng thái
            _status = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // lấy ra dòng đang được select trên datagridview thông qua vị trí = _idx 
            var rowDelete = _IConn.resultsDataset().Tables["AllAccounts"].Rows[_idx];
            // xóa dòng đang chọn ra khỏi dataset = hàm delete()
            rowDelete.Delete();
            // reset lại form 
            resetForm("AllAccounts");
            // gán lại gia strij cho biến trạng thái
            _status = true;
        }

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

        #endregion

    }
}
