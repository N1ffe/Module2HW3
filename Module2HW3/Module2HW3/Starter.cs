namespace Module2HW3
{
    public class Starter
    {
        public void Run()
        {
            Chef chef = new Chef("Frank");
            Salad salad = new Salad(
                "Coleslaw",
                new (Ingredient ingredient, int mass)[]
                {
                    (new Ingredient("Green cabbage", 29), 200),
                    (new Ingredient("Purple cabbage", 31), 150),
                    (new Ingredient("Carrot", 41), 100),
                    (new Ingredient("Mayonnaise", 680), 50),
                    (new Ingredient("Vinegar", 18), 10),
                    (new Ingredient("Celery seeds", 392), 20),
                    (new Ingredient("Sugar", 387), 2),
                    (new Ingredient("Salt", 0), 2),
                    (new Ingredient("Pepper", 255), 2)
                },
                "In a large serving bowl, combine cabbage, purple cabbage, and carrot. In a small mixing bowl, " +
                "mix together mayonnaise, vinegar, sugar, celery seeds, salt, and pepper. Stir to combine. " +
                "Add dressing to the salad and toss to combine.");
            chef.ChefManager.Make(salad);
            Console.WriteLine();
            chef.ChefManager.ShowCalories(salad);
            Console.WriteLine();
            chef.ChefManager.ShowIngredients(salad);
            Console.WriteLine();
            chef.ChefManager.SortIngredients(salad);
            Console.WriteLine();
            chef.ChefManager.FindIngredients(salad);
        }
    }
}
