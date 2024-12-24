namespace TrackNumberSystem.Models;

using Services;
using Abstract;

public class HomeTrack : Track
{
    public string HomeCity { get; set; }
    public string DepartCity { get; set; }

    public HomeTrack(string homeCity, string departCity, double weight, TrackGenerator generator)
        : base(weight)
    {
        HomeCity = homeCity;
        DepartCity = departCity;
        TrackNumber = generator.Generate();
    }
}