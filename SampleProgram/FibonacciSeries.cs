namespace CSharp_Learning.SampleProgram;

public class FibonacciSeries
{
    public static void Run()
    {
        int n1 = 0, n2 = 1, n3, i, num;
        
        // Taking input for elements
        Console.Write("Enter the number of elements you want: ");
        num = int.Parse(Console.ReadLine());
        
        // Printing first two elements
        Console.Write(n1 + " " + n2 + " ");
        
        // Printing from third element
        for (i = 2; i < num; i++)
        {
            n3 = n1 + n2;
            Console.Write(n3 + " ");

            n1 = n2;
            n2 = n3;
        }
    }
}