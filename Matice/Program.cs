using System;

namespace Matice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolik ma graf vrcholu?");
            int vrcholy = 10;

            int INF = int.MaxValue / 2;
            int[,] matice =
            {
            {0,2,INF,INF,INF,INF,4,5,INF,4},
            {2,0,3,INF,INF,INF,INF,INF,INF,3},
            {INF,3,0,4,INF,INF,INF,INF,3,2},
            {INF,INF,4,0,2,4,INF,INF,3,INF},
            {INF,INF,INF,2,0,3,INF,INF,INF,INF},
            {INF,INF,INF,4,3,0,5,3,2,INF},
            {4,INF,INF,INF,INF,5,0,3,INF,INF},
            {5,INF,INF,INF,INF,3,3,0,3,4},
            {INF,INF,3,3,INF,2,INF,3,0,4},
            {4,3,2,INF,INF,INF,INF,4,4,0},
            };
            
            int[,] MaticeOptimal = {
            {0,2,INF,INF,INF,INF,4,5,INF,4},
            {2,0,3,INF,INF,INF,INF,INF,INF,3},
            {INF,3,0,4,INF,INF,INF,INF,3,2},
            {INF,INF,4,0,INF,4,INF,INF,3,INF},
            {INF,INF,INF,INF,0,3,INF,INF,INF,INF},
            {INF,INF,INF,4,3,0,5,3,2,INF},
            {4,INF,INF,INF,INF,5,0,3,INF,INF},
            {5,INF,INF,INF,INF,3,3,0,3,4},
            {INF,INF,3,3,INF,2,INF,3,0,4},
            {4,3,2,INF,INF,INF,INF,4,4,0},
            };
            string[,] Objizdka = new string[vrcholy,vrcholy];

            FloydWarshall();




            void FloydWarshall()
            {
                string KudyKam = "";

                for (int k = 0; k < vrcholy; k++)
                {
                    for (int i = 0; i < vrcholy; i++)
                    {
                        for (int j = 0; j < vrcholy; j++)
                        {
                            if (MaticeOptimal[i, j] < (MaticeOptimal[i, k] + MaticeOptimal[k, j]))
                            {
                                MaticeOptimal[i, j] = MaticeOptimal[i, j];
  
                            }
                            else 
                            {
                                MaticeOptimal[i, j] = MaticeOptimal[i, k] + MaticeOptimal[k, j];
                            }

                        }

                    }
                }
                Console.WriteLine("Odkud chceš cestu?");
                int odkud = int.Parse(Console.ReadLine());
                Console.WriteLine("Kam chceš cestu?");
                int kam = int.Parse(Console.ReadLine());
                Console.WriteLine(MaticeOptimal[odkud - 1, kam - 1]);
                Console.WriteLine(KudyKam);
                Console.WriteLine("Přes vrcholy {0}", KudyKam);
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
