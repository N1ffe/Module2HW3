namespace Module2HW3
{
    public class Salad : IMeal
    {
        public Salad(string name, (Ingredient ingredient, int mass)[] ingredients, string recipe)
        {
            Name = name;
            Ingredients = ingredients;
            foreach ((Ingredient ingredient, int mass) ingredient in Ingredients)
            {
                Calories += ingredient.ingredient.Calories100g * ingredient.mass / 100;
            }
            Recipe = recipe;
        }
        public string Name { get; set; }
        public (Ingredient ingredient, int mass)[] Ingredients { get; set; }
        public int Calories { get; set; }
        public string Recipe { get; set; }
    }
}
