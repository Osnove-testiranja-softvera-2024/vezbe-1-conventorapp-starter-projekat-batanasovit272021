using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp
{
    internal class ConvertMoney : IConvert
    {
        public double Convert(double value)
        {
            double result = value * 117;
            return result;
        }
    }
}
