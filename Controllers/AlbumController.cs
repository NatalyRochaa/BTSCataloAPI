using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class AlbumController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAlbuns()
    {
        
        return Ok("Em breve: álbuns vindos do Spotify!");
    }
}
