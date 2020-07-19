using DDD.Entidadess;
using DDD.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01.Controllers
{
    public class ProveedorController : Controller
    {
        // Definir un Manager
        ManagerProveedor mngProveedor = new ManagerProveedor();
        ManagerPais mngPais = new ManagerPais();

        // GET: Cliente
        public ActionResult Index()
        {
            return View(mngProveedor.Listar());
        }

        public ActionResult RegistrarProveedor()
        {
            ViewBag.paises = mngPais.Listar();
            return View(new Proveedor());
        }

        [HttpPost]
        public ActionResult RegistrarProveedor(Proveedor obj)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.paises = mngPais.Listar();
                return View(obj);
            }
            else
            {
                mngProveedor.Insertar(obj);
                return RedirectToAction("Index");
            }
        }

        public ActionResult ActualizarProveedor(int id)
        {
            Proveedor obj = mngProveedor.Obtener(id);
            ViewBag.paises = mngPais.Listar();
            return View(obj);
        }

        [HttpPost]
        public ActionResult ActualizarProveedor(Proveedor obj)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.paises = mngPais.Listar();
                return View(obj);
            }
            else
            {
                mngProveedor.Actualizar(obj);
                return RedirectToAction("Index");
            }
        }

        public ActionResult VerProveedor(int id)
        {
            return View(mngProveedor.Obtener(id));
        }

        public ActionResult EliminarProveedor(int id)
        {
            Proveedor obj = mngProveedor.Obtener(id);
            return View(obj);
        }

        [HttpPost]
        public ActionResult EliminarProveedor(Proveedor obj)
        {
            mngProveedor.Eliminar(obj.IdProveedor);
            return RedirectToAction("Index");
        }


    }
}