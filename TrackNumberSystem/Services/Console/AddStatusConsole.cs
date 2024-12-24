namespace TrackNumberSystem.Services.Console;

using System;
using Interfaces;
using Models.Abstract;
using Models;
using Repositories;

public class AddStatusConsole : IAddStatus
{
    public static void AddStatus()
    {
        Console.Clear();
        Console.WriteLine("Добавление статуса к трек-номеру...");
        Console.Write("Введите трек-номер: ");
        var trackNumber = Console.ReadLine();
        try
        {
            Track track = TracksRegistry<Track>.FindTrack(trackNumber);
            Console.Write("Введите город: ");
            string city = Console.ReadLine();
            Console.Write("Введите описание статуса: ");
            string statusDescription = Console.ReadLine();
            Status newStatus = new Status(DateTime.Now, city, statusDescription);
            track.StatusRegistry.AddStatus(newStatus);
            Console.WriteLine("Статус успешно добавлен!");
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
        catch (Exception)
        {
            Console.WriteLine("Некорректные данные");
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }
}