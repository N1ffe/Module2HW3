namespace Module2HW3
{
    public class Ingredient : IIngredient
    {
        public Ingredient(string name, int calories)
        {
            Name = name;
            Calories100g = calories;
        }
        public string Name { get; set; }
        public int Calories100g { get; set; }
    }
}
