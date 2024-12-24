namespace TrackNumberSystem.Services.Console.Menus;

using System;
using Interfaces;

public class UserMenuConsole : IUserMenu
{
    public static void Show()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Выберите опцию:");
            Console.WriteLine("1. Отслеживание по трек-номеру");
            Console.WriteLine("2. Администрирование");
            Console.WriteLine("3. Выход");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    TrackFinderConsole.FindNumber();
                    break;

                case "2":
                    AdminMenu.Show();
                    break;

                case "3":
                    Console.WriteLine("Выход из программы...");
                    return;

                default:
                    Console.WriteLine("Неизвестная команда. Нажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}