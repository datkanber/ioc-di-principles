using System;

namespace UdemyIOC.console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BL bl = new BL(new OracleDAL());

            bl.GetProducts().ForEach(x =>
            {
                Console.WriteLine($"{x.Id}-{x.Name}-{x.Price}-{x.Stock}");
            });

            Console.ReadLine();
        }
    }
}