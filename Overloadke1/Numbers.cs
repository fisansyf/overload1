using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloadke1
{
    internal class Numbers
    {
        public int CariNilaiMin(int a, int b)
        {
            int min;
            if (a < b)
            {
                Console.WriteLine("Nilai min dari kedua nilai ({0}, {1}) adalah : {0}", min = a, min = b);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Nilai min dari kedua nilai ({0}, {1}) adalah : {1}", min = a, min = b);
                Console.ReadKey();
            }
            return min;
        }

        public int CariNilaiMin(int a, int b, int c)
        {
            int min;
            if (a < b)
            {
                Console.WriteLine("Nilai min dari ketiga nilai ({0}, {1}, {2}) adalah : {0}", min = a, min = b, min = c);
                Console.ReadKey();
            }
            else if (b < c)
            {
                Console.WriteLine("Nilai min dari ketiga nilai ({0}, {1}, {2}) adalah : {1}", min = a, min = b, min = c);
                Console.ReadKey();
            }
            else if (c < a)
            {
                Console.WriteLine("Nilai min dari ketiga nilai ({0}, {1}, {2}) adalah : {2}", min = a, min = b, min = c);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("tidak di temukan nilai min dari {0}, {1}, {2}", min = a, min = b, min = c);
                Console.ReadKey();
            }
            return min;
        }

        public int CariNilaiMax(int a, int b)
        {
            int max;
            if (a > b)
            {
                Console.WriteLine("Nilai max dari kedua nilai ({0}, {1}) adalah : {0}", max = a, max = b);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Nilai max dari kedua nilai ({0}, {1}) adalah : {1}", max = a, max = b);
                Console.ReadKey();
            }
            return max;
        }

        public int CariNilaiMax(int a, int b, int c)
        {
            int max;

            if (a > b)
            {
                Console.WriteLine("Nilai max dari ketiga nilai ({0}, {1}, {2}) adalah : {0}", max = a, max = b, max = c);
                Console.ReadKey();
            }
            else if (b > c)
            {
                Console.WriteLine("Nilai max dari ketiga nilai ({0}, {1}, {2}) adalah : {1}", max = a, max = b, max = c);
                Console.ReadKey();
            }
            else if (c > a)
            {
                Console.WriteLine("Nilai max dari ketiga nilai ({0}, {1}, {2}) adalah : {2}", max = a, max = b, max = c);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("tidak di temukan nilai max dari {0}, {1}, {2}", max = a, max = b, max = c);
                Console.ReadKey();
            }
            return max;
        }
    }
}
