using System;

namespace T03_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 12;
            double N = 6.5;
            double M = 11.3;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(N);
            Console.WriteLine(M);
            Console.WriteLine(x+y);
            Console.WriteLine(x-y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y);
            Console.WriteLine(x % y);
            Console.WriteLine(N + M);
            Console.WriteLine(N - M);
            Console.WriteLine(N * M);
            Console.WriteLine(N / M);
            Console.WriteLine(N % M);
            Console.WriteLine(x + N);
            Console.WriteLine(y / M);
            Console.WriteLine(y % M);

            Console.WriteLine(x * 2);
            Console.WriteLine(y * 2);
            Console.WriteLine(N * 2);
            Console.WriteLine(M * 2);
            Console.WriteLine(x+y+N+M);
            Console.WriteLine(x * y * N * M);

            Console.ReadKey();
        }
    }
}
