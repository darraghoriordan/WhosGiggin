using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WhosGiggin.Models;

namespace WhosGiggin.DataContext
{
    public class UOW : IDisposable, IUOW
    {
        private DatabaseContext _context = new DatabaseContext();
        private GenericRepository<VenueModel> _venueRepository;
        private GenericRepository<EventModel> _eventRepository;
        public UOW(GenericRepository<VenueModel> venueRepository, GenericRepository<EventModel> eventRepository) {
            this._venueRepository = venueRepository;
            this._eventRepository = eventRepository;
        }
        public GenericRepository<VenueModel> VenueRepository
        {
            get
            {          
                return _venueRepository;
            }
        }

        public GenericRepository<EventModel> EventRepository
        {
            get
            {
                return _eventRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}