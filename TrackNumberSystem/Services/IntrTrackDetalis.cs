namespace TrackNumberSystem.Services;

using Interfaces;
using System;
using Models;
using Models.Abstract;

public class IntrTrackDetails : ITrackDetails
{
    public string Detalis(Track track)
    {
        var _track = track as IntrTrack
                     ?? throw new InvalidCastException();
        var statusDetails = _track.StatusRegistry.GetStatuses();
        return $"Трек-номер: {_track.TrackNumber}\n" +
               $"Страна прибытия: {_track.HomeCountry}\n" +
               $"Страна отправления: {_track.DepartCountry}\n" +
               $"Вес: {_track.Weight} кг\n" +
               $"Создан: {_track.CreationDate}\n" +
               $"Статусы:\n{statusDetails}";
    }
}