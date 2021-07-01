using System;

namespace MaxAreaofIsland
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] i1 =
            {
                new[] {0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0}, new[] {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                new[] {0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0}, new[] {0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0},
                new[] {0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0}, new[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                new[] {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0}, new[] {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0}
            };
            int r1 = MaxAreaOfIsland(i1);

            int[][] i2 =
            {
                new[] {1, 1, 0, 0, 0}, new[] {1, 1, 0, 0, 0},
                new[] {0, 0, 0, 1, 1}, new[] {0, 0, 0, 1, 1},
            };
            int r2 = MaxAreaOfIsland(i2);
        }

        static void Reccur(int[][] grid, int i, int j, int m, int n)
        {
            if (i - 1 >= 0 && grid[i - 1][j] == 1)
            {
                grid[i - 1][j] = 2;
                Reccur(grid, i - 1, j, m, n);
            }

            if (i + 1 < m && grid[i + 1][j] == 1)
            {
                grid[i + 1][j] = 2;
                Reccur(grid, i + 1, j, m, n);
            }

            if (j - 1 >= 0 && grid[i][j - 1] == 1)
            {
                grid[i][j - 1] = 2;
                Reccur(grid, i, j - 1, m, n);
            }

            if (j + 1 < n && grid[i][j + 1] == 1)
            {
                grid[i][j + 1] = 2;
                Reccur(grid, i, j + 1, m, n);
            }
        }

        static int MaxAreaOfIsland(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int count = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int x = grid[i][j];
                    if (x == 1)
                    {
                        count++;
                        grid[i][j] = 2;
                        Reccur(grid, i, j, m, n);
                    }
                }
            }

            return count;
        }
    }
}