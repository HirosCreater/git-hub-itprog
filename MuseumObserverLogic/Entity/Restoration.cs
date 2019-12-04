using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MuseumObserverLogic.Entity
{
    class Restoration
    {
        private System.Data.SqlClient.SqlDataAdapter dataAdapter;
        public bool Save(DataSetMuseum dataSet, Connection conn, Transaction tr)
        {
            dataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            dataAdapter.InsertCommand = new System.Data.SqlClient.SqlCommand(string.Format("INSERT INTO Restoration (Name, ExhibitID, RestorerID, Start, [End], Photo, Description) " +
                                                                                                        "VALUES (@Name, @ExhibitID, @RestorerID, @Start, @[End], @Photo, @Description);"),
                                                                                                        conn.getConnection(), tr.getTransaction());
            dataAdapter.InsertCommand.Parameters.Add("@ID", SqlDbType.Int, 11, "ID");
            dataAdapter.InsertCommand.Parameters.Add("@Name", SqlDbType.NChar, 255, "Name");
            dataAdapter.InsertCommand.Parameters.Add("@ExhibitID", SqlDbType.Int, 11, "ExhibitID");
            dataAdapter.InsertCommand.Parameters.Add("@RestorerID", SqlDbType.Int, 11, "RestorerID");
            dataAdapter.InsertCommand.Parameters.Add("@Start", SqlDbType.DateTime, 11, "Start");
            dataAdapter.InsertCommand.Parameters.Add("@[End]", SqlDbType.DateTime, 11, "[End]");
            dataAdapter.InsertCommand.Parameters.Add("@Photo", SqlDbType.NChar, 255, "Photo");
            dataAdapter.InsertCommand.Parameters.Add("@Description", SqlDbType.NText, 10000, "Description");

            dataAdapter.UpdateCommand = new System.Data.SqlClient.SqlCommand(string.Format("UPDATE Restoration SET Name = @Name, ExhibitID = @ExhibitID, RestorerID = @RestorerID, Start = @Start, [End] = @[End], Photo = @Photo, Description = @Description WHERE ID = @ID;"), conn.getConnection(), tr.getTransaction());
            dataAdapter.UpdateCommand.Parameters.Add("@ID", SqlDbType.Int, 11, "ID");
            dataAdapter.UpdateCommand.Parameters.Add("@Name", SqlDbType.NChar, 255, "Name");
            dataAdapter.UpdateCommand.Parameters.Add("@ExhibitID", SqlDbType.Int, 11, "ExhibitID");
            dataAdapter.UpdateCommand.Parameters.Add("@RestorerID", SqlDbType.Int, 11, "RestorerID");
            dataAdapter.UpdateCommand.Parameters.Add("@Start", SqlDbType.DateTime, 11, "Start");
            dataAdapter.UpdateCommand.Parameters.Add("@[End]", SqlDbType.DateTime, 11, "[End]");
            dataAdapter.UpdateCommand.Parameters.Add("@Photo", SqlDbType.NChar, 255, "Photo");
            dataAdapter.UpdateCommand.Parameters.Add("@Description", SqlDbType.NText, 10000, "Description");

            dataAdapter.DeleteCommand = new System.Data.SqlClient.SqlCommand(string.Format("DELETE FROM Restoration WHERE ID = @ID;"), conn.getConnection(), tr.getTransaction());
            dataAdapter.DeleteCommand.Parameters.Add("@ID", SqlDbType.Int, 11, "ID");
            dataAdapter.DeleteCommand.Parameters.Add("@Name", SqlDbType.NChar, 255, "Name");
            dataAdapter.DeleteCommand.Parameters.Add("@ExhibitID", SqlDbType.Int, 11, "ExhibitID");
            dataAdapter.DeleteCommand.Parameters.Add("@RestorerID", SqlDbType.Int, 11, "RestorerID");
            dataAdapter.DeleteCommand.Parameters.Add("@Start", SqlDbType.DateTime, 11, "Start");
            dataAdapter.DeleteCommand.Parameters.Add("@[End]", SqlDbType.DateTime, 11, "[End]");
            dataAdapter.DeleteCommand.Parameters.Add("@Photo", SqlDbType.NChar, 255, "Photo");
            dataAdapter.DeleteCommand.Parameters.Add("@Description", SqlDbType.NText, 10000, "Description");

            var countUpdate = dataAdapter.Update(dataSet, dataSet.Restoration.TableName);
            return (countUpdate > 0) ? true : false;
        }

        public void Read(DataSetMuseum dataSet, Connection conn, Transaction tr)
        {
            dataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            dataAdapter.SelectCommand = new System.Data.SqlClient.SqlCommand("SELECT * FROM Restoration", conn.getConnection(), tr.getTransaction());
            dataAdapter.Fill(dataSet, "Restoration");
        }
    }
}
