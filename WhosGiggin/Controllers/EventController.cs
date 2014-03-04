using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WhosGiggin.Models;
using WhosGiggin.DataContext;

namespace WhosGiggin.Controllers
{   
    public class EventController : Controller
    {
		private readonly IUOW _repositoryUOW;

        public EventController(IUOW eventmodelRepository)
        {
            _repositoryUOW = eventmodelRepository;
        }

        //
        // GET: /Event/

        public ViewResult Index()
        {
            return View(_repositoryUOW.EventRepository.All);
        }

        //
        // GET: /Event/Details/5

        public ViewResult Details(int id)
        {
            return View(_repositoryUOW.EventRepository.Find(id));
        }

        //
        // GET: /Event/Create

        public ActionResult Create()
        {
            this.ViewBag.VenueId = new SelectList(_repositoryUOW.VenueRepository.All, "Id", "Name");

            return View();
        } 

        //
        // POST: /Event/Create

        [HttpPost]
        public ActionResult Create(EventModel eventmodel)
        {
            if (ModelState.IsValid) {
                if (string.IsNullOrEmpty(eventmodel.ListedBy))
                {
                    eventmodel.ListedBy = User.Identity.Name;
                }
                _repositoryUOW.EventRepository.InsertOrUpdate(eventmodel);
                _repositoryUOW.EventRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /Event/Edit/5
 
        public ActionResult Edit(int id)
        {
            this.ViewBag.VenueId = new SelectList(_repositoryUOW.VenueRepository.All, "Id", "Name");

            return View(_repositoryUOW.EventRepository.Find(id));
        }

        //
        // POST: /Event/Edit/5

        [HttpPost]
        public ActionResult Edit(EventModel eventmodel)
        {
            if (ModelState.IsValid) {
                _repositoryUOW.EventRepository.InsertOrUpdate(eventmodel);
                _repositoryUOW.EventRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /Event/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(_repositoryUOW.EventRepository.Find(id));
        }

        //
        // POST: /Event/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            _repositoryUOW.EventRepository.Delete(id);
            _repositoryUOW.EventRepository.Save();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                _repositoryUOW.EventRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

