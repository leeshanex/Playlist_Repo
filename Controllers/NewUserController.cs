using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Playlist_Project.Controllers
{
    public class NewUserController : Controller
    {
        // GET: NewUser
        public ActionResult Index()
        {
            return View();
        }

        // GET: NewUser/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NewUser/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewUser/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NewUser/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NewUser/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NewUser/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NewUser/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}