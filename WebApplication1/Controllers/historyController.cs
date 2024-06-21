using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class historyController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult get(int id)
        {
            var context = new OnlineVideoStreamingAshfaqContext();
            var d = context.Histories.AsQueryable();

            if(id != null)
            {
                d = d.Where(r => r.UserId == id);
            }

            var res = d.ToList();
            return Ok(res);
        }

        [HttpPost]

        public IActionResult post([FromBody] History data)
        {
            var context = new OnlineVideoStreamingAshfaqContext();
            
            context.Histories.Add(data);
            context.SaveChanges();
            
            return Ok();
        }
    }
}
