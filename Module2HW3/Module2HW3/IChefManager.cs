namespace Module2HW3
{
    public interface IChefManager
    {
        void Make(IMeal meal);
        void ShowCalories(IMeal meal);
        void ShowIngredients(IMeal meal);
        void FindIngredients(IMeal meal);
        void SortIngredients(IMeal meal);
    }
}
