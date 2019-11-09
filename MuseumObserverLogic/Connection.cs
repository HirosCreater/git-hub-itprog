using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseumObserverLogic
{
    class Connection
    {
        private System.Data.SqlClient.SqlConnection Conn;

        public Connection()
        {
            var connectionString = @"Data Source = (local)\SQLEXPRESS;Initial Catalog=MuseumDB;Integrated Security=True";
            Conn = new SqlConnection(connectionString);
        }
        public void Open() { Conn.Open(); }
        public void Close() { Conn.Close(); }
        public Transaction BeginTransaction()
        {
            System.Data.SqlClient.SqlTransaction tr = Conn.BeginTransaction();
            Transaction result = new Transaction(tr);
            return result;
        }
        public System.Data.SqlClient.SqlConnection getConnection() { return Conn; }
    }
}
