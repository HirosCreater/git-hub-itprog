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
        public Exhibit()
        {
            InitializeComponent();

            dataset = new DataSetMuseum();
            loadDataFromBase();

            exhibitsCategor = new DataView(dataset.Category);
            comboBoxExhibitCategor.DataSource = null;

            categoryComboBox.DataSource = dataset.Category;
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.ValueMember = "ID";

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile("Pictures/DefaultImage.jpg");
            canChooseListBox = true;
            canChooseCombo = true;

            /*setExhibitListBox();
            setNameTextBox();
            setCategoryTextBox();
            setDescriptionTextBox();
            setAppearanceDate();*/
        }

        private void loadDataFromBase()
        {
            dataset = new DataSetMuseum();
            dataset.Merge(logic.getCategory());
            dataset.Merge(logic.getExhibit());
            dataset.Merge(logic.getCrutch());
            dataset.Merge(logic.getMuseum());
            dataset.Merge(logic.getMaecenas());
        }

        private void setExhibitListBox()
        {
            canChooseListBox = false;

            comboBoxExhibitCategor.DataSource = null;

            DataView exhibitView = new DataView(dataset.Exhibit);
            //DateTime timeFrom = new DateTime(appearanceDateFrom.Value.Year, appearanceDateFrom.Value.Month, appearanceDateFrom.Value.Day, 0, 0, 0);
            //DateTime timeTo = new DateTime(appearanceDateFrom.Value.Year, appearanceDateFrom.Value.Month, appearanceDateFrom.Value.Day, 0, 0, 0);
            //DateTime tempdate = dataset.Exhibit[1]["AppearanceDate"];
            exhibitView.RowFilter = "AppearanceDate >= #" + appearanceDateFrom.Value.Year + "-" + appearanceDateFrom.Value.Month + "-" +appearanceDateFrom.Value.Day
                                    + "#AND AppearanceDate <= #" + +appearanceDateTo.Value.Year + "-" + appearanceDateTo.Value.Month + "-" + appearanceDateTo.Value.Day
                                    + "#AND CategoryID = " + categoryComboBox.SelectedValue;
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
                tableNameDaritel = (string)dataset.Crutch.Rows.Find(tempRow["CrutchID"])["FROM"];
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
                        radioMecenat.Checked = true;
                        tempViewDaritel = new DataView(dataset.Maecenas);
                        comboBoxGetFrom.DataSource = tempViewDaritel;
                        comboBoxGetFrom.SelectedValue = tempIDDaritel;
                    }
                    else
                    {
                        radioMuseum.Checked = false;
                        radioMecenat.Checked = false;
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

        }
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (canChooseCombo)
            {
               
                    setExhibitListBox();
                
            }
        }
        private void exhibitListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (canChooseListBox)
            {
                setExhibitData();
            }
        }
        private void SetPhotoButton_Click(object sender, EventArgs e)
        {
            getAndCopyPicture();
        }
        private void getAndCopyPicture()
        {

        }
        private void RadioMecenat_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMecenat.Checked == true)
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
    }
}
