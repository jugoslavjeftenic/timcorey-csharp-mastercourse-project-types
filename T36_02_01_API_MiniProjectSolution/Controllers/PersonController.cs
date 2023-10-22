using Microsoft.AspNetCore.Mvc;
using T36_02_01_API_MiniProjectSolution.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace T36_02_01_API_MiniProjectSolution.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PersonController : ControllerBase
	{
		private ILogger _logger;

		public PersonController(ILogger<PersonController> logger)
		{
			_logger = logger;
		}

		// POST api/<PersonController>
		[HttpPost]
		public void Post([FromBody] PersonModel data)
		{
			_logger.LogInformation("Person was logged as {Person}", data);
		}
	}
}
