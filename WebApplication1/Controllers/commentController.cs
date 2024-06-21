using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class commentController : ControllerBase
    {
        [HttpGet]
        public IActionResult get()
        {
            var context = new OnlineVideoStreamingAshfaqContext();
            var d = context.Comments;
            return Ok(d);
        }


        [HttpGet("{id}")]

        public IActionResult get(int id)
        {
            var context = new OnlineVideoStreamingAshfaqContext();
            var d = context.Comments.AsQueryable();

            if( id != null)
            {
                d = d.Where(r => r.VideoId == id);
            }

            var res = d.ToList();
            return Ok(res);
        }

        [HttpPost]
        public IActionResult post([FromBody] Comment newData)
        {
            var context = new OnlineVideoStreamingAshfaqContext();

            context.Comments.Add(newData);
            context.SaveChanges();
            return Ok();
        }

        //[HttpDelete("{id}")]

        //public IActionResult delete(int id)
        //{
        //    var context = new OnlineVideoStreamingAshfaqContext();
        //    var d = context.Comments.Find(id);

        //    context.Comments.Remove(d);
        //    context.SaveChanges() ;

        //    return Ok();
        //}

        [HttpDelete("deleteVideo")]
        public IActionResult delete(int id, int userId, int userCommentId)
        {
            
            if(userId == userCommentId)
            {
                var context = new OnlineVideoStreamingAshfaqContext();
                var d = context.Comments.Find(id);
                context.Comments.Remove(d);
                context.SaveChanges();
                
            }
            return Ok();
        }
    }
}
