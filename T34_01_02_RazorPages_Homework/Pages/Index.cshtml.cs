using Microsoft.AspNetCore.Mvc.RazorPages;

namespace T34_01_02_RazorPages_Homework.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{

		}
	}
}