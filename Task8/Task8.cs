internal class Task8
{
    static void Main()
    {
        byte a, b, c;
        double avg;

        Console.WriteLine("Enter a: ");
        a = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter b: ");
        b = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter c: ");
        c = byte.Parse(Console.ReadLine());

        avg = (a + b + c) / 3.0;

        Console.WriteLine(avg);
    }
}