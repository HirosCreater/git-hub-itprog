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

        public Exhibition()
        {
            InitializeComponent();
            dataset = new DataSetMuseum();
            loadDataFromBase();

            exhibitionListBox.DataSource = dataset.Exhibition;
            exhibitionListBox.DisplayMember = "Name";
            exhibitionListBox.ValueMember = "ID";

            //exhibitListBox.Items.Insert(0, exhibitionListBox.SelectedValue);
            /*EnumerableRowCollection<DataRow> query = from exhibition in (dataset.Exhibition as DataTable).AsEnumerable()
                                                     where exhibition.Field<Int32>("ShowroomID") > 3
                                                     select exhibition;

            exhibitionListBox.DataSource = query.AsDataView();
            exhibitionListBox.DisplayMember = "Name";
            exhibitionListBox.ValueMember = "ID";*/

            /*EnumerableRowCollection<DataRow> query = from e in (dataset.Exhibit_Exhibition as DataTable).AsEnumerable()
                                                     where e.Field<Int32>("ExhibitionID") > 3
                                                     select e;

            exhibitListBox.DataSource = query.AsDataView();
            exhibitListBox.DisplayMember = "ExhibitionID";
            exhibitListBox.ValueMember = "ExhibitionID"; */





        }

        private void loadDataFromBase()
        {
            dataset = new DataSetMuseum();
            dataset.Merge(logic.getExhibition());
            dataset.Merge(logic.getExhibit());
            dataset.Merge(logic.getExhibit_Exhibition());
        }

        private void exhibitionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*exhibitListBox.Items.Clear();
            exhibitListBox.Items.Insert(0, exhibitionListBox.SelectedValue);*/
        }
    }
}
