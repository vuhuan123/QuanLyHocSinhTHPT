using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.AccessControl;
using System.Data.SqlClient;

namespace Quan_Ly_Hoc_Sinh_THPT
{


     class Modify
    {
        public Modify()
        {

        }
        SqlCommand sqlCommand;
        SqlDataReader sqlReader;
        public List<TaiKhoan> TaiKhoans (string query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open ();
                sqlCommand = new SqlCommand(query,connection);
                sqlReader = sqlCommand.ExecuteReader ();
                while (sqlReader.Read())
                {
                    taiKhoans.Add (new TaiKhoan(sqlReader.GetString(0),sqlReader.GetString(1)));

                }

                connection.Close ();

            }

            return taiKhoans;   

        }

        public void Command(string query) {

            using (SqlConnection sqlConnection = Connection.GetConnection())
            {

                sqlConnection.Open ();
                sqlCommand = new SqlCommand (query,sqlConnection);
                sqlCommand.ExecuteNonQuery ();

                sqlConnection.Close();
            }
        
        }


     }
}
