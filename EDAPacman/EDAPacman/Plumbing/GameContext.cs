using System.Data.Entity;
using EDAPacman.Model;

namespace EDAPacman.Plumbing
{
    public class GameContext : DbContext
    {
        public DbSet<Maze> Mazes { get; set; }
    }
}