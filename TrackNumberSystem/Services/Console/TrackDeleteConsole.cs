namespace TrackNumberSystem.Services.Console;

using Interfaces;
using System;
using Repositories;
using Models.Abstract;

public class TrackDeleteConsole : IDeleteTrack
{
    public static void DeleteTrack()
    {
        Console.Clear();
        Console.WriteLine("Удаление трек-номера");
        Console.Write("Введите трек-номер: ");
        string trackNumber = Console.ReadLine();
        Track track = TracksRegistry<Track>.FindTrack(trackNumber);
        if (track == null)
        {
            Console.WriteLine("Трек-номер не найден");
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
        else
        {
            TracksRegistry<Track>.RemoveTrack(track);
            Console.WriteLine("Трек успешно удален!");
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }
}