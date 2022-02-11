using System;

namespace Cartel
{
    class DrugDealer : Cartel
    {
        public DrugDealer(int aage, string arole, string arealname)
            : base(aage, arole, arealname)
        {

        }

        public override void drugAddiction()
        {
            Console.WriteLine("The drug dealer is addicted to weed.");
        }

        public override void cartelName()
        {
            Console.WriteLine("The drug dealer knows the cartel name..");
        }

        public override void realName()
        {
            Console.WriteLine($"The dealers real name is {realname}");
        }

        public void powerfulPassport()
        {
            Console.WriteLine("The drug dealer can fly all over the world.");
        }

        public void unlimitedPhones()
        {
            Console.WriteLine("The drug dealer has unlimited phones tho call his customers with.");
        }
    }
}
