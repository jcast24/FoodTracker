namespace FoodTracker.Models;

public enum MealType
{
    Breakfast,
    Lunch,
    Dinner,
    Snack,
}


public class Meal
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public double Protein { get; set; }
    public double Carbs { get; set; }
    public double Fats { get; set; }
    public double Calories { get; set; }
    public DateTime LoggedAt { get; set; } = DateTime.Now;

    public MealType Type { get; set; }
}
