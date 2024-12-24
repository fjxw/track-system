namespace TrackNumberSystem.Services;

public class IntrTrackGenerator : TrackGenerator
{
    public string Generate(string homeCounty, string departCountry)
    {
        var numberPart = base.Generate();
        return $"{homeCounty.Substring(0, 2).ToUpper()}{numberPart}{departCountry.Substring(0, 2).ToUpper()}";
    }
}