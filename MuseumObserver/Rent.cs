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
        Exhibit ExW;

        bool chengeList = false;

        bool canDoEnything = false;

        int rentIndex = 0;

        bool canChooseAnyMuseum = false;
        DataView museumRents;
        object[,] masRent;
        ControlFunction CFunc;
        public Rent(Exhibit tempExhibitWindow, ref DataSetMuseum tempDataset, ref ControlFunction tempConrolFunction)
        {
            InitializeComponent();

            SetControlDefault();

            dataset = tempDataset;
            ExW = tempExhibitWindow;
            CFunc = tempConrolFunction;

            museumComboBox.DataSource = dataset.Museum;
            museumComboBox.DisplayMember = "Name";
            museumComboBox.ValueMember = "ID";


            canChooseAnyMuseum = true;
        }
        private void museumComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (canChooseAnyMuseum)
            {
                canDoEnything = true;
                museumtenantComboBox.Enabled = true;
                rentStart.Enabled = true;
                rentEnd.Enabled = true;
                setExhibitListBox();
            }
        }

        private void setExhibitListBox()
        {
            RentListBox.Items.Clear();
            museumRents = new DataView(dataset.Rent);
            museumRents.RowFilter = "MuseumID = " + museumComboBox.SelectedValue;
            if (FilterByStartTime.Checked)
            {
                museumRents.RowFilter += " AND Start >= #" + dateStartFrom.Value.Year + "-" + dateStartFrom.Value.Month + "-" + dateStartFrom.Value.Day + "#"
                                        + " AND Start <= #" + dateStartTo.Value.Year + "-" + dateStartTo.Value.Month + "-" + dateStartTo.Value.Day + "#";
            }
            if (FilterByEndTime.Checked)
            {
                museumRents.RowFilter += " AND End >= #" + dateEndFrom.Value.Year + "-" + dateEndFrom.Value.Month + "-" + dateEndFrom.Value.Day + "#"
                                        + " AND End <= #" + dateEndTo.Value.Year + "-" + dateEndTo.Value.Month + "-" + dateEndTo.Value.Day + "#";
            }

            masRent = new object[museumRents.Count, 2];

            for (int i = 0; i < museumRents.Count; i++)
            {
                string str = "С ";
                if (((DateTime)museumRents[i]["Start"]).Day < 10)
                    str += "0";
                str += ((DateTime)museumRents[i]["Start"]).Day.ToString() + ".";

                if (((DateTime)museumRents[i]["Start"]).Month < 10)
                    str += "0";
                str += ((DateTime)museumRents[i]["Start"]).Month.ToString() + "." + ((DateTime)museumRents[i]["Start"]).Year.ToString() + " по ";

                if (((DateTime)museumRents[i]["End"]).Day < 10)
                    str += "0";
                str += ((DateTime)museumRents[i]["End"]).Day.ToString() + ".";

                if (((DateTime)museumRents[i]["End"]).Month < 10)
                    str += "0";
                str += ((DateTime)museumRents[i]["End"]).Month.ToString() + "." + ((DateTime)museumRents[i]["End"]).Year.ToString();

                masRent[i, 0] = museumRents[i]["ID"];
                masRent[i, 1] = str;

                RentListBox.Items.Add(str);
            }
        }
        private void SetControlDefault()
        {
            canDoEnything = false;
            museumtenantComboBox.Enabled = false;
            rentStart.Enabled = false; rentStart.Value = DateTime.Now;
            rentEnd.Enabled = false; rentEnd.Value = DateTime.Now;
            saveButton.Enabled = false;
        }

        private void Rent_FormClosed(object sender, FormClosedEventArgs e)
        {
            ExW.Enabled = true;
        }

        ///////////////////////////////////////////////////////////////////
        private void DateStartFrom_ValueChanged(object sender, EventArgs e)
        {
            dateStartTo.MinDate = dateStartFrom.Value;
            if (FilterByStartTime.Checked)
                setExhibitListBox();
        }
        private void DateStartTo_ValueChanged(object sender, EventArgs e)
        {
            dateStartFrom.MaxDate = dateStartTo.Value;
            if (FilterByStartTime.Checked)
                setExhibitListBox();
        }

        private void DateEndFrom_ValueChanged(object sender, EventArgs e)
        {
            dateEndTo.MinDate = dateEndFrom.Value;
            if (FilterByEndTime.Checked)
                setExhibitListBox();
        }
        private void DateEndTo_ValueChanged(object sender, EventArgs e)
        {
            dateEndFrom.MaxDate = dateEndTo.Value;
            if (FilterByEndTime.Checked)
                setExhibitListBox();
        }
        ///////////////////////////////////////////////////////////////////

        private void RentStart_ValueChanged(object sender, EventArgs e)
        {
            rentEnd.MinDate = rentStart.Value;
            saveButton.Enabled = true;
        }
        private void RentEnd_ValueChanged(object sender, EventArgs e)
        {
            rentStart.MaxDate = rentEnd.Value;
            saveButton.Enabled = true;
        }

        private void FilterByStartTime_CheckedChanged(object sender, EventArgs e)
        {
            if (canChooseAnyMuseum)
            {
                canDoEnything = true;
                museumtenantComboBox.Enabled = true;
                rentStart.Enabled = true;
                rentEnd.Enabled = true;
                setExhibitListBox();
            }
        }
        private void FilterByEndTime_CheckedChanged(object sender, EventArgs e)
        {
            if (canChooseAnyMuseum)
            {
                canDoEnything = true;
                museumtenantComboBox.Enabled = true;
                rentStart.Enabled = true;
                rentEnd.Enabled = true;
                setExhibitListBox();
            }
        }

        private void RentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            rentIndex = (int)masRent[RentListBox.SelectedIndex,0];

            museumtenantComboBox.DataSource = dataset.Museum;
            museumtenantComboBox.DisplayMember = "Name";
            museumtenantComboBox.ValueMember = "ID";

            ExhibitCombo.DataSource = dataset.Exhibit;
            ExhibitCombo.DisplayMember = "Name";
            ExhibitCombo.ValueMember = "ID";

            rentStart.MinDate = DateTimePicker.MinimumDateTime;
            rentStart.MaxDate = DateTimePicker.MaximumDateTime;

            rentEnd.MinDate = DateTimePicker.MinimumDateTime;
            rentEnd.MaxDate = DateTimePicker.MaximumDateTime;
            
            museumtenantComboBox.SelectedValue = dataset.Rent.Rows.Find(rentIndex)["MuseumID"];
            rentStart.Value = (DateTime)dataset.Rent.Rows.Find(rentIndex)["Start"];
            rentEnd.Value = (DateTime)dataset.Rent.Rows.Find(rentIndex)["End"];
            ExhibitCombo.SelectedValue = dataset.Rent.Rows.Find(rentIndex)["ExhibitID"];
        }

        private void MuseumtenantComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = true;
        }

        private void ExhibitCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            DataView tempView = new DataView(dataset.Rent);
            tempView.RowFilter = "ExhibitID = " + ExhibitCombo.SelectedValue;
            for (int i = 0; i < tempView.Count; i++)
            {
                DateTime temp1 = (DateTime)tempView[i]["Start"];
                DateTime temp2 = (DateTime)tempView[i]["End"];
                int tempInt = (int)tempView[i]["ID"];
                int tempExhibitID = (int)tempView[i]["ExhibitID"];
                if (temp1 <= rentStart.Value && temp2 >= rentStart.Value || temp1 <= rentEnd.Value && temp2 >= rentEnd.Value)
                {
                    if (tempInt != rentIndex)
                    {
                        CFunc.ShowMessage("В указанный период данный экспонат находится в аренде в музее '" + dataset.Museum.Rows.Find(tempView[i]["MuseumID"])["Name"] + "'!!!");
                        return;
                    }
                }
            }

            dataset.Rent.Rows.Find(rentIndex)["MuseumID"] = museumtenantComboBox.SelectedValue;
            dataset.Rent.Rows.Find(rentIndex)["Start"] = rentStart.Value;
            dataset.Rent.Rows.Find(rentIndex)["End"] = rentEnd.Value;
            dataset.Rent.Rows.Find(rentIndex)["ExhibitID"] = ExhibitCombo.SelectedValue;

            saveButton.Enabled = false;
            setExhibitListBox();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (rentIndex != 0)
                dataset.Rent.Rows.Find(rentIndex).Delete();
            else
                CFunc.ShowMessage("Выберите сначала период аренды с интересующим экспонатом!!!");
        }
    }
}
