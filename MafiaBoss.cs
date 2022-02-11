using System;
using System.Collections.Generic;

namespace Cartel
{


    class MafiaBoss : Cartel
    {
        public List<DrugDealer> worker1 = new List<DrugDealer>();
        public List<Professor> worker2 = new List<Professor>();

        public MafiaBoss(int aage, string arole, string arealname)
            : base(aage, arole, arealname)
        {

        }

        public override void drugAddiction()
        {
            Console.WriteLine("The Mafia Boss is addicted to cocaine.");
        }

        public override void drugKnownledge()
        {
            Console.WriteLine("The Mafia Boss can roll a joint with his hands behind his back.");
        }

        public override void cartelName()
        {
            Console.WriteLine("The Mafia Boss's name is Gustavo so the cartels name is obviously Gustavos Cartel");
        }

        public void goldCard()
        {
            Console.WriteLine("The Mafia Boss has a gold card with unlimited money.");
        }

        public void powerfulContacts()
        {
            Console.WriteLine("The Mafia Boss has powerful contacts. Don't mess with him!");
        }
    }
}
