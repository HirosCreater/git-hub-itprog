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


        DataView exhibitCombo = null;
        DataView RestorationList = null;
        int restoratorID;
        bool canChooseComboRestorer = false;
        bool canChooseListRestorerExhibit = false;

        bool canRemember = false;

        Exhibit ExW;
        ControlFunction CFunc;
        string photoFilePath = "";
        string EnterNameRestorations = "Введите название реставрации!";
        string ChooseNewRestorer = "Выберите реставратора!";
        string ChooseNewExhibit = "Выберите реставрируемый экспонат!";
        int indexNewRestorer = 0;
        int indexNewExhibit = 0;
        public Restoration(Exhibit tempExhibitWindow, ref DataSetMuseum tempDataset, ref ControlFunction tempConrolFunction)
        {
            InitializeComponent();

            dataset = tempDataset;
            ExW = tempExhibitWindow;
            CFunc = tempConrolFunction;
            UpdateDataView();

            photoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            photoPictureBox.Image = Image.FromFile("Pictures/DefaultImage.jpg");

            restorerComboBox.DataSource = dataset.Restorer;
            restorerComboBox.DisplayMember = "Name";
            restorerComboBox.ValueMember = "ID";

            RestorationListBox.DataSource = null;
            RestorationListBox.DisplayMember = "Name";
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
            DataRow tempRowExhibitRestoration = dataset.Restoration.Rows.Find(RestorationListBox.SelectedValue);
            
            //DataRow tempRowExhibit = dataset.Exhibit.Rows.Find(dataset.Restoration.Rows.Find(restoratorID)["ExhibitID"]);

            //Вывод названиея реставрации
            {
                RestorerNameTextBox.Text = (string)tempRowExhibitRestoration["Name"];
            }

            //Вывод экспоната и реставратора
            {
                RestorationRestorerComboBox.DataSource = null;
                RestorationRestorerComboBox.DataSource = dataset.Restorer;
                RestorationRestorerComboBox.DisplayMember = "Name";
                RestorationRestorerComboBox.ValueMember = "ID";
                RestorationRestorerComboBox.SelectedValue = tempRowExhibitRestoration["RestorerID"];

                comboBoxExhibit.DataSource = null;
                comboBoxExhibit.DataSource = dataset.Exhibit;
                comboBoxExhibit.DisplayMember = "Name";
                comboBoxExhibit.ValueMember = "ID";
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
            photoFilePath = CFunc.GetPicturePath();
            if (photoFilePath != "NOTHING")
            {
                photoPictureBox.Image = Image.FromFile(photoFilePath);
                dataset.Restoration.Rows.Find(RestorationListBox.SelectedValue)["Photo"] = photoFilePath;
            }
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
            string nameText = CFunc.CheckTextBox(this, RestorerNameTextBox.Text, EnterNameRestorations);
            if (nameText == "")
                return;
            if (indexNewRestorer == 0)
            {
                CFunc.ShowMessage(ChooseNewRestorer);
                return;
            }
            if (indexNewExhibit == 0)
            {
                CFunc.ShowMessage(ChooseNewExhibit);
                return;
            }
            if (photoFilePath != "NOTHING" || photoFilePath != null)
            {
                dataset.Exhibit.Rows.Find(restorationID)["Photo"] = photoFilePath;
                photoFilePath = "";
            }

            dataset.Restoration.Rows.Find(restorationID)["Name"] = RestorerNameTextBox.Text;
            dataset.Restoration.Rows.Find(restorationID)["ExhibitID"] = RestorationRestorerComboBox.SelectedValue;
            dataset.Restoration.Rows.Find(restorationID)["RestorerID"] = comboBoxExhibit.SelectedValue;
            dataset.Restoration.Rows.Find(restorationID)["Start"] = RestorationStart.Value;
            dataset.Restoration.Rows.Find(restorationID)["End"] = RestorationEnd.Value;
            dataset.Restoration.Rows.Find(restorationID)["Photo"] = photoFilePath;
            dataset.Restoration.Rows.Find(restorationID)["Description"] = descriptionTextBox.Text;
            getRestorationList() = new DataView(dataset.Restoration);
        }

        private void UpdateDataView()
        {
            exhibitCombo = new DataView(dataset.Exhibit);
            RestorationList = new DataView(dataset.Restoration);
        }
        private void SaveToDataBase()
        {
            ExW.SaveToDataBase();
            UpdateDataView();
        }

        private ref DataView getExhibitCombo()
        {
            return ref exhibitCombo;
        }
        private ref DataView getRestorationList()
        {
            return ref RestorationList;
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
            RestorerNameTextBox.Text = "";
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
            
            this.Enabled = false;
            RestorationAdd restorationAdd = new RestorationAdd(this, ref dataset, ref CFunc);
            restorationAdd.Show();
        }

        private void Restoration_FormClosed(object sender, FormClosedEventArgs e)
        {
            ExW.Enabled = true;
        }

        private void AppearanceDateFrom_ValueChanged(object sender, EventArgs e)
        {
            appearanceDateTo.MinDate = appearanceDateFrom.Value;
        }
    }
}
