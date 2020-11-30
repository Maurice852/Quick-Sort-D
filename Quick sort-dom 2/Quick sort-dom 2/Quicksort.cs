using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_sort_dom_2
{
    class Quicksort
    {
        /// <summary>
        /// fill the array with random numbers
        /// </summary>

        static Random random = new Random();
        internal static int[] FillArrayRandom(int n, int min, int max)
        {
            int[] z = new int[n];

            for (int i = 0; i < n; i++)
            {
                z[i] = random.Next(min, max);
            }
            return z;
        }

        /// <summary>
        /// sort a asc
        /// </summary>
        /// <algo>
        /// Sort the array by calculating the average,
        /// count amount of values > average
        /// then creating 2 arrays for numbers > and <= than the average.
        /// stop if there are no values > average (all values are equal)
        /// fill both arrays with correct data
        /// recurse those 2 arrays
        /// finally we concat both the arrays to show the final sorted array.
        /// </algo>
        internal static int[] SortArray(int[] a)
        {
            double average = 0;
            for (int i = 0; i < a.Length; i++) average += a[i];
            average /= a.Length;
            int b = 0;
            for (int i = 0; i < a.Length; i++) if (a[i] > average) b++;
            //stopcondition
            if (b == 0) return a;
            int kg = a.Length - b;
            int[] kgar = new int[kg];
            int[] gar = new int[b];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > average) gar[--b] = a[i];
                else kgar[--kg] = a[i];
            }
            kgar = SortArray(kgar);
            gar = SortArray(gar);
            for (int i = 0; i < kgar.Length; i++) a[i] = kgar[i];
            for (int i = 0; i < gar.Length; i++) a[i + kgar.Length] = gar[i];
            return a;
        }
    }
}
