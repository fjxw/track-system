namespace TrackNumberSystem.Tests;

using System;
using Xunit;
using System;
using Repositories;
using Services;
using Models;
using Models.Abstract;

public class StatusModelTests
{
    [Fact]
    public void StatusCreates()
    {
        var date = DateTime.Now;
        var city = "Москва";
        var description = "Доставлено";
        var status = new Status(date, city, description);
        Assert.Equal(date, status.Date);
        Assert.Equal(city, status.City);
        Assert.Equal(description, status.StatusDescription);
        Assert.Equal($"[{date:yyyy-MM-dd HH:mm:ss}] {city} : {description}", status.StatusDetails());
    }

    [Fact]
    public void CorrectFormat()
    {
        var date = new DateTime(2023, 10, 1, 14, 30, 0);
        var city = "Москва";
        var description = "В пути";
        var status = new Status(date, city, description);
        var details = "[2023-10-01 14:30:00] Москва : В пути";
        Assert.Equal(details, status.StatusDetails());
    }

    [Fact]
    public void EmptyCity()
    {
        var date = new DateTime(2023, 10, 1, 14, 30, 0);
        var city = "";
        var description = "В пути";
        var status = new Status(date, city, description);
        var details = "[2023-10-01 14:30:00]  : В пути";
        Assert.Equal(details, status.StatusDetails());
    }

    [Fact]
    public void EmptyDescription()
    {
        var date = new DateTime(2023, 10, 1, 14, 30, 0);
        var city = "Москва";
        var description = "";
        var status = new Status(date, city, description);
        var details = "[2023-10-01 14:30:00] Москва : ";
        Assert.Equal(details, status.StatusDetails());
    }

    [Fact]
    public void NullCity()
    {
        var date = new DateTime(2023, 10, 1, 14, 30, 0);
        string city = null!;
        var description = "В пути";
        var status = new Status(date, city, description);
        var details = "[2023-10-01 14:30:00]  : В пути";
        Assert.Equal(details, status.StatusDetails());
    }

    [Fact]
    public void NullDescription()
    {
        var date = new DateTime(2023, 10, 1, 14, 30, 0);
        var city = "Москва";
        string description = null!;
        var status = new Status(date, city, description);
        var details = "[2023-10-01 14:30:00] Москва : ";
        Assert.Equal(details, status.StatusDetails());
    }
}