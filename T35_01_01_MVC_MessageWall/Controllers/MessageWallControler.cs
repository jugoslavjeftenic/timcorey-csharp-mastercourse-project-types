using Microsoft.AspNetCore.Mvc;

namespace T35_01_01_MVC_MessageWall.Controllers
{
	public class MessageWallControler : Controller
	{
		// GET: MessageWallControler
		public ActionResult Index()
		{
			return View();
		}

		// GET: MessageWallControler/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: MessageWallControler/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: MessageWallControler/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
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

		// GET: MessageWallControler/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: MessageWallControler/Edit/5
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

		// GET: MessageWallControler/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: MessageWallControler/Delete/5
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
