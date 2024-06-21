using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        [HttpGet]

        public IActionResult get()
        {
            var context = new OnlineVideoStreamingAshfaqContext();
            var d = context.Ratings;

            return Ok(d);
        }

        [HttpPost]

        public IActionResult post([FromBody] Rating newRating)
        {
            var context = new OnlineVideoStreamingAshfaqContext();
            context.Ratings.Add(newRating);
            context.SaveChanges();
            return Ok();
        }

        [HttpGet("searchingById")]

        public IActionResult getById(int userid,int videoid)
        {
            var context = new OnlineVideoStreamingAshfaqContext();
            var d = context.Ratings.AsQueryable();

            if( userid != null && videoid != null)
            {
                d = d.Where(r => r.UserId == userid && r.VideoId == videoid);
                
            }
            
            return Ok(d);
        }
    }
}
