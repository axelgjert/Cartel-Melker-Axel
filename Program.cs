using System;

namespace Cartel
{
    class Program
    {
        static void Main(string[] args)
        {
            Lobby();
        }

        static void Lobby()
        {
            Cartel cartel = new Cartel(50, "Cartel", "GUSTAVOS CARTEL");
            MafiaBoss mafiaBoss = new MafiaBoss(50, "Mafiaboss", "Gustavo");
            DrugDealer drugDealer = new DrugDealer(21, "Drug Dealer", "Sully");
            Professor professor = new Professor(37, "Chemistry Professor", "Mr. Grey");

            string choice;

            Console.WriteLine("The Mafia Boss Gustavo welcomes you to the Cartel. Do you want to know more about the cartel Y/N?");
            choice = Console.ReadLine();

            if (choice == "Y")
            {
                CartelHQ(cartel, mafiaBoss, drugDealer, professor);
            }
            else
            {
                Console.WriteLine("You got shot by one of Gustavos assistants..");
            }
        }

        static void CartelHQ(Cartel cartel, MafiaBoss mafiaBoss, DrugDealer drugDealer, Professor professor)
        {
            int learn;

            Console.Clear();

            Console.WriteLine("Learn more about the Mafia boss. Press 1");
            Console.WriteLine("Learn more about the Drug dealer. Press 2");
            Console.WriteLine("Learn more about the Professor. Press 3");

            learn = Convert.ToInt32(Console.ReadLine());

            switch (learn)
            {
                case 1:
                    Console.WriteLine("Mafia boss Informaton tab: ");
                    Console.WriteLine("-------------------------------------------------");
                    mafiaBoss.drugKnownledge();
                    mafiaBoss.cartelName();
                    mafiaBoss.goldCard();
                    mafiaBoss.powerfulContacts();
                    Console.WriteLine("-------------------------------------------------");

                    learnMore(cartel, mafiaBoss, drugDealer, professor);

                    break;

                case 2:
                    Console.WriteLine("Drug dealer information tab: ");
                    Console.WriteLine("-------------------------------------------------");
                    drugDealer.drugKnownledge();
                    drugDealer.drugAddiction();
                    drugDealer.cartelName();
                    Console.WriteLine("-------------------------------------------------");

                    learnMore(cartel, mafiaBoss, drugDealer, professor);

                    break;

                case 3:
                    Console.WriteLine("Professor information tab: ");
                    Console.WriteLine("-------------------------------------------------");
                    professor.Createdrugs();
                    professor.realName();
                    professor.cartelName();
                    Console.WriteLine("-------------------------------------------------");

                    learnMore(cartel, mafiaBoss, drugDealer, professor);

                    break;
            }

            static void learnMore(Cartel cartel, MafiaBoss mafiaBoss, DrugDealer drugDealer, Professor professor)
            {
                int choice; 

                Console.WriteLine("Would you like to know more about other staff");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CartelHQ(cartel, mafiaBoss, drugDealer, professor);

                        break;
                    case 2:
                        Console.WriteLine("Have a good day boss.");
                        Console.WriteLine("");
                        Console.WriteLine("Press Any Key to leave");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
