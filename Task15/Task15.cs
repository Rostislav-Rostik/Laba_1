internal class Task15
{
    static void Main()
    {
        double a, b, c;
        string product;

        Console.WriteLine("Enter a: ");
        a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter b: ");
        b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter c: ");
        c = double.Parse(Console.ReadLine());

        if ((a<0 && b<0 && c<0) || (a<0 && b>0 && c>0) || (b<0 && a>0 && c>0) || (c<0 && a>0 && b>0))
        {
            product = "Negative";
        }
        else
        {
            product = "Positive";
        }
        Console.WriteLine(product);
    }
}