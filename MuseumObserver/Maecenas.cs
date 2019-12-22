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
        protected int idListBox = 0;
        protected bool canChooseMaecenas = false;
        Exhibit ExW;
        string EnterNameMaecenas = "Введите имя мецената!";
        string NeedChooseMaecenas = "Нужно выбрать мецената!";
        ControlFunction CFunc;
        public Maecenas(Exhibit tempExhibitWindow, ref DataSetMuseum tempDataset,ref ControlFunction tempControlFunction)
        {
            InitializeComponent();
            ExW = tempExhibitWindow; ExW.Enabled = false;
            dataset = tempDataset;
            CFunc = tempControlFunction;

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
            if (idListBox != 0)
            {
                string nameText = CFunc.CheckTextBox(this, NameMaecenas.Text, EnterNameMaecenas);
                if (nameText == "")
                    return;
                dataset.Maecenas.Rows.Find(idListBox)["Name"] = NameMaecenas.Text;
                canChooseMaecenas = true;
                MaecenasListBox.DataSource = dataset.Maecenas;
            }
            else
            {
                CFunc.ShowMessage(NeedChooseMaecenas);
            }
        }

        private void AddMaecenas_Click(object sender, EventArgs e)
        {
            string nameText = CFunc.CheckTextBox(this, NameMaecenas.Text, EnterNameMaecenas);
            if (nameText == "")
                return;
            foreach (DataRow item in dataset.Maecenas)
            {
                if (item["Name"].ToString() == nameText)
                {
                    CFunc.ShowMessage("Меценат '" + nameText + "' уже существует!");
                    return;
                }
            }
            var dr = dataset.Maecenas.NewRow();
            dr["Name"] = NameMaecenas.Text;
            dataset.Maecenas.Rows.Add(dr);
            ExW.SaveToDataBase();

            DataView tempMaecenas = new DataView(dataset.Maecenas);
            tempMaecenas.RowFilter = "Name = " + nameText;
            var newRow = dataset.Maecenas.NewRow();
            newRow["From"] = "Maecenas";
            newRow["InstanceID"] = tempMaecenas[0][0];
            dataset.Crutch.Rows.Add(newRow);
            ExW.SaveToDataBase();
        }

        private void DeleteMaecenas_Click(object sender, EventArgs e)
        {
            canChooseMaecenas = false;
            if (idListBox != 0)
            {
                NameMaecenas.Text = "";
                dataset.Maecenas.Rows.Find(idListBox).Delete();
                idListBox = 0;
            }
            else
            {
                CFunc.ShowMessage(NeedChooseMaecenas);
            }
            canChooseMaecenas = true;
        }

        private void Maecenas_FormClosed(object sender, FormClosedEventArgs e)
        {
            ExW.Enabled = true;
        }
    }
}
