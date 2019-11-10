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
            setNameTextBox();
            setDescriptionTextBox();
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
            /*EnumerableRowCollection<DataRow> query = from ex in (dataset.Exhibit as DataTable).AsEnumerable()
                                                     where ex.Field<Int32>("CategoryID") == (int)categoryComboBox.SelectedValue
                                                     select ex;

            exhibitListBox.DataSource = query.AsDataView();
            exhibitListBox.DisplayMember = "Name";
            exhibitListBox.ValueMember = "ID";*/
        }
        private void setNameTextBox()
        {
            nameTextBox.Text = (restorerComboBox.SelectedItem as DataRowView)["Name"].ToString();
        }

        private void setDescriptionTextBox()
        {

        }
    }
}
