using Microsoft.AspNetCore.Mvc;
using BTSCataloAPI.Models;
using System.Collections.Generic;
using BTSCataloAPI.Data;

[Route("api/[controller]")]
[ApiController]
public class MusicController : ControllerBase
{
    
    private readonly AppDbContext _context;

    public MusicController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetMusics()
    {
        var musics = _context.Musics.ToList();
        return Ok(musics);
    }


    
    [HttpPost]
    public ActionResult<Music> AddMusic([FromBody] Music novaMusic)
    {
        if (novaMusic == null || string.IsNullOrWhiteSpace(novaMusic.Titulo))
            {
                return BadRequest("Música inválida.");
            }

    _context.Musics.Add(novaMusic);
    _context.SaveChanges();
    return CreatedAtAction(nameof(GetMusics), new { id = novaMusic.Id }, novaMusic);
}

}
