using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    //Parent
    public class OffProfile
    {
        public string name = "Hariharan Magesh";
        public int Emp_ID = 15;
        public string Position = "Mobile App Intern";

    }
    //Inheritance
    //child
    public class mail : OffProfile
    {
        public string mailID = "hariharan.kanini@gmail.com";

    }
}
