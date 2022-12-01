namespace MethodsExercise;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        string userName = Console.ReadLine();

        Console.WriteLine("What is your favorite color?");
        string favoriteColor = Console.ReadLine();

        Console.WriteLine("what is your favorite animal?");
        string favoriteAnimal = Console.ReadLine();

        Console.WriteLine("What is your favorite band");
        string favoriteBand = Console.ReadLine();

        Console.WriteLine($"There was a man named {userName}, his favorite color is {favoriteColor}.");
        Console.WriteLine($"His favorite animal is a {favoriteAnimal}.");
        Console.WriteLine($"He loves to listen music and {favoriteBand} is his favorite band.");

        Console.WriteLine($"Give me a number");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Give me another number to add to the first");
        int num2 = int.Parse(Console.ReadLine());

        int Sum = Add(num1, num2);
        Console.WriteLine($"The answer is {Sum}");

        Console.WriteLine($"Give me a number");
        int num3 = int.Parse(Console.ReadLine());


        Console.WriteLine($"Give me another number to subtract from the first");
        int num4 = int.Parse(Console.ReadLine());

        int answer = Subtract(num3, num4
            );
        Console.WriteLine($"The answer is {answer}");

        Console.WriteLine($"Give me a number");
        int num5 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Give me another number to multiply");
        int num6 = int.Parse(Console.ReadLine());

        int Product = Multiply(num5, num6);
        Console.WriteLine($"The answer is {Product}");

        Console.WriteLine($"Give me a number");
        int num7 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Give me another number to divide");
        int num8 = int.Parse(Console.ReadLine());

        int Result = Divide(num7, num8);
        Console.WriteLine($"The answer is {Result}");

        Console.WriteLine($"Give me a number");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine($"Give me another number to get the remainder");
        int b = int.Parse(Console.ReadLine());

        int Remainder = Modulus(a, b);
        Console.WriteLine($"The answer is {Remainder}");

    }


    public static int Add(int num1, int num2)
    {


        return num1 + num2;
    }

    public static int Subtract(int num3, int num4)
    {
        return num3 - num4;
    }

    public static int Multiply(int num5, int num6)
    {
        return num5 * num6;
    }

    public static int Divide(int num7, int num8)
    {
        return num7 / num8;
    }

    public static int Modulus(int a, int b)
    {
        return a % b;
    }
}
