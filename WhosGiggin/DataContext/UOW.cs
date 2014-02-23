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
        
        public GenericRepository<VenueModel> VenueRepository
        {
            get
            {

                if (_venueRepository == null)
                {
                    _venueRepository = new GenericRepository<VenueModel>(_context);
                }
                return _venueRepository;
            }
        }

        public GenericRepository<EventModel> EventRepository
        {
            get
            {

                if (_eventRepository == null)
                {
                    _eventRepository = new GenericRepository<EventModel>(_context);
                }
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