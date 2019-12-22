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
        ControlFunction CFunc;

        int indexRestorer = 0;
        int indexExhibit = 0;

        bool CanChooseRestorer = false;
        bool CanChooseExhibit = false;

        public RestorationAdd(Restoration tempRestorationWindow, ref DataSetMuseum tempDataset, ref ControlFunction tempControlFunction)
        {
            InitializeComponent();
            RW = tempRestorationWindow;
            dataset = tempDataset;
            CFunc = tempControlFunction;

            RestorationRestorerComboBox.DataSource = dataset.Restorer;
            RestorationRestorerComboBox.DisplayMember = "Name";
            RestorationRestorerComboBox.ValueMember = "ID";

            comboBoxExhibit.DataSource = dataset.Exhibit;
            comboBoxExhibit.DisplayMember = "Name";
            comboBoxExhibit.ValueMember = "ID";

            CanChooseRestorer = true;
            CanChooseExhibit = true;
        }

        private void SetPhotoButton_Click(object sender, EventArgs e)
        {
            getAndCopyPicture();
        }
        private void getAndCopyPicture()
        {
            photoFilePath = CFunc.GetPicturePath();
            if (photoFilePath != "NOTHING")
            {
                photoPictureBox.Image = Image.FromFile(photoFilePath);
            }
        }
        
        private void SaveNewRestorationButton_Click(object sender, EventArgs e)
        {
            CreateNewRestorer();
            Exit();
        }
        private void CreateNewRestorer()
        {
            var newExhibit = dataset.Restoration.NewRow();

            if (indexRestorer == 0)
            {
                CFunc.ShowMessage("Выберите реставратора!");
                return;
            }
            newExhibit["RestorerID"] = RestorationRestorerComboBox.SelectedValue;

            if (indexExhibit == 0)
            {
                CFunc.ShowMessage("Выберите экспонат!");
                return;
            }
            newExhibit["ExhibitID"] = comboBoxExhibit.SelectedValue;

            newExhibit["Start"] = RestorationStart.Value;
            newExhibit["End"] = RestorationEnd.Value;

            if (photoFilePath == "NOTHING")
            {
                CFunc.ShowMessage("Выберите фотографию!");
                return;
            }
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

        private void RestorationRestorerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CanChooseRestorer)
            {
                indexRestorer = (int)RestorationRestorerComboBox.SelectedValue;
            }
        }
        private void ComboBoxExhibit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CanChooseExhibit)
            {
                indexExhibit = (int)comboBoxExhibit.SelectedValue;
            }
        }

        private void RestorationStart_ValueChanged(object sender, EventArgs e)
        {
            RestorationEnd.MinDate = RestorationStart.Value;
        }
    }
}
