namespace FunnyScaler
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        
        // watch me
        // edit it anyway lolololololooolololol epic failed (rekt)
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageUpscaler = new System.Windows.Forms.TabPage();
            this.inputPathLabel = new System.Windows.Forms.TextBox();
            this.lengthSelect = new System.Windows.Forms.RadioButton();
            this.heightSelect = new System.Windows.Forms.RadioButton();
            this.textPx = new System.Windows.Forms.Label();
            this.textOutputResolution = new System.Windows.Forms.Label();
            this.pixelSize = new System.Windows.Forms.TextBox();
            this.upscaleButton = new System.Windows.Forms.Button();
            this.outputDirButton = new System.Windows.Forms.Button();
            this.inpuDirButton = new System.Windows.Forms.Button();
            this.textOutputImage = new System.Windows.Forms.Label();
            this.outputPicture = new System.Windows.Forms.PictureBox();
            this.textArrow = new System.Windows.Forms.Label();
            this.textInputImage = new System.Windows.Forms.Label();
            this.inputPicture = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.outputPathLabel = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageUpscaler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageUpscaler);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(735, 460);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageUpscaler
            // 
            this.tabPageUpscaler.Controls.Add(this.outputPathLabel);
            this.tabPageUpscaler.Controls.Add(this.inputPathLabel);
            this.tabPageUpscaler.Controls.Add(this.lengthSelect);
            this.tabPageUpscaler.Controls.Add(this.heightSelect);
            this.tabPageUpscaler.Controls.Add(this.textPx);
            this.tabPageUpscaler.Controls.Add(this.textOutputResolution);
            this.tabPageUpscaler.Controls.Add(this.pixelSize);
            this.tabPageUpscaler.Controls.Add(this.upscaleButton);
            this.tabPageUpscaler.Controls.Add(this.outputDirButton);
            this.tabPageUpscaler.Controls.Add(this.inpuDirButton);
            this.tabPageUpscaler.Controls.Add(this.textOutputImage);
            this.tabPageUpscaler.Controls.Add(this.outputPicture);
            this.tabPageUpscaler.Controls.Add(this.textArrow);
            this.tabPageUpscaler.Controls.Add(this.textInputImage);
            this.tabPageUpscaler.Controls.Add(this.inputPicture);
            this.tabPageUpscaler.Location = new System.Drawing.Point(4, 25);
            this.tabPageUpscaler.Name = "tabPageUpscaler";
            this.tabPageUpscaler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpscaler.Size = new System.Drawing.Size(727, 431);
            this.tabPageUpscaler.TabIndex = 0;
            this.tabPageUpscaler.Text = "Upscaler";
            this.tabPageUpscaler.UseVisualStyleBackColor = true;
            // 
            // inputPathLabel
            // 
            this.inputPathLabel.Location = new System.Drawing.Point(6, 44);
            this.inputPathLabel.Name = "inputPathLabel";
            this.inputPathLabel.Size = new System.Drawing.Size(265, 22);
            this.inputPathLabel.TabIndex = 15;
            // 
            // lengthSelect
            // 
            this.lengthSelect.AutoSize = true;
            this.lengthSelect.Location = new System.Drawing.Point(195, 401);
            this.lengthSelect.Name = "lengthSelect";
            this.lengthSelect.Size = new System.Drawing.Size(65, 21);
            this.lengthSelect.TabIndex = 14;
            this.lengthSelect.TabStop = true;
            this.lengthSelect.Text = "Width";
            this.lengthSelect.UseVisualStyleBackColor = true;
            // 
            // heightSelect
            // 
            this.heightSelect.AutoSize = true;
            this.heightSelect.Location = new System.Drawing.Point(195, 374);
            this.heightSelect.Name = "heightSelect";
            this.heightSelect.Size = new System.Drawing.Size(70, 21);
            this.heightSelect.TabIndex = 13;
            this.heightSelect.TabStop = true;
            this.heightSelect.Text = "Height";
            this.heightSelect.UseVisualStyleBackColor = true;
            // 
            // textPx
            // 
            this.textPx.AutoSize = true;
            this.textPx.Location = new System.Drawing.Point(167, 378);
            this.textPx.Name = "textPx";
            this.textPx.Size = new System.Drawing.Size(22, 17);
            this.textPx.TabIndex = 12;
            this.textPx.Text = "px";
            // 
            // textOutputResolution
            // 
            this.textOutputResolution.AutoSize = true;
            this.textOutputResolution.Location = new System.Drawing.Point(6, 373);
            this.textOutputResolution.Name = "textOutputResolution";
            this.textOutputResolution.Size = new System.Drawing.Size(117, 17);
            this.textOutputResolution.TabIndex = 11;
            this.textOutputResolution.Text = "Output resolution";
            // 
            // pixelSize
            // 
            this.pixelSize.Location = new System.Drawing.Point(123, 373);
            this.pixelSize.Name = "pixelSize";
            this.pixelSize.Size = new System.Drawing.Size(38, 22);
            this.pixelSize.TabIndex = 10;
            // 
            // upscaleButton
            // 
            this.upscaleButton.Location = new System.Drawing.Point(318, 89);
            this.upscaleButton.Name = "upscaleButton";
            this.upscaleButton.Size = new System.Drawing.Size(86, 28);
            this.upscaleButton.TabIndex = 9;
            this.upscaleButton.Text = "Upscale!";
            this.upscaleButton.UseVisualStyleBackColor = true;
            // 
            // outputDirButton
            // 
            this.outputDirButton.Location = new System.Drawing.Point(455, 14);
            this.outputDirButton.Name = "outputDirButton";
            this.outputDirButton.Size = new System.Drawing.Size(266, 28);
            this.outputDirButton.TabIndex = 6;
            this.outputDirButton.Text = "Select output directory";
            this.outputDirButton.UseVisualStyleBackColor = true;
            this.outputDirButton.Click += new System.EventHandler(this.outputDirButton_Click);
            // 
            // inpuDirButton
            // 
            this.inpuDirButton.Location = new System.Drawing.Point(6, 15);
            this.inpuDirButton.Name = "inpuDirButton";
            this.inpuDirButton.Size = new System.Drawing.Size(265, 27);
            this.inpuDirButton.TabIndex = 5;
            this.inpuDirButton.Text = "Select input file";
            this.inpuDirButton.UseVisualStyleBackColor = true;
            this.inpuDirButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textOutputImage
            // 
            this.textOutputImage.AutoSize = true;
            this.textOutputImage.Location = new System.Drawing.Point(549, 66);
            this.textOutputImage.Name = "textOutputImage";
            this.textOutputImage.Size = new System.Drawing.Size(93, 17);
            this.textOutputImage.TabIndex = 4;
            this.textOutputImage.Text = "Output Image";
            // 
            // outputPicture
            // 
            this.outputPicture.Location = new System.Drawing.Point(455, 89);
            this.outputPicture.Name = "outputPicture";
            this.outputPicture.Size = new System.Drawing.Size(266, 278);
            this.outputPicture.TabIndex = 3;
            this.outputPicture.TabStop = false;
            // 
            // textArrow
            // 
            this.textArrow.AutoSize = true;
            this.textArrow.Location = new System.Drawing.Point(350, 218);
            this.textArrow.Name = "textArrow";
            this.textArrow.Size = new System.Drawing.Size(22, 17);
            this.textArrow.TabIndex = 2;
            this.textArrow.Text = "→";
            // 
            // textInputImage
            // 
            this.textInputImage.AutoSize = true;
            this.textInputImage.Location = new System.Drawing.Point(80, 66);
            this.textInputImage.Name = "textInputImage";
            this.textInputImage.Size = new System.Drawing.Size(81, 17);
            this.textInputImage.TabIndex = 1;
            this.textInputImage.Text = "Input Image";
            // 
            // inputPicture
            // 
            this.inputPicture.Location = new System.Drawing.Point(6, 89);
            this.inputPicture.Name = "inputPicture";
            this.inputPicture.Size = new System.Drawing.Size(265, 278);
            this.inputPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inputPicture.TabIndex = 0;
            this.inputPicture.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(727, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // textBox1
            // 
            this.outputPathLabel.Location = new System.Drawing.Point(455, 44);
            this.outputPathLabel.Name = "textBox1";
            this.outputPathLabel.Size = new System.Drawing.Size(266, 22);
            this.outputPathLabel.TabIndex = 16;
            // 
            // MainPage
            // 
            this.AcceptButton = this.outputDirButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(737, 461);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.Text = "Funny Scaler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageUpscaler.ResumeLayout(false);
            this.tabPageUpscaler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageUpscaler;
        private System.Windows.Forms.Label textArrow;
        private System.Windows.Forms.Label textInputImage;
        private System.Windows.Forms.PictureBox inputPicture;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label textOutputImage;
        private System.Windows.Forms.PictureBox outputPicture;
        private System.Windows.Forms.Label textOutputResolution;
        private System.Windows.Forms.TextBox pixelSize;
        private System.Windows.Forms.Button upscaleButton;
        private System.Windows.Forms.Button outputDirButton;
        private System.Windows.Forms.Button inpuDirButton;
        private System.Windows.Forms.RadioButton lengthSelect;
        private System.Windows.Forms.RadioButton heightSelect;
        private System.Windows.Forms.Label textPx;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox inputPathLabel;
        private System.Windows.Forms.TextBox outputPathLabel;
    }
}

