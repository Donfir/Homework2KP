using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;

namespace Third
{
    internal class Less3
    {
        public static int[] Enter()
        {
            string A = Console.ReadLine();
            return A.Split(' ').Select(int.Parse).SkipLast(1).ToArray() ?? [];
        }
        public static int Kolvo(int[] A)
        {
            int cnt = 0;
            for(int i = 1; i < A.Count();i++)
            {
                if (A[i] > A[i - 1])
                    cnt++;
            }
            return cnt;
        }
        public static string UnEq(int a, int b)
        {
            if (b == 0 && a == 0)
                return "Many solutions";
            if (b != 0 && a == 0)
                return "No solution";
            if ((b / a) * a == b)
                return (b / a).ToString();
            else
                return "No solution";
        }
    }
}
