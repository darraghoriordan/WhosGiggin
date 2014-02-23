using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WhosGiggin.Models;
using WhosGiggin.DataContext;

namespace WhosGiggin.Controllers
{   
    public class VenueController : Controller
    {
			private readonly IUOW _repositoryUOW;

		// If you are using Dependency Injection, you can delete the following constructor
        public VenueController() : this(new UOW())
        {
        }

        public VenueController(IUOW eventmodelRepository)
        {
            _repositoryUOW = eventmodelRepository;
        }


        //
        // GET: /Venue/

        public ViewResult Index()
        {
            return View(_repositoryUOW.VenueRepository.All);
        }

        //
        // GET: /Venue/Details/5

        public ViewResult Details(int id)
        {
            return View(_repositoryUOW.VenueRepository.Find(id));
        }

        //
        // GET: /Venue/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Venue/Create

        [HttpPost]
        public ActionResult Create(VenueModel venuemodel)
        {
            if (ModelState.IsValid) {
                _repositoryUOW.VenueRepository.InsertOrUpdate(venuemodel);
                _repositoryUOW.VenueRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /Venue/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View(_repositoryUOW.VenueRepository.Find(id));
        }

        //
        // POST: /Venue/Edit/5

        [HttpPost]
        public ActionResult Edit(VenueModel venuemodel)
        {
            if (ModelState.IsValid) {
                _repositoryUOW.VenueRepository.InsertOrUpdate(venuemodel);
                _repositoryUOW.VenueRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /Venue/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(_repositoryUOW.VenueRepository.Find(id));
        }

        //
        // POST: /Venue/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            _repositoryUOW.VenueRepository.Delete(id);
            _repositoryUOW.VenueRepository.Save();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                _repositoryUOW.VenueRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

