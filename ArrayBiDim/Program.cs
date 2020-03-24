using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            int h;
            int v;
            float f;
            float mt = 0;

            Console.WriteLine("Escreva a dimensão horizontal de um array bidimensional de floats");
            while (!int.TryParse(Console.ReadLine(), out h))
                    {
                        Console.WriteLine("Escreva a dimensão horizontal de um array bidimensional de floats");
                        Console.WriteLine("Not a valid int");
                    }

            Console.WriteLine("Escreva a dimensão vertical de um array bidimensional de floats");
            while (!int.TryParse(Console.ReadLine(), out v))
                    {
                        Console.WriteLine("Escreva a dimensão vertical de um array bidimensional de floats");
                        Console.WriteLine("Not a valid int");
                    }

            float [,] matrix = new float [h,v];

            for (int i = 0; i < h; i++)
            {
                float m = 0;

                for (int j = 0; j < v; j++)
                {
                    Console.WriteLine($"Escreva o número real que ocupa o {j+1}º elemento da {i+1}ª linha");
                    while (!float.TryParse(Console.ReadLine(), out f))
                    {
                        Console.WriteLine($"Escreva o número real que ocupa o {j+1}º elemento da {i+1}ª linha");
                        Console.WriteLine("Not a valid float");
                    }

                    matrix[i,j] = f;
                    m += f;
                }

                m /= v;
                mt += m;
                Console.WriteLine($"Média da {i+1}ª linha: {m}");
            }

            Console.WriteLine($"Soma das médias: {mt}");
        }
    }
}
