﻿using Microsoft.AspNetCore.Mvc;
using T35_02_02_MiniProjectSolution.Models;

namespace T35_02_02_MiniProjectSolution.Controllers
{
	public class PersonController : Controller
	{
		private readonly ILogger<PersonController> _logger;

		public PersonController(ILogger<PersonController> logger)
		{
			_logger = logger;
		}

		// GET: PersonController
		public ActionResult Index()
		{
			return View();
		}

		// GET: PersonController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: PersonController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(PersonModel data)
		{
			if (ModelState.IsValid == false)
			{
				_logger.LogWarning("The user submitted an invalid Person upon Create.");
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
