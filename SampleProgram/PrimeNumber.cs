namespace CSharp_Learning.SampleProgram;

public class PrimeNumber
{
    public static void Run()
    {
        int input, i, divided;
        bool flag = false;

        // Taking input for checking number
        Console.Write("Enter number for check prime or not: ");
        input = int.Parse(Console.ReadLine());

        divided = input / 2;

        for (i = 2; i < divided; i++)
        {
            if (input % i == 0)
            {
                Console.WriteLine("Prime Number!");
                flag = true;
                break;
            }
        }

        if (flag == false)
        {
            Console.WriteLine("Not Prime Number!");
        }
    }
}