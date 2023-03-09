using System;

namespace Matice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolik ma graf vrcholu?");
            int vrcholy = int.Parse(Console.ReadLine());

            int[,] matice = new int[vrcholy, vrcholy];

            for (int x = 0; x < vrcholy; x++)
            {
                for (int y = 0; y < vrcholy; y++)
                {
                    
                    if (x == y)
                    {
                        matice[x, y] = 0;
                        continue;
                    }
                    Console.WriteLine("Je vrchol {0} propojen s vrcholem {1}? 1/2", x + 1, y + 1);
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            matice[x, y] = 1;
                            break;
                        case 2:
                            matice[x, y] = 0;
                            break;
                    }
                }
            }
            for (int x = 0; x < vrcholy; x++)
            {
                Console.WriteLine();
                for (int y = 0; y < vrcholy; y++)
                {
                    Console.Write(matice[x, y]);
                }
            }
        }
    }
}
