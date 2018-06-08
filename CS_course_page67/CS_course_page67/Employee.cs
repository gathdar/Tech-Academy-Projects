using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_course_page77
{
    class Employee : Person
    {
        public int Id;

        public static bool operator ==(Employee one, Employee two)
        {
            if (one.Id == two.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Employee one, Employee two)
        {
            if (one.Id != two.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
