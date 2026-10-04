using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_SWAPI
{
    public partial class QuestForm : Form
    {
        public bool IsAnswerCorrect { get; private set; } = false;
        private string correctAnswer = string.Empty;
        private readonly object fileLock = new object();
        public QuestForm()
        {
            InitializeComponent();
        }
        private void QuestForm_Load(object sender, EventArgs e)
        {
            try
            {
                int id = Random.Shared.Next(1, 31);
                string data =  File.ReadAllText("Properties/quiz_advanced.json");                
                List<Quiz> quizzes = JsonHelper.Deserialize<List<Quiz>>(data);
                Quiz quiz = quizzes.FirstOrDefault(q => q.Id == id);
                if (quiz != null)
                {
                    label1.Text = quiz.Question;
                    correctAnswer = quiz.CorrectAnswer;
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Quiz file not found. Please ensure 'quiz_advanced.json' is in the application directory.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading quiz: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter an answer.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (string.Equals(textBox1.Text.ToLower(), correctAnswer.ToLower(), StringComparison.OrdinalIgnoreCase))
                {
                    IsAnswerCorrect = true;
                    MessageBox.Show("Correct answer!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    IsAnswerCorrect = false;
                    MessageBox.Show($"Wrong answer! The correct answer was: {correctAnswer}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

    }
}
