using Microsoft.AspNetCore.Mvc;
using T35_02_02_MiniProjectSolution.Models;

namespace T35_02_02_MiniProjectSolution.Controllers
{
	public class AddressController : Controller
	{
		private readonly ILogger<AddressController> _logger;

		public AddressController(ILogger<AddressController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		// GET: AddressController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: AddressController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(AddressModel data)
		{
			if (ModelState.IsValid == false)
			{
				_logger.LogWarning("The user submitted an invalid Address upon Create.");
				return View();
			}

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
