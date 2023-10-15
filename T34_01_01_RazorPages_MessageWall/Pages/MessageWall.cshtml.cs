using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace T34_01_01_RazorPages_MessageWall.Pages
{
	public class MessageWallModel : PageModel
	{
		[BindProperty]
		public string Message { get; set; } = "";
		[BindProperty]
		public List<string> Messages { get; set; } = new();

		public void OnGet()
		{
		}

		public IActionResult OnPost()
		{
			Messages.Add(Message);
			return Page();
		}
	}
}
