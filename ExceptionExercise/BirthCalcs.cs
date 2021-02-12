using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExercise
{
    public class BirthCalcs 
    {
        public int Year(int age)
        {
            int currentYear = DateTime.Now.Year;
            int birthYear = currentYear - age;
            if (birthYear >= DateTime.Now.Year)
            {
                throw new ZeroException();
            }
            else
            {
                return birthYear;
            }
        }   
          
    }
}
