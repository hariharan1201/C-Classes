using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    abstract class abstrct
    {
        public abstract void position();
        public void CurrentPosition()
        {
            Console.WriteLine("Student");
        }

    }

    class Overrideabsrtct : abstrct
    {
        public override void position()
        {
           Console.WriteLine("Intern");
        }
    }
}
