using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        [HttpGet]
        public IActionResult get(string email, string password)
        {
            var context = new OnlineVideoStreamingAshfaqContext();

            var d = context.Admins.FirstOrDefault( res => res.AdminEmail == email && res.AdminPassword == password);

            if (d != null)
            {
                return Ok(d);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
