using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericEmployee
{
    public class Employee<C>
    {
        public List<C> things { get; set; }

    }
}
