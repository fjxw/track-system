namespace TrackNumberSystem.Services.Console;

using Interfaces;
using System;

public class AuthConsole : IAuthInteract
{
    public static bool AuthUserConsole(IAuth authService)
    {
        Console.Clear();
        Console.WriteLine("Введите пароль:");
        if (authService.Auth())
        {
            Console.WriteLine("Пароль принят. Добро пожаловать в режим администрирования!");
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
            return true;
        }

        Console.WriteLine("Неверный пароль. Возврат в главное меню...");
        Console.ReadKey();
        return false;
    }
}