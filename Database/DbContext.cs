using FoodTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodTracker.Database;

public class FoodTrackerContext : DbContext
{
    public DbSet<Meal> Meals { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data source=tracker.db");
    }
}



