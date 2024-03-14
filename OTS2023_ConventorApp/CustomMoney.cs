using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp
{
    internal static class CustomMoney
    {
        public static double ConvertCustom(string expression)
        {
            char from = '0';
            char to = '0';
            int i = 0;
            foreach (char c in expression)
            {
                if(c == '$' || c == '€' || c == '£')
                {
                    from = c;
                    break;
                }
                i++;
            }
            to = Convert.ToChar(expression.Substring(expression.Length - 1, 1).Trim());
            double value = Convert.ToDouble(expression.Substring(0, i).Trim());
            if (from == '$' && to == '€')
            {
                return value * 0.91;
            }
            if (from == '€' && to == '$')
            {
                return value * 1.09414;
            }
            if (from == '£' && to == '€')
            {
                return value * 1.116479;
            }
            if (from == '€' && to == '£')
            {
                return value * 0.855412;
            }
            return 0;
        }
    }
}
