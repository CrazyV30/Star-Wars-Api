using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_SWAPI;

public interface INameable
{
    string Name { get; set; }
}

public class Film: INameable
{
    [JsonProperty("title")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("opening_crawl")]
    public string OpeningCrawl { get; set; } = string.Empty;

    [JsonProperty("release_date")]
    public DateTime? ReleaseDate { get; set; } = new();

    [JsonProperty("characters")]
    public List<string> CharactersUrl { get; set; } = new();
    [JsonProperty("planets")]
    public List<string> PlanetsUrl { get; set; } = new();
    [JsonProperty("starships")]
    public List<string> StarshipsUrl { get; set; } = new();
    [JsonProperty("url")]
    public string Url { get; set; } = string.Empty; 


    string symbol = new string('*', 15);
    public override string ToString() => $"{Name}";
    public string Info() => $"{symbol}\r\nTitle: {Name}\r\nRelease date: {ReleaseDate?.ToString("yyyy-MM-dd")}\r\nOpening crawl:\r\n{OpeningCrawl}\r\n" +
        $"{symbol}\r\n";

}

public class People: INameable
{
    private UIHelper uIHelper = new UIHelper();

    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("birth_year")]
    public string BirthYear { get; set; } = string.Empty;

    [JsonProperty("gender")]
    public string Gender { get; set; } = string.Empty;

    [JsonProperty("homeworld")]
    public string Homeworld { get; set; } = string.Empty;

    [JsonProperty("starships")]
    public List<string> StarshipsUrls { get; set; } = new();

    string symbol = new string('*', 15);
    public override string ToString() => $"{Name}";
    public async Task<string> Info() => $"{symbol}\r\nName: {Name}\r\nGender: {Gender}\r\nBirth year: {BirthYear}\r\nHomeworld: {await uIHelper.GetHomeWorld(Homeworld)}\r\n" +
        $"Starships: {string.Join(", ", await uIHelper.GetListData<StarShip>(StarshipsUrls))}\r\n{symbol}\r\n";

}

public class Planet: INameable
{
    private UIHelper uIHelper = new UIHelper();

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("climate")]
    public string Climate { get; set; }

    [JsonProperty("gravity")]
    public string Gravity { get; set; }

    [JsonProperty("terrain")]
    public string Terrain { get; set; }

    [JsonProperty("residents")]
    public List<string> Residents { get; set; }

    [JsonProperty("films")]
    public List<string> Films { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    string symbol = new string('*', 15);
    public override string ToString() => $"{Name}";
    public async Task<string> Info() => $"{symbol}\r\nName: {Name}\r\nClimate: {Climate}\r\nGravity:{Gravity}\r\nTerrain:{Terrain}" +
        $"\r\nFilms:\r\n{await uIHelper.GetListData<Film>(Films)}\r\n{symbol}\r\n";


}

public class StarShip: INameable
{
    private UIHelper uIHelper = new UIHelper();

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("model")]
    public string Model { get; set; }

    [JsonProperty("manufacturer")]
    public string Manufacturer { get; set; }

    [JsonProperty("cost_in_credits")]
    public string CostInCredits { get; set; }

    [JsonProperty("length")]
    public string Length { get; set; }

    [JsonProperty("max_atmosphering_speed")]
    public string MaxAtmospheringSpeed { get; set; }

    [JsonProperty("crew")]
    public string Crew { get; set; }

    [JsonProperty("passengers")]
    public string Passengers { get; set; }

    [JsonProperty("starship_class")]
    public string StarshipClass { get; set; }

    [JsonProperty("pilots")]
    public List<string> Pilots { get; set; }

    [JsonProperty("films")]
    public List<string> Films { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }


    string symbol = new string('*', 15);
    public override string ToString() => $"{Name}";
    public async Task<string> Info() => $"{symbol}\r\nName: {Name}\r\nModel: {Model}\r\nManufacturer:{Manufacturer}\r\nCost in credits:{CostInCredits}\r\n" +
        $"Length:{Length}\r\nMax Atmosphering peed:{MaxAtmospheringSpeed}\r\nCrew:{Crew}\r\nPassengers:{Passengers}\r\n" +
        $"Pilots:\r\n{string.Join(", ", await uIHelper.GetListData<People>(Pilots))}\r\n{symbol}\r\n";

}
public class ImageLink
{
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;
    [JsonProperty("image")]
    public string LinkImage { get; set; } = string.Empty;

}
