using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class bobvideoController  : ControllerBase
    {

        [HttpGet("totalVideos")]

        public IActionResult totalVideos()
        {
            var context = new OnlineVideoStreamingAshfaqContext();
            var totalCount = context.BobVideosData.Count();
            return Ok(totalCount);
        }


        [HttpGet]
        public IActionResult get()
        {
            var context = new OnlineVideoStreamingAshfaqContext();

            var d = context.BobVideosData;

            return Ok(d);
        }

        [HttpGet("{searchName}")]

        public IActionResult get(string searchName)
        {
            var context = new OnlineVideoStreamingAshfaqContext();

            var d = context.BobVideosData.AsQueryable();

            if(searchName != null)
            {
                d = d.Where(r => r.VideoName.Contains(searchName));

            }

            var res = d.ToList();
            return Ok(res);
        }


        [HttpDelete("{id}")]

        public IActionResult deleteUser(int id)
        {
            var context = new OnlineVideoStreamingAshfaqContext();
            var d = context.BobVideosData.Find(id);

            context.BobVideosData.Remove(d);
            context.SaveChanges();
            return Ok();
        }


        [HttpPost]
        public IActionResult insert([FromBody] BobVideosDatum newData)
        {
            var context = new OnlineVideoStreamingAshfaqContext();
            
            context.BobVideosData.Add(newData);
            context.SaveChanges();
            return Ok();
        }
    }
}
