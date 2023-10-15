using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace T34_01_02_RazorPages_Homework.Pages
{
	public class PrivacyModel : PageModel
	{
		private readonly ILogger<PrivacyModel> _logger;

		public PrivacyModel(ILogger<PrivacyModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{
		}
	}
}