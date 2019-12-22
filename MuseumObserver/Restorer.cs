using MuseumObserverLogic;
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
    public partial class Restorer : Form
    {
        DataSetMuseum dataset;
        protected int idListBox = 0;
        protected bool canChooseRestorer = false;
        Exhibit ExW;
        ControlFunction CFunc;
        string EnterNameRestorer = "Введите имя реставрартора!!!";
        string ChooseRestorer = "Выберите реставратора!!!";
        public Restorer(Exhibit tempExhibitWindow, ref DataSetMuseum tempDataset, ref ControlFunction tempConrolFunction)
        {
            InitializeComponent();

            dataset = tempDataset;
            ExW = tempExhibitWindow;
            CFunc = tempConrolFunction;

            RestorerListBox.DataSource = dataset.Restorer;
            RestorerListBox.DisplayMember = "Name";
            RestorerListBox.ValueMember = "ID";

            canChooseRestorer = true;
        }

        private void setNameTextBox()
        {
            nameTextBox.Text = (RestorerListBox.SelectedItem as DataRowView)["Name"].ToString();
        }

        private void RestorerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (canChooseRestorer)
            {
                idListBox = (int)RestorerListBox.SelectedValue;
                nameTextBox.Text = dataset.Restorer.Rows.Find(idListBox)["Name"].ToString();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string nameText = CFunc.CheckTextBox(this, nameTextBox.Text, EnterNameRestorer);
            if (nameText == "")
                return;
            dataset.Restorer.Rows.Find(idListBox)["Name"] = nameText;
            RestorerListBox.DataSource = dataset.Restorer;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string nameText = CFunc.CheckTextBox(this, nameTextBox.Text, EnterNameRestorer);
            if (nameText == "")
                return;
            var dr = dataset.Restorer.NewRow();
            dr["Name"] = nameTextBox.Text;
            dataset.Restorer.Rows.Add(dr);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            canChooseRestorer = false;
            if (idListBox != 0)
            {
                nameTextBox.Text = "";
                dataset.Restorer.Rows.Find(idListBox).Delete();
                idListBox = 0;
            }
            else
            {
                CFunc.ShowMessage(ChooseRestorer);
            }
            canChooseRestorer = true;
        }

        private void Restorer_FormClosed(object sender, FormClosedEventArgs e)
        {
            ExW.Enabled = true;
        }
    }
}
