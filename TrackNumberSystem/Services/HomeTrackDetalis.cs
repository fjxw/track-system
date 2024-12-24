namespace TrackNumberSystem.Services;

using Interfaces;
using System;
using Models;
using Models.Abstract;

public class HomeTrackDetails : ITrackDetails
{
    public string Detalis(Track track)
    {
        var _track = track as HomeTrack
                     ?? throw new InvalidCastException();
        var statusDetails = _track.StatusRegistry.GetStatuses();
        return $"Трек-номер: {_track.TrackNumber}\n" +
               $"Город отправления: {_track.DepartCity}\n" +
               $"Город прибытия: {_track.HomeCity}\n" +
               $"Вес: {_track.Weight} кг\n" +
               $"Создан: {_track.CreationDate}\n" +
               $"Статусы:\n{statusDetails}";
    }
}