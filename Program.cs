namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Products products = new Products() { ID =1, Price=19.5, DiscountPercentage=12.5, Name="Tomato"};
            products.DiscountPercentage = 100;
            products.DiscountChange += Products_DiscountChange;
            products.DiscountPercentage = 100;
            products.DiscountPercentage = 99;
        }

        private static void Products_DiscountChange(Products product, double discount)
        {
            Console.WriteLine("Hello World");
        }
    }
}