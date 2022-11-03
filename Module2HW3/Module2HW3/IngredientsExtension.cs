namespace Module2HW3
{
    public static class IngredientsExtension
    {
        public static (Ingredient ingredient, int mass)?[] FindByName(this (Ingredient ingredient, int mass)[] array, string name)
        {
            (Ingredient ingredient, int mass)?[] result = new (Ingredient ingredient, int mass)?[array.Length];
            int i = 0;
            foreach ((Ingredient ingredient, int mass) ingredient in array)
            {
                if (ingredient.ingredient.Name.Contains(name))
                {
                    result[i] = ingredient;
                    i++;
                }
            }
            return result;
        }
        public static (Ingredient ingredient, int mass)?[] FindByMass(this (Ingredient ingredient, int mass)[] array, int mass, string op)
        {
            (Ingredient ingredient, int mass)?[] result = new (Ingredient ingredient, int mass)?[array.Length];
            int i = 0;
            foreach ((Ingredient ingredient, int mass) ingredient in array)
            {
                switch (op)
                {
                    case "<":
                        if (ingredient.mass < mass)
                        {
                            result[i] = ingredient;
                            i++;
                        }
                        break;
                    case "<=":
                        if (ingredient.mass <= mass)
                        {
                            result[i] = ingredient;
                            i++;
                        }
                        break;
                    case "=":
                        if (ingredient.mass == mass)
                        {
                            result[i] = ingredient;
                            i++;
                        }
                        break;
                    case ">":
                        if (ingredient.mass > mass)
                        {
                            result[i] = ingredient;
                            i++;
                        }
                        break;
                    case ">=":
                        if (ingredient.mass >= mass)
                        {
                            result[i] = ingredient;
                            i++;
                        }
                        break;
                }
            }
            return result;
        }
        public static (Ingredient ingredient, int mass)?[] FindByCalories(this (Ingredient ingredient, int mass)[] array, int calories, string op)
        {
            (Ingredient ingredient, int mass)?[] result = new (Ingredient ingredient, int mass)?[array.Length];
            int i = 0;
            foreach ((Ingredient ingredient, int mass) ingredient in array)
            {
                switch (op)
                {
                    case "<":
                        if (ingredient.ingredient.Calories100g < calories)
                        {
                            result[i] = ingredient;
                            i++;
                        }
                        break;
                    case "<=":
                        if (ingredient.ingredient.Calories100g <= calories)
                        {
                            result[i] = ingredient;
                            i++;
                        }
                        break;
                    case "=":
                        if (ingredient.ingredient.Calories100g == calories)
                        {
                            result[i] = ingredient;
                            i++;
                        }
                        break;
                    case ">":
                        if (ingredient.ingredient.Calories100g > calories)
                        {
                            result[i] = ingredient;
                            i++;
                        }
                        break;
                    case ">=":
                        if (ingredient.ingredient.Calories100g >= calories)
                        {
                            result[i] = ingredient;
                            i++;
                        }
                        break;
                }
            }
            return result;
        }
    }
}
