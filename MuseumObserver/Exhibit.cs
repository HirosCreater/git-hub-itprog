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
    public partial class Exhibit : Form
    {
        DataSetMuseum dataset;
        Logic logic = new Logic();
        bool canChooseListBox = false;
        bool canChooseCombo = false;
        DataView exhibitsCategor;
        DataView tempViewDaritel;
        string tableNameDaritel;
        int tempIDDaritel;
        bool getEnabledControl = false;

        string ComyPath = "C:\\Pictures";
        string photoFilePath;
        OpenFileDialog OPF;

        int getFromID;
        int categorID;
        bool canChooseComboBoxGetFrom = false;
        bool canChooseComboBoxExhibitCategor = false;

        bool canRemember = false;
        public Exhibit()
        {
            InitializeComponent();

            OPF = new OpenFileDialog();
            OPF.FilterIndex = 5;

            OPF.Filter = "Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF | All files(*.*) | *.*";
            OPF.InitialDirectory = "C:\\";

            ChangeActivityControl();

            dataset = new DataSetMuseum();
            LoadDataFromBase();

            exhibitsCategor = new DataView(dataset.Category);
            comboBoxExhibitCategor.DataSource = null;

            categoryComboBox.DataSource = dataset.Category;
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.ValueMember = "ID";

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile("Pictures/DefaultImage.jpg");
            canChooseListBox = true;
            canChooseCombo = true;
            canChooseComboBoxGetFrom = true;
            canChooseComboBoxExhibitCategor = true;

            /*setExhibitListBox();
            setNameTextBox();
            setCategoryTextBox();
            setDescriptionTextBox();
            setAppearanceDate();*/
        }

        private void LoadDataFromBase()
        {
            dataset = new DataSetMuseum();
            dataset.Merge(logic.getCategory());
            dataset.Merge(logic.getExhibit());
            dataset.Merge(logic.getCrutch());
            dataset.Merge(logic.getMuseum());
            dataset.Merge(logic.getMaecenas());
        }

        private void SaveToDataBase()
        {
            logic.setCategory(dataset);
            logic.setCrutch(dataset);
            logic.setExhibit(dataset);

            logic.setMuseum(dataset);
            logic.setMaecenas(dataset);
            LoadDataFromBase();
        }

        private void setExhibitListBox()
        {
            SetDefaultRestorationControls();
            canChooseListBox = false;

            comboBoxExhibitCategor.DataSource = null;

            DataView exhibitView = new DataView(dataset.Exhibit);
            //DateTime timeFrom = new DateTime(appearanceDateFrom.Value.Year, appearanceDateFrom.Value.Month, appearanceDateFrom.Value.Day, 0, 0, 0);
            //DateTime timeTo = new DateTime(appearanceDateFrom.Value.Year, appearanceDateFrom.Value.Month, appearanceDateFrom.Value.Day, 0, 0, 0);
            //DateTime tempdate = dataset.Exhibit[1]["AppearanceDate"];
            if (checkBoxTimeFilter.Checked)
                exhibitView.RowFilter = "AppearanceDate >= #" + appearanceDateFrom.Value.Year + "-" + appearanceDateFrom.Value.Month + "-" + appearanceDateFrom.Value.Day
                                        + "#AND AppearanceDate <= #" + +appearanceDateTo.Value.Year + "-" + appearanceDateTo.Value.Month + "-" + appearanceDateTo.Value.Day
                                        + "#AND CategoryID = " + categoryComboBox.SelectedValue;
            if (!checkBoxTimeFilter.Checked)
                exhibitView.RowFilter = "CategoryID = " + categoryComboBox.SelectedValue;

            comboBoxExhibitCategor.DisplayMember = "Name";
            comboBoxExhibitCategor.ValueMember = "ID";

            exhibitListBox.DataSource = exhibitView;
            exhibitListBox.DisplayMember = "Name";
            exhibitListBox.ValueMember = "ID";


            comboBoxGetFrom.DisplayMember = "Name";
            comboBoxGetFrom.ValueMember = "ID";

            canChooseListBox = true;
        }

        private void setExhibitData()
        {

            DataRow tempRow = dataset.Exhibit.Rows.Find(exhibitListBox.SelectedValue);
            //Вывод названия экспоната
            {
                nameTextBox.Text = tempRow["Name"].ToString();
            }
            //Вывод дарителя экспоната
            {
                tableNameDaritel = ((string)dataset.Crutch.Rows.Find(tempRow["CrutchID"])["From"]).Trim();
                tempIDDaritel = (int)dataset.Crutch.Rows.Find(tempRow["CrutchID"])["InstanceID"];
                if (tableNameDaritel == "Museum")
                {
                    radioMuseum.Checked = true;
                    tempViewDaritel = new DataView(dataset.Museum);
                    comboBoxGetFrom.DataSource = tempViewDaritel;
                    comboBoxGetFrom.SelectedValue = tempIDDaritel;
                }
                else
                {
                    if (tableNameDaritel == "Maecenas")
                    {
                        radioMaecenas.Checked = true;
                        tempViewDaritel = new DataView(dataset.Maecenas);
                        comboBoxGetFrom.DataSource = tempViewDaritel;
                        comboBoxGetFrom.SelectedValue = tempIDDaritel;
                    }
                    else
                    {
                        radioMuseum.Checked = false;
                        radioMaecenas.Checked = false;
                        tempViewDaritel = null;
                    }
                }

            }
            //Вывод категории экспоната
            {
                comboBoxExhibitCategor.DataSource = exhibitsCategor;
                comboBoxExhibitCategor.SelectedValue = categoryComboBox.SelectedValue;
            }
            //Вывод картинки экспоната
            {
                string str = dataset.Exhibit.Rows.Find(exhibitListBox.SelectedValue)["Photo"].ToString();
                if (File.Exists(str))
                {
                    pictureBox1.Image = Image.FromFile(str);
                }
                else
                {
                    pictureBox1.Image = Image.FromFile("Pictures/DefaultImage.jpg");
                }
            }
            //Вывод дат появления экспоната в музее
            {
                appearanceDate.Value = (DateTime)tempRow["AppearanceDate"];
            }
            //Вывод описания экспоната
            {
                descriptionTextBox.Text = (string)tempRow["Description"];
            }

            getFromID = (int)dataset.Crutch.Rows.Find(tempRow["CrutchID"])["InstanceID"];
            categorID = (int)tempRow["CategoryID"];

            getEnabledControl = true;
            ChangeActivityControl();
        }
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (canChooseCombo)
            {
                canChooseComboBoxExhibitCategor = false;
                canChooseCombo = false;
                setExhibitListBox();
                canChooseCombo = true;
                canChooseComboBoxExhibitCategor = true;
            }
        }
        private void exhibitListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (canChooseListBox)
            {
                canChooseListBox = false;
                canRemember = true;
                canChooseComboBoxGetFrom = false;
                canChooseComboBoxExhibitCategor = false;
                setExhibitData();
                canChooseComboBoxGetFrom = true;
                canChooseComboBoxExhibitCategor = true;

                canChooseListBox = true;
            }
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
            dataset.Exhibit.Rows.Find(exhibitListBox.SelectedValue)["Photo"] = filename;
        }
        private void RadioMecenat_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMaecenas.Checked == true)
            {
                tempViewDaritel = new DataView(dataset.Maecenas);
                comboBoxGetFrom.DataSource = tempViewDaritel;
                if (tableNameDaritel == "Maecenas")
                {
                    comboBoxGetFrom.SelectedValue = tempIDDaritel;
                }
            }
        }

        private void RadioMuseum_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMuseum.Checked == true)
            {
                tempViewDaritel = new DataView(dataset.Museum);
                comboBoxGetFrom.DataSource = tempViewDaritel;
                if (tableNameDaritel == "Museum")
                {
                    comboBoxGetFrom.SelectedValue = tempIDDaritel;
                }
            }
        }

        private void AppearanceDateFrom_ValueChanged(object sender, EventArgs e)
        {
            setExhibitListBox();
        }

        private void AppearanceDateTo_ValueChanged(object sender, EventArgs e)
        {
            setExhibitListBox();
        }

        private void CheckBoxTimeFilter_CheckedChanged(object sender, EventArgs e)
        {
            setExhibitListBox();
        }

        private void ChangeActivityControl()
        {
            appearanceDate.Enabled = getEnabledControl;
            createdDate.Enabled = getEnabledControl;
            comboBoxGetFrom.Enabled = getEnabledControl;
            groupBox1.Enabled = getEnabledControl;
            comboBoxExhibitCategor.Enabled = getEnabledControl;
            setPhotoButton.Enabled = getEnabledControl;
            buttonRememberChenged.Enabled = getEnabledControl;
        }

        private void ButtonRememberChenged_Click(object sender, EventArgs e)
        {
            if (canRemember)
            {
                canChooseComboBoxGetFrom = false;
                canChooseComboBoxExhibitCategor = false;
                canChooseListBox = false;
                canRemember = false;
                RememberChenged();
                canChooseListBox = true;
                canChooseComboBoxGetFrom = true;
                canChooseComboBoxExhibitCategor = true;
            }
        }
        private void RememberChenged()
        {
            int exhibitID = (int)exhibitListBox.SelectedValue;
            int crutchID = (int)dataset.Exhibit.Rows.Find(exhibitID)["CrutchID"];

            string crutchFilter = "From = ";
            string fromTable = "";

            dataset.Exhibit.Rows.Find(exhibitID)["Name"] = nameTextBox.Text;
            dataset.Exhibit.Rows.Find(exhibitID)["CategoryID"] = categorID;
            dataset.Exhibit.Rows.Find(exhibitID)["CreatedDate"] = createdDate.Value;
            dataset.Exhibit.Rows.Find(exhibitID)["AppearanceDate"] = appearanceDate.Value;
            if ((string)dataset.Exhibit.Rows.Find(exhibitID)["Photo"] != photoFilePath && photoFilePath != null)
                dataset.Exhibit.Rows.Find(exhibitID)["Photo"] = photoFilePath;
            dataset.Exhibit.Rows.Find(exhibitID)["Description"] = descriptionTextBox.Text;
            if (radioMaecenas.Checked)
            {
                dataset.Crutch.Rows.Find(crutchID)["From"] = "Maecenas";
                crutchFilter += "'Maecenas' ";
                fromTable = "Maecenas";
            }
            if (radioMuseum.Checked)
            {
                dataset.Crutch.Rows.Find(crutchID)["From"] = "Museum";
                crutchFilter += "'Museum' ";
                fromTable = "Museum";
            }
            crutchFilter += "AND InstanceID = " + getFromID;
            DataView tempCrutch = new DataView(dataset.Crutch);
            tempCrutch.RowFilter = crutchFilter;
            tempCrutch.RowFilter = "From = '" + fromTable + "' " + "AND InstanceID = " + getFromID;
            dataset.Exhibit.Rows.Find(exhibitID)["CrutchID"] = (int)tempCrutch[0][0];
        }

        private void ComboBoxGetFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (canChooseComboBoxGetFrom)
                getFromID = (int)comboBoxGetFrom.SelectedValue;
        }
        private void ComboBoxExhibitCategor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (canChooseComboBoxExhibitCategor)
                categorID = (int)comboBoxExhibitCategor.SelectedValue;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            ExhibitAdd exhibitAdd = new ExhibitAdd(this, ref dataset);
            exhibitAdd.Show();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (canChooseListBox)
            {
                canChooseListBox = false;

                canChooseComboBoxGetFrom = false;
                canChooseComboBoxExhibitCategor = false;

                /*if (File.Exists(dataset.Exhibit.Rows.Find(exhibitListBox.SelectedValue)["Photo"].ToString()))
                    File.Delete(dataset.Exhibit.Rows.Find(exhibitListBox.SelectedValue)["Photo"].ToString());*/
                dataset.Exhibit.Rows.Find(exhibitListBox.SelectedValue).Delete();

                canChooseComboBoxGetFrom = true;
                canChooseComboBoxExhibitCategor = true;

                canChooseListBox = true;
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveToDataBase();
        }
        private void SetDefaultRestorationControls()
        {
            pictureBox1.Image = Image.FromFile("Pictures/DefaultImage.jpg");
            nameTextBox.Text = "";
            appearanceDate.Value = DateTime.Now;
            createdDate.Value = DateTime.Now;
            comboBoxGetFrom.DataSource = null;
            radioMaecenas.Checked = false;
            radioMuseum.Checked = false;
            comboBoxExhibitCategor.DataSource = null;
            descriptionTextBox.Text = "";
        }
    }
}
