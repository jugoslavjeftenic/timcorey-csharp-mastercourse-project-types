using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using T34_02_02_RazorPages_MiniProjectSolution.Models;

namespace T34_02_02_RazorPages_MiniProjectSolution.Pages
{
	public class PeopleModel : PageModel
	{
		[BindProperty]
		public PersonModel Person { get; set; } = new();

		public void OnGet()
		{
		}

		public IActionResult OnPost()
		{
			if (ModelState.IsValid == false)
			{
				return Page();
			}

			return RedirectToPage("./Index");
		}
	}
}
