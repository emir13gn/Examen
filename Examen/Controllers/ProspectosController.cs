using Examen.DB;
using Examen.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen.Controllers
{
    public class ProspectosController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ProspectosController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Prospecto> listaProspectos = _context.Prospecto;
            return View(listaProspectos);
        }

        [HttpPost]
        public IActionResult Captura(Prospecto prospecto)
        {
            if (ModelState.IsValid)
            {
                _context.Prospecto.Add(prospecto);
                _context.SaveChanges();

                return RedirectToAction("Index");

            }

            return View();
        }

        public IActionResult Info(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            var prospecto = _context.Prospecto.Find(id);

            if(prospecto == null)
            {
                return NotFound();
            }
            
            return View(prospecto);
        }

        public IActionResult Evaluar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var prospecto = _context.Prospecto.Find(id);

            if (prospecto == null)
            {
                return NotFound();
            }

            return View(prospecto);
        }

        [HttpPost]
        public IActionResult Evaluar(Prospecto prospecto)
        {
            if (ModelState.IsValid)
            {
                _context.Prospecto.Add(prospecto);
                _context.SaveChanges();

                return RedirectToAction("Index");
                
            }

            return View();
        }
        
        public IActionResult Autorizar(Prospecto prospecto)
        {
            if (ModelState.IsValid)
            {
                prospecto.estatus = "AUTORIZADO";
                prospecto.observaciones = "";
                _context.Prospecto.Add(prospecto);
                _context.SaveChanges();

                return RedirectToAction("Index");

            }

            return View();
        }

        
        public IActionResult Rechazar(Prospecto prospecto)
        {

            if (ModelState.IsValid)
            {
                prospecto.estatus = "RECHAZADO";
                _context.Prospecto.Add(prospecto);
                _context.SaveChanges();

                return RedirectToAction("Index");

            }

            return View();
        }



    }
}
