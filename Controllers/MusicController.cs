using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class MusicController : ControllerBase
{
    [HttpGet]
    public IActionResult GetMusics()
    {
    
        return Ok("Em breve: músicas vindas do Spotify!");
    }
}
