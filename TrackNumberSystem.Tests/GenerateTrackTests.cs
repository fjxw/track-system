namespace TrackNumberSystem.Tests;

using Services;

public class GenerateTrackTests
{
    [Fact]
    public void HomeTrackValidCode()
    {
        var generator = new TrackGenerator();
        var trackNumber = generator.Generate();
        Assert.Equal(9, trackNumber.Length);
    }

    [Fact]
    public void IntrTrackValidCode()
    {
        var generator = new IntrTrackGenerator();
        var trackNumber = generator.Generate("Россия", "Китай");
        Assert.StartsWith("РО", trackNumber);
        Assert.EndsWith("КИ", trackNumber);
        Assert.Equal(13, trackNumber.Length);
    }
}