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
    public partial class RestorationAdd : Form
    {
        Logic logic = new Logic();
        DataSetMuseum dataset;
        Restoration RW;
        bool exit = false;
        string photoFilePath;
        ControlFunction CFunc = new ControlFunction();

        public RestorationAdd(Restoration tempRestorationWindow, ref DataSetMuseum tempDataset)
        {
            InitializeComponent();
            RW = tempRestorationWindow;
            dataset = tempDataset;

            RestorationRestorerComboBox.DataSource = dataset.Restorer;
            RestorationRestorerComboBox.DisplayMember = "Name";
            RestorationRestorerComboBox.ValueMember = "ID";

            comboBoxExhibit.DataSource = dataset.Exhibit;
            comboBoxExhibit.DisplayMember = "Name";
            comboBoxExhibit.ValueMember = "ID";
        }

        private void SetPhotoButton_Click(object sender, EventArgs e)
        {
            getAndCopyPicture();
        }
        private void getAndCopyPicture()
        {
            photoFilePath = CFunc.GetPicturePath();
            photoPictureBox.Image = Image.FromFile(photoFilePath);
        }
        
        private void SaveNewRestorationButton_Click(object sender, EventArgs e)
        {
            CreateNewRestorer();
            Exit();
        }
        private void CreateNewRestorer()
        {
            var newExhibit = dataset.Restoration.NewRow();

            newExhibit["RestorerID"] = RestorationRestorerComboBox.SelectedValue;
            newExhibit["ExhibitID"] = comboBoxExhibit.SelectedValue;
            newExhibit["Start"] = RestorationStart.Value;
            newExhibit["End"] = RestorationEnd.Value;
            newExhibit["Photo"] = photoFilePath;
            newExhibit["Description"] = descriptionTextBox.Text;
            
            dataset.Restoration.Rows.Add(newExhibit);
        }
        private void RestorationAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!exit)
                Exit();
        }
        private void Exit()
        {
            exit = true;
            RW.Enabled = true;
            this.Close();
        }
    }
}
