internal class Program
{
    //private const int V = 2;

    private static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        //int i = 1;

        for (int i = 1; i < number; i++)
        {
            if (i % 2 != 0)
                continue;
            Console.WriteLine(i);
        }
    }
}