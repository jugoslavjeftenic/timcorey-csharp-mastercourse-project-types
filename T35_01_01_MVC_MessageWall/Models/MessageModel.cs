using System.ComponentModel.DataAnnotations;

namespace T35_01_01_MVC_MessageWall.Models
{
	public class MessageModel
	{
		[Required]
		[StringLength(10, MinimumLength = 5)]
		[Display(Name = "Really cool message")]
		public string Message { get; set; } = "";
	}
}
