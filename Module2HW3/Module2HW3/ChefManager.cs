namespace Module2HW3
{
    public class ChefManager : IChefManager
    {
        public void Make(IMeal meal)
        {
            Console.WriteLine($"You ordered: {meal.Name}");
            Console.WriteLine(meal.Recipe);
            Console.WriteLine($"Your {meal.Name} is ready. Enjoy.");
        }
        public void ShowCalories(IMeal meal)
        {
            Console.WriteLine($"This {meal.Name} contains {meal.Calories} calories.");
        }
        public void ShowIngredients(IMeal meal)
        {
            Console.WriteLine($"Ingredients for: {meal.Name}");
            foreach ((Ingredient ingredient, int mass) ingredient in meal.Ingredients)
            {
                Console.WriteLine($"{ingredient.ingredient.Name}: {ingredient.mass}g ({ingredient.ingredient.Calories100g} kcal/100g)");
            }
        }
        public void FindIngredients(IMeal meal)
        {
            int opt, intValue = 0;
            string op = string.Empty, stringValue = string.Empty;
            (Ingredient ingredient, int mass)?[] result;
            Console.WriteLine("Choose parameter to search for:\n1. Name\n2. Mass\n3. Calories\n");
            opt = Convert.ToInt32(Console.ReadLine());
            if (opt != 1)
            {
                Console.Write("Enter operator (<, <=, =, >, >=): ");
                op = Console.ReadLine();
            }
            Console.Write("Enter value: ");
            if (opt == 1)
            {
                stringValue = Console.ReadLine();
            }
            else
            {
                intValue = Convert.ToInt32(Console.ReadLine());
            }
            switch (opt)
            {
                case 1:
                    result = meal.Ingredients.FindByName(stringValue);
                    foreach ((Ingredient ingredient, int mass)? ingredient in result)
                    {
                        if (ingredient is null)
                        {
                            break;
                        }
                        Console.WriteLine($"{ingredient?.ingredient.Name}");
                    }
                    Console.WriteLine();
                    break;
                case 2:
                    result = meal.Ingredients.FindByMass(intValue, op);
                    foreach ((Ingredient ingredient, int mass)? ingredient in result)
                    {
                        if (ingredient is null)
                        {
                            break;
                        }
                        Console.WriteLine($"{ingredient?.ingredient.Name}: {ingredient?.mass}g");
                    }
                    Console.WriteLine();
                    break;
                case 3:
                    result = meal.Ingredients.FindByCalories(intValue, op);
                    foreach ((Ingredient ingredient, int mass)? ingredient in result)
                    {
                        if (ingredient is null)
                        {
                            break;
                        }
                        Console.WriteLine($"{ingredient?.ingredient.Name}: {ingredient?.ingredient.Calories100g} kcal/100g");
                    }
                    Console.WriteLine();
                    break;
                default:
                    result = new (Ingredient ingredient, int mass)?[0];
                    break;
            }
        }
        public void SortIngredients(IMeal meal)
        {
            int opt;
            Console.WriteLine("Choose parameter to sort by:\n1. Name\n2. Mass\n3. Calories\n");
            opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    meal.Ingredients = meal.Ingredients.OrderBy(x => x.ingredient.Name).ToArray(); // can't do it in any adequate way without linq
                    break;
                case 2:
                    meal.Ingredients = meal.Ingredients.OrderBy(x => x.mass).ToArray();
                    break;
                case 3:
                    meal.Ingredients = meal.Ingredients.OrderBy(x => x.ingredient.Calories100g).ToArray();
                    break;
            }
            foreach ((Ingredient ingredient, int mass) ingredient in meal.Ingredients)
            {
                Console.WriteLine($"{ingredient.ingredient.Name}: {ingredient.mass}g ({ingredient.ingredient.Calories100g} kcal/100g)");
            }
        }
    }
}
