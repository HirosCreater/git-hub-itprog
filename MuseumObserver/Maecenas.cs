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
        public Maecenas()
        {
            InitializeComponent();
            LoadDataFromBase();
            MaecenasListBox.DataSource = dataset.Maecenas;
            MaecenasListBox.DisplayMember = "Name";
            MaecenasListBox.ValueMember = "ID";

            canChooseMaecenas = true;
        }

        private void LoadDataFromBase()
        {
            dataset = new DataSetMuseum();
            dataset.Merge(logic.getCategory());
            dataset.Merge(logic.getCrutch());
            dataset.Merge(logic.getExhibit());
            dataset.Merge(logic.getExhibition());
            dataset.Merge(logic.getExhibit_Exhibition());
            dataset.Merge(logic.getMaecenas());
            dataset.Merge(logic.getMuseum());
            dataset.Merge(logic.getRent());
            dataset.Merge(logic.getRestoration());
            dataset.Merge(logic.getRestorer());
            dataset.Merge(logic.getShowroom());
        }
        private void SaveDataToBase()
        {
            logic.setCategory(dataset);
            logic.setCrutch(dataset);
            logic.setExhibit(dataset);
            logic.setExhibition(dataset);
            logic.setExhibit_Exhibition(dataset);
            logic.setMaecenas(dataset);
            logic.setMuseum(dataset);
            logic.setRent(dataset);
            logic.setRestoration(dataset);
            logic.setRestorer(dataset);
            logic.setShowroom(dataset);
            LoadDataFromBase();
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
    }
}
