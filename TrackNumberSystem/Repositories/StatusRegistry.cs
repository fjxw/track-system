namespace TrackNumberSystem.Repositories;

using Models;

public class StatusRegistry
{
    public List<Status> Statuses { get; set; } = new();

    public void AddStatus(Status status)
    {
        Statuses.Add(status);
    }

    public string GetStatuses()
    {
        var result = "";
        for (var i = 0; i < Statuses.Count; i++) result += $"[#{i + 1}] {Statuses[i].StatusDetails()}\n";
        return result;
    }
}