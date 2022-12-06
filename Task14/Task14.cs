internal class Task14
{
    static void Main()
    {
        int a,b,c;

        Console.WriteLine("Enter a: ");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter b:");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter c: ");
        c = int.Parse(Console.ReadLine());

        if (a>b && a>c)
        {
            Console.WriteLine("A: " + a);
        }
        else if (b>a && b>c)
        {
            Console.WriteLine("B: " + b);
        }
        else if (c>a && c>b)
        {
            Console.WriteLine("C: " + c);
        }
    }
}