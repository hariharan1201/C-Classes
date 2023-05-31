using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Education
    {
        public void institution()
        {
            Console.WriteLine("IFET College of engineering");
        }

    }
    public class SchoolSr : Education
    {
        public void institution()
        {
            Console.WriteLine("St.Anne's Matriculation Hr.Sec.School");
        }
    }
    public class SchoolJr : Education
    {
        public void institution()
        {
            Console.WriteLine("Sri Saraswathi vidhyalaya Primary school");
        }
    }

}
