namespace TrackNumberSystem.Services.Console.Menus;

using System;
using Interfaces;

public class AdminMenu : IAdminMenu
{
    public static void Show()
    {
        if (!AuthConsole.AuthUserConsole(new AuthService())) return;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Администрирование:");
            Console.WriteLine("1. Создать новый трек-номер");
            Console.WriteLine("2. Добавить статус к существующему трек-номеру");
            Console.WriteLine("3. Редактировать трек-номер");
            Console.WriteLine("4. Удалить трек-номер");
            Console.WriteLine("5. Вывести все трек-номера");
            Console.WriteLine("6. Выход");

            var adminChoice = Console.ReadLine();
            switch (adminChoice)
            {
                case "1":
                    CreateTrackConsole.CreateTrack();
                    break;

                case "2":
                    AddStatusConsole.AddStatus();
                    break;

                case "3":
                    EditTrackConsole.EditTrack();
                    break;

                case "4":
                    TrackDeleteConsole.DeleteTrack();
                    break;
                case "5":
                    ListTracksConsole.AllTracks();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Неизвестная команда. Нажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}