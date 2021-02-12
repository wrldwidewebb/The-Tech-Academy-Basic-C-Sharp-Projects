using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constvarchain
{
    class Showrooms
    {
        public int number;
        public string named;
        public Showrooms() : this(0, "") { }
        public Showrooms(int number, string named)
        {
            this.number = number;
            this.named = named;
        }
        public Showrooms(int number) : this(number, "") { }
        public Showrooms(string named) : this(0, named) { }
    }
}
