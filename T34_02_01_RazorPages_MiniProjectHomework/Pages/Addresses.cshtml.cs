using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using T34_02_01_RazorPages_MiniProjectHomework.Models;

namespace T34_02_01_RazorPages_MiniProjectHomework.Pages
{
	public class AddressesModel : PageModel
	{
		[BindProperty]
		public List<AddressModel> Addresses { get; set; } = new();
		[BindProperty]
		public string BindedStreetAddress { get; set; } = "";
		[BindProperty]
		public string BindedCity { get; set; } = "";
		[BindProperty]
		public string BindedState { get; set; } = "";
		[BindProperty]
		public string BindedZipCode { get; set; } = "";

		public void OnGet()
		{
		}

		public IActionResult OnPost()
		{
			Addresses.Add(new AddressModel()
			{
				StreetAddress = BindedStreetAddress,
				City = BindedCity,
				State = BindedState,
				ZipCode = BindedZipCode
			});
			return Page();
		}
	}
}
