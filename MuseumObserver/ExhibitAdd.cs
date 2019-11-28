using MuseumObserverLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseumObserver
{
    public partial class ExhibitAdd : Form
    {
        Logic logic = new Logic();
        DataSetMuseum dataset;
        Exhibit EW;
        bool exit = false;
        string photoFilePath;
        DataView tempViewDaritel;
        string tableNameDaritel;
        ControlFunction CFunc = new ControlFunction();

        public ExhibitAdd(Exhibit tempExhibitWindow, ref DataSetMuseum tempDtaset)
        {
            InitializeComponent();
            EW = tempExhibitWindow;
            dataset = tempDtaset;

            comboBoxGetFrom.DisplayMember = "Name";
            comboBoxGetFrom.ValueMember = "ID";

            comboBoxExhibitCategor.DataSource = dataset.Category;
            comboBoxExhibitCategor.DisplayMember = "Name";
            comboBoxExhibitCategor.ValueMember = "ID";

            radioMuseum.Checked = false;
            radioMaecenas.Checked = false;
        }

        private void SetPhotoButton_Click(object sender, EventArgs e)
        {
            getAndCopyPicture();
        }
        private void getAndCopyPicture()
        {
            photoFilePath = CFunc.GetPicturePath();
            pictureBox1.Image = Image.FromFile(photoFilePath);
        }

        private void CreateNewExhibit()
        {
            var newExhibit = dataset.Exhibit.NewRow();
            DateTime temp = appearanceDate.Value;

            newExhibit["Name"] = nameTextBox.Text;
            newExhibit["CategoryID"] = comboBoxExhibitCategor.SelectedValue;
            newExhibit["CreatedDate"] = createdDate.Value;
            newExhibit["AppearanceDate"] = appearanceDate.Value;
            newExhibit["Photo"] = photoFilePath;
            newExhibit["Description"] = descriptionTextBox.Text;

            int getFromID = (int)comboBoxGetFrom.SelectedValue;
            string crutchFilter = "[From] = '" + tableNameDaritel + "' " + "AND InstanceID = " + getFromID;
            DataView tempCrutch = new DataView(dataset.Crutch);
            tempCrutch.RowFilter = crutchFilter;
            newExhibit["CrutchID"] = (int)tempCrutch[0][0];

            dataset.Exhibit.Rows.Add(newExhibit);
        }
        private void SaveToDataset_Click(object sender, EventArgs e)
        {
            CreateNewExhibit();
            Exit();
        }
        private void ExhibitAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!exit)
                Exit();
        }
        private void Exit()
        {
            exit = true;
            EW.Enabled = true;
            this.Close();
        }
        private void RadioMaecenas_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMaecenas.Checked == true)
            {
                tempViewDaritel = new DataView(dataset.Maecenas);
                comboBoxGetFrom.DataSource = tempViewDaritel;
                tableNameDaritel = "Maecenas";
            }
        }
        private void RadioMuseum_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMuseum.Checked == true)
            {
                tempViewDaritel = new DataView(dataset.Museum);
                comboBoxGetFrom.DataSource = tempViewDaritel;
                tableNameDaritel = "Museum";
            }
        }
    }

}
