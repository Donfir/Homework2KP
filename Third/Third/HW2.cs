using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Third
{
    class HW2
    {
        public static int Nchmin(int[] a, int N)
        {
            int mina = a[0];
            int cnt = 0;
            for (int i = 0; i < N; i++)
                if (a[i] <= mina && a[i] % 2 != 0)
                {
                    cnt++;
                    mina = a[i];
                }
            if (cnt != 0)
                return mina;
            else
                return 0;
        }
        public static int Binser(int[] a, int target)
        {
            int left = 0, right = a.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (a[mid] == target)
                    return mid; // Элемент найден, возвращаем индекс

                if (a[mid] < target)
                    left = mid + 1; // Ищем в правой половине
                else
                    right = mid - 1; // Ищем в левой половине
            }

            return -1; // Элемент не найден
        }
    }
}
