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
        }

        private void loadDataFromBase()
        {
            dataset = new DataSetMuseum();
            dataset.Merge(logic.getRent());
            dataset.Merge(logic.getMuseum());
            dataset.Merge(logic.getExhibit());
        }
    }
}
