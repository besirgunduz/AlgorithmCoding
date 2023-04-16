namespace AlgorithmCoding
{
    public class IslandPerimeter
    {
        //You are given row x col grid representing a map where grid[i][j] = 1 represents land and grid[i][j] = 0 represents water.
        //Grid cells are connected horizontally/vertically(not diagonally). The grid is completely surrounded by water, and there is exactly one island(i.e., one or more connected land cells).
        //The island doesn't have "lakes", meaning the water inside isn't connected to the water around the island.One cell is a square with side length 1. The grid is rectangular, width and height don't exceed 100. Determine the perimeter of the island.

        //Input: grid = [[0,1,0,0],
        //              [1,1,1,0],
        //              [0,1,0,0],
        //              [1,1,0,0]]
        //Output: 16

        public static int IslandPerimeterResult(int[][] grid)
        {
            var land = 0;
            var neighbour = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        land++;

                        if (i < grid.Length - 1 && grid[i + 1][j] == 1)
                        {
                            neighbour++;
                        }

                        if (j < grid[i].Length - 1 && grid[i][j + 1] == 1)
                        {
                            neighbour++;
                        }
                    }
                }
            }

            return land * 4 - (neighbour * 2);
        }
    }
}
