using AzsPruebaPirachican.Data;
using AzsPruebaPirachican.Dtos;
using AzsPruebaPirachican.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AzsPruebaPirachican.Controllers
{
    public class HomeController : Controller
    {
		private readonly AppliactionDbContext _context;
		private readonly ILogger<HomeController> _logger;

		public List<LibrosModel> libroList;
		
		public HomeController(ILogger<HomeController> logger,
             AppliactionDbContext db)
		{
			_logger = logger;
			_context = db;
		}

        [HttpGet]
        public async Task<IActionResult> Lista()
        {
			List<LibrosModel> list = new List<LibrosModel>();
			list = await _context.libros.ToListAsync();
			return View(list);	
		}

		private List<LibrosModel> NewMetodo(List<LibrosModel> list)
		{
			throw new NotImplementedException();
		}

		public async Task<IActionResult> Index()
        {

			List<LibrosModel> list = new List<LibrosModel>();
			list = await _context.libros.ToListAsync();
			return View(list);
		}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}