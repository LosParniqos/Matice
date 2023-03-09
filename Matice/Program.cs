using System;

namespace Matice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolik ma graf vrcholu?");
            int vrcholy = int.Parse(Console.ReadLine());

            int INF = int.MaxValue;
            int[,] matice = new int[vrcholy, vrcholy];

            for (int x = 0; x < vrcholy; x++)
            {
                for (int y = 0; y < vrcholy; y++)
                {

                    if (x == y)
                    {
                        matice[x, y] = INF;
                        continue;
                    }
                    Console.WriteLine("Jakou vahu ma propoj {0} s {1}?", x + 1, y + 1);
                    int VahaSpoje = int.Parse(Console.ReadLine());
                    if (VahaSpoje == 0)
                    {
                        matice[x, y] = INF;
                    }
                    else
                    {
                        matice[x, y] = VahaSpoje;
                    }
                }
            }
            for (int x = 0; x < vrcholy; x++)
            {
                Console.WriteLine();
                for (int y = 0; y < vrcholy; y++)
                {
                    if (matice[x, y] == INF)
                    {
                        Console.Write("MAX".ToString().PadLeft(5));
                    }
                    else
                    {
                        Console.Write(matice[x, y].ToString().PadLeft(5));
                    }
                }
            }
        }
    }
}
