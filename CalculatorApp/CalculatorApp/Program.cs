using static System.Collections.Specialized.BitVector32;

namespace CalculatorApp;

class Program
{
    static void Main(string[] args)
    {

        int num1;
        int num2;
        int answer;
        string? selection;

        Console.WriteLine("Welcome to The Calculator App!");

        Console.WriteLine("Enter you first number:");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter another number:");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Select a for addition, s for subtraction, m for multiplication, and any other key for division.");

        selection = Console.ReadLine();


        if (selection == "a")
        {
            answer = num1 + num2;
        }
        else if (selection == "s")
        {
            answer = num1 - num2;
        }
        else if (selection == "m")
        {
            answer = num1 * num2;
        }
        else
        {
            answer = num1 / num2;
        }

        Console.WriteLine("The answer is " + answer);

    }
}

