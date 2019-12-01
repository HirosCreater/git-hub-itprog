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
    public partial class Maecenas : Form
    {
        DataSetMuseum dataset;
        Logic logic = new Logic();
        protected int idListBox = -1;
        protected bool canChooseMaecenas = false;
        Exhibit ExW;
        public Maecenas(Exhibit tempExhibitWindow, ref DataSetMuseum tempDataset)
        {
            InitializeComponent();
            ExW = tempExhibitWindow; ExW.Enabled = false;
            dataset = tempDataset;
            MaecenasListBox.DataSource = dataset.Maecenas;
            MaecenasListBox.DisplayMember = "Name";
            MaecenasListBox.ValueMember = "ID";

            canChooseMaecenas = true;
        }
        
        private void MaecenasListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (canChooseMaecenas)
            {
                idListBox = (int)MaecenasListBox.SelectedValue;
                NameMaecenas.Text = dataset.Maecenas.Rows.Find(idListBox)["Name"].ToString();
            }
        }

        private void ChangeMaecenas_Click(object sender, EventArgs e)
        {
            if (idListBox != -1)
            {
                canChooseMaecenas = false;
                dataset.Maecenas.Rows.Find(idListBox)["Name"] = NameMaecenas.Text;
                canChooseMaecenas = true;
                MaecenasListBox.DataSource = dataset.Maecenas;
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
        }

        private void AddMaecenas_Click(object sender, EventArgs e)
        {
            int newID = 0;
            if (dataset.Maecenas.Rows.Count == 0)
                newID = 1;
            else
                newID = (int)dataset.Maecenas.Rows[dataset.Maecenas.Rows.Count - 1]["ID"] + 1;
            var dr = dataset.Maecenas.NewRow();
            dr["ID"] = newID;
            dr["Name"] = NameMaecenas.Text;
            dataset.Maecenas.Rows.Add(dr);
        }

        private void DeleteMaecenas_Click(object sender, EventArgs e)
        {
            canChooseMaecenas = false;
            if (idListBox != -1)
            {
                NameMaecenas.Text = "";
                dataset.Maecenas.Rows.Find(idListBox).Delete();
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
            canChooseMaecenas = true;
        }

        private void Maecenas_FormClosed(object sender, FormClosedEventArgs e)
        {
            ExW.Enabled = true;
        }
    }
}
