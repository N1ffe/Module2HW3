namespace Module2HW3
{
    public interface IMeal
    {
        string Name { get; set; }
        (Ingredient ingredient, int mass)[] Ingredients { get; set; }
        int Calories { get; set; }
        string Recipe { get; set; }
    }
}
