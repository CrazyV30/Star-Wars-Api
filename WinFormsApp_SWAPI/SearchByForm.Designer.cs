namespace WinFormsApp_SWAPI
{
    partial class SearchByForm
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchByForm));
            label1 = new Label();
            comboBoxGender = new ComboBox();
            label2 = new Label();
            comboBoxHomeworld = new ComboBox();
            label3 = new Label();
            comboBoxStarship = new ComboBox();
            buttonSearch = new Button();
            listBoxCharacters = new ListBox();
            pictureBoxCharacter = new PictureBox();
            textBoxInfo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCharacter).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Gender:";
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Location = new Point(113, 11);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(151, 28);
            comboBoxGender.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 2;
            label2.Text = "Homeworld:";
            // 
            // comboBoxHomeworld
            // 
            comboBoxHomeworld.FormattingEnabled = true;
            comboBoxHomeworld.Location = new Point(113, 52);
            comboBoxHomeworld.Name = "comboBoxHomeworld";
            comboBoxHomeworld.Size = new Size(151, 28);
            comboBoxHomeworld.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 4;
            label3.Text = "Starship:";
            // 
            // comboBoxStarship
            // 
            comboBoxStarship.FormattingEnabled = true;
            comboBoxStarship.Location = new Point(113, 97);
            comboBoxStarship.Name = "comboBoxStarship";
            comboBoxStarship.Size = new Size(151, 28);
            comboBoxStarship.TabIndex = 5;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.PeachPuff;
            buttonSearch.Location = new Point(12, 141);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(252, 29);
            buttonSearch.TabIndex = 6;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // listBoxCharacters
            // 
            listBoxCharacters.FormattingEnabled = true;
            listBoxCharacters.Location = new Point(12, 187);
            listBoxCharacters.Name = "listBoxCharacters";
            listBoxCharacters.Size = new Size(252, 244);
            listBoxCharacters.TabIndex = 7;
            listBoxCharacters.SelectedIndexChanged += listBoxCharacters_SelectedIndexChanged;
            // 
            // pictureBoxCharacter
            // 
            pictureBoxCharacter.Location = new Point(281, 11);
            pictureBoxCharacter.Name = "pictureBoxCharacter";
            pictureBoxCharacter.Size = new Size(260, 420);
            pictureBoxCharacter.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCharacter.TabIndex = 8;
            pictureBoxCharacter.TabStop = false;
            // 
            // textBoxInfo
            // 
            textBoxInfo.Location = new Point(547, 11);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.ReadOnly = true;
            textBoxInfo.ScrollBars = ScrollBars.Vertical;
            textBoxInfo.Size = new Size(241, 420);
            textBoxInfo.TabIndex = 9;
            // 
            // SearchByForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxInfo);
            Controls.Add(pictureBoxCharacter);
            Controls.Add(listBoxCharacters);
            Controls.Add(buttonSearch);
            Controls.Add(comboBoxStarship);
            Controls.Add(label3);
            Controls.Add(comboBoxHomeworld);
            Controls.Add(label2);
            Controls.Add(comboBoxGender);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SearchByForm";
            Text = "SearchBy";
            Load += SearchBy_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCharacter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxGender;
        private Label label2;
        private ComboBox comboBoxHomeworld;
        private Label label3;
        private ComboBox comboBoxStarship;
        private Button buttonSearch;
        private ListBox listBoxCharacters;
        private PictureBox pictureBoxCharacter;
        private TextBox textBoxInfo;
    }
}