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
        }

        private void loadDataFromBase()
        {
            dataset = new DataSetMuseum();
            dataset.Merge(logic.getExhibition());
        }
    }
}
