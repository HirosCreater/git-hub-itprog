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
    public partial class Showroom : Form
    {
        DataSetMuseum dataset;
        Logic logic = new Logic();
        public Showroom()
        {
            InitializeComponent();

            dataset = new DataSetMuseum();
            loadDataFromBase();

            showroomListBox.DataSource = dataset.Showroom;
            showroomListBox.DisplayMember = "Name";
            showroomListBox.ValueMember = "ID";

            setNameTextBox();
        }

        private void loadDataFromBase()
        {
            dataset = new DataSetMuseum();
            dataset.Merge(logic.getShowroom());
        }

        private void setNameTextBox()
        {
            nameTextBox.Text = (showroomListBox.SelectedItem as DataRowView)["Name"].ToString();
        }

        private void showroomListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setNameTextBox();
        }

        private void Showroom_Load(object sender, EventArgs e)
        {

        }
    }
}
