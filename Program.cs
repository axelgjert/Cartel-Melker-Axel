using System;

namespace Cartel
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartel cartel = new Cartel(50, "Cartel", 100, "GUSTAVOS CARTEL");
            MafiaBoss mafiaBoss = new MafiaBoss(50, "Mafiaboss", 200, "Gustavo");
            DrugDealer drugDealer = new DrugDealer(21, "Drug Dealer", 70, "Sully");
            Professor professor = new Professor(37, "Chemistry Professor", 54, "Mr. Grey");


            Console.WriteLine("Welcome to the Cartel. We have heard that you are our new boss. Do you want to know more about the cartel Y/N?");
            string number = Console.ReadLine();
            if (number == "Y")
            {
                Console.WriteLine("Learn more about the Mafia boss. Press 1");

                Console.WriteLine("Learn more about the Drug dealer. Press 2");

                Console.WriteLine("To learn more about the Professor. Press 3");
                int learn = Convert.ToInt32(Console.ReadLine());
                if(learn == 1)
                {
                    Console.WriteLine("Mafia boss Informaton tab: ");
                    Console.WriteLine("-------------------------------------------------");
                    mafiaBoss.drugKnownledge();
                    mafiaBoss.cartelName();
                    mafiaBoss.goldCard();
                    mafiaBoss.powerfulContacts();
                    
                }
                if(learn == 2)
                {
                    Console.WriteLine("Drug dealer information tab: ");
                    Console.WriteLine("-------------------------------------------------");
                    drugDealer.drugKnownledge();
                    drugDealer.drugAddiction();
                }
                if(learn == 3)
                {
                    Console.WriteLine("Professor information tab: ");
                    Console.WriteLine("-------------------------------------------------");
                    
                }
                
                    
                
            }
            else
            {
                Console.WriteLine("You got shot by one of Gustavos assistants and got sent back to the lobby");
            }
        }

    }   
}

