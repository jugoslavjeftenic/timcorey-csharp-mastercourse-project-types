using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace T34_01_02_RazorPages_Homework.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

		[BindProperty]
		public string FirstName { get; set; } = "";
		[BindProperty]
		public string LastName { get; set; } = "";
		[BindProperty]
		public string Output { get; set; } = "";

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{
		}

		public IActionResult OnPost()
		{
			Output = $"Hi {FirstName} {LastName}.";
			return Page();
		}
	}
}