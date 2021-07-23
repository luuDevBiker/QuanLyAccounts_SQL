using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyAccounts_SQL.IServices;

namespace QuanLyAccounts_SQL.Services
{
    public class FormLoad : IFormLoad
    {
        public List<int> resultsListYear()
        {
            List<int> listYear = new List<int>();
            for (int i = 1950; i < DateTime.Now.Year; i++)
            {
                listYear.Add(i);
            }

            return listYear;
        }
    }
}
