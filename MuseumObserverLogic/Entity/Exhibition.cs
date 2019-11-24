using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MuseumObserverLogic.Entity
{
    class Exhibition
    {
        private System.Data.SqlClient.SqlDataAdapter dataAdapter;
        public bool Save(DataSetMuseum dataSet, Connection conn, Transaction tr)
        {
            dataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            dataAdapter.InsertCommand = new System.Data.SqlClient.SqlCommand(string.Format("INSERT INTO Exhibition (Name, Start, [End], ShowroomID) " +
                                                                                                        "VALUES (@Name, @Start, @[End], @ShowroomID);"),
                                                                                                        conn.getConnection(), tr.getTransaction());
            dataAdapter.InsertCommand.Parameters.Add("@ID", SqlDbType.Int, 11, "ID");
            dataAdapter.InsertCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 255, "Name");
            dataAdapter.InsertCommand.Parameters.Add("@Start", SqlDbType.DateTime, 11, "Start");
            dataAdapter.InsertCommand.Parameters.Add("@[End]", SqlDbType.DateTime, 11, "[End]");
            dataAdapter.InsertCommand.Parameters.Add("@ShowroomID", SqlDbType.Int, 11, "ShowroomID");

            dataAdapter.UpdateCommand = new System.Data.SqlClient.SqlCommand(string.Format("UPDATE Exhibition SET Name = @Name, Start = @Start, [End] = @[End], ShowroomID = @ShowroomID WHERE ID = @ID;"), conn.getConnection(), tr.getTransaction());
            dataAdapter.UpdateCommand.Parameters.Add("@ID", SqlDbType.Int, 11, "ID");
            dataAdapter.UpdateCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 255, "Name");
            dataAdapter.UpdateCommand.Parameters.Add("@Start", SqlDbType.DateTime, 11, "Start");
            dataAdapter.UpdateCommand.Parameters.Add("@[End]", SqlDbType.DateTime, 11, "[End]");
            dataAdapter.UpdateCommand.Parameters.Add("@ShowroomID", SqlDbType.Int, 11, "ShowroomID");

            dataAdapter.DeleteCommand = new System.Data.SqlClient.SqlCommand(string.Format("DELETE FROM Exhibition WHERE ID = @ID;"), conn.getConnection(), tr.getTransaction());
            dataAdapter.DeleteCommand.Parameters.Add("@ID", SqlDbType.Int, 11, "ID");
            dataAdapter.DeleteCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 255, "Name");
            dataAdapter.DeleteCommand.Parameters.Add("@Start", SqlDbType.DateTime, 11, "Start");
            dataAdapter.DeleteCommand.Parameters.Add("@[End]", SqlDbType.DateTime, 11, "[End]");
            dataAdapter.DeleteCommand.Parameters.Add("@ShowroomID", SqlDbType.Int, 11, "ShowroomID");

            var countUpdate = dataAdapter.Update(dataSet, dataSet.Exhibition.TableName);
            return (countUpdate > 0) ? true : false;
        }

        public void Read(DataSetMuseum dataSet, Connection conn, Transaction tr)
        {
            dataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            dataAdapter.SelectCommand = new System.Data.SqlClient.SqlCommand("SELECT * FROM Exhibition", conn.getConnection(), tr.getTransaction());
            dataAdapter.Fill(dataSet, "Exhibition");
        }
    }
}
