namespace TrackNumberSystem.Tests;

using System;
using Repositories;
using Models;

public class StatusRegistryTests
{
    [Fact]
    public void AddStatusToRegistry()
    {
        var statusRegistry = new StatusRegistry();
        var status = new Status(DateTime.Now, "Город", "Описание");
        statusRegistry.AddStatus(status);
        Assert.Contains(status, statusRegistry.Statuses);
    }
}