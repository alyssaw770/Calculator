using static System.Collections.Specialized.BitVector32;

namespace CalculatorApp;

class Program
{
    static void Main(string[] args)
    {

        float num1;
        float num2;
        float answer;
        string? selection;

        Console.WriteLine("Welcome to The Calculator App!");

        Console.WriteLine("Enter you first number:");
        num1 = float.Parse(Console.ReadLine()!);

        Console.WriteLine("Enter another number:");
        num2 = float.Parse(Console.ReadLine()!);

        Console.WriteLine("Select a for addition, s for subtraction, m for multiplication, and any other key for division.");

        selection = Console.ReadLine()!.ToLower();

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
            answer = num2 == 0? float.NaN: num1 / num2;
        }

        if(float.IsNaN(answer)){
            Console.WriteLine("Cannot divide by 0!");
        } else{
            Console.WriteLine("The answer is " + answer);
        }
    }
}

