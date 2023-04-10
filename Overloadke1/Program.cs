using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloadke1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            numbers.CariNilaiMin(13, 15);
            numbers.CariNilaiMin(14, 16, 20);
            numbers.CariNilaiMax(13, 15);
            numbers.CariNilaiMax(14, 16, 20);
        }
    }
}
