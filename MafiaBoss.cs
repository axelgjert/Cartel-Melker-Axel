using System;
using System.Collections.Generic;
using System.Text;

namespace Cartel
{
    class MafiaBoss : Cartel 
    {
        public override void drugAddiction()
        {
            Console.WriteLine("The Mafia Boss is addicted to cocaine.");
        }

        public override void cartelName()
        {
            Console.WriteLine("The Mafia Boss's name is Gustavo so the cartels name is obviously Gustavos Cartel");
        }

        public override void realName()
        {
            Console.WriteLine("The Mafia Boss's name is Gustavo");
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
