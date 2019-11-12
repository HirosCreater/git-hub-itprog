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
        int selectCombo = -1;
        int selectList = -1;
        public Exhibit()
        {
            InitializeComponent();

            dataset = new DataSetMuseum();
            loadDataFromBase();

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
        }

        private void setExhibitListBox()
        {
            canChooseListBox = false;
            DataView exhibitView = new DataView(dataset.Exhibit);
            exhibitView.RowFilter = "[CategoryID] = " + categoryComboBox.SelectedValue;

            exhibitListBox.DataSource = exhibitView;
            exhibitListBox.DisplayMember = "Name";
            exhibitListBox.ValueMember = "ID";
            canChooseListBox = true;
        }

        private void setExhibitData()
        {
            //Вывод названия экспоната
            {
                nameTextBox.Text = dataset.Exhibit.Rows.Find(exhibitListBox.SelectedValue)["Name"].ToString();
            }
            //Вывод категории экспоната
            {
                categoryTextBox.Text = dataset.Category.Rows.Find(categoryComboBox.SelectedValue)["Name"].ToString();
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
            //Вывод дат экспоната
            { }

        }
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (canChooseCombo)
            {
                try
                {
                    setExhibitListBox();
                }
                catch { }
            }
        }
        private void exhibitListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (canChooseListBox)
            {
                try
                {
                    setExhibitData();
                }
                catch { }
            }
        }
        private void SetPhotoButton_Click(object sender, EventArgs e)
        {
            //getAndCopyPicture();
        }
    }
}
