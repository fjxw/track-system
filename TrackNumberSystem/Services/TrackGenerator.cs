namespace TrackNumberSystem.Services;

public class TrackGenerator
{
    private static Random numberGenerator = new();

    public string Generate()
    {
        return numberGenerator.Next(100000000, 999999999).ToString();
    }
}