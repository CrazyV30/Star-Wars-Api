using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace WinFormsApp_SWAPI
{
    public partial class SlideShowForm : Form
    {
        private System.Windows.Forms.Timer timer1;
        private UIHelper uIHelper = new();
        private List<ImageLink> additionalLinks = new();
        private int currentIndex = 0;
        public SlideShowForm()
        {
            InitializeComponent();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 5000; // 5 seconds
            timer1.Tick += Timer1_Tick;
        }

        private async void Timer1_Tick(object? sender, EventArgs e)
        {
            await uIHelper.ShowImage(additionalLinks[currentIndex], pictureBox1);
            labelName.Text = additionalLinks[currentIndex].Name;
            currentIndex++;
        }

        private async void SlideShowForm_Load(object sender, EventArgs e)
        {
            additionalLinks = await uIHelper.LoadImageLink(additionalLinks);
            await uIHelper.ShowImage(additionalLinks[currentIndex], pictureBox1);
            labelName.Text = additionalLinks[currentIndex].Name;
            currentIndex++;
            timer1.Start();
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }
    }
}
