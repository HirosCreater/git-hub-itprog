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
        protected int idListBox = -1;
        protected bool canChooseMuseum = false;
        Exhibit ExW;
        public Museum(Exhibit tempExhibitWindow, ref DataSetMuseum tempDataset)
        {
            InitializeComponent();
            ExW = tempExhibitWindow; ExW.Enabled = false;
            dataset = tempDataset;
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
            }
        }

        private void ChangeMuseum_Click(object sender, EventArgs e)
        {
            if (idListBox != -1)
            {
                canChooseMuseum = false;
                dataset.Museum.Rows.Find(idListBox)["Name"] = NameMuseum.Text;
                canChooseMuseum = true;
                MuseumListBox.DataSource = dataset.Museum;
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
        }

        private void AddMuseum_Click(object sender, EventArgs e)
        {
            int newID = 0;
            if (dataset.Museum.Rows.Count == 0)
                newID = 1;
            else
                newID = (int)dataset.Museum.Rows[dataset.Museum.Rows.Count - 1]["ID"] + 1;
            var dr = dataset.Museum.NewRow();
            dr["ID"] = newID;
            dr["Name"] = NameMuseum.Text;
            dataset.Museum.Rows.Add(dr);
        }

        private void DeleteMuseum_Click(object sender, EventArgs e)
        {
            canChooseMuseum = false;
            if (idListBox != -1)
            {
                NameMuseum.Text = "";
                dataset.Museum.Rows.Find(idListBox).Delete();
                idListBox = -1;
            }
            else
            {
                MessageBox.Show(
                    "Нужно выбрать мецената!",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            canChooseMuseum = true;
        }

        private void Museum_FormClosed(object sender, FormClosedEventArgs e)
        {
            ExW.Enabled = true;
        }
    }
}
