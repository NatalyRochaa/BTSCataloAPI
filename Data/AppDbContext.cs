using Microsoft.EntityFrameworkCore;
using BTSCataloAPI.Models;

namespace BTSCataloAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Album> Albuns { get; set; }
        public DbSet<Music> Musics { get; set; } 
    }
}
