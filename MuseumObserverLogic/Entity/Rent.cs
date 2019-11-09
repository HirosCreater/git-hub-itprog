using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MuseumObserverLogic.Entity
{
    class Rent
    {
        private System.Data.SqlClient.SqlDataAdapter dataAdapter;
        public bool Save(DataSetMuseum dataSet, Connection conn, Transaction tr)
        {
            dataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            dataAdapter.InsertCommand = new System.Data.SqlClient.SqlCommand(string.Format("INSERT INTO Rent (ID, ExhibitID, MuseumID, Start, [End]) " +
                                                                                                        "VALUES (@ID, @ExhibitID, @MuseumID, @Start, @[End]);"),
                                                                                                        conn.getConnection(), tr.getTransaction());
            dataAdapter.InsertCommand.Parameters.Add("@ID", SqlDbType.Int, 11, "ID");
            dataAdapter.InsertCommand.Parameters.Add("@ExhibitID", SqlDbType.Int, 11, "ExhibitID");
            dataAdapter.InsertCommand.Parameters.Add("@MuseumID", SqlDbType.Int, 11, "MuseumID");
            dataAdapter.InsertCommand.Parameters.Add("@Start", SqlDbType.DateTime, 11, "Start");
            dataAdapter.InsertCommand.Parameters.Add("@[End]", SqlDbType.DateTime, 11, "[End]");

            dataAdapter.UpdateCommand = new System.Data.SqlClient.SqlCommand(string.Format("UPDATE Rent SET ExhibitID = @ExhibitID, MuseumID = @MuseumID, Start = @Start, [End] = @[End] WHERE ID = @ID;"), conn.getConnection(), tr.getTransaction());
            dataAdapter.UpdateCommand.Parameters.Add("@ID", SqlDbType.Int, 11, "ID");
            dataAdapter.UpdateCommand.Parameters.Add("@ExhibitID", SqlDbType.Int, 11, "ExhibitID");
            dataAdapter.UpdateCommand.Parameters.Add("@MuseumID", SqlDbType.Int, 11, "MuseumID");
            dataAdapter.UpdateCommand.Parameters.Add("@Start", SqlDbType.DateTime, 11, "Start");
            dataAdapter.UpdateCommand.Parameters.Add("@[End]", SqlDbType.DateTime, 11, "[End]");

            dataAdapter.DeleteCommand = new System.Data.SqlClient.SqlCommand(string.Format("DELETE FROM Rent WHERE ID = @ID;"), conn.getConnection(), tr.getTransaction());
            dataAdapter.DeleteCommand.Parameters.Add("@ID", SqlDbType.Int, 11, "ID");
            dataAdapter.DeleteCommand.Parameters.Add("@ExhibitID", SqlDbType.Int, 11, "ExhibitID");
            dataAdapter.DeleteCommand.Parameters.Add("@MuseumID", SqlDbType.Int, 11, "MuseumID");
            dataAdapter.DeleteCommand.Parameters.Add("@Start", SqlDbType.DateTime, 11, "Start");
            dataAdapter.DeleteCommand.Parameters.Add("@[End]", SqlDbType.DateTime, 11, "[End]");

            var countUpdate = dataAdapter.Update(dataSet, dataSet.Rent.TableName);
            return (countUpdate > 0) ? true : false;
        }

        public void Read(DataSetMuseum dataSet, Connection conn, Transaction tr)
        {
            dataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            dataAdapter.SelectCommand = new System.Data.SqlClient.SqlCommand("SELECT * FROM Rent", conn.getConnection(), tr.getTransaction());
            dataAdapter.Fill(dataSet, "Rent");
        }
    }
}
