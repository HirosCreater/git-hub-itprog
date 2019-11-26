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
using MuseumObserverLogic;

namespace MuseumObserver
{
    public partial class Restoration : Form
    {
        DataSetMuseum dataset;
        Logic logic = new Logic();

        string ComyPath = "C:\\Pictures";
        string photoFilePath;
        OpenFileDialog OPF;

        DataView exhibitCombo = null;
        DataView RestorationList = null;
        DataView RestorerMainCombo = null;
        DataView RestorerCoopCombo = null;
        int restoratorID;
        bool canChooseComboRestorer = false;
        bool canChooseListRestorerExhibit = false;

        bool canRemember = false;
        public Restoration()
        {
            InitializeComponent();

            photoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            photoPictureBox.Image = Image.FromFile("Pictures/DefaultImage.jpg");

            OPF = new OpenFileDialog();
            OPF.FilterIndex = 5;

            OPF.Filter = "Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF | All files(*.*) | *.*";
            OPF.InitialDirectory = "C:\\";

            dataset = new DataSetMuseum();
            LoadDataFromBase();

            restorerComboBox.DataSource = getRestorerMainCombo();
            restorerComboBox.DisplayMember = "Name";
            restorerComboBox.ValueMember = "ID";

            RestorationListBox.DataSource = null;
            RestorationListBox.DisplayMember = "Description";
            RestorationListBox.ValueMember = "ID";

            RestorationRestorerComboBox.DataSource = null;
            RestorationRestorerComboBox.DisplayMember = "Name";
            RestorationRestorerComboBox.ValueMember = "ID";

            comboBoxExhibit.DataSource = null;
            comboBoxExhibit.DisplayMember = "Name";
            comboBoxExhibit.ValueMember = "ID";

            canChooseComboRestorer = true;
        }

        private void restorerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (canChooseComboRestorer)
            {
                canChooseComboRestorer = false;
                canChooseListRestorerExhibit = false;
                canRemember = false;
                setRestoratorsExhibits();

                canChooseComboRestorer = true;
                canChooseListRestorerExhibit = true;
            }
        }
        private void setRestoratorsExhibits() //вывод экспонатов на реставрации у конкретного реставратора
        {
            SetDefaultRestorationControls();
            restoratorID = (int)restorerComboBox.SelectedValue;
            DataRow tempRowRestorer = dataset.Restorer.Rows.Find(restoratorID);
            //Наложение фильтров на exhibitListBox
            {
                DataView tempRestoration = new DataView(dataset.Restoration);
                DataView tempExhibitRestorer = new DataView(dataset.Exhibit);

                tempRestoration.RowFilter = "RestorerID = " + restoratorID;
                if (tempRestoration.Count != 0)
                {
                    string filterExhibit = "ExhibitID = " + tempRestoration[0][0];
                    if (TimeFilterCheckBox.Checked)
                    {
                        filterExhibit += "AND Start >= #" + appearanceDateFrom.Value.Year + "-" + appearanceDateFrom.Value.Month + "-" + appearanceDateFrom.Value.Day
                                            + "#AND End <= #" + +appearanceDateTo.Value.Year + "-" + appearanceDateTo.Value.Month + "-" + appearanceDateTo.Value.Day + "#";
                    }

                    SetDataViewFilter(getRestorationList(), filterExhibit);
                    RestorationListBox.DataSource = getRestorationList();
                }
                else { RestorationListBox.DataSource = null; }
            }

        }

        private void ExhibitListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (canChooseListRestorerExhibit)
            {
                canRemember = true;
                setRestorationExhibitData();
            }
        }
        private void setRestorationExhibitData() //вывод данных реставрации по данному экспонату
        {
            RestorationRestorerComboBox.DataSource = getRestorerCoopCombo();
            RestorationListBox.DataSource = getRestorationList();
            comboBoxExhibit.DataSource = getExhibitCombo();

            DataRow tempRowExhibitRestoration = dataset.Restoration.Rows.Find(RestorationListBox.SelectedValue);

            //DataRow tempRowExhibit = dataset.Exhibit.Rows.Find(dataset.Restoration.Rows.Find(restoratorID)["ExhibitID"]);

            //Вывод экспоната и реставратора
            {
                RestorationRestorerComboBox.DataSource = getRestorerCoopCombo();
                RestorationRestorerComboBox.SelectedValue = restoratorID;
                comboBoxExhibit.DataSource = getExhibitCombo();
                comboBoxExhibit.SelectedValue = tempRowExhibitRestoration["ExhibitID"];
            }
            //вывод дат реставрации
            {
                RestorationStart.Value = (DateTime)tempRowExhibitRestoration["Start"];
                RestorationEnd.Value = (DateTime)tempRowExhibitRestoration["End"];
            }
            //вывод фото
            {
                string str = tempRowExhibitRestoration["Photo"].ToString();
                if (File.Exists(str))
                {
                    photoPictureBox.Image = Image.FromFile(str);
                }
                else
                {
                    photoPictureBox.Image = Image.FromFile("Pictures/ImageNotFound.jpg");
                }
            }
            //Вывод описания экспоната
            {
                descriptionTextBox.Text = (string)tempRowExhibitRestoration["Description"];
            }
        }
        private void TimeFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            canChooseListRestorerExhibit = false;
            setRestoratorsExhibits();
            canChooseListRestorerExhibit = true;
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
            dataset.Restoration.Rows.Find(RestorationListBox.SelectedValue)["Photo"] = filename;
        }

        private void RememberChangesButton_Click(object sender, EventArgs e)
        {
            if (canRemember)
            {
                canChooseListRestorerExhibit = false;
                RememberChenged();
                canChooseListRestorerExhibit = true;
            }
        }
        private void RememberChenged()
        {
            int restorationID = (int)RestorationListBox.SelectedValue;

            dataset.Restoration.Rows.Find(restorationID)["ExhibitID"] = RestorationRestorerComboBox.SelectedValue;
            dataset.Restoration.Rows.Find(restorationID)["RestorerID"] = comboBoxExhibit.SelectedValue;
            dataset.Restoration.Rows.Find(restorationID)["Start"] = RestorationStart.Value;
            dataset.Restoration.Rows.Find(restorationID)["End"] = RestorationEnd.Value;
            dataset.Restoration.Rows.Find(restorationID)["Photo"] = photoFilePath;
            dataset.Restoration.Rows.Find(restorationID)["Description"] = descriptionTextBox.Text;
            getRestorationList() = new DataView(dataset.Restoration);
        }


        private void LoadDataFromBase()
        {
            dataset = new DataSetMuseum();
            dataset.Merge(logic.getRestorer());
            dataset.Merge(logic.getRestoration());
            dataset.Merge(logic.getExhibit());

            UpdateDataView();
        }
        private void UpdateDataView()
        {
            exhibitCombo = new DataView(dataset.Exhibit);
            RestorationList = new DataView(dataset.Restoration);
            RestorerMainCombo = new DataView(dataset.Restorer);
            RestorerCoopCombo = new DataView(dataset.Restorer);
        }
        private void SaveToDataBase()
        {
            logic.setRestorer(dataset);
            logic.setRestoration(dataset);
            logic.setExhibit(dataset);
            LoadDataFromBase();
        }

        private ref DataView getExhibitCombo()
        {
            return ref exhibitCombo;
        }
        private ref DataView getRestorationList()
        {
            return ref RestorationList;
        }
        private ref DataView getRestorerMainCombo()
        {
            return ref RestorerMainCombo;
        }
        private ref DataView getRestorerCoopCombo()
        {
            return ref RestorerCoopCombo;
        }
        private void SetDataViewFilter(DataView curentView, string strFilter)
        {
            curentView.RowFilter = strFilter;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveToDataBase();
        }
        private void SetDefaultRestorationControls()
        {
            photoPictureBox.Image = Image.FromFile("Pictures/DefaultImage.jpg");
            RestorationRestorerComboBox.DataSource = null;
            RestorationStart.Value = DateTime.Now;
            RestorationEnd.Value = DateTime.Now;
            comboBoxExhibit.DataSource = null;
            descriptionTextBox.Text = "";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            dataset.Restoration.Rows.Find(RestorationListBox.SelectedValue).Delete();
            //удаление файлов-картинок
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            /*
            this.Enabled = false;
            RestorationAdd restorationAdd = new ExhibitAdd(this, ref dataset);
            restorationAdd.Show();*/
        }
    }
}
