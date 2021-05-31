using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practica2parcialllpa1.Business;
using practica2parcialllpa1.Data.Entities;

namespace practica2parcialllpa1.Controllers
{
    public class PochocloController : Controller


    {
        private PochocloBiz pochocloBiz;
        // GET: Pochoclo
        public PochocloController()
        {
            pochocloBiz = new PochocloBiz();
        }

        public ActionResult Index()
        {
            var pochoclos = pochocloBiz.Listar();
            return View(pochoclos);
        }

        [HttpPost]
        public ActionResult Edit(Pochoclo pochoclo)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            pochocloBiz.Update(pochoclo);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var pochoclo = pochocloBiz.Get(id);

            if (pochoclo != null)
            {
                return View(pochoclo);
            }

            return View();
        }

        [HttpPost]
        public ActionResult Create(Pochoclo pochoclo)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            pochocloBiz.Agregar(pochoclo);

            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            
            return View();
        }

        public ActionResult Delete(int id)
        {
            var pochoclo = pochocloBiz.Get(id);
            if (pochoclo == null)
            {
                return View();
            }

            return View(pochoclo);
        }

        [HttpPost]
        public ActionResult Delete(Pochoclo model)
        {
            if (!ModelState.IsValid || model == null)
            {
                return View();
            }

            pochocloBiz.Eliminar(model);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var pochoclo = pochocloBiz.Get(id);
            if (pochoclo == null)
            {
                return View();
            }

            return View(pochoclo);
        }
    }
}