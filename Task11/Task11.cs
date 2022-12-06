internal class Task11
{
    static void Main()
    {
        int number, n, nDigit;

        Console.WriteLine("Enter a number: ");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a count:");
        n = int.Parse(Console.ReadLine());

        nDigit = (int)(number / Math.Pow(10, (n - 1)) % 10);

        Console.WriteLine(nDigit);

    }
}