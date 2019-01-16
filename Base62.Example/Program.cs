using System;

namespace Base62.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                string str = Base62.Encode(i);
                Console.Write($"{str}:{Base62.Decode(str)}\t");
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
