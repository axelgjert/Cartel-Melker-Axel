using System;

namespace Cartel
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartel cartel = new Cartel();
            MafiaBoss mafiaBoss = new MafiaBoss();
            DrugDealer drugDealer = new DrugDealer();
            Slave slave = new Slave();

            mafiaBoss.drugAddiction();
            mafiaBoss.cartelName();
            mafiaBoss.powerfulContacts();
            mafiaBoss.goldCard();

        }
    }
}
