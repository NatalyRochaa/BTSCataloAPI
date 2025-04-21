using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YourNamespace.Services
{
    public class SpotifyService
    {
        private static readonly HttpClient client = new HttpClient();
        private static string accessToken = "";  

        public async Task<Album> GetAlbumDetails(string albumId)
        {
            try
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);

                var response = await client.GetStringAsync($"https://api.spotify.com/v1/albums/43wFM1HquliY3iwKWzPN4y");
                var album = JsonConvert.DeserializeObject<Album>(response);

                return album;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao pegar dados do álbum: {ex.Message}");
                return null;
            }
        }

        public async Task<Music> GetTrackDetails(string trackId)
        {
            try
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);

                var response = await client.GetStringAsync($"https://api.spotify.com/v1/tracks/5YMXGBD6vcYP7IolemyLtK");
                var track = JsonConvert.DeserializeObject<Music>(response);

                return track;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao pegar dados da música: {ex.Message}");
                return null;
            }
        }
    }
}

