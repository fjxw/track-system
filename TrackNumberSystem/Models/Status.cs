namespace TrackNumberSystem.Models;

public class Status
{
    public DateTime Date { get; set; }
    public string City { get; set; }
    public string StatusDescription { get; set; }
    public Func<string> StatusDetails { get; set; }

    public Status(DateTime date, string city, string statusDescription)
    {
        Date = date;
        City = city;
        StatusDescription = statusDescription;
        StatusDetails = () => $"[{Date:yyyy-MM-dd HH:mm:ss}] {City} : {StatusDescription}";
    }
}