namespace CSharp_Learning.SampleProgram;

public class FibonacciSeriesRecursion
{
    static int fibonacci(int num)
    {
        if (num <= 1)
        {
            return num;
        }

        return fibonacci(num - 1) + fibonacci(num - 2);
    }

    public static void Run()
    {
        int number;
        
        // Taiking input number for elements
        Console.Write("Enter number of elements you want: ");
        number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            Console.Write(fibonacci(i) + " ");
        }
    }
}