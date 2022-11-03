namespace Module2HW3
{
    public class Chef
    {
        public Chef(string name)
        {
            Name = name;
            ChefManager = new ChefManager();
        }
        public string Name { get; private set; }
        public IChefManager ChefManager { get; private set; }
    }
}
