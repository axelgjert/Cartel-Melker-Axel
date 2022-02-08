using System;
using System.Collections.Generic;
using System.Text;

namespace Cartel
{
    class Cartel
    {
        public int age { get; set; }
        public string role { get; set; }
        public double weight { get; set; }
        public string realname { get; set; }
        
        public Cartel(int aage, string arole, double aweight, string arealname)
        {
            this.age = aage;
            this.role = arole;
            this.weight = aweight;
            this.realname = arealname;

        }
    

        public virtual void drugAddiction()
        {
            Console.WriteLine("All emplyees in Gustavos cartel have a drug addiction..");
        }

        public virtual void drugKnownledge()
        {
            Console.WriteLine($"The {role} knows everything about drugs.");
        }

        public virtual void cartelName()
        {
            Console.WriteLine("This employee knows the cartel name.. It's Gustavos Cartel, but don't tell anyone.");
        }

        public virtual void realName()
        {
            Console.WriteLine("All employees have a real name aswell as their cartel name.");
        }
        
    }
}
