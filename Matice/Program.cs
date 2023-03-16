using System;

namespace Matice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolik ma graf vrcholu?");
            int vrcholy = int.Parse(Console.ReadLine());

            int INF = int.MaxValue / 2;
            int[,] matice =
            {
            {0, 5, INF, 10},
            {INF, 0, 3, 1},
            {INF, INF, 0, 1},
            {INF, INF, INF, 0},
            };


            FloydWarshall();
            void FloydWarshall()
            {

                for (int i = 0; i < vrcholy; i++)
                {
                    for (int j = 0; j < vrcholy; j++)
                    {
                        for (int k = 0; k < vrcholy; k++)
                        {
                            matice[i, j] = Math.Min(matice[i, j], matice[i, k] + matice[k, j]);
                        }
                    }
                }
                Console.WriteLine("Odkud chceš cestu?");
                int odkud = int.Parse(Console.ReadLine());
                Console.WriteLine("Kam chceš cestu?");
                int kam = int.Parse(Console.ReadLine());
                Console.WriteLine(matice[odkud - 1, kam - 1]);
            }



          /*  int[,] matice = new int[vrcholy, vrcholy];
            
            InicializaceGrafu();

           void InicializaceGrafu()
            {
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
            }*/

        }
    }
}
