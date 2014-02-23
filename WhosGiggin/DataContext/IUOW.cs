using System;
using WhosGiggin.Models;

namespace WhosGiggin.DataContext
{
    public interface IUOW
    {
        void Dispose();
        GenericRepository<EventModel> EventRepository { get; }
        void Save();
        GenericRepository<VenueModel> VenueRepository { get; }
    }
}
