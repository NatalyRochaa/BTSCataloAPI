using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using YourNamespace.Services;

[ApiController]
[Route("api/[controller]")]
public class MusicController : ControllerBase
{
    private readonly SpotifyService _spotifyService;

    public MusicController()
    {
        _spotifyService = new SpotifyService();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetMusicById(string id)
    {
        var music = await _spotifyService.GetTrackDetails(id);
        if (music == null)
            return NotFound("Música não encontrada.");
        return Ok(music);
    }
}