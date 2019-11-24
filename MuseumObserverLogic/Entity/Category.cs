﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MuseumObserverLogic.Entity
{
    class Category
    {
        private System.Data.SqlClient.SqlDataAdapter dataAdapter;
        public bool Save(DataSetMuseum dataSet, Connection conn, Transaction tr)
        {
            dataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            dataAdapter.InsertCommand = new System.Data.SqlClient.SqlCommand(string.Format("INSERT INTO Category (Name) VALUES (@Name);"), conn.getConnection(), tr.getTransaction());
            dataAdapter.InsertCommand.Parameters.Add("@ID", SqlDbType.Int, 11, "ID");
            dataAdapter.InsertCommand.Parameters.Add("@Name", SqlDbType.NChar, 50, "Name");

            dataAdapter.UpdateCommand = new System.Data.SqlClient.SqlCommand(string.Format("UPDATE Category SET Name = @Name WHERE ID = @ID;"), conn.getConnection(), tr.getTransaction());
            dataAdapter.UpdateCommand.Parameters.Add("@ID", SqlDbType.Int, 11, "ID");
            dataAdapter.UpdateCommand.Parameters.Add("@Name", SqlDbType.NChar, 50, "Name");

            dataAdapter.DeleteCommand = new System.Data.SqlClient.SqlCommand(string.Format("DELETE FROM Category WHERE ID = @ID;"), conn.getConnection(), tr.getTransaction());
            dataAdapter.DeleteCommand.Parameters.Add("@ID", SqlDbType.Int, 11, "ID");
            dataAdapter.DeleteCommand.Parameters.Add("@Name", SqlDbType.NChar, 50, "Name");

            var countUpdate = dataAdapter.Update(dataSet, dataSet.Category.TableName);
            return (countUpdate > 0) ? true : false;
        }

        public void Read(DataSetMuseum dataSet, Connection conn, Transaction tr)
        {
            dataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            dataAdapter.SelectCommand = new System.Data.SqlClient.SqlCommand("SELECT * FROM Category", conn.getConnection(), tr.getTransaction());
            dataAdapter.Fill(dataSet, "Category");
        }
    }
}
