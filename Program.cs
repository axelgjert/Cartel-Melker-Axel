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
            Chemistry_professor professor = new Chemistry_professor();

            drugDealer.drugAddiction();
        }
    }
}
