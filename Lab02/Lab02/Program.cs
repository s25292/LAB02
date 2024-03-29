﻿namespace Lab02;

class Program
{
    static void Main(string[] args)
    {
        int[] tab = { 1, 2, 3, 4, 5 };
        Console.WriteLine(Avg(tab));
        Console.WriteLine(Max(tab));
    }

    static int Avg(int[] tab)
    {
        int sum = 0;
        for (int k = 0; k < tab.Length; k++)
        {
            sum += tab[k];
        }
        
        return sum / tab.Length;
    }

    static int Max(int[] tab)
    {
        int max = tab[0];
        for (int i = 0; i < tab.Length; i++)
        {
            if (max < tab[i])
            {
                max = tab[i];
            }
        }

        return max;
    }
}