using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExampleAI_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            const int gridSize = 11;
            var rng = new Random();

            int player = int.Parse(Console.ReadLine());

            var grid = new int[gridSize, gridSize];

            for (int moveCount = 0; moveCount < (gridSize* gridSize); ++moveCount)
            {
                if ((moveCount % 2) == player)
                {
                    while (true)
                    {
                        int x = rng.Next(gridSize);
                        int y = rng.Next(gridSize);

                        if (grid[y, x] != 0)
                            continue;

                        grid[y, x] = 1;
                        Console.WriteLine($"{x} {y}");
                        break;
                    }
                }
                else
                {
                    var c = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                    grid[c[1], c[0]] = 2;
                }
            }
        }
    }
}
