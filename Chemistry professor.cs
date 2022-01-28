using System;
using System.Collections.Generic;
using System.Text;

namespace Cartel
{
    class Chemistry_professor : Cartel
    {
        public void Createdrugs()
        {
            Console.WriteLine("The chemistry professors speciality is creating drugs in his lab.");
        }

        public override void drugAddiction()
        {
            Console.WriteLine("The professor is addicted to crystal meth.");
        }

        public override void cartelName()
        {
            Console.WriteLine("The professor doesn't know the cartels name.");
        }

        public override void realName()
        {
            Console.WriteLine("The professors real name is Mr. Grey");
        }
    }

    public class Lab_Card
    {
        public void Swipe(Chemistry_professor obj)
    }
}
