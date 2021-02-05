using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadEmployee
{
    public class Employee
    {
        public int ID { get; set; }

        public static bool operator ==(Employee A, Employee B)
        {
            bool status = false;
            if (A == B)
            {
                status = true;

            }
            return status;
        }

        public static bool operator !=(Employee A, Employee B)
        {
            bool status = false;
            if (A != B)
            {
                status = false;

            }
            return status;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
