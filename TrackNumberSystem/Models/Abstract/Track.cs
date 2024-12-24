namespace TrackNumberSystem.Models.Abstract;

using Interfaces;
using Repositories;

public abstract class Track
{
    public string TrackNumber { get; set; }
    public double Weight { get; set; }
    public DateTime CreationDate { get; set; }
    public StatusRegistry StatusRegistry { get; set; }
    public Track(double weight)
    {
        CreationDate = DateTime.Now;
        Weight = weight;
        StatusRegistry = new StatusRegistry();
    }
}