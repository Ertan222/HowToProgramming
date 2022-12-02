using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HowToProgramming.Helpers
{
    public class AgeFinder
    {
        public static int AgeFind(DateTime DOB) {
            return DateTime.Now.Year - DOB.Year;
        }
    }
}