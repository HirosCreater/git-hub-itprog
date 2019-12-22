using MuseumObserverLogic;

using System.IO;
using System.Windows.Forms;

namespace MuseumObserver
{
    public class ControlFunction
    {
        private OpenFileDialog OPF;
        private string ComyPath = "C:\\Pictures";
        private string nothing = "NOTHING";
        string photoFilePath;
        Exhibit ExW;
        Museum MusW;
        Maecenas MaecW;
        Showroom ShowW;
        Restorer RestorerW;
        ExhibitAdd ExAddW;
        public ControlFunction()
        {
            OPF = new OpenFileDialog();
            OPF.FilterIndex = 1;

            OPF.Filter = "Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF | All files(*.*) | *.*";
            OPF.InitialDirectory = "C:\\";
        }

        public string GetPicturePath()
        {
            photoFilePath = "";
            int newFileName = 0;

            if (OPF.ShowDialog() == DialogResult.Cancel)
                return nothing;
            photoFilePath = ComyPath + "\\" + Path.GetFileName(OPF.FileName);

                if (!File.Exists("C:\\Pictures\\" + Path.GetFileName(OPF.FileName).Split('.')))
                {
                    while (true)
                    {
                        if (System.IO.File.Exists(photoFilePath))
                        {
                            newFileName++;
                            photoFilePath = ComyPath + "\\" + Path.GetFileName(OPF.FileName).Split('.')[0] + " - Копия" + newFileName + "." + Path.GetFileName(OPF.FileName).Split('.')[1];
                        }
                        else
                            break;
                    }

                    File.Copy(OPF.FileName, photoFilePath);
                }
            
            return photoFilePath;
        }

        public string CheckTextBox(object window, string checkStr, string showSTR)
        {
            string newSTR = "";
            //Для Exhibit
            {
                if (window.GetType() == typeof(Exhibit))
                {
                    ExW = (Exhibit)window;
                    ExW.Enabled = false;
                    if (checkStr.Trim() == "")
                    {
                        ShowMessage(showSTR);
                    }
                    ExW.Enabled = true;
                    return checkStr;
                }
            }
            //Для ExhibitAdd
            {
                if (window.GetType() == typeof(ExhibitAdd))
                {
                    ExAddW = (ExhibitAdd)window;
                    ExAddW.Enabled = false;
                    if (checkStr.Trim() == "")
                    {
                        ShowMessage(showSTR);
                    }
                    ExAddW.Enabled = true;
                    return checkStr;
                }
            }
            //Для Museum
            {
                if (window.GetType() == typeof(Museum))
                {
                    MusW = (Museum)window;
                    MusW.Enabled = false;
                    if (checkStr.Trim() == "")
                    {
                        ShowMessage(showSTR);
                    }
                    MusW.Enabled = true;
                    return checkStr;
                }
            }
            //Для Maecenas
            {
                if (window.GetType() == typeof(Maecenas))
                {
                    MaecW = (Maecenas)window;
                    MaecW.Enabled = false;
                    if (checkStr.Trim() == "")
                    {
                        ShowMessage(showSTR);
                    }
                    MaecW.Enabled = true;
                    return checkStr;
                }
            }
            //Для Showroom
            {
                if (window.GetType() == typeof(Showroom))
                {
                    ShowW = (Showroom)window;
                    ShowW.Enabled = false;
                    if (checkStr.Trim() == "")
                    {
                        ShowMessage(showSTR);
                    }
                    ShowW.Enabled = true;
                    return checkStr;
                }
            }
            //Для Restorer
            {
                if (window.GetType() == typeof(Restorer))
                {
                    RestorerW = (Restorer)window;
                    RestorerW.Enabled = false;
                    if (checkStr.Trim() == "")
                    {
                        ShowMessage(showSTR);
                    }
                    RestorerW.Enabled = true;
                    return checkStr;
                }
            }
            return newSTR;
        }
        public void ShowMessage(string showSTR)
        {
            MessageBox.Show(
                showSTR,
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }

    }
}
