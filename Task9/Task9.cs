internal class Task9
{
    static void Main()
    {
        float a, b, h;
        double area;

        Console.WriteLine("Enter a: ");
        a = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter b: ");
        b = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter h: ");
        h = float.Parse(Console.ReadLine());
        
        area = ((a+b)/2.0)*h;

        Console.WriteLine(area);
    }
}