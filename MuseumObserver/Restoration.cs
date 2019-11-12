using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuseumObserverLogic;

namespace MuseumObserver
{
    public partial class Restoration : Form
    {
        DataSetMuseum dataset;
        Logic logic = new Logic();
        public Restoration()
        {
            InitializeComponent();

            dataset = new DataSetMuseum();
            loadDataFromBase();

            restorerComboBox.DataSource = dataset.Restorer;
            restorerComboBox.DisplayMember = "Name";
            restorerComboBox.ValueMember = "ID";

            setExhibitListBox();
            setRestorationData();
        }

        private void loadDataFromBase()
        {
            dataset = new DataSetMuseum();
            dataset.Merge(logic.getRestorer());
            dataset.Merge(logic.getRestoration());
            dataset.Merge(logic.getExhibit());
        }

        private void setExhibitListBox()
        {
            try
            {
                DataTable restorers = dataset.Restorer;
                DataTable exhibits = dataset.Exhibit;
                EnumerableRowCollection<DataRow> query = from r in (dataset.Restoration as DataTable).AsEnumerable()
                                                         where r.Field<Int32>("RestorerID") == (int)restorerComboBox.SelectedValue
                                                         select r;
                string getExhibitsFilter = "[ID] IN (";
                for (int i = 0; i < query.Count(); i++)
                {
                    getExhibitsFilter += "'" + query.ElementAt(i).Field<Int32>("ExhibitID") + "'";
                    if (i + 1 != query.Count())
                        getExhibitsFilter += ",";
                }
                getExhibitsFilter += ")";
                DataView exhibitView = new DataView(dataset.Exhibit);
                exhibitView.RowFilter = getExhibitsFilter;

                exhibitListBox.DataSource = exhibitView;
                exhibitListBox.DisplayMember = "Name";
                exhibitListBox.ValueMember = "ID";
            }
            catch { }
        }
        private void setNameTextBox()
        {
            nameTextBox.Text = (restorerComboBox.SelectedItem as DataRowView)["Name"].ToString();
        }

        private void setDescriptionTextBox()
        {
            try
            {
                descriptionTextBox.Text = dataset.Restoration.Rows.Find(exhibitListBox.SelectedValue)["Description"].ToString();
            }
            catch { }
        }

        private void setRestorationData()
        {
            try
            {
                setNameTextBox();
                setPhoto();
                setDescriptionTextBox();
            }
            catch { }
        }
        
        private void setPhoto()
        {
            string str = dataset.Restoration.Rows.Find(exhibitListBox.SelectedValue)["Photo"].ToString();
            str = "Pictures/" + str + ".jpg";
            if (File.Exists(str))
            {
                photoPictureBox.Image = Image.FromFile(str);
            }
            else
            {
                photoPictureBox.Image = Image.FromFile("Pictures/DefaultImage.jpg");
            }
        }

        private void restorerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setExhibitListBox();
            setRestorationData();
        }
    }
}
