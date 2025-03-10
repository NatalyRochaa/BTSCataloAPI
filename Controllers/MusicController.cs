using Microsoft.AspNetCore.Mvc;
using BTSCataloAPI.Models;
using System.Collections.Generic;

[Route("api/[controller]")]
[ApiController]
public class MusicController : ControllerBase
{
    
    private static List<Music> musicas = new List<Music>();

    
    [HttpGet]
    public ActionResult<IEnumerable<Music>> GetMusics()
    {
        return Ok(musicas);
    }

    
    [HttpPost]
    public ActionResult<Music> AddMusic([FromBody] Music novaMusic)
    {
        musicas.Add(novaMusic);
        return CreatedAtAction(nameof(GetMusics), new { id = novaMusic.Id }, novaMusic);
    }
}
