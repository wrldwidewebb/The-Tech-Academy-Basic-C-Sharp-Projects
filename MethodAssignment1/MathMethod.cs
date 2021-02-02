using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment1
{
    class MathMethod
    {
        public int Sum(int num1)
        {
            var Total = num1 + 22;
            return Total;
        }
        public int Sum(decimal num1)
        {
            var Total = num1 - 10;
            return Convert.ToInt32(Total);
        }
        public int Sum(string num1)
        {
            var Total = Convert.ToInt32(num1) * 2;
            return Total;
        }
    }
}
