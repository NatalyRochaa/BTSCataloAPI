using System;

public class Music
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string ExternalUrl { get; set; }
    public int DurationMs { get; set; }  
    public byte[] Image { get; set; }  

    public Music(Guid id, string name, string externalUrl, int durationMs, byte[] image)
    {
        Id = id;
        Name = name;
        ExternalUrl = externalUrl;
        DurationMs = durationMs;
        Image = image;
    }
}
