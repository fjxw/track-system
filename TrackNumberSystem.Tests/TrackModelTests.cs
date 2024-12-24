namespace TrackNumberSystem.Tests;

using Services;
using Models;

public class TrackModelTests
{
    [Fact]
    public void IntrTrackCreates()
    {
        var track = new IntrTrack("Россия", "Китай", 15, new IntrTrackGenerator());
        Assert.Equal("Россия", track.HomeCountry);
        Assert.Equal("Китай", track.DepartCountry);
        Assert.Equal(15, track.Weight);
        Assert.NotNull(track.TrackNumber);
        Assert.NotNull(track.StatusRegistry);
    }

    [Fact]
    public void HomeTrackCreates()
    {
        var track = new HomeTrack("Москва", "Санкт-Петербург", 20, new TrackGenerator());
        Assert.Equal("Москва", track.HomeCity);
        Assert.Equal("Санкт-Петербург", track.DepartCity);
        Assert.Equal(20, track.Weight);
        Assert.NotNull(track.TrackNumber);
        Assert.NotNull(track.StatusRegistry);
    }
}