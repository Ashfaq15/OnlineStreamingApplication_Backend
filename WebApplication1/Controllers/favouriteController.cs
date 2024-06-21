using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class favouriteController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult get(int id)
        {
            var context = new OnlineVideoStreamingAshfaqContext();
            var d = context.Favourites.AsQueryable();

            if(id != null)
            {
                d = d.Where(r => r.UserId == id);
            }
            var res = d.ToList();
            return Ok(res);
        }

        [HttpPost]

        public IActionResult post([FromBody] Favourite newData)
        {
            var context = new OnlineVideoStreamingAshfaqContext();
            
            context.Favourites.Add(newData);
            context.SaveChanges();
            return Ok();
        }

        [HttpGet("checking")]

        public IActionResult checking(int userid, int videoid)
        {
            var context = new OnlineVideoStreamingAshfaqContext();
            var d = context.Favourites.AsQueryable();

            if(userid != null && videoid != null)
            {
                d = d.Where(r => r.UserId == userid && r.VideoId == videoid);
                return Ok(d);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
