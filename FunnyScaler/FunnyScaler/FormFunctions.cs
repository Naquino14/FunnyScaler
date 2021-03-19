using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace FunnyScaler
{
    public class FormFunctions
    {
        private string[] extensions = new string[15]; // length not index
        /// <summary>
        /// Supported extensions:
        /// 0 jpg | jpegs
        /// 1 jpeg
        /// 2 jpe
        /// 3 jfif
        /// 4 exif
        /// 5 png | png
        /// 6 bmp | bitmaps
        /// 7 dib 
        /// 8 rle
        /// 9 tiff | tiff
        /// 10 tif
        /// 11 gif
        /// 12 tga
        /// 13 heic
        /// 14 webp
        /// </summary>

        public string targetFileStringR;
        public Image targetImageR;
        private Bitmap targetBitmap;
        public string targetFileStringW;
        public Image TargetImageW;

        public int converterQualitySetting = 95;

        public static bool isError = false;

        public enum OutputType
        {
            png,
            jpg

        }
        public OutputType outputType;
        public FileStream outputFileStream;

        public string trainingPath;
        public FileStream trainingFileStream;

        OpenFileDialog openFileDialog = new OpenFileDialog();
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

        // migrate stuff from MainPage.cs
        private TextBox outputPathLabel;
        private TextBox inputPathLabel;
        private ErrorProvider errorProvider;
        private Button inputDirButton;
        private Button outputDirButton;
        private PictureBox inputPicture;
        private TextBox trainingPathLabel;
        private Button trainingDirButton;
        private Button detectGPUButton;
        private CheckBox useGPUCheckbox;
        private Button helpButton;

        private bool saveLocationSelected = false;

        public void Init(
            TextBox OPL, 
            TextBox IPL, 
            ErrorProvider EPV, 
            Button IDB, 
            Button ODB, 
            PictureBox IPB, 
            TextBox TPL,
            Button TDB,
            Button DGB,
            CheckBox UGT,
            Button HBT
            )
        {
            InitExtensionArray();

            outputPathLabel = OPL;
            outputPathLabel.ReadOnly = true; // force on
            inputPathLabel = IPL;
            inputPathLabel.ReadOnly = true; // force on
            errorProvider = EPV;
            inputDirButton = IDB;
            outputDirButton = ODB;
            inputPicture = IPB;
            trainingPathLabel = TPL;
            trainingPathLabel.ReadOnly = true;
            trainingDirButton = TDB;
            detectGPUButton = DGB;
            useGPUCheckbox = UGT;
            helpButton = HBT;
        }

        public void InitExtensionArray()
        {
            extensions[0] = "jpg";
            extensions[1] = "jpeg";
            extensions[2] = "jpe";
            extensions[3] = "jfif";
            extensions[4] = "exif";
            extensions[5] = "png";
            extensions[6] = "bmp";
            extensions[7] = "dib";
            extensions[8] = "rle";
            extensions[9] = "tiff";
            extensions[10] = "tif";
            extensions[11] = "gif";
            extensions[12] = "tga";
            extensions[13] = "heic";
            extensions[14] = "webp";
        }


        public void SelectFileOnClick()
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputPathLabel.Text = openFileDialog.FileName; // says file name but its the path
                    string extension = openFileDialog.FileName.Split('.')[1];
                    extension.ToLower();
                    bool moveAlong = false;
                    foreach (string _extensions in extensions)
                        if (_extensions == extension)
                            moveAlong = true;
                    if (!moveAlong)
                    {
                        // open dialog saying invalid file type
                        errorProvider.SetError(inputDirButton, "Invalid File Type.");
                        isError = true;
                    }
                    else if (moveAlong)
                    {
                        targetFileStringR = openFileDialog.FileName;
                        errorProvider.SetError(inputDirButton, null);
                        isError = false;
                        Image imageRead = Image.FromFile(targetFileStringR);
                        inputPicture.Image = imageRead;
                        // ok so preferably wanna process these as png
                        targetImageR = ConvertToPng(imageRead);

                    }

                    // onsuccess dispose useless info
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SelectOutputOnClick()
        {
            try
            {
                saveFileDialog.Filter = "Jpeg Image (*.jpg)|*.jpg|Png Image (*.png)|*.png";
                saveFileDialog.DefaultExt = ".jpg";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.Title = "Select output file name and location.";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (saveFileDialog.FileName != "")
                    {
                        FileStream fileStream = (FileStream)saveFileDialog.OpenFile(); // cast is not redundant

                        // case switch for filetypes
                        switch (saveFileDialog.FilterIndex)
                        {
                            case 1: // v handy
                                outputType = OutputType.png;
                                break;
                            case 2:
                                outputType = OutputType.jpg;
                                break;

                        }
                        outputFileStream = fileStream;
                        targetFileStringW = saveFileDialog.FileName;
                        outputPathLabel.Text = targetFileStringW;
                        string _name = saveFileDialog.FileName.Split('\\')[saveFileDialog.FileName.Split('\\').Length - 1]; // LMAOOOOO
                        saveLocationSelected = true;
                        MessageBox.Show("Set save location for: " + _name + ".", "Set Location.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } // DO NOT CLOSE FILESTREAM HERE!
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpscaleOnClick()
        {
            if (!saveLocationSelected)
            {
                MessageBox.Show("Select a save Location!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProvider.SetError(outputDirButton, "Set a save location!");
                return;
            }
            // do stuff
        }

        private Image ConvertToPng(Image input) // tbh this prob doesnt do anything
        {
            try // convert to jpeg. idk if this will work properly
            {
                Bitmap output = new Bitmap(input.Width, input.Height); // this is ok
                Graphics graphic = Graphics.FromImage(output);
                graphic.DrawImage(input, new Rectangle(0, 0, input.Width, input.Height), 0, 0, input.Width, input.Height, GraphicsUnit.Pixel);

                graphic.Dispose();

                // do not dispose parameter
                return output;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
        }

        public void HelpOnClick() => Process.Start("https://github.com/Naquino14/FunnyScaler");

        public void TrainingPathOnClick()
        {
            // open dialog for the path and store it as a filestream? and a path
            try
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    trainingPath = folderBrowserDialog.SelectedPath;
                    trainingPathLabel.Text = trainingPath;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OnFinish() // pub for now
        {
            // finished ai.
            try
            {
                // saving
                if (!isError)
                {
                    if (TargetImageW == null)
                    {
                        MessageBox.Show("Target Image is null, no further info. @MainPage.cs OnFinish() L?", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (outputType == OutputType.png)
                        TargetImageW.Save(outputFileStream, ImageFormat.Png);
                    if (outputType == OutputType.jpg)
                        TargetImageW.Save(outputFileStream, ImageFormat.Jpeg);

                    outputFileStream.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
