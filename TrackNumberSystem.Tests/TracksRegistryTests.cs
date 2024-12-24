namespace TrackNumberSystem.Tests;

using Repositories;
using Services;
using Models;
using Models.Abstract;

public class TracksRegistryTests
{
    [Fact]
    public void AddTrackToRegistry()
    {
        Track track = new HomeTrack("Город", "Город", 10, new TrackGenerator());
        TracksRegistry<Track>.AddTrack(track);
        Assert.Contains(track, TracksRegistry<Track>.AllTracks());
    }

    [Fact]
    public void ReturnsCorrectTrack()
    {
        Track track = new HomeTrack("Город", "Город", 10, new TrackGenerator());
        TracksRegistry<Track>.AddTrack(track);
        var foundTrack = TracksRegistry<Track>.FindTrack(track.TrackNumber);
        Assert.Equal(track, foundTrack);
    }

    [Fact]
    public void RemoveTrack()
    {
        Track track = new HomeTrack("Город", "Город", 10, new TrackGenerator());
        TracksRegistry<Track>.AddTrack(track);
        TracksRegistry<Track>.RemoveTrack(track);
        Assert.DoesNotContain(track, TracksRegistry<Track>.AllTracks());
    }

    [Fact]
    public void ReturnsAllTracks()
    {
        Track track1 = new HomeTrack("Город", "Город", 10, new TrackGenerator());
        Track track2 = new HomeTrack("Город", "Город", 90, new TrackGenerator());
        TracksRegistry<Track>.AddTrack(track1);
        TracksRegistry<Track>.AddTrack(track2);
        var allTracks = TracksRegistry<Track>.AllTracks();
        Assert.Contains(track1, allTracks);
        Assert.Contains(track2, allTracks);
    }
}