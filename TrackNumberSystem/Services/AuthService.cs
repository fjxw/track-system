namespace TrackNumberSystem.Services.Console;

using Interfaces;
using System;

public class AuthService : IAuth
{
    private const string Password = "admin";

    public bool Auth()
    {
        var password = Console.ReadLine();
        return password == Password;
    }
}