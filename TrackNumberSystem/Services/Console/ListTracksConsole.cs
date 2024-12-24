namespace TrackNumberSystem.Services.Console;

using Interfaces;
using System;
using Repositories;
using Models.Abstract;

public class ListTracksConsole : IListTracks
{
    public static void AllTracks()
    {
        Console.Clear();
        Console.WriteLine("Список всех трек-номеров:");
        List<Track> allTracks = TracksRegistry<Track>.AllTracks();
        foreach (var track in allTracks) Console.WriteLine(track.TrackNumber);
        Console.WriteLine("Нажмите любую клавишу для продолжения...");
        Console.ReadKey();
    }
}