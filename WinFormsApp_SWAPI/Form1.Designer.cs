namespace WinFormsApp_SWAPI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBoxFilms = new ListBox();
            textBoxResult = new TextBox();
            listBoxCharacters = new ListBox();
            pictureBox1 = new PictureBox();
            button_SlideShow = new Button();
            checkBoxCacheImage = new CheckBox();
            buttonPDF = new Button();
            comboBox1 = new ComboBox();
            buttonSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBoxFilms
            // 
            listBoxFilms.BackColor = SystemColors.Window;
            listBoxFilms.FormattingEnabled = true;
            listBoxFilms.ItemHeight = 22;
            listBoxFilms.Location = new Point(16, 61);
            listBoxFilms.Margin = new Padding(4, 5, 4, 5);
            listBoxFilms.Name = "listBoxFilms";
            listBoxFilms.Size = new Size(231, 576);
            listBoxFilms.TabIndex = 1;
            listBoxFilms.SelectedIndexChanged += listBoxFilms_SelectedIndexChanged;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(779, 61);
            textBoxResult.Margin = new Padding(4, 5, 4, 5);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(344, 576);
            textBoxResult.TabIndex = 2;
            // 
            // listBoxCharacters
            // 
            listBoxCharacters.FormattingEnabled = true;
            listBoxCharacters.ItemHeight = 22;
            listBoxCharacters.Location = new Point(254, 61);
            listBoxCharacters.Margin = new Padding(4, 5, 4, 5);
            listBoxCharacters.Name = "listBoxCharacters";
            listBoxCharacters.Size = new Size(238, 576);
            listBoxCharacters.TabIndex = 3;
            listBoxCharacters.SelectedIndexChanged += listBoxCharacters_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(502, 61);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 577);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button_SlideShow
            // 
            button_SlideShow.BackColor = Color.Aquamarine;
            button_SlideShow.Location = new Point(500, 20);
            button_SlideShow.Margin = new Padding(4);
            button_SlideShow.Name = "button_SlideShow";
            button_SlideShow.Size = new Size(270, 32);
            button_SlideShow.TabIndex = 5;
            button_SlideShow.Text = "SlideShow";
            button_SlideShow.UseVisualStyleBackColor = false;
            button_SlideShow.Click += button_SlideShow_Click;
            // 
            // checkBoxCacheImage
            // 
            checkBoxCacheImage.AutoSize = true;
            checkBoxCacheImage.Font = new Font("Calibri", 11F, FontStyle.Italic);
            checkBoxCacheImage.Location = new Point(986, 24);
            checkBoxCacheImage.Margin = new Padding(4);
            checkBoxCacheImage.Name = "checkBoxCacheImage";
            checkBoxCacheImage.Size = new Size(139, 27);
            checkBoxCacheImage.TabIndex = 6;
            checkBoxCacheImage.Text = "Cache Images";
            checkBoxCacheImage.UseVisualStyleBackColor = true;
            checkBoxCacheImage.CheckedChanged += checkBoxCacheImage_CheckedChanged;
            // 
            // buttonPDF
            // 
            buttonPDF.BackColor = Color.Khaki;
            buttonPDF.Location = new Point(254, 20);
            buttonPDF.Margin = new Padding(4);
            buttonPDF.Name = "buttonPDF";
            buttonPDF.Size = new Size(238, 32);
            buttonPDF.TabIndex = 7;
            buttonPDF.Text = "Generate PDF";
            buttonPDF.UseVisualStyleBackColor = false;
            buttonPDF.Click += buttonPDF_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(17, 22);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(230, 30);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.LightCyan;
            buttonSearch.Location = new Point(779, 22);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(200, 29);
            buttonSearch.TabIndex = 9;
            buttonSearch.Text = "Search Character By";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1138, 660);
            Controls.Add(buttonSearch);
            Controls.Add(comboBox1);
            Controls.Add(buttonPDF);
            Controls.Add(checkBoxCacheImage);
            Controls.Add(button_SlideShow);
            Controls.Add(pictureBox1);
            Controls.Add(listBoxCharacters);
            Controls.Add(textBoxResult);
            Controls.Add(listBoxFilms);
            Font = new Font("Calibri", 11F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Star Wars";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBoxFilms;
        private TextBox textBoxResult;
        private ListBox listBoxCharacters;
        private PictureBox pictureBox1;
        private Button button_SlideShow;
        private CheckBox checkBoxCacheImage;
        private Button buttonPDF;
        private ComboBox comboBox1;
        private Button buttonSearch;
    }
}
