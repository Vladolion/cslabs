namespace ConsoleApp1
{
    class lab1()
    {
        static void Main()
        {
            try
            {
                Product apple = new Product("Яблуко", 5, 100);
                Console.WriteLine(apple.GetInfo());
                apple.Sell(20);
                Console.WriteLine(apple.GetInfo());
                System.Threading.Thread.Sleep(2000);
                apple.Restock(50);
                Console.WriteLine(apple.GetInfo());
                apple.Price = 7;
                Console.WriteLine(apple.GetInfo());
                System.Threading.Thread.Sleep(2000);
                apple.Name = "Зелене яблуко";
                Console.WriteLine(apple.GetInfo());
                apple.Price = -10;
                apple.Name = "";
                apple.Sell(200);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}