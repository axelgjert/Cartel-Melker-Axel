using System;
using System.Collections.Generic;
using System.Text;

namespace Cartel 
{
    class Slave : Cartel
    {
        public void dirtyHands()
        {
            Console.WriteLine("The slave always have dirty hands. But watch out.. He is strong.");
        }

        public void plantingSkills()
        {
            Console.WriteLine("The slave has some green hands. He can grow whatever plant he wants.");
        }
    }
}
