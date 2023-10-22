using Microsoft.AspNetCore.Mvc;
using T36_02_01_API_MiniProjectSolution.Models;

namespace T36_02_01_API_MiniProjectSolution.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AddressController : ControllerBase
	{
		private ILogger _logger;

		public AddressController(ILogger<AddressController> logger)
		{
			_logger = logger;
		}

		// POST api/<AddressController>
		[HttpPost]
		public void Post([FromBody] AddressModel data)
		{
			_logger.LogInformation("Person was logged as {Address}", data);
		}
	}
}
