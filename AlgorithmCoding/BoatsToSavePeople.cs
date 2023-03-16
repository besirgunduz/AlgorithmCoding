using System;

namespace AlgorithmCoding
{
    public class BoatsToSavePeople
    {
        //You are given an array people where people[i] is the weight of the ith person,
        //and an infinite number of boats where each boat can carry a maximum weight of limit.
        //Each boat carries at most two people at the same time, provided the sum of the weight of those people is at most limit.
        //Return the minimum number of boats to carry every given person.

        //Input: people = [3,2,2,1], limit = 3
        //Output: 3
        //Explanation: 3 boats(1, 2), (2) and(3)

        public static int NumRescueBoats(int[] people, int limit)
        {
            Array.Sort(people);

            var start = 0;
            var end = people.Length - 1;
            var boatCount = 0;

            while (start <= end)
            {
                if (people[start] + people[end] <= limit)
                {
                    start++;
                    end--;
                }
                else
                {
                    end--;
                }

                boatCount++;
            }

            return boatCount;
        }
    }
}
