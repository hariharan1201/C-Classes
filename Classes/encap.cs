using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
  class encap
    {
        //Hide the personal name with private, so Pvtname become Capsulate
        private String Pvtname ="Akash";
       public string name
        {
            get { return Pvtname; }
            
        }
        public long Phno = 9360557911;
        public string mail = "hariakash1117@gmail.com";
    }
}
