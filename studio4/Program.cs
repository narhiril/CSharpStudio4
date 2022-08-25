namespace studio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            MenuItem testItem = new MenuItem("Pasta", "It's pasta!", "Dinner", 9.99m);
            menu.AddMenuItem(testItem);
            Console.WriteLine(testItem.ToString());
        }
    }
}