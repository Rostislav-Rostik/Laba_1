internal class Task13
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool result = true;

        if ((n%9==0) || (n%11==0) || (n%13==0))
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