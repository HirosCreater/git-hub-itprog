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
        string ComyPath = "C:\\Pictures";
        string photoFilePath;
        OpenFileDialog OPF;
        DataView tempViewDaritel;
        string tableNameDaritel;

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

            OPF = new OpenFileDialog();
            OPF.FilterIndex = 5;

            OPF.Filter = "Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF | All files(*.*) | *.*";
            OPF.InitialDirectory = "C:\\";

            radioMuseum.Checked = false;
            radioMaecenas.Checked = false;
        }

        private void SetPhotoButton_Click(object sender, EventArgs e)
        {
            getAndCopyPicture();
        }
        private void getAndCopyPicture()
        {
            string filename = "";
            int newFileName = 0;

            if (OPF.ShowDialog() == DialogResult.Cancel)
                return;
            filename = ComyPath + "\\" + Path.GetFileName(OPF.FileName);
            while (true)
            {
                if (System.IO.File.Exists(filename))
                {
                    newFileName++;
                    filename = ComyPath + "\\" + Path.GetFileName(OPF.FileName).Split('.')[0] + " - Копия" + newFileName + "." + Path.GetFileName(OPF.FileName).Split('.')[1];
                }
                else
                    break;
            }
            File.Copy(OPF.FileName, filename);
            photoFilePath = filename;
            pictureBox1.Image = Image.FromFile(photoFilePath);
        }
        private void CreateNewExhibit()
        {
            var newExhibit = dataset.Exhibit.NewRow();


            DateTime temp = appearanceDate.Value;

            newExhibit["ID"] = (int)dataset.Exhibit.Max(row => row.ID) + 1;
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
            if (tempCrutch.Count == 0)
            {
                var newRow = dataset.Crutch.NewRow();
                //int newID = (int)dataset.Crutch.Max(row => row.ID) + 1;
                //newRow["ID"] = newID;
                newRow["From"] = tableNameDaritel;
                newRow["InstanceID"] = getFromID;
                dataset.Crutch.Rows.Add(newRow);

                tempCrutch = new DataView(dataset.Crutch);
                tempCrutch.RowFilter = "[From] = '" + tableNameDaritel + "' " + "AND InstanceID = " + getFromID; ;


                newExhibit["CrutchID"] = (int)tempCrutch[0][0];
            }
            else
            {
                newExhibit["CrutchID"] = (int)tempCrutch[0][0];
            }
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
