using Microsoft.AspNetCore.Mvc;

namespace TestRazor
{
    [Route("api/[controller]")]
    public class AvatarController : ControllerBase
    {
        [HttpGet, Route("{id}")]
        public IActionResult GetAvatar([FromRoute] string id)
        {
            if (id == "michelle")
            {
                return File(System.IO.File.OpenRead("images/michelle.png"), "images/jpeg");
            }
            if (id == "trump")
            {
                return File(System.IO.File.OpenRead("images/trump.jpg"), "images/jpeg");
            }
            return File(System.IO.File.OpenRead("images/unknown.jpg"), "images/jpeg");
        }
    }
}
