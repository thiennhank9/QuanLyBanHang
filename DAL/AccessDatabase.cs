using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccessDatabase
    {   private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\Databases\QUANLYBANHANG.mdf"";Integrated Security=True";
        protected SqlConnection _connection = new SqlConnection(connectionString);

        public SqlConnection Connection
        {
            get { return _connection; }
        }

        protected void OpenConnection()
        {
            Connection.Open();
        }

        protected void CloseConnection()
        {
            Connection.Close();
        }
    }
}
