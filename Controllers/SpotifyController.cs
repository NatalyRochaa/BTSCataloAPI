using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Text.Json;

namespace BTSCataloAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpotifyController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly string _spotifyToken;

        public SpotifyController(IConfiguration configuration)
        {
            _spotifyToken = configuration["Spotify:Token"];
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _spotifyToken);
        }

        [HttpGet("bts")]
        public async Task<IActionResult> GetBTSAlbums()
        {
            
            var searchResponse = await _httpClient.GetAsync("https://api.spotify.com/v1/albums/...");
            if (!searchResponse.IsSuccessStatusCode) return StatusCode((int)searchResponse.StatusCode);

            var searchContent = await searchResponse.Content.ReadAsStringAsync();
            using var searchJson = JsonDocument.Parse(searchContent);
            var btsId = searchJson.RootElement
                .GetProperty("artists")
                .GetProperty("items")[0]
                .GetProperty("id")
                .GetString();

            if (string.IsNullOrEmpty(btsId)) return NotFound("Artista BTS não encontrado.");

           
            var albumsResponse = await _httpClient.GetAsync($"https://api.spotify.com/v1/tracks/...");
            if (!albumsResponse.IsSuccessStatusCode) return StatusCode((int)albumsResponse.StatusCode);

            var albumsContent = await albumsResponse.Content.ReadAsStringAsync();
            using var albumsJson = JsonDocument.Parse(albumsContent);

            var albums = albumsJson.RootElement.GetProperty("items")
                .EnumerateArray()
                .Select(album => new
                {
                    Name = album.GetProperty("name").GetString(),
                    ReleaseDate = album.GetProperty("release_date").GetString(),
                    ImageUrl = album.GetProperty("images").EnumerateArray().FirstOrDefault().GetProperty("url").GetString()
                })
                .ToList();

            return Ok(albums);
        }
    }
}