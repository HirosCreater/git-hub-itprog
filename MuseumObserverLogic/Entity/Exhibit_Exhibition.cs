using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MuseumObserverLogic.Entity
{
    class Exhibit_Exhibition
    {
        private System.Data.SqlClient.SqlDataAdapter dataAdapter;
        public bool Save(DataSetMuseum dataSet, Connection conn, Transaction tr)
        {
            dataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            dataAdapter.InsertCommand = new System.Data.SqlClient.SqlCommand(string.Format("INSERT INTO Exhibit_Exhibition (ExhibitID, ExhibitionID) " +
                                                                                                        "VALUES (@ExhibitID, @ExhibitionID);"),
                                                                                                        conn.getConnection(), tr.getTransaction());
            dataAdapter.InsertCommand.Parameters.Add("@ExhibitID", SqlDbType.Int, 11, "ExhibitID");
            dataAdapter.InsertCommand.Parameters.Add("@ExhibitionID", SqlDbType.Int, 11, "ExhibitionID");

            dataAdapter.UpdateCommand = new System.Data.SqlClient.SqlCommand(string.Format("UPDATE Exhibit_Exhibition SET ExhibitID = @ExhibitID WHERE ExhibitionID = @ExhibitionID;"), conn.getConnection(), tr.getTransaction());
            dataAdapter.UpdateCommand.Parameters.Add("@ExhibitID", SqlDbType.Int, 11, "ExhibitID");
            dataAdapter.UpdateCommand.Parameters.Add("@ExhibitionID", SqlDbType.Int, 11, "ExhibitionID");

            dataAdapter.DeleteCommand = new System.Data.SqlClient.SqlCommand(string.Format("DELETE FROM Exhibit_Exhibition WHERE ID = @ID;"), conn.getConnection(), tr.getTransaction());
            dataAdapter.DeleteCommand.Parameters.Add("@ExhibitID", SqlDbType.Int, 11, "ExhibitID");
            dataAdapter.DeleteCommand.Parameters.Add("@ExhibitionID", SqlDbType.Int, 11, "ExhibitionID");

            var countUpdate = dataAdapter.Update(dataSet, dataSet.Exhibit_Exhibition.TableName);
            return (countUpdate > 0) ? true : false;
        }

        public void Read(DataSetMuseum dataSet, Connection conn, Transaction tr)
        {
            dataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            dataAdapter.SelectCommand = new System.Data.SqlClient.SqlCommand("SELECT * FROM Exhibit_Exhibition", conn.getConnection(), tr.getTransaction());
            dataAdapter.Fill(dataSet, "Exhibit_Exhibition");
        }
    }
}
