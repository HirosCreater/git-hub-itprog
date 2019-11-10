using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MuseumObserverLogic.Entity
{
    class Crutch
    {
        private System.Data.SqlClient.SqlDataAdapter dataAdapter;
        public bool Save(DataSetMuseum dataSet, Connection conn, Transaction tr)
        {
            dataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            dataAdapter.InsertCommand = new System.Data.SqlClient.SqlCommand(string.Format("INSERT INTO Crutch (ID, [From], InstanceID) VALUES (@ID, @[From], @InstanceID);"), conn.getConnection(), tr.getTransaction());
            dataAdapter.InsertCommand.Parameters.Add("@ID", SqlDbType.Int, 11, "ID");
            dataAdapter.InsertCommand.Parameters.Add("@[From]", SqlDbType.NChar, 50, "[From]");
            dataAdapter.InsertCommand.Parameters.Add("@InstanceID", SqlDbType.Int, 11, "InstanceID");

            dataAdapter.UpdateCommand = new System.Data.SqlClient.SqlCommand(string.Format("UPDATE Crutch SET [From] = @[From], InstanceID = @InstanceID WHERE ID = @ID;"), conn.getConnection(), tr.getTransaction());
            dataAdapter.InsertCommand.Parameters.Add("@ID", SqlDbType.Int, 11, "ID");
            dataAdapter.InsertCommand.Parameters.Add("@[From]", SqlDbType.NChar, 50, "[From]");
            dataAdapter.InsertCommand.Parameters.Add("@InstanceID", SqlDbType.Int, 11, "InstanceID");

            dataAdapter.DeleteCommand = new System.Data.SqlClient.SqlCommand(string.Format("DELETE FROM Crutch WHERE ID = @ID;"), conn.getConnection(), tr.getTransaction());
            dataAdapter.InsertCommand.Parameters.Add("@ID", SqlDbType.Int, 11, "ID");
            dataAdapter.InsertCommand.Parameters.Add("@[From]", SqlDbType.NChar, 50, "[From]");
            dataAdapter.InsertCommand.Parameters.Add("@InstanceID", SqlDbType.Int, 11, "InstanceID");

            var countUpdate = dataAdapter.Update(dataSet, dataSet.Crutch.TableName);
            return (countUpdate > 0) ? true : false;
        }

        public void Read(DataSetMuseum dataSet, Connection conn, Transaction tr)
        {
            dataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            dataAdapter.SelectCommand = new System.Data.SqlClient.SqlCommand("SELECT * FROM Crutch", conn.getConnection(), tr.getTransaction());
            dataAdapter.Fill(dataSet, "Crutch");
        }
    }
}
