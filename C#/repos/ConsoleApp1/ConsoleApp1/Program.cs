public class Progress
{  
    public static void Main(String[] args)
    {
        one();
        Console.WriteLine();
        two();

    }


    public static void one()
    {
        for (int a = 1; a <= 10; a++)
        {
            Console.WriteLine(a);
        }
    }
    public static void two()
    {
        for (int b = 10; b > 0; b--)
        {
            Console.WriteLine(b);
        }
    }
}