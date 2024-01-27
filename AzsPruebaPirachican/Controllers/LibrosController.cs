using AzsPruebaPirachican.Data;
using AzsPruebaPirachican.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AzsPruebaPirachican.Controllers
{
	public class LibrosController : Controller
	{
		private readonly AppliactionDbContext _context;

        public LibrosController(AppliactionDbContext db)
		{
			_context = db;
		}
		// GET: LibrosController
		public async Task<IActionResult> Index()
		{
			List<AutoresModel> list = new List<AutoresModel>();
			list = await _context.Autores.ToListAsync();
			return View(list);
		}

		// GET: LibrosController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: LibrosController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: LibrosController/Create
		[HttpPost]
		//[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(IFormCollection collection)
		{
			LibrosModel obj = new LibrosModel();
			obj.titulo = Request.Form["tit"];
			obj.AutorID = Convert.ToInt32(Request.Form["selAutor"]);
			//obj.libroID = "gh003";
			obj.fecCreacion = DateTime.Today;
			obj.estado = 1;
			
				_context.Add(obj);
				await _context.SaveChangesAsync();

			return  Redirect("Index");
		}

		// GET: LibrosController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: LibrosController/Edit/5
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

		// GET: LibrosController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: LibrosController/Delete/5
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

		public async Task<IActionResult> listaAutores()
		{
			List<AutoresModel> list = new List<AutoresModel>();
			list = await _context.Autores.ToListAsync();
			return View(list);
		}
	}
}
