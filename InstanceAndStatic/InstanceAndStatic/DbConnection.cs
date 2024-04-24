using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceAndStatic
{
    public class DbConnection
    {
        public static string ConnectionString = "server;Others options";

        private ConnectionState _connectionState;
        private string _userName;
        private string _password;

        public DbConnection(string userName, string password)
        {
            this._userName = userName;
            this._password = password;
            this._connectionState = ConnectionState.Undefined;
        }

        public void Open()
        {
            _connectionState = ConnectionState.Open;
        }

        public void Close()
        {
            _connectionState = ConnectionState.Closed;
        }

        public int ExecuteQuery(string sql)
        {
            switch (_connectionState)
            {
                case ConnectionState.Open:
                    // do the query
                    return 0;

                default:
                    throw new Exception("Connection state doesn't allow query execution");
            }  
        }
    }


    public static class QueryExecutionEngine
    {
        public static int ExecuteQuery(string username, string password, string sql)
        {
            DbConnection connection = new DbConnection(username, password);
            connection.Open();
            int result = connection.ExecuteQuery(sql);
            connection.Close();

            return result;
        }
    }

}
