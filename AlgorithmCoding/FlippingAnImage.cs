using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCoding
{
    public class FlippingAnImage
    {
        //Given an n x n binary matrix image, flip the image horizontally, then invert it, and return the resulting image.

        //Input: image = [[1,1,0],[1,0,1],[0,0,0]]
        //Output: [[1,0,0],[0,1,0],[1,1,1]]
        //Explanation: First reverse each row: [[0,1,1],[1,0,1],[0,0,0]].
        //Then, invert the image: [[1,0,0],[0,1,0],[1,1,1]]

        public static int[][] FlipAndInvertImage(int[][] image)
        {
            for (int i = 0; i < image.Length; i++)
            {
                var start = 0;
                var end = image.Length - 1;

                while (start < end)
                {
                    var temp = image[i][start];
                    image[i][start] = image[i][end];
                    image[i][end] = temp;

                    start++;
                    end--;
                }

                for (int j = 0; j < image.Length; j++)
                {
                    image[i][j] ^= 1;
                }

            }

            return image;
        }
    }
}
