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
        protected int idListBox = -1;
        protected bool canChooseShowroom = false;
        public Showroom()
        {
            InitializeComponent();

            dataset = new DataSetMuseum();
            LoadDataFromBase();

            showroomListBox.DataSource = dataset.Showroom;
            showroomListBox.DisplayMember = "Name";
            showroomListBox.ValueMember = "ID";

            setNameTextBox();
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

        private void setNameTextBox()
        {
            nameTextBox.Text = (showroomListBox.SelectedItem as DataRowView)["Name"].ToString();
        }

        private void showroomListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (canChooseShowroom)
            {
                idListBox = (int)showroomListBox.SelectedValue;
                nameTextBox.Text = dataset.Maecenas.Rows.Find(idListBox)["Name"].ToString();
            }
        }

        private void Showroom_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (idListBox != -1)
            {
                canChooseShowroom = false;
                dataset.Showroom.Rows.Find(idListBox)["Name"] = nameTextBox.Text;
                canChooseShowroom = true;
                showroomListBox.DataSource = dataset.Showroom;
            }
            else
            {
                MessageBox.Show(
                    "Нужно выбрать выставочный зал!",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int newID = 0;
            if (dataset.Showroom.Rows.Count == 0)
                newID = 1;
            else
                newID = (int)dataset.Showroom.Rows[dataset.Showroom.Rows.Count - 1]["ID"] + 1;
            var dr = dataset.Showroom.NewRow();
            dr["ID"] = newID;
            dr["Name"] = nameTextBox.Text;
            dataset.Showroom.Rows.Add(dr);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            canChooseShowroom = false;
            if (idListBox != -1)
            {
                nameTextBox.Text = "";
                dataset.Showroom.Rows.Find(idListBox).Delete();
                idListBox = -1;
            }
            else
            {
                MessageBox.Show(
                    "Нужно выбрать выставочный зал!",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            canChooseShowroom = true;
        }
    }
}
