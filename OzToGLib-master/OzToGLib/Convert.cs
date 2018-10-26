using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzToGLib
{
    public static class Convert
    {
        public static double OzToG(double Oz)
        {
            return Oz * 28.3495231;
        }
        public static double GToOz(double G)
        {
            return G * 0.0352739619;
        }
    }
}
