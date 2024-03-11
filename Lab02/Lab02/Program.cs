namespace Lab02;

class Program
{
    static void Main(string[] args)
    {
        int[] tab = { 1, 2, 3, 4, 5 };
        Console.WriteLine(Avg(tab));
    }

    static int Avg(int[] tab)
    {
        int sum = 0;
        for (int i = 0; i < tab.Length; i++)
        {
            sum += tab[i];
        }

        return sum / tab.Length;
    }
}