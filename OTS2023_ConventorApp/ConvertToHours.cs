using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp
{
    internal class ConvertToHours : IConvert
    {
        public double Convert(double value)
        {
            double result = value * 24;
            return result;
        }
    }
}
