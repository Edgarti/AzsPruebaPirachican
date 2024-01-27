using AzsPruebaPirachican.Data;
using AzsPruebaPirachican.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AzsPruebaPirachican.Controllers
{
    public class AutoresController : Controller
    {

		private readonly AppliactionDbContext _context;

        public AutoresController(AppliactionDbContext db)
        {
			_context = db;
		}
        // GET: AutoresController
        public async Task<IActionResult> Index()
        {
			List<AutoresModel> list = new List<AutoresModel>();
			list = await _context.Autores.ToListAsync();
			return View(list);
		}

		[HttpPost]
		//[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(IFormCollection collection)
		{
			AutoresModel obj = new AutoresModel();
			//obj.autorID = Convert.ToInt32(Request.Form["aut"]);
			obj.nombre= Request.Form["aut"];
			obj.fecCreacion = DateTime.Today;
			obj.estado = 1;

			_context.Add(obj);
			await _context.SaveChangesAsync();

			return Redirect("Index");
		}

		// GET: AutoresController/Details/5
		public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AutoresController/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: AutoresController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AutoresController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AutoresController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AutoresController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
