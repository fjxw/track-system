namespace TrackNumberSystem.Services.Console;

using System;
using Interfaces;
using Models;
using Models.Abstract;
using Repositories;

public class CreateTrackConsole : ICreateTrack
{
    public static void CreateTrack()
    {
        Console.Clear();
        Console.WriteLine("Создание нового трек-номера");
        Console.WriteLine("Выберите тип трек-номера:\n1. Региональный\n2. Международный");
        var choice = Console.ReadLine();
        try
        {
            Track newTrack = null!;
            switch (choice)
            {
                case "1":
                {
                    Console.Clear();
                    Console.Write("Введите город отправления: ");
                    var departTown = Console.ReadLine();
                    Console.Write("Введите город прибытия: ");
                    var homeTown = Console.ReadLine();
                    Console.Write("Введите вес груза (в кг): ");
                    var weight = Convert.ToDouble(Console.ReadLine());
                    newTrack = new HomeTrack(homeTown, departTown, weight, new TrackGenerator());
                    break;
                }
                case "2":
                {
                    Console.Clear();
                    Console.Write("Введите страну отправления: ");
                    var departCountry = Console.ReadLine();
                    Console.Write("Введите страну прибытия: ");
                    var homeCountry = Console.ReadLine();
                    Console.Write("Введите вес груза (в кг): ");
                    var weight = Convert.ToDouble(Console.ReadLine());
                    newTrack = new IntrTrack(homeCountry, departCountry, weight, new IntrTrackGenerator());
                    break;
                }
                default:
                    Console.WriteLine("Неверный выбор");
                    break;
            }

            TracksRegistry<Track>.AddTrack(newTrack);
            Console.WriteLine($"Трек-номер {newTrack.TrackNumber} успешно создан!");
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