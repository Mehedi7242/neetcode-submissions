public class Solution {
public int IslandPerimeter(int[][] grid)
    {
        int totalIsland = 0;
        int sharedBorder = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                if(grid[i][j] == 1)
                {
                    totalIsland += 1;
                    if (j + 1 < grid[i].Length && grid[i][j+1] == 1)
                    {
                        sharedBorder += 1;
                    }

                    if (i + 1 < grid.Length && grid[i+1][j] == 1)
                    {
                        sharedBorder += 1;
                    }
                }
            }
        }
        Console.WriteLine("totalIsland: " + totalIsland);
        Console.WriteLine("sharedBorder: " + sharedBorder);
        int totalPerimeter = (totalIsland * 4) - (sharedBorder * 2);
        Console.WriteLine("totalPerimeter: " + totalPerimeter);
        return totalPerimeter;
    }
    }