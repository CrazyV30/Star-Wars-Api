using Newtonsoft.Json;
using QuestPDF.Infrastructure;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_SWAPI
{
    public partial class Form1 : Form
    {
        private const string urlBase = "https://swapi.info/api/";
        private readonly UIHelper uIHelper = new UIHelper();
        internal List<ImageLink> additionalLinks = new();
        public Form1()
        {
            InitializeComponent();
            checkBoxCacheImage.CheckedChanged -= checkBoxCacheImage_CheckedChanged;
            checkBoxCacheImage.Checked = uIHelper.LoadFromConfigIfWantToCache("cache_config.txt");
            checkBoxCacheImage.CheckedChanged += checkBoxCacheImage_CheckedChanged;
            QuestPDF.Settings.License = LicenseType.Community;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Films");
            comboBox1.Items.Add("Planets");
            comboBox1.Items.Add("Characters");
            comboBox1.SelectedIndex = 0;
                        
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            //Check if the user wants to cache images and load them accordingly
            if (checkBoxCacheImage.Checked)
                additionalLinks = await uIHelper.LoadImageLink(additionalLinks);
            else if (!checkBoxCacheImage.Checked)
            {
                List<ImageLink> deserializedLinks = await uIHelper.LoadImageLink(additionalLinks);
                await Task.Run(async () => await uIHelper.DownloadImagesAsync(deserializedLinks, "Images"));
            }

            // Load initial data based on the default selection in the combo box
            if (comboBox1.SelectedItem?.ToString() == "Films")
            {
                uIHelper.ShowListData<Film>(listBoxFilms, await uIHelper.LoadData<Film>(urlBase + "films"));
            }
            else if (comboBox1.SelectedItem?.ToString() == "Planets")
            {
                uIHelper.ShowListData<Planet>(listBoxFilms, await uIHelper.LoadData<Planet>(urlBase + "planets"));
            }
            else if (comboBox1.SelectedItem?.ToString() == "Characters")
            {
                uIHelper.ShowListData<People>(listBoxFilms, await uIHelper.LoadData<People>(urlBase + "people"));
                buttonPDF.Enabled = false;
            }
            else { } //SMTH
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            uIHelper.SaveToConfig("cache_config.txt", checkBoxCacheImage.Checked);
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
            if (!checkBoxCacheImage.Checked && Directory.Exists(path))
            {
                try
                {
                    Directory.Delete(path, true);
                    Debug.WriteLine("Каталог Images успішно видалено.");
                }
                catch (UnauthorizedAccessException)
                {
                    Debug.WriteLine("Немає прав на видалення файлу");
                }
                catch (IOException ex)
                {
                    Debug.WriteLine($"Помилка доступу: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Помилка при видаленні каталогу Images: {ex.Message}");
                }
            }
        }
        private async void listBoxFilms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFilms.SelectedItem is Film film)
            {
                Debug.WriteLine($"Selected film: {film.Name}");
                List<People> DeserializedPeople = await uIHelper.LoadListData<People>(film.CharactersUrl ?? new());
                uIHelper.ShowListData<People>(listBoxCharacters, DeserializedPeople);
                textBoxResult.Text = film.Info();
            }
            else if (listBoxFilms.SelectedItem is Planet planet)
            {
                Debug.WriteLine($"Selected planet: {planet.Name}");
                List<People> DeserializedResidents = await uIHelper.LoadListData<People>(planet.Residents ?? new());
                uIHelper.ShowListData<People>(listBoxCharacters, DeserializedResidents);
                textBoxResult.Text = await planet.Info();
            }
            else if (listBoxFilms.SelectedItem is People people)
            {
                Debug.WriteLine($"Selected character: {people.Name}");
                List<StarShip> DeserializedStarShips = await uIHelper.LoadListData<StarShip>(people.StarshipsUrls ?? new());
                uIHelper.ShowListData<StarShip>(listBoxCharacters, DeserializedStarShips);
                textBoxResult.Text = await people.Info();
            }
            else { } //SMTH
        }

        private async void listBoxCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCharacters.SelectedItem is People people)
            {
                if (additionalLinks.FirstOrDefault(l => string.Equals(l.Name, people.Name)) is ImageLink link)
                    await uIHelper.ShowImage(link, pictureBox1);
                else await uIHelper.ShowImage(new ImageLink() { Name = people.Name }, pictureBox1);
                textBoxResult.Text = await people.Info();
            }
            else if (listBoxCharacters.SelectedItem is StarShip starShip)
            {
                textBoxResult.Text = await starShip.Info();
                await uIHelper.ShowImage(new ImageLink() { Name = starShip.Name }, pictureBox1);
            }
            else { } //SMTH
        }

        private void button_SlideShow_Click(object sender, EventArgs e)
        {
            this.Hide();
            SlideShowForm slideShow = new SlideShowForm();
            slideShow.FormClosed += (s, args) => this.Show();
            slideShow.Show();
        }

        private void buttonPDF_Click(object sender, EventArgs e)
        {
            if (listBoxCharacters.SelectedItem is People people)
                uIHelper.GeneratePdf(people);
            else
                MessageBox.Show("Please select a character to generate PDF.", "No Character Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    List<Film> films = await uIHelper.LoadData<Film>(urlBase + "films");
                    uIHelper.ShowListData<Film>(listBoxFilms, films);
                    buttonPDF.Enabled = true;
                    break;
                case 1:
                    List<Planet> planets = await uIHelper.LoadData<Planet>(urlBase + "planets");
                    uIHelper.ShowListData<Planet>(listBoxFilms, planets);
                    buttonPDF.Enabled = true;
                    break;
                case 2:
                    List<People> people = await uIHelper.LoadData<People>(urlBase + "people");
                    uIHelper.ShowListData<People>(listBoxFilms, people);
                    buttonPDF.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void checkBoxCacheImage_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxCacheImage.CheckedChanged -= checkBoxCacheImage_CheckedChanged;
            if (checkBoxCacheImage.Checked)
            {
                checkBoxCacheImage.Checked = false;
                QuestForm form = new QuestForm();
                form.ShowDialog();
                if (form.IsAnswerCorrect)
                    checkBoxCacheImage.Checked = true;
            }
            checkBoxCacheImage.CheckedChanged += checkBoxCacheImage_CheckedChanged;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchByForm searchByForm = new SearchByForm();
            searchByForm.ShowDialog();
        }
    }
}
