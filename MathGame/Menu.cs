

namespace MathGame
{
    internal class Menu
    {
        GameEngine engine = new GameEngine();
        internal void ShowMenu(string? name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Hello {name}, it's {date}. This is Math Game. \n");
            Console.WriteLine("Press any key to see menu.");
            Console.ReadLine();

            var isLoop = true;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"What game would you like to play today?
                V - View History
                A - Addition
                S - Subtraction
                M - Multiplication
                D - Division
                Q - Quit
                ");
                Console.WriteLine("----------------------------------------");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.GetHistory();
                        break;
                    case "a":
                        engine.AdditionGame("Addition game.");
                        break;
                    case "s":
                        engine.SubtractionGame("Subtraction game.");
                        break;
                    case "m":
                        engine.MultiplicationGame("Multiplication game.");
                        break;
                    case "d":
                        engine.DivisionGame("Division game.");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye!");
                        isLoop = false;
                        //Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid Input!!!");
                        //Environment.Exit(1);
                        break;
                }
            }
            while (isLoop);

        }
    }
}
