internal class Task10
{
    static void Main()
    {
        int n, lastDigit;
        Console.WriteLine("Enter a number:");
        n = int.Parse(Console.ReadLine());

        lastDigit = n % 10;

        Console.WriteLine(lastDigit);
    }
}