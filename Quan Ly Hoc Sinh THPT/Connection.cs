using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Hoc_Sinh_THPT
{
    internal class Connection
    {
        private static string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\WorkSpace\C#\Quan Ly Hoc Sinh THPT\Quan Ly Hoc Sinh THPT\Database1.mdf"";Integrated Security=True";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connection);
        }
    
    }
}
