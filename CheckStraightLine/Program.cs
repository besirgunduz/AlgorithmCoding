using System;

namespace CheckStraightLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You are given an array coordinates, coordinates[i] = [x, y], where [x, y] represents the coordinate of a point.
            //Check if these points make a straight line in the XY plane.

            //Input: coordinates = [[1,2],[2,3],[3,4],[4,5],[5,6],[6,7]]
            //Output: true

        }
        public static bool CheckStraightLine(int[][] c)
        {

            if (c.Length < 2) return true;

            for (int i = 0; i < c.Length - 2; i++)
            {
                if ((c[i + 2][1] - c[i + 1][1]) * (c[i + 1][0] - c[i][0]) !=
                  (c[i + 1][1] - c[i][1]) * (c[i + 2][0] - c[i + 1][0]))
                {
                    return false;
                }
            }

            return true;

        }
    }
}
