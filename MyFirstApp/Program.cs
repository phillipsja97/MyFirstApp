using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Console.WriteLine("Enter your name...");
            var userEntry = Console.ReadLine();

            Console.WriteLine(userEntry);
            Console.ReadLine();

            if (userEntry == "jamie")
            {
                Console.WriteLine("you are awesome");
            }
            else
            {
                Console.WriteLine("you suck");
            }
            Console.ReadLine();

            var i = 0;
            while (i < 10)
            {
                Console.WriteLine($"Current value of i is {i++}...");
            }
            Console.ReadLine();

            for (var j = 0; j < 10; j++)
            {
                Console.WriteLine($"Current value of i is {j}...");
            }

            foreach (var currentCharacter in userEntry)
            {
                Console.WriteLine($"the current character is {currentCharacter}");
            }

            switch (userEntry)
            {
                case "jamie":
                    Console.WriteLine("It's jamie");
                    break;
                default:
                    Console.WriteLine("It's anything but jamie");
                    break;
            }
                    Console.ReadLine();

            var isJamie = userEntry == "jamie" ? true : false;

            //try
            //{
            //    var y = 0;
            //    var x = 1 / y;
            //}
            //catch (Exception e)
            //{
                            
                
            //    Console.WriteLine(e);
            //    throw;
            //}

        }
    }
}
