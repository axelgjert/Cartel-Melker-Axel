using System;
using System.Collections.Generic;
using System.Text;

namespace Cartel
{
    class Cartel
    {
        string regularname;
        int age;
        double height;
        double weight;
    

        public virtual void drugAddiction()
        {
            Console.WriteLine("All emplyees in Gustavos cartel have a drug addiction..");
        }

        public virtual void drugKnownledge()
        {
            Console.WriteLine("This employee knows everything about drugs.");
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
