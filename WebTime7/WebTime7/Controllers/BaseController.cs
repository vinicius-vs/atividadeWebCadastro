using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTime7.Models;
using WebTime7.Repository;

namespace WebTime7.Controllers
{
    public class BaseController<M,R> : Controller where M:Basemodel where R:BaseRepository<M>
    {
        R repor = Activator.CreateInstance<R>();

        public ActionResult Index()
        {
            return View(repor.Read());
        }

        // GET: TransportController1/Details/5
        public ActionResult Details(int id)
        {
            return View(repor.Read(id));
        }

        // GET: TransportController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TransportController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(M model)
        {
            try
            {
                repor.Create(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TransportController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View(repor.Read(id));
        }

        // POST: TransportController1/Edit/5
        [HttpPost]
        public ActionResult Edit( M model)
        {
            try
            {
                repor.Update(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TransportController1/Delete/5
       
        public ActionResult Delete(int id)
        {
            try
            {
                repor.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
