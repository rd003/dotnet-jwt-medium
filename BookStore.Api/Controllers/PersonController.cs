using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
    [Route("api/people")]
    [ApiController]
    [Authorize(Roles ="Admin")]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var fruits= await Task.FromResult(new string[] { "Jack", "Joe", "Jill" });
            return Ok(fruits);
        }
    }
}
