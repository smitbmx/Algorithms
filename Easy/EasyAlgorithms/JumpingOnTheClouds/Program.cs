using System;

namespace JumpingOnTheClouds
{
    class Program
    {
        static int jumpingOnClouds(int[] c)
        {
            int jumps = 0;

            int i = 0;
            while (i < c.Length - 1)
            {
                int next = i + 1;
                int nextnext = i + 2;

                if ((c[next] == 0 || c[next] == 1) && nextnext == c.Length)
                {
                    jumps++;
                    break;
                }

                if (c[nextnext] == 1)
                {
                    i++;
                    jumps++;
                }
                else if (c[nextnext] == 0)
                {
                    i++;
                    i++;
                    jumps++;
                }
            }

            return jumps;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = jumpingOnClouds(c);

            Console.WriteLine(result);
        }
    }
}
