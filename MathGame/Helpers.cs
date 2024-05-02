
using MathGame.Models;

namespace MathGame
{
    internal class Helpers
    {
        static List<Game> games = new List<Game>()
        {
            //new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
            //new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
            //new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
            //new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
            //new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
            //new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
            //new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
            //new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
            //new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 },
        };
        internal static void AddToHistory(int score, GameType type)
        {
            //games.Add($"{DateTime.Now} - {type}: Score = {score} pts");
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = score,
                Type = type
            });
        }

        internal static int[] GetDivisionNumber()
        {
            var random = new Random();

            int[] result = new int[2];

            int firstNumber = random.Next(1, 99);
            int secondNumber = random.Next(1, 99);

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        internal static void GetHistory()
        {
            //var gamesToPrint = games.Where(x => x.Type == GameType.Division);
            Console.Clear();
            Console.WriteLine("---------------------------------------");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date}-{game.Type}:{game.Score}pts");
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Press any key to go to main menu");
            Console.ReadLine();
        }

        internal static string? ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Your answer needs to be an integer. Try again");
                result = Console.ReadLine();
            }
            return result;
        }

        internal static string GetName()
        {
            Console.WriteLine("Please enter your name");
            var name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty.");
                name = Console.ReadLine();
            }
            return name;
        }
    }
}
