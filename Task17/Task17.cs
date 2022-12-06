internal class Task17
{
    static void Main()
    {
        int number, fact = 1;
        Console.WriteLine("Enter number: ");
        number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            fact = fact * i;
        }
        Console.WriteLine("Factorial of " + number + " is: " + fact);
    }
}