using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuseumObserverLogic;

namespace MuseumObserver
{
    public partial class Exhibition : Form
    {
        DataSetMuseum dataset;
        Logic logic = new Logic();
        Exhibit ExW;
        private bool canRemember = false;
        public Exhibition(Exhibit tempExhibitWindow, ref DataSetMuseum tempDataset)
        {
            InitializeComponent();

            dataset = tempDataset;
            ExW = tempExhibitWindow;

            exhibitionListBox.DataSource = dataset.Exhibition;
            exhibitionListBox.DisplayMember = "Name";
            exhibitionListBox.ValueMember = "ID";
        }

        private void loadDataFromBase()
        {
            dataset = new DataSetMuseum();
            dataset.Merge(logic.getExhibition());
            dataset.Merge(logic.getExhibit());
            dataset.Merge(logic.getExhibit_Exhibition());
        }
        private void setExhibitListBox()
        {
            try
            {
                DataTable exhibitions = dataset.Exhibition;
                DataTable exhibits = dataset.Exhibit;
                EnumerableRowCollection<DataRow> query = from e_ex in (dataset.Exhibit_Exhibition as DataTable).AsEnumerable()
                                                         where e_ex.Field<Int32>("ExhibitionID") == (int)exhibitionListBox.SelectedValue
                                                         select e_ex;
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
            nameTextBox.Text = (exhibitionListBox.SelectedItem as DataRowView)["Name"].ToString();
        }

        private void exhibitionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                setExhibitListBox();
                setNameTextBox();
                setStartDate();
                setEndDate();
            }
            catch(Exception ex) { }
        }

        private void setStartDate()
        {
            DataRow tempRow = dataset.Exhibition.Rows.Find(exhibitionListBox.SelectedValue);
            startDate.Value = (DateTime)tempRow["Start"];
        }
        
        private void setEndDate()
        {
            DataRow tempRow = dataset.Exhibition.Rows.Find(exhibitionListBox.SelectedValue);
            endDate.Value = (DateTime)tempRow["End"];
        }




        private void Exhibition_FormClosed(object sender, FormClosedEventArgs e)
        {
            ExW.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
           
        }
    }
}
