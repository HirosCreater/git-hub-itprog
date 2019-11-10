using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseumObserver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Showroom showroom = new Showroom();
            showroom.Show();

            /*Restoration restoration = new Restoration();
            restoration.Show();

            Exhibition exhibition = new Exhibition();
            exhibition.Show();

            Exhibit exhibit = new Exhibit();
            exhibit.Show();*/
        }
    }
}