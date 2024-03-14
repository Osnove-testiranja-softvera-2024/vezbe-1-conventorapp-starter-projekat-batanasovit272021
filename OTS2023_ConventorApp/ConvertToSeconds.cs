using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp
{
    internal class ConvertToSeconds : IConvert
    {
        public double Convert(double value)
        {
            double result = value * 86400;
            return result;
        }
    }
}
