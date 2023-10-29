// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;

DateTime fullDate = DateTime.Now;
DateOnly today = DateOnly.FromDateTime(fullDate);
TimeOnly currentTime = TimeOnly.FromDateTime(fullDate);
List<string> validNumbers = new List<string>{"1", "2", "3", "4"};

Console.WriteLine("-----------------------------------------------------------------");
Console.WriteLine($@"Welcome to the math game! The date is {today.ToString("MMMM")} {today.Day}, {today.Year} and the time is: {currentTime}!");
Console.WriteLine("Please input the number based on the following options below and press the ENTER key once done: ");
Console.WriteLine("1. Addition 2. Subtraction 3. Division 4. Multiplication");
Console.WriteLine("-----------------------------------------------------------------");
string userInput = Console.ReadLine();



while (!validNumbers.Contains(userInput))
{
    Console.Write("Invalid input! Please try again: ");
    userInput = Console.ReadLine();
}

int userChoice = int.Parse(userInput);
Console.Clear();
switch (userChoice)
{
    
    case 1:
        Console.WriteLine("Addition selected!");
        break;
    case 2:
        Console.WriteLine("Subtraction selected!");
        break;
    case 3:
        Console.WriteLine("Division selected!");
        break;
    case 4:
        Console.WriteLine("Multiplication selected!");
        break;
}




