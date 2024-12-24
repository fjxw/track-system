namespace TrackNumberSystem.Models;

using Services;
using Abstract;

public class IntrTrack : Track
{
    public string HomeCountry { get; set; }
    public string DepartCountry { get; set; }

    public IntrTrack(string homeCountry, string departCountry, double weight, TrackGenerator generator)
        : base(weight)
    {
        HomeCountry = homeCountry;
        DepartCountry = departCountry;
        var _generator = generator as IntrTrackGenerator
                         ?? throw new InvalidCastException();
        TrackNumber = _generator.Generate(homeCountry, departCountry);
    }
}