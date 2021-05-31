using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practica2parcialllpa1.Business;
using practica2parcialllpa1.Data.Entities;

namespace practica2parcialllpa1.Controllers
{
    public class PedidoController : Controller


    {
        private PedidoBiz pedidoBiz;
        // GET: Pochoclo
        public PedidoController()
        {
            pedidoBiz = new PedidoBiz();
        }

        public ActionResult Index()
        {
            var pochoclos = pedidoBiz.Listar();
            return View(pochoclos);
        }

        [HttpPost]
        public ActionResult Edit(Pedido pedido)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            pedidoBiz.Update(pedido);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var pedido = pedidoBiz.Get(id);

            if (pedido != null)
            {
                return View(pedido);
            }

            return View();
        }

        [HttpPost]
        public ActionResult Create(Pedido pedido)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            pedidoBiz.Agregar(pedido);

            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            
            return View();
        }

        public ActionResult Delete(int id)
        {
            var pedido = pedidoBiz.Get(id);
            if (pedido == null)
            {
                return View();
            }

            return View(pedido);
        }

        [HttpPost]
        public ActionResult Delete(Pedido model)
        {
            if (!ModelState.IsValid || model == null)
            {
                return View();
            }

            pedidoBiz.Eliminar(model);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var pedido = pedidoBiz.Get(id);
            if (pedido == null)
            {
                return View();
            }

            return View(pedido);
        }
    }
}