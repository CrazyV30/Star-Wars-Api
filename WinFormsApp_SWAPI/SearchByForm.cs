using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_SWAPI
{
    public partial class SearchByForm : Form
    {
        private readonly UIHelper uIHelper;
        private string urlBase = "https://swapi.info/api/";
        private List<People> people;
        private List<ImageLink> additionalLinks;
        public SearchByForm()
        {
            InitializeComponent();
            uIHelper = new UIHelper();
            people = new List<People>();
            additionalLinks = new List<ImageLink>();
        }

        private async void SearchBy_Load(object sender, EventArgs e)
        {
            people = await uIHelper.LoadData<People>(urlBase + "people");
            additionalLinks = await uIHelper.LoadImageLink(additionalLinks);
            LoadInfoForComboBoxes();
        }
        private async void LoadInfoForComboBoxes()
        {
            // load genders
            List<string> gender = people.Select(p => p.Gender).Distinct().ToList();
            foreach (var item in gender) comboBoxGender.Items.Add(item);
            // load homeworlds
            List<string> homeworlds = new();
            foreach (var person in people)
            {
                if (person.Homeworld != null)
                {
                    string homeworldName = await uIHelper.GetHomeWorld(person.Homeworld);
                    homeworlds.Add(homeworldName);
                }
            }
            homeworlds = homeworlds.Distinct().ToList();
            foreach (var item in homeworlds) comboBoxHomeworld.Items.Add(item);
            comboBoxHomeworld.SelectedIndex = 0;
            // load starships
            List<string> starships = new();
            foreach (var person in people)
            {
                if (person.StarshipsUrls != null)
                {
                    List<string> starshipsForPerson = await uIHelper.GetListData<StarShip>(person.StarshipsUrls);
                    starships.AddRange(starshipsForPerson);
                }
            }
            starships = starships.Distinct().ToList();
            foreach (var item in starships) comboBoxStarship.Items.Add(item);
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            string? selectedGender = comboBoxGender.SelectedItem?.ToString() ?? null;
            string? selectedHomeworld = comboBoxHomeworld.SelectedItem?.ToString() ?? null;
            string? selectedStarship = comboBoxStarship.SelectedItem?.ToString() ?? null;
            listBoxCharacters.Items.Clear();
            // пошук за вибраними критеріями

            //filter by gender
            List<People> filteredPeople;
            if (string.IsNullOrEmpty(selectedGender))
                filteredPeople = people;
            else
                filteredPeople = people.Where(p => p.Gender == selectedGender).ToList();
            //filter by homeworld
            if (!string.IsNullOrEmpty(selectedHomeworld))
                filteredPeople = await FilterByHomeworld(filteredPeople, selectedHomeworld);
            //filter by starship
            if (string.IsNullOrEmpty(selectedStarship))
            {
                foreach (var item in filteredPeople)
                {
                    if (item.StarshipsUrls.Count == 0)
                        listBoxCharacters.Items.Add(item);
                }
            }
            else
            {
                foreach (var item in filteredPeople)
                {
                    if (item.StarshipsUrls != null)
                    {
                        List<string> starshipsForPerson = await uIHelper.GetListData<StarShip>(item.StarshipsUrls);
                        if (starshipsForPerson.Contains(selectedStarship!))
                        {
                            listBoxCharacters.Items.Add(item);
                        }
                    }
                }
            }
        }

        private async Task<List<People>> FilterByHomeworld(List<People> filteredPeople, string selectedHomeworld)
        {
            List<People> peopleToSave = new List<People>();
            foreach (var item in filteredPeople)
            {
                if (item.Homeworld != null)
                {
                    string homeworldName = await uIHelper.GetHomeWorld(item.Homeworld);
                    if (homeworldName == selectedHomeworld)
                        peopleToSave.Add(item);
                }
            }
            return peopleToSave;
        }

        private async void listBoxCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCharacters.SelectedItem is People selectedPerson)
            {
                if (additionalLinks.FirstOrDefault(l => string.Equals(l.Name, selectedPerson.Name)) is ImageLink link)
                    await uIHelper.ShowImage(link, pictureBoxCharacter);
                else await uIHelper.ShowImage(new ImageLink() { Name = selectedPerson.Name }, pictureBoxCharacter);
                textBoxInfo.Text = await selectedPerson.Info();
            }
        }
    }
}
