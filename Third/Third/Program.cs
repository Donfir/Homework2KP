using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace Third
{
    internal class Program
    {
        public static int min_v(int[] a)
        {
            int mina = 100;
            foreach (int i in a)
                if (i < mina)
                    mina = i;
            return mina;
        }
        public static int max_v(int[] a)
        {
            int maxa = -1;
            foreach (int i in a)
                if (i > maxa)
                    maxa = i;
            return maxa;
        }
        public static int[] massiv(int N)
        {
            int[] a = new int[N];
            for (int i = 0; i < N; i++)
            {
                Random rnd = new Random();
                a[i] = rnd.Next(1, 98);
            }
            return a;
        }
        public static int[] minmass(int[] a, int mina, int N)
        {
            int[] c = new int[N];
            Array.Copy(a, c, N);
            for (int i = 0; i < N; i++)
                if (c[i] == mina)
                    c[i] = 0;
            return c;
        }
        public static int[] maxmass(int[] a, int maxa, int N)
        {
            int[] d = new int[N];
            Array.Copy(a, d, N);
            for (int i = 0; i < N; i++)
                if (d[i] == maxa)
                    d[i] = 99;
            return d;
        }
        static void Cout(int[] a)
        {
            var str = string.Join(" ", a);
            Console.WriteLine(str);
        }
        static void Main(string[] args)
        {
            /*int N = Convert.ToInt32(Console.ReadLine());
            int[] a = massiv(N);
            Cout(a);
            int mina = min_v(a);
            int maxa = max_v(a);
            int[] b = new int[N];
            b = minmass(a, mina, N);
            b = maxmass(b, maxa, N);
            Cout(a);
            Cout(b);
            int[] A = Less3.Enter();
            Console.WriteLine(Less3.Kolvo(A).ToString());
            Test_12();*/
            Task13();
            Task14();
        }
        static void Task13()
        {
            Console.WriteLine("Задача 13(введите количество эл-ов в массиве:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] a = massiv(N);//Массив создается рандомно
            Cout(a);
            int mina = HW2.Nchmin(a, N);
            Console.WriteLine(mina.ToString());
        }
        static void Task14()
        {
            Console.WriteLine("Задача 14(введите массив и через энтер число для поиска:");
            int[] a = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int F = Convert.ToInt32(Console.ReadLine());
            Array.Sort(a);
            Cout(a);
            int ind = HW2.Binser(a, F);
            if (ind != -1)
                Console.WriteLine(ind.ToString());
            else
                Console.WriteLine("NO");

        }
        static void Test_12()
        {
            if (Less3.UnEq(1, -2) == "-2")
                Console.WriteLine("OK");
            else
                Console.WriteLine("BAD");
            if (Less3.UnEq(2, -1) == "No solution")
                Console.WriteLine("OK");
            else
                Console.WriteLine("BAD");
            if (Less3.UnEq(0, 0) == "Many solutions")
                Console.WriteLine("OK");
            else
                Console.WriteLine("BAD");
            if (Less3.UnEq(5, 0) == "0")
                Console.WriteLine("OK");
            else
                Console.WriteLine("BAD");
            if (Less3.UnEq(0, 7) == "No solution")
                Console.WriteLine("OK");
            else
                Console.WriteLine("BAD");
            if (Less3.UnEq(10, 11) == "No solution")
                Console.WriteLine("OK");
            else
                Console.WriteLine("BAD");
            if (Less3.UnEq(1, 3000) == "3000")
                Console.WriteLine("OK");
            else
                Console.WriteLine("BAD");
            if (Less3.UnEq(-1500, 1500) == "-1")
                Console.WriteLine("OK");
            else
                Console.WriteLine("BAD");
            if (Less3.UnEq(-29999, 24999) == "No solution")
                Console.WriteLine("OK");
            else
                Console.WriteLine("BAD");
        }
    }
}
