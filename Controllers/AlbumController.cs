using Microsoft.AspNetCore.Mvc;
using BTSCataloAPI.Models;
using BTSCataloAPI.Data;
using System.Collections.Generic;
using System.Linq;

[Route("api/[controller]")]
[ApiController]
public class AlbumController : ControllerBase
{
    private readonly AppDbContext _context;

    public AlbumController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAlbuns()
    {
        var albuns = _context.Albuns.ToList();
        return Ok(albuns);
    }

    [HttpPost]
    public ActionResult<Album> AddAlbum([FromBody] Album novoAlbum)
    {
        _context.Albuns.Add(novoAlbum);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetAlbuns), new { id = novoAlbum.Id }, novoAlbum);
    }
}