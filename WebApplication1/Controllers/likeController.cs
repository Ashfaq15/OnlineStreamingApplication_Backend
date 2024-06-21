using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class likeController : ControllerBase
    {

        [HttpGet]
        public IActionResult get()
        {
            var context = new OnlineVideoStreamingAshfaqContext();
            var d = context.Likes;

            return Ok(d);
        }


        [HttpGet("{id}")]

        public IActionResult get(int id)
        {
            var context = new OnlineVideoStreamingAshfaqContext();
            var d = context.Likes.AsQueryable();

            if(id != null)
            {
                d = d.Where(r => r.UserId == id);
            }

            var res = d.ToList();
            return Ok(res);
        }

        [HttpPost]

        public IActionResult post([FromBody] Like newData)
        {
            var context = new OnlineVideoStreamingAshfaqContext();
            
            context.Likes.Add(newData);
            context.SaveChanges();
            return Ok();
        }


        //checking if video is liked already
        [HttpGet("checking")]

        public IActionResult checking(int userid, int videoid)
        {
            var context = new OnlineVideoStreamingAshfaqContext();
            var d = context.Likes.AsQueryable();

            if(userid != null && videoid != null)
            {
                d = d.Where( r => r.UserId == userid && r.VideoId == videoid);
            }
            return Ok(d);

        }
    }
}
