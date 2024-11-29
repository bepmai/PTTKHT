using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lop
{
    internal class DataConnection
    {
        private static string strCon = @"Data Source=LAPTOP-71K3QRQR\\SQLEXPRESS;Initial Catalog=lop;Integrated Security=True";
    
        public static SqlConnection getConnection()
        {
            return new SqlConnection(strCon);
        }
    }
}
