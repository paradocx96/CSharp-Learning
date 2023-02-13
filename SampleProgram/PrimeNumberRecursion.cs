namespace CSharp_Learning.SampleProgram;

public class PrimeNumberRecursion
{
    static bool isPrime(int input, int i)
    {
        if (input <= 2)
            return (input == 2) ? true : false;

        if (input % i == 0)
            return false;

        if (i * i > input)
            return true;

        return isPrime(input, i + 1);
    }

    public static void Run()
    {
        int number;

        // Taking input number for check prime or not
        Console.Write("Enter a number to check prime ot not: ");
        number = int.Parse(Console.ReadLine());

        if (isPrime(number, 2))
        {
            Console.WriteLine("Prime Number!");
        }
        else
        {
            Console.WriteLine("Not Prime Number!");
        }
    }
}