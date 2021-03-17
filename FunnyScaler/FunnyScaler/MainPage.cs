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

namespace FunnyScaler
{
    public partial class MainPage : Form
    {
        FormFunctions mainFF;

        public MainPage()
        {
            InitializeComponent();
            mainFF = new FormFunctions();
            mainFF.Init(outputPathLabel,
                inputPathLabel, 
                errorProvider,
                inpuDirButton,
                outputDirButton,
                inputPicture
                );
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //; // do not delete
        }
        private void button1_Click(object sender, EventArgs e) => mainFF.SelectFileOnClick();
        private void outputDirButton_Click(object sender, EventArgs e) => mainFF.SelectOutputOnClick();
        private void upscaleButton_Click(object sender, EventArgs e) => mainFF.UpscaleOnClick();
    }
}
