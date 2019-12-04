using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MuseumObserverLogic.Entity
{
    class Exhibit
    {
        private System.Data.SqlClient.SqlDataAdapter dataAdapter;
        public bool Save(DataSetMuseum dataSet, Connection conn, Transaction tr)
        {
            dataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            dataAdapter.InsertCommand = new System.Data.SqlClient.SqlCommand(string.Format("INSERT INTO Exhibit (Name, CategoryID, CreatedDate, AppearanceDate, Photo, Description, CrutchID) " +
                                                                                                        "VALUES (@Name, @CategoryID, @CreatedDate, @AppearanceDate, @Photo, @Description, @CrutchID);"),
                                                                                                        conn.getConnection(), tr.getTransaction());
            //dataAdapter.InsertCommand.Parameters.Add("@ID", SqlDbType.Int, 11, "ID");
            dataAdapter.InsertCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
            dataAdapter.InsertCommand.Parameters.Add("@CategoryID", SqlDbType.Int, 11, "CategoryID");
            dataAdapter.InsertCommand.Parameters.Add("@CreatedDate", SqlDbType.NVarChar, 50, "CreatedDate");
            dataAdapter.InsertCommand.Parameters.Add("@AppearanceDate", SqlDbType.DateTime, 11, "AppearanceDate");
            dataAdapter.InsertCommand.Parameters.Add("@Photo", SqlDbType.NVarChar, 255, "Photo");
            dataAdapter.InsertCommand.Parameters.Add("@Description", SqlDbType.NText, 10000, "Description");
            dataAdapter.InsertCommand.Parameters.Add("@CrutchID", SqlDbType.Int, 11, "CrutchID");

            dataAdapter.UpdateCommand = new System.Data.SqlClient.SqlCommand(string.Format("UPDATE Exhibit SET Name = @Name, CategoryID = @CategoryID, CreatedDate = @CreatedDate, AppearanceDate = @AppearanceDate, Photo = @Photo, Description = @Description, CrutchID = CrutchID WHERE ID = @ID;"), conn.getConnection(), tr.getTransaction());
            dataAdapter.UpdateCommand.Parameters.Add("@ID", SqlDbType.Int, 11, "ID");
            dataAdapter.UpdateCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
            dataAdapter.UpdateCommand.Parameters.Add("@CategoryID", SqlDbType.Int, 11, "CategoryID");
            dataAdapter.UpdateCommand.Parameters.Add("@CreatedDate", SqlDbType.NVarChar, 50, "CreatedDate");
            dataAdapter.UpdateCommand.Parameters.Add("@AppearanceDate", SqlDbType.DateTime, 11, "AppearanceDate");
            dataAdapter.UpdateCommand.Parameters.Add("@Photo", SqlDbType.NVarChar, 255, "Photo");
            dataAdapter.UpdateCommand.Parameters.Add("@Description", SqlDbType.NText, 10000, "Description");
            dataAdapter.UpdateCommand.Parameters.Add("@CrutchID", SqlDbType.Int, 11, "CrutchID");

            dataAdapter.DeleteCommand = new System.Data.SqlClient.SqlCommand(string.Format("DELETE FROM Exhibit WHERE ID = @ID;"), conn.getConnection(), tr.getTransaction());
            dataAdapter.DeleteCommand.Parameters.Add("@ID", SqlDbType.Int, 11, "ID");
            dataAdapter.DeleteCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 50, "Name");
            dataAdapter.DeleteCommand.Parameters.Add("@CategoryID", SqlDbType.Int, 11, "CategoryID");
            dataAdapter.DeleteCommand.Parameters.Add("@CreatedDate", SqlDbType.NVarChar, 50, "CreatedDate");
            dataAdapter.DeleteCommand.Parameters.Add("@AppearanceDate", SqlDbType.DateTime, 11, "AppearanceDate");
            dataAdapter.DeleteCommand.Parameters.Add("@Photo", SqlDbType.NVarChar, 255, "Photo");
            dataAdapter.DeleteCommand.Parameters.Add("@Description", SqlDbType.NText, 10000, "Description");
            dataAdapter.DeleteCommand.Parameters.Add("@CrutchID", SqlDbType.Int, 11, "CrutchID");

            var countUpdate = dataAdapter.Update(dataSet, dataSet.Exhibit.TableName);
            return (countUpdate > 0) ? true : false;
        }

        public void Read(DataSetMuseum dataSet, Connection conn, Transaction tr)
        {
            dataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            dataAdapter.SelectCommand = new System.Data.SqlClient.SqlCommand("SELECT * FROM Exhibit", conn.getConnection(), tr.getTransaction());
            dataAdapter.Fill(dataSet, "Exhibit");
        }
    }
}
