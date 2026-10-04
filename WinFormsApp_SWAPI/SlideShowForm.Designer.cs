namespace WinFormsApp_SWAPI
{
    partial class SlideShowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlideShowForm));
            button_Stop = new Button();
            pictureBox1 = new PictureBox();
            labelName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_Stop
            // 
            button_Stop.Location = new Point(14, 13);
            button_Stop.Margin = new Padding(4);
            button_Stop.Name = "button_Stop";
            button_Stop.Size = new Size(106, 28);
            button_Stop.TabIndex = 0;
            button_Stop.Text = "Stop";
            button_Stop.UseVisualStyleBackColor = true;
            button_Stop.Click += button_Stop_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(14, 47);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(526, 599);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Calibri", 11F);
            labelName.Location = new Point(93, 659);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(71, 23);
            labelName.TabIndex = 2;
            labelName.Text = "<name>";
            // 
            // SlideShowForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 704);
            Controls.Add(labelName);
            Controls.Add(pictureBox1);
            Controls.Add(button_Stop);
            Font = new Font("Calibri", 10F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "SlideShowForm";
            Text = "SlideShowForm";
            Load += SlideShowForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Stop;
        private PictureBox pictureBox1;
        private Label labelName;
    }
}