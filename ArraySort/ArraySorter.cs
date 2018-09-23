using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    public static class ArraySorter
    {
        #region MergeSorting
        public static void MergeSorting(int[] a, int l, int r)
        {
            if (l < r)
            {
                int m = (l + r) / 2;
                MergeSorting(a, l, m);
                MergeSorting(a, m + 1, r);

                //слияние
                int[] buf = new int[a.Length];
                Array.Copy(a, buf, buf.Length);

                int j = l;
                int k = m + 1;
                for (int i = l; i <= r; i++)
                {
                    if (j > m)
                    {
                        a[i] = buf[k];
                        k++;
                    }
                    else if (k > r)
                    {
                        a[i] = buf[j];
                        j++;
                    }
                    else if (buf[j] < buf[k])
                    {
                        a[i] = buf[j];
                        j++;
                    }
                    else
                    {
                        a[i] = buf[k];
                        k++;
                    }
                }
            }
        }
        #endregion

        #region QuickSort
        public static void QuickSorting(int[] a, int l, int r)
        {
            if (l >= r)
                return;

            Random rand = new Random();
            int index = rand.Next(l, r);
            Swap(ref a[index], ref a[l]);

            int m = Partition(a, l, r);
            QuickSorting(a, l, m - 1);
            QuickSorting(a, m + 1, r);
        }

        public static int Partition(int[] a, int l, int r)
        {
            int i = l;
            int j = r + 1;

            while (true)
            {
                do
                {
                    j--;
                } while (a[i] < a[j]);
                if (i >= j)
                    break;
                Swap(ref a[i], ref a[j]);

                do
                {
                    i++;
                } while (a[i] < a[j]);
                if (i >= j)
                    break;
                Swap(ref a[i], ref a[j]);
            }
            return j;
        }

        public static void Swap(ref int first, ref int second)
        {
            int buf;
            buf = first;
            first = second;
            second = buf;
        }
        #endregion

        #region InsertionSort
        public static void InsertionSorting(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                int x = a[i];
                int j = i;
                while (j > 0 && a[j - 1] > x)
                {
                    a[j] = a[j - 1];
                    j--;
                }
                a[j] = x;
            }
        }
        #endregion   
    }
}
