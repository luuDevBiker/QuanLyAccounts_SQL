using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyAccounts_SQL.IServices
{
    interface IConnetionSQL
    {
        // trả về một dataset có table mới được fill vào thỏa mãn câu lệnh select có tên = nameTable
        DataSet resultsDataSet(string strConn, string strSelect, string nameTable);
        //trả về dataset hiện tại 
        DataSet resultsDataset();
        // lưu các thay đổi trên dataset vào SQL 
        void seveData(string nameTable);
    }
}
