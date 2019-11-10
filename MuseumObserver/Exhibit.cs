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
    public partial class Exhibit : Form
    {
        DataSetMuseum dataset;
        Logic logic = new Logic();
        public Exhibit()
        {
            InitializeComponent();

            dataset = new DataSetMuseum();
            loadDataFromBase();

            categoryComboBox.DataSource = dataset.Category;
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.ValueMember = "ID";

            setExhibitListBox();
            setNameTextBox();
            setCategoryTextBox();
            setDescriptionTextBox();
            setAppearanceDate();
        }

        private void loadDataFromBase()
        {
            dataset = new DataSetMuseum();
            dataset.Merge(logic.getCategory());
            dataset.Merge(logic.getExhibit());
        }

        private void setExhibitListBox()
        {
            EnumerableRowCollection<DataRow> query = from ex in (dataset.Exhibit as DataTable).AsEnumerable()
                                                     where ex.Field<Int32>("CategoryID") == (int)categoryComboBox.SelectedValue
                                                     select ex;

            exhibitListBox.DataSource = query.AsDataView();
            exhibitListBox.DisplayMember = "Name";
            exhibitListBox.ValueMember = "ID";
        }

        private void setNameTextBox()
        {
            nameTextBox.Text = (exhibitListBox.SelectedItem as DataRowView)["Name"].ToString();
        }

        private void setCategoryTextBox()
        {
            categoryTextBox.Text = (categoryComboBox.SelectedItem as DataRowView)["Name"].ToString();
        }

        private void setDescriptionTextBox()
        {
            descriptionTextBox.Text = (exhibitListBox.SelectedItem as DataRowView)["Description"].ToString();
        }

        private void setAppearanceDate()
        {

        }

        private void categoryLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                setExhibitListBox();
                setCategoryTextBox();
            }
            catch { }
        }

        private void exhibitListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                setNameTextBox();
                setDescriptionTextBox();
                setAppearanceDate();
            }
            catch { }
        }
    }
}
