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
        protected int idListBox = 0;
        protected bool canChooseShowroom = false;
        Exhibit ExW;
        ControlFunction CFunc;
        string EnterNameShowRoom = "Введите название зала";
        public Showroom(Exhibit tempExhibitWindow, ref DataSetMuseum tempDataset, ref ControlFunction tempConrolFunction)
        {
            InitializeComponent();

            dataset = tempDataset;
            ExW = tempExhibitWindow;
            CFunc = tempConrolFunction;

            showroomListBox.DataSource = dataset.Showroom;
            showroomListBox.DisplayMember = "Name";
            showroomListBox.ValueMember = "ID";

            canChooseShowroom = true;
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
                nameTextBox.Text = dataset.Showroom.Rows.Find(idListBox)["Name"].ToString();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string nameText = CFunc.CheckTextBox(this, nameTextBox.Text, EnterNameShowRoom);
            if (nameText == "")
                return;
            dataset.Showroom.Rows.Find(idListBox)["Name"] = nameText;
            showroomListBox.DataSource = dataset.Showroom;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string nameText = CFunc.CheckTextBox(this, nameTextBox.Text, EnterNameShowRoom);
            if (nameText == "")
                return;
            foreach (DataRow item in dataset.Showroom)
            {
                if (item["Name"].ToString() == nameText)
                {
                    CFunc.ShowMessage("Зал '"+ nameText + "' уже существует!");
                    return;
                }
            }
            var dr = dataset.Showroom.NewRow();
            dr["Name"] = nameTextBox.Text;
            dataset.Showroom.Rows.Add(dr);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            canChooseShowroom = false;
            if (idListBox != 0)
            {
                nameTextBox.Text = "";
                dataset.Showroom.Rows.Find(idListBox).Delete();
                idListBox = 0;
            }
            else
            {
                CFunc.ShowMessage("Нужно выбрать выставочный зал!");
            }
            canChooseShowroom = true;
        }

        private void Showroom_FormClosed(object sender, FormClosedEventArgs e)
        {
            ExW.Enabled = true;
        }
    }
}
