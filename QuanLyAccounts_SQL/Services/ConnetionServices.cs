using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyAccounts_SQL.IServices;

namespace QuanLyAccounts_SQL.Services
{
    class ConnetionServices : IConnetionSQL
    {
        private SqlConnection _cnn = null;
        private SqlCommand _cmd = null;
        private SqlDataAdapter _adapter = null;
        private DataSet _data = new DataSet();


        public DataSet resultsDataSet(string strConn, string strSelect, string nameTable)
        {
            try
            {
                // sqldataadapter trả về một đối tượng được select từ server bằng chỗi connection và selection string
                _adapter = new SqlDataAdapter(strSelect, strConn);
                // gán các sự kiện delete update cho adapter 
                SqlCommandBuilder cmbdBuilder = new SqlCommandBuilder(_adapter);
                // mỗi lần fill dataadapter sẽ thêm 1 table vào dataset
                // table được select từ Server lên phía client
                _adapter.Fill(_data, nameTable);
                return _data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        // trả về dataset hiện tại
        public DataSet resultsDataset()
        {
            return _data;
        }
        // lưu những thay đổi của dataset về phía server thông qua SqlCommanbuilder 
        public void seveData(string nameTable)// nametable chính là table được cập nhật . table này được tạo ra vào quản lý bởi dataadapter thông qua dataset
        {
            try
            {
                _adapter.Update(_data.Tables[nameTable]);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi Lưu Dữ Liệu","Thông báo");
            }
        }

    }
}
