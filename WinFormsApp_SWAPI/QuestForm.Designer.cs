namespace WinFormsApp_SWAPI
{
    partial class QuestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestForm));
            label1 = new Label();
            textBox1 = new TextBox();
            buttonAnswer = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 30);
            label1.Name = "label1";
            label1.Size = new Size(61, 24);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.Location = new Point(16, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 32);
            textBox1.TabIndex = 1;
            // 
            // buttonAnswer
            // 
            buttonAnswer.BackColor = Color.PaleGreen;
            buttonAnswer.Font = new Font("Segoe UI", 9F);
            buttonAnswer.Location = new Point(282, 119);
            buttonAnswer.Name = "buttonAnswer";
            buttonAnswer.Size = new Size(118, 34);
            buttonAnswer.TabIndex = 2;
            buttonAnswer.Text = "Answer";
            buttonAnswer.UseVisualStyleBackColor = false;
            buttonAnswer.Click += buttonAnswer_Click;
            // 
            // QuestForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 161);
            Controls.Add(buttonAnswer);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Calibri", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "QuestForm";
            Text = "Quiz";
            Load += QuestForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button buttonAnswer;
    }
}