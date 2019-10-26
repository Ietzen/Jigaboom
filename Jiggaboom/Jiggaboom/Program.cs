using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Jigaboom.Grid;

namespace ExampleAI_CS
{
    class Program
    {
        const int gridSize = 11;

        static void Main(string[] args)
        {
            var rng = new Random();
            var currentPebble = new Pebble(0, 0 ,0);

            int player = int.Parse(Console.ReadLine());

            var grid = new int[gridSize, gridSize];

            for (int moveCount = 0; moveCount < (gridSize* gridSize); ++moveCount)
            {
                if ((moveCount % 2) == player)
                {
                    // First move is random
                    if (moveCount == 0 || moveCount == 1)
                    {
                        while (true)
                        {
                            int x = rng.Next(gridSize);
                            int y = rng.Next(gridSize);

                            if (grid[y, x] != 0)
                                continue;

                            currentPebble.X = x;
                            currentPebble.Y = y;
                            currentPebble.team = 1;

                            grid[y, x] = 1;
                            Console.WriteLine($"{x} {y}");
                            break;
                        }
                    }
                    else
                    {
                        var move = GetMove(grid, currentPebble);
                        // If not found get random
                        if (move == (-1, -1))
                        {
                            while (true)
                            {
                                int x = rng.Next(gridSize);
                                int y = rng.Next(gridSize);

                                if (grid[y, x] != 0)
                                    continue;

                                currentPebble.X = x;
                                currentPebble.Y = y;
                                currentPebble.team = 1;

                                grid[y, x] = 1;
                                Console.WriteLine($"{x} {y}");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{move.Item2} {move.Item1}");
                            grid[move.Item1, move.Item2] = 1;
                            currentPebble.Y = move.Item1;
                            currentPebble.X = move.Item2;
                            currentPebble.team = 1;
                        }
                    }
                }
                else
                {
                    var c = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                    grid[c[1], c[0]] = 2;
                }
            }
        }

        static (int, int) GetMove(int[,] grid, Pebble currentPebble)
        {
            if (currentPebble.X + 1 <= gridSize - 1 && grid[currentPebble.Y, currentPebble.X + 1] == 0)
            {
                return (currentPebble.Y, currentPebble.X + 1);
            }
            if (currentPebble.X - 1 >= 0 && grid[currentPebble.Y, currentPebble.X - 1] == 0)
            {
                return (currentPebble.Y, currentPebble.X - 1);
            }
            if (currentPebble.Y + 1 <= gridSize - 1 && grid[currentPebble.Y + 1, currentPebble.X] == 0)
            {
                return (currentPebble.Y + 1, currentPebble.X);
            }
            if (currentPebble.Y - 1 >= 0 && grid[currentPebble.Y - 1, currentPebble.X] == 0)
            {
                return (currentPebble.Y - 1, currentPebble.X);
            }

            return (-1, -1);
        }
    }
}
