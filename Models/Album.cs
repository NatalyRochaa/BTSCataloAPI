namespace BTSCataloAPI.Models // pesquisei oq era esse namespace, e ele basicamente serve 
// como um agrupador de classes, interfaces e outros componentes. Ele organiza quando tem
// diferentes classas com o mesmo nome em um projeto
{
    public class Album
    {
        public int Id { get; set; } 
        public string Title { get; set; } = string.Empty;
        public string Artist { get; set; } = "BTS";
        public DateTime ReleaseDate { get; set; }
        public List<Music> Tracks { get; set; } = new List<Music>();
    }
}
