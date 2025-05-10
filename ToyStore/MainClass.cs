using System;


    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue; // Set the text color to blue
            Console.WriteLine("Hello, what is your name?");
            string customerName = Console.ReadLine();
            Console.WriteLine(customerName + "...That is a nice name!");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("------------------------------------------");

            while (true)
            {
                
                Toys toys = new Toys(); // Connects the Toys class to the main class
                toys.toyList();

                Console.WriteLine("Enter a toy name to get information:");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "Nerf Gun":
                        Console.WriteLine("Nerf Gun is a popular toy for outdoor play. \nThe price of this toy is R55.");
                        break;
                    case "Hotwheel":
                        Console.WriteLine("Hotwheel is a brand of toy cars. \nThe price of this toy is R23.");
                        break;
                    case "Lego":
                        Console.WriteLine("Lego is a brand of building blocks. \nThe price of this toy is R300.");
                        break;
                    case "Playstation 5":
                        Console.WriteLine("Playstation 5 is a video game console. \nThe price of this toy is R12 000.");
                        break;
                    case "Barbie Doll":
                        Console.WriteLine("Barbie Doll is a popular fashion doll. \nThe price of this toy is R150.");
                        break;
                    case "Remote Control Car":
                        Console.WriteLine("Remote Control Car is a toy car controlled remotely. \nThe price of this toy is R180.");
                        break;
                    case "Board Game":
                        Console.WriteLine("Board Game is a game played on a board. \nThe price of this toy is R250.");
                        break;
                    case "Teddy Bear":
                        Console.WriteLine("Teddy Bear is a soft toy bear. \nThe price of this toy is R90.");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Toy not found in the list.");
                        Console.ForegroundColor = ConsoleColor.Green; // Reset color to default
                        break;
                }

                Console.WriteLine("Would you like to pick a toy, " + customerName + "? (Yes/No)");
                string quit = Console.ReadLine();

                if (quit == "No")
                {
                    Console.WriteLine("That is fine and you should take your time.");
                }
                else if (quit == "Yes")
                {
                    Console.WriteLine("Excellent!");
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter either 'Yes' or 'No'.");
                    Console.ForegroundColor = ConsoleColor.Green; // Reset color to default
                }
            }
        }
    }

