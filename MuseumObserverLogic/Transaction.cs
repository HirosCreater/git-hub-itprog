using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseumObserverLogic
{
    class Transaction
    {
        private System.Data.SqlClient.SqlTransaction Tr;
        public Transaction(SqlTransaction t) { Tr = t; }
        public void Commit() { Tr.Commit(); }
        public void Rollback() { Tr.Rollback(); }
        public System.Data.SqlClient.SqlTransaction getTransaction() { return Tr; }
    }
}
