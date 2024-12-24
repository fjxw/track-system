namespace TrackNumberSystem.Services.Console;

using Interfaces;
using System;
using Repositories;
using Models;
using Models.Abstract;

public class TrackFinderConsole : IFindTrack
{
    public static void FindNumber()
    {
        Console.Clear();
        Console.WriteLine("Поиск по трек-номеру");
        Console.WriteLine("Введите трек-номер: ");
        var track = Console.ReadLine();
        try
        {
            var findTrack = TracksRegistry<Track>.FindTrack(track);
            ITrackDetails details = findTrack is IntrTrack ? new IntrTrackDetails() : new HomeTrackDetails();
            Console.WriteLine(details.Detalis(findTrack));
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
        catch (Exception)
        {
            Console.WriteLine("Трек-номер не найден");
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }
}