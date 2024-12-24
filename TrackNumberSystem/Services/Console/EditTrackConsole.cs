namespace TrackNumberSystem.Services.Console;

using Interfaces;
using System;
using Repositories;
using Models;
using Models.Abstract;

public class EditTrackConsole : IEditTrack
{
    public static void EditTrack()
    {
        Console.Clear();
        Console.WriteLine("Редактирование трек-номера");
        Console.Write("Введите текущий трек-номер: ");
        var trackNumber = Console.ReadLine();
        try
        {
            var track = TracksRegistry<Track>.FindTrack(trackNumber);
            if (track == null)
            {
                Console.WriteLine("Трек-номер не найден");
                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Выберите, что вы хотите отредактировать:");
            Console.WriteLine("1. Вес");
            Console.WriteLine("2. Изменить статус");
            Console.WriteLine("3. Удалить статус");
            if (track is HomeTrack)
            {
                Console.WriteLine("4. Город отправления");
                Console.WriteLine("5. Город прибытия");
            }
            else
            {
                Console.WriteLine("4. Страна отправления");
                Console.WriteLine("5. Страна прибытия");
            }

            Console.WriteLine("6. Выход");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    Console.Write("Введите новый вес: ");
                    track.Weight = Convert.ToDouble(Console.ReadLine());
                    track.StatusRegistry.AddStatus(new Status(DateTime.Now, "РЕДАКТИРОВАНИЕ", "Изменен вес"));
                    Console.WriteLine("Вес успешно изменен!");
                    break;
                case "2":
                    Console.Write("Введите индекс статуса для изменения: ");
                    var statusIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (statusIndex < 0 && statusIndex > track.StatusRegistry.Statuses.Count)
                        Console.WriteLine("Неверный индекс статуса");

                    Console.Write("Введите новый город: ");
                    var newCity = Console.ReadLine();

                    Console.Write("Введите новое описание статуса: ");
                    var newDescription = Console.ReadLine();

                    track.StatusRegistry.Statuses[statusIndex] = new Status(DateTime.Now, newCity, newDescription);
                    track.StatusRegistry.AddStatus(new Status(DateTime.Now, "РЕДАКТИРОВАНИЕ",
                        $"Статус изменен"));
                    Console.WriteLine("Статус успешно изменен!");
                    break;
                case "3":
                    Console.Write("Введите номер статуса для удаления: ");
                    var deleteIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (deleteIndex < 0 && deleteIndex < track.StatusRegistry.Statuses.Count)
                        Console.WriteLine("Неверный номер статуса");

                    track.StatusRegistry.Statuses.RemoveAt(deleteIndex);
                    track.StatusRegistry.AddStatus(new Status(DateTime.Now, "РЕДАКТИРОВАНИЕ",
                        $"Статус удален"));
                    Console.WriteLine("Статус успешно удален");
                    break;
                case "4":
                    if (track is HomeTrack)
                    {
                        Console.Write("Введите новый город отправления: ");
                        var _track = track as HomeTrack
                                     ?? throw new NullReferenceException("Неверное приведение типов");
                        _track.DepartCity = Console.ReadLine();
                        track.StatusRegistry.AddStatus(new Status(DateTime.Now, "РЕДАКТИРОВАНИЕ",
                            $"Изменен город отправления на {_track.DepartCity}"));
                        Console.WriteLine("Город отправления успешно изменен!");
                    }
                    else
                    {
                        Console.Write("Введите новую страну отправления: ");
                        var _track = track as IntrTrack
                                     ?? throw new NullReferenceException("Неверное приведение типов");
                        _track.DepartCountry = Console.ReadLine();
                        track.StatusRegistry.AddStatus(new Status(DateTime.Now, "РЕДАКТИРОВАНИЕ",
                            $"Изменена страна отправления на {_track.DepartCountry}"));
                        Console.WriteLine("Страна отправления успешно изменена");
                    }

                    break;
                case "5":
                    if (track is HomeTrack)
                    {
                        Console.Write("Введите новый город прибытия: ");
                        var _track = track as HomeTrack
                                     ?? throw new NullReferenceException("Неверное приведение типов");
                        _track.HomeCity = Console.ReadLine();
                        track.StatusRegistry.AddStatus(new Status(DateTime.Now, "РЕДАКТИРОВАНИЕ",
                            $"Изменен город прибытия на {_track.HomeCity}"));
                        Console.WriteLine("Город прибытия успешно изменен!");
                    }
                    else
                    {
                        Console.Write("Введите новую страну прибытия: ");
                        var _track = track as IntrTrack
                                     ?? throw new NullReferenceException("Неверное приведение типов");
                        _track.HomeCountry = Console.ReadLine();
                        track.StatusRegistry.AddStatus(new Status(DateTime.Now, "РЕДАКТИРОВАНИЕ",
                            $"Изменена страна прибытия на {_track.HomeCountry}"));
                        Console.WriteLine("Страна прибытия успешно изменена");
                    }

                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Неверный выбор");
                    break;
            }

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