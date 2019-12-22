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
    public partial class Museum : Form
    {
        DataSetMuseum dataset;
        Logic logic = new Logic();
        protected int idListBox = 0;
        protected bool canChooseMuseum = false;
        Exhibit ExW;
        
        string EnterNameMuseum = "Введите название музея!!!";
        ControlFunction CFunc;
        public Museum(Exhibit tempExhibitWindow, ref DataSetMuseum tempDataset, ref ControlFunction tempConrolFunction)
        {
            InitializeComponent();
            ExW = tempExhibitWindow; ExW.Enabled = false;
            dataset = tempDataset;
            CFunc = tempConrolFunction;
            MuseumListBox.DataSource = dataset.Museum;
            MuseumListBox.DisplayMember = "Name";
            MuseumListBox.ValueMember = "ID";

            canChooseMuseum = true;
        }
        private void MuseumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (canChooseMuseum)
            {
                idListBox = (int)MuseumListBox.SelectedValue;
                NameMuseum.Text = dataset.Museum.Rows.Find(idListBox)["Name"].ToString();
                ChangeMuseum.Enabled = true;
            }
        }

        private void ChangeMuseum_Click(object sender, EventArgs e)
        {
            canChooseMuseum = false;
            string nameText = CFunc.CheckTextBox(this, NameMuseum.Text, EnterNameMuseum);

            if (nameText != "")
            {
                dataset.Museum.Rows.Find(idListBox)["Name"] = NameMuseum.Text;
                ChangeMuseum.Enabled = true;
            }
            canChooseMuseum = true;
            return;
        }

        private void AddMuseum_Click(object sender, EventArgs e)
        {
            string nameText = CFunc.CheckTextBox(this, NameMuseum.Text, EnterNameMuseum);
            if (nameText == "")
                return;
            foreach (DataRow item in dataset.Museum)
            {
                if (item["Name"].ToString() == nameText)
                {
                    CFunc.ShowMessage("Музей '" + nameText + "' уже существует!");
                    return;
                }
            }
            var dr = dataset.Museum.NewRow();
            dr["Name"] = nameText;
            dataset.Museum.Rows.Add(dr);
            ExW.SaveToDataBase();

            DataView tempMuseum = new DataView(dataset.Museum);
            tempMuseum.RowFilter = "Name = " + "'" + nameText + "'";
            var newRow = dataset.Crutch.NewRow();
            newRow["From"] = "Museum";
            newRow["InstanceID"] = tempMuseum[0][0];
            dataset.Crutch.Rows.Add(newRow);
            ChangeMuseum.Enabled = false;
            ExW.SaveToDataBase();
        }

        private void DeleteMuseum_Click(object sender, EventArgs e)
        {
            canChooseMuseum = false;
            if (idListBox != 0)
            {
                NameMuseum.Text = "";
                dataset.Museum.Rows.Find(idListBox).Delete();
                ChangeMuseum.Enabled = false;
                idListBox = 0;
            }
            else
            {
                MessageBox.Show(
                    "Нужно выбрать музей!",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            ExW.SaveToDataBase();
            canChooseMuseum = true;
        }

        private void Museum_FormClosed(object sender, FormClosedEventArgs e)
        {
            ExW.Enabled = true;
        }
    }
}
