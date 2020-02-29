using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please pick your dialect: Southern, Northern, Other");

            if (args.Length == 0)
            {
                Console.WriteLine();
                var userEntry = Console.ReadLine();
                switch (userEntry)
                {
                    case "Southern":
                        Console.WriteLine("Hey Ya'll!");
                        break;
                    case "Northern":
                        Console.WriteLine("Hi, Youse guys!");
                        break;
                    case "Other":
                        Console.WriteLine("Live long and prosper.");
                        break;
                    default:
                        Console.WriteLine("Hey Ya'll!");
                        break;
                }
            }

            Console.WriteLine("Please enter your Name:");
            var userName = Console.ReadLine();
            Console.WriteLine($"Hay {userName}!");

            Console.WriteLine("What's your favorite color?");
            var faveColor = Console.ReadLine();
            Console.WriteLine($"Cool, your favorite color is {faveColor}.");


            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "Cat", "Dog" };
            var vowels = new[] { 'a', 'e', 'i', 'o', 'u', 'y' };
            int count = 0;

            foreach (var animal in animals)
            {
                foreach(var vowel in vowels)
                {
                    if (animal.Contains(vowel))
                    {
                        count++;
                    }
                }
                if (count >= 2)
                {
                    Console.WriteLine(animal);
                }
                count = 0;
            }

            Random randomAnimal = new Random();
            int index = randomAnimal.Next(animals.Length);
            Console.WriteLine($"{userName} would you like to have a {faveColor} {animals[index]}?");

            Console.ReadKey(); // What happens if you run the app without this line?
        }
    }
}
