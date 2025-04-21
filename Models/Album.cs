using System;
using System.Collections.Generic;

public enum AlbumType
{
    Studio,
    Live,
    Compilation,
    EP
}

public class Album
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime ReleaseDate { get; set; }
    public AlbumType Type { get; set; }
    public List<string> Images { get; set; }  
    public string ExternalUrl { get; set; }

    public Album(Guid id, string name, DateTime releaseDate, AlbumType type, List<string> images, string externalUrl)
    {
        Id = id;
        Name = name;
        ReleaseDate = releaseDate;
        Type = type;
        Images = images;
        ExternalUrl = externalUrl;
    }
}
