using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDataController : ControllerBase
    {


        [HttpGet("totalUsers")]

        public IActionResult getTotalUsers()
        {
            var context = new OnlineVideoStreamingAshfaqContext();
            var totalCount = context.UsersData.Count();
            return Ok(totalCount);
        }


        [HttpGet]
        public IActionResult getData()
        {
            var context = new OnlineVideoStreamingAshfaqContext();
            var data = context.UsersData;

            return Ok(data);
        }

        [HttpPost]
        public IActionResult addData([FromBody] UsersDatum user)
        {
            try
            {
                var context = new OnlineVideoStreamingAshfaqContext();
                var data = context.UsersData;

                context.UsersData.Add(user);
                context.SaveChanges();

                return Ok(new { message = "User added successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        //login Search

        [HttpGet("login")]

        public IActionResult checkUser(string email, string password)
        {
            var context = new OnlineVideoStreamingAshfaqContext();
            var data = context.UsersData.FirstOrDefault(u => u.UserEmail == email ); 

            if(data != null)
            {
                return Ok(data);
            }
            else
            {
                return NotFound(); 
            }
        }
    }
}
