using System.ComponentModel.DataAnnotations;

namespace T35_02_02_MiniProjectSolution.Models
{
	public class PersonModel
	{
		[Required]
		[Display(Name = "First Name")]
		public string FirstName { get; set; } = "";

		[Required]
		[Display(Name = "Last Name")]
		public string LastName { get; set; } = "";

		[Display(Name = "Active User")]
		public bool IsActive { get; set; }
	}
}
