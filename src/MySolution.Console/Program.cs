
namespace MySolution.Console
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("What's your name?");
                var name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name)){
                    break;   
                }

                Console.WriteLine($"Hello, {name}!");
            }
            Console.WriteLine("Bye!");
        }
    }
}
