using Microsoft.EntityFrameworkCore;
using MoodAnalyzerAPI.Models;

namespace MoodAnalyzerAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<MoodEntry> MoodEntries { get; set; }
    }
}