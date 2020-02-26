using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Howdy Y'all!!");

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.ReadKey(); // What happens if you run the app without this line?
        }
    }
}
