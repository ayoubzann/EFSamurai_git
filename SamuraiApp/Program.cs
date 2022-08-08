using Microsoft.EntityFrameworkCore;
using EFSamurai.Domain;
using EFSamurai.Data;

namespace SamuraiApp
{
    public class Program
    {

        private static void AddOneSamurai(string name)
        {
            using SamuraiDbContext db = new();
            Samurai samurai = new() { Name = $"{name}" };
            db.Samurais.Add(samurai);
            db.SaveChanges();
        }

        private static void AddSomeSamurais(List<Samurai> samurais)
        {
            using SamuraiDbContext db = new();
            db.Samurais.AddRange(samurais);
            db.SaveChanges();
        }
        /*
         Skriv metoden AddOneSamuraiWithRelatedData, som legger til en samurai og alt av 
tilhørende data, altså legger noe i alle tabeller i databasen. Tips: Det er helt greit å gjøre 
dette som flere Add / AddRange metodekall i AddOneSamuraiWithRelatedData etter 
hverandre, det trenger ikke være en kjempe-insert som gjør alt på en gang. 
         */
        private static void AddSomeBattles(List<Battle>Battles)
        {
            foreach (var battlefight in Battles)
            {
                //TODO : Validate user input
                Console.WriteLine("What is the name of the battle? Please type in the name and press [ENTER]:");
                    battlefight.Name = Console.ReadLine();
                
                Console.WriteLine("Please provide a brief description of the battle:");
                    battlefight.Description = Console.ReadLine();

                Console.WriteLine("Was the battle brutal? Respond with Y/N:");
                if (Console.ReadLine() == "Y")
                {
                    battlefight.IsBrutal = true;
                }
                else if (Console.ReadLine() == "N")
                {
                    battlefight.IsBrutal = false;
                }

                Console.WriteLine("What is the startdate of the battle? Format: MM/DD/YYYY");
                battlefight.StartDate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("What is the enddate of the battle? Format: MM/DD/YYYY");
                battlefight.EndDate = DateTime.Parse(Console.ReadLine());
               
                int orderNum = 1;
                bool EventLogging = false;

                Console.WriteLine("Are there any events to report? Respond with Y/N:");
                if (Console.ReadLine() == "Y")
                { EventLogging = true; }

                BattleEvent bEvents = new();
                List<BattleEvent> BattleEvents = new();
                while (EventLogging == true)
                {
                    bEvents.Order = orderNum;
                    Console.WriteLine("Please tell the events in chronological order.\n Give a summary of the event:");
                    bEvents.Summary = Console.ReadLine();

                    Console.WriteLine("Please provide a description of the event:");
                    bEvents.Description = Console.ReadLine();

                    BattleEvents.Add(bEvents);
                    orderNum++;

                    Console.WriteLine("Are there any more events to report? Respond with Y/N");

                    if (Console.ReadLine() == "N") { EventLogging = false; }
                }

                

                
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

