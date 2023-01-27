using System.Collections;
using System.Collections.Generic;

namespace AlgorithmCoding
{
    //Given an integer numRows, return the first numRows of Pascal's triangle.
    //In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:

    //Input: numRows = 5
    //Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]

    public class PascalTriangle
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            var triangle = new List<IList<int>>();

            if (numRows == 0)
                return triangle;

            var firstRow = new List<int>();
            firstRow.Add(1);
            triangle.Add(firstRow);

            for (int i = 1; i < numRows; i++)
            {
                var previousRow = triangle[i - 1];
                var currentRow = new List<int>();
                currentRow.Add(1);

                for (int j = 1; j < i; j++)
                {
                    currentRow.Add(previousRow[j] + previousRow[j - 1]);
                }

                currentRow.Add(1);
                triangle.Add(currentRow);
            }

            return triangle;
        }
    }
}
