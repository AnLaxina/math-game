// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;

DateTime fullDate = DateTime.Now;
DateOnly today = DateOnly.FromDateTime(fullDate);
TimeOnly currentTime = TimeOnly.FromDateTime(fullDate);
List<string> validNumbers = new List<string>{"1", "2", "3", "4"};
Random random = new Random();

MainMenu();

// Create Individual Methods for each game mode
void MainMenu()
{
    Console.WriteLine("-----------------------------------------------------------------");
    Console.WriteLine(
        $@"Welcome to the math game! The date is {today.ToString("MMMM")} {today.Day}, {today.Year} and the time is: {currentTime}!");
    Console.WriteLine(
        "Please input the number based on the following options below and press the ENTER key once done: ");
    Console.WriteLine("1. Addition 2. Subtraction 3. Division 4. Multiplication");
    Console.WriteLine("-----------------------------------------------------------------");
    string userInput = Console.ReadLine();


// Checks to see if the user has inputted any invalid inputs
// If they did, the program loops until the user enters valid input
    while (!validNumbers.Contains(userInput))
    {
        Console.Write("Invalid input! Please try again: ");
        userInput = Console.ReadLine();
    }

    int userChoice = int.Parse(userInput);
    Console.Clear();
    Console.WriteLine("-----------------------------------------------------------------");
    switch (userChoice)
    {
        case 1:
            Console.WriteLine("Addition selected!");
            AdditionGame();
            break;
        case 2:
            Console.WriteLine("Subtraction selected!");
            Console.WriteLine(userChoice.GetType());
            break;
        case 3:
            Console.WriteLine("Division selected!");
            break;
        case 4:
            Console.WriteLine("Multiplication selected!");
            break;
    }

    Console.WriteLine("-----------------------------------------------------------------");
}

void AdditionGame()
{
    var isValid = true;
    var score = 0;
    Console.WriteLine("You will solve 4 questions total! Your score will be shown once you finish!");
    
    while (isValid)
    {
        var num1 = random.Next(1, 101);
        var num2 = random.Next(1, 101);
        Console.Write($"{num1} + {num2} = ");
        var userAnswer = Console.ReadLine();
        if (!userAnswer.GetType().ToString().Equals("System.Int32"))
        {
            Console.WriteLine(userAnswer.GetType());
            isValid = false;
        }

    }
}



