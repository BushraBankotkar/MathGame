string? name = GetName();

var date = DateTime.UtcNow;

var games = new List<string>();
string GetName()
{
    Console.WriteLine("Please enter your name");
    var name = Console.ReadLine();
    return name;
}

Menu(name);

void Menu(string? name)
{
    Console.WriteLine("----------------------------------------");
    Console.WriteLine($"Hello {name}, it's {date}. This is Math Game. \n");

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
                GetHistory();
                break;
            case "a":
                AdditionGame("Addition game.");
                break;
            case "s":
                SubtractionGame("Subtraction game.");
                break;
            case "m":
                MultiplicationGame("Multiplication game.");
                break;
            case "d":
                DivisionGame("Division game.");
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

void GetHistory()
{
    Console.Clear();
    Console.WriteLine("---------------------------------------");
    foreach(string game in games)
    {
        Console.WriteLine(game);
    }
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("Press any key to go to main menu");
    Console.ReadLine();
}

void AdditionGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);
    var random = new Random();
    int firstNumber;
    int secondNumber;
    int score = 0;
    for(int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(0, 9);
        secondNumber = random.Next(0, 9);

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();

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
        if (i == 4) { 
            Console.WriteLine($"Addition game completed. Your score is {score}. Press any key to go back to the main menu.");
            Console.ReadLine();
        }
    }
    AddToHistory(score, "Addition");  
}

void AddToHistory(int score, string type)
{
    games.Add($"{DateTime.Now} - {type}: Score = {score} pts");
}

void SubtractionGame(string message)
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
        if (i == 4) { 
            Console.WriteLine($"Subtraction game completed. Your score is {score}. Press any key to go back to the main menu.");
            Console.ReadLine();
        }
    }

    AddToHistory(score, "Subtraction");
}

void MultiplicationGame(string message)
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
        if (i == 4) { 
            Console.WriteLine($"Multiplication game completed. Your score is {score}. Press any key to go back to the main menu.");
            Console.ReadLine();
        }
    }
    AddToHistory(score, "Multiplication");
}

void DivisionGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);
    int score = 0;
    for (int i = 0; i < 5; i++)
    {
        var divNumbers = GetDivisionNumber();
        var firstNumber = divNumbers[0];
        var secondNumber = divNumbers[1];

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var result = Console.ReadLine();

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
        if (i == 4) { 
            Console.WriteLine($"Division game completed. Your score is {score}. Press any key to go back to the main menu.");
            Console.ReadLine();
        }

    }
    AddToHistory(score, "Division");
}

int[] GetDivisionNumber()
{
    var random = new Random();

    int[] result = new int[2];

    int firstNumber = random.Next(1, 99);
    int secondNumber = random.Next(1, 99);

    while(firstNumber % secondNumber != 0)
    {
        firstNumber = random.Next(1, 99);
        secondNumber = random.Next(1, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;

    return result;
}

