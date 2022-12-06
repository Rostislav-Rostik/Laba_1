internal class Task12
{
    static void Main()
    {
        int n;
        bool result = true;

        n = int.Parse(Console.ReadLine());

        if (n>20 && n%2!=0)
        {
            result = true;
            
        }
        else
        {
            result = false;
        }
        Console.WriteLine(result);
    }
}