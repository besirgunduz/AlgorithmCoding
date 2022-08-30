namespace FindTownJudge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //In a town, there are n people labeled from 1 to n. There is a rumor that one of these people is secretly the town judge.
            //If the town judge exists, then:
            //1. The town judge trusts nobody.
            //2. Everybody(except for the town judge) trusts the town judge.
            //3. There is exactly one person that satisfies properties 1 and 2.
            //Return the label of the town judge if the town judge exists and can be identified, or return -1 otherwise.
        }

        private static int FindJudge(int n, int[][] trust)
        {
            var trustCount = new int[n + 1];

            foreach (var t in trust)
            {
                trustCount[t[0]]--;
                trustCount[t[1]]++;
            }

            for (int i = 1; i <= n; i++)
            {
                if (trustCount[i] == n - 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
