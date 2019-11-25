using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseumObserver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*Maecenas maecenas = new Maecenas();
            maecenas.Show();

            Showroom showroom = new Showroom();
            showroom.Show();
            */
            Restoration restoration = new Restoration();
            restoration.Show();

            Exhibit exhibit = new Exhibit();
            exhibit.Show();

            /*Rent rent = new Rent();
            rent.Show();

            Exhibition exhibition = new Exhibition();
            exhibition.Show();
            
            Exhibit exhibit = new Exhibit();
            exhibit.Show();

            Maecenas maecenas = new Maecenas();
            maecenas.Show();
            Museum museum = new Museum();
            museum.Show();*/
        }
    }
}
/*
            DataView tempCrutch = new DataView(dataset.Crutch);
            DataView tempTable = new DataView(dataset.Maecenas);
            for (int i = 0; i<dataset.Maecenas.Rows.Count; i++)
            {
                tempCrutch.RowFilter = "[From] = 'Maecenas' AND InstanceID = " + dataset.Maecenas.Rows[i]["ID"];
                if (tempCrutch.Count == 0)
                {
                    var newRow = dataset.Crutch.NewRow();
                    //int newID = (int)dataset.Crutch.Max(row => row.ID) + 1;
                    //newRow["ID"] = newID;
                    newRow["From"] = "Maecenas";
                    newRow["InstanceID"] = dataset.Maecenas.Rows[i]["ID"];
                    dataset.Crutch.Rows.Add(newRow);
                }
            }
            for (int i = 0; i<dataset.Museum.Rows.Count; i++)
            {
                tempCrutch.RowFilter = "[From] = 'Museum' AND InstanceID = " + dataset.Museum.Rows[i]["ID"];
                if (tempCrutch.Count == 0)
                {
                    var newRow = dataset.Crutch.NewRow();
                    //int newID = (int)dataset.Crutch.Max(row => row.ID) + 1;
                    //newRow["ID"] = newID;
                    newRow["From"] = "Museum";
                    newRow["InstanceID"] = dataset.Museum.Rows[i]["ID"];
                    dataset.Crutch.Rows.Add(newRow);
                }
            }
            SaveToDataBase();
            */