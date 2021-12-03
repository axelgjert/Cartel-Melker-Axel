using System;
using System.Collections.Generic;
using System.Text;

namespace Cartel
{
    class Cartel
    {
        public virtual void drugAddiction()
        {
            Console.WriteLine("This employee is addicted to weed..");
        }

        public virtual void drugKnownledge()
        {
            Console.WriteLine("This employee knows everything about drugs.");
        }

        public virtual void cartelName()
        {
            Console.WriteLine("This employee knows the cartel name.. It's Gustavos Cartel, but don't tell anyone.");
        }
    }
}
