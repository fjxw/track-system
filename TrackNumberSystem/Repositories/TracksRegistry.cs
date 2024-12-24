namespace TrackNumberSystem.Repositories;

using Models.Abstract;

public static class TracksRegistry<T> where T : Track
{
    private static List<T> tracks = new();

    public static void AddTrack(T track)
    {
        tracks.Add(track);
    }

    public static Track FindTrack(string trackNumber)
    {
        foreach (var track in tracks)
            if (track.TrackNumber == trackNumber)
                return track;

        return null!;
    }

    public static void RemoveTrack(T track)
    {
        tracks.Remove(track);
    }

    public static List<T> AllTracks()
    {
        return tracks;
    }
}