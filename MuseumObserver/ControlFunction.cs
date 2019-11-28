using MuseumObserverLogic;

using System.IO;
using System.Windows.Forms;

namespace MuseumObserver
{
    class ControlFunction
    {
        private OpenFileDialog OPF;
        private string ComyPath = "C:\\Pictures";
        private string nothing = "NOTHING";
        string photoFilePath;
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

        public void CreateNewRow(Restoration tempRestoration, ref DataSetMuseum dataset)
        {
            
        }
    }
}
