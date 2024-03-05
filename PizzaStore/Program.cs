using System.Security.Cryptography.X509Certificates;

namespace PizzaStore
{
    public class Program
    {
        static void Main(string[] args)
        {
            Store.start();
            Console.ReadKey();
        }
    }
}
