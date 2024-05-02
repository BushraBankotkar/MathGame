
using MathGame.Models;

namespace MathGame
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            var random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(0, 9);
                secondNumber = random.Next(0, 9);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("You are correct. Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You are incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine($"Addition game completed. Your score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.Addition);
        }

        internal void SubtractionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            var random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(0, 9);
                secondNumber = random.Next(0, 9);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("You are correct. Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You are incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine($"Subtraction game completed. Your score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Subtraction);
        }

        internal void MultiplicationGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            var random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(0, 9);
                secondNumber = random.Next(0, 9);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("You are correct. Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You are incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine($"Multiplication game completed. Your score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.Multiplication);
        }

        internal void DivisionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                var divNumbers = Helpers.GetDivisionNumber();
                var firstNumber = divNumbers[0];
                var secondNumber = divNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("You are correct. Type any key for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You are incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine($"Division game completed. Your score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }

            }
            Helpers.AddToHistory(score, GameType.Division);
        }
    }
}
