using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using YourNamespace.Services;

[ApiController]
[Route("api/[controller]")]
public class AlbumController : ControllerBase
{
    private readonly SpotifyService _spotifyService;

    public AlbumController()
    {
        _spotifyService = new SpotifyService();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAlbumById(string id)
    {
        var album = await _spotifyService.GetAlbumDetails(id);
        if (album == null)
            return NotFound("Álbum não encontrado.");
        return Ok(album);
    }
}