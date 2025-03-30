using System.Text.Json.Serialization;

namespace BTSCataloAPI.Models
{
    public class Music
    {
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    [JsonConverter(typeof(TimeSpanConverter))] 
    public TimeSpan Duracao { get; set; }
    public string Album {get; set;} = string.Empty;
    public string Titulo { get; set; } = string.Empty;
    public string Artista { get; set; } = string.Empty;
    }
}
