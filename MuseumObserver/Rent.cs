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
    public partial class Rent : Form
    {
        DataSetMuseum dataset;
        Logic logic = new Logic();
        public Rent()
        {
            InitializeComponent();

            dataset = new DataSetMuseum();
            loadDataFromBase();

            museumComboBox.DataSource = dataset.Museum;
            museumComboBox.DisplayMember = "Name";
            museumComboBox.ValueMember = "ID";

            museumtenantComboBox.DataSource = dataset.Museum;
            museumtenantComboBox.DisplayMember = "Name";
            museumtenantComboBox.ValueMember = "ID";

            exhibitComboBox.DataSource = dataset.Exhibit;
            exhibitComboBox.DisplayMember = "Name";
            exhibitComboBox.ValueMember = "ID";
        }

        private void loadDataFromBase()
        {
            dataset = new DataSetMuseum();
            dataset.Merge(logic.getRent());
            dataset.Merge(logic.getMuseum());
            dataset.Merge(logic.getExhibit());
        }

        private void museumComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setExhibitListBox();
        }

        private void setExhibitListBox()
        {
            try
            {

                /*if (checkBoxTimeFilter.Checked)
                    exhibitView.RowFilter = "AppearanceDate >= #" + appearanceDateFrom.Value.Year + "-" + appearanceDateFrom.Value.Month + "-" + appearanceDateFrom.Value.Day
                                            + "#AND AppearanceDate <= #" + +appearanceDateTo.Value.Year + "-" + appearanceDateTo.Value.Month + "-" + appearanceDateTo.Value.Day
                                            + "#AND CategoryID = " + categoryComboBox.SelectedValue;
                if (!checkBoxTimeFilter.Checked)
                    exhibitView.RowFilter = "CategoryID = " + categoryComboBox.SelectedValue;*/


                DataTable exhibitions = dataset.Rent;
                DataTable exhibits = dataset.Exhibit;
                EnumerableRowCollection<DataRow> query = from e_ex in (dataset.Rent as DataTable).AsEnumerable()
                                                         where e_ex.Field<Int32>("MuseumID") == (int)museumComboBox.SelectedValue
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
            catch {
                exhibitListBox.DataSource = null;
            }
        }
    }
}
