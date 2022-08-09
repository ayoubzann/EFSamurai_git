using Microsoft.EntityFrameworkCore;
using EFSamurai.Domain;
using EFSamurai.Data;
using Microsoft.Data.SqlClient;

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
         Skriv metoden ClearDatabase, som sletter alle rader i hele tabellen. Tips for å slette: Enten 
benytte cascading delete (Cascading delete er default for FKs i EF Core) eller slette tabellene 
som inneholder fremmednøkler før de øvrige tabellene. Senere (når du kommer til unit test 
oppgavene) kall også denne metoden først i ditt testprogram, så har du en mer konsistent 
database å teste på! 
         */

        //int primaryKeyId, string whereColumn, string table - Input queries
       

        private static void AddOneSamuraiWithRelatedData()
        {       

        using SamuraiDbContext db = new();

            Samurai samurai = new();

            samurai.Name = "Jack";
            samurai.Hairstyle = Hairstyle.Western;

            List<Quote> quotes = new List<Quote>();

            Quote firstQuote = new();
            firstQuote.Text = "A samurai should always be prepared for death – whether his own or someone else's.";
            firstQuote.QuoteStyle = QuoteStyle.Awesome;
            firstQuote.samurai = samurai;
            quotes.Add(firstQuote);

            Quote secondQuote = new();
            secondQuote.Text = "You must understand that there is more than one path to the top of the mountain.";
            secondQuote.QuoteStyle = QuoteStyle.Awesome;
            secondQuote.samurai = samurai;
            quotes.Add(secondQuote);

            SecretIdentity secretIdentity = new ( samurai, "Erlend Elias");
            Battle battle = new Battle();
            SamuraiBattle samuraiBattle = new(samurai, battle);

       
        db.Samurais.Add(samurai);
        db.Quotes.AddRange(firstQuote, secondQuote);
        db.SecretIdentities.Add(secretIdentity);
        db.SamuraiBattles.Add(samuraiBattle);
        db.SaveChanges();

        }

        private static void AddSomeBattles(List<Battle>Battles)
        {
            List<Battle> battles = new List<Battle>();
            foreach (var battle in Battles)
            {
                

                battle.Name = "Battle of Kyoto";
                battle.Description = "A huge battle with around 40.000 warriors. The city of Kyoto was under siege on all sides.";
                battle.IsBrutal = true;
                battle.StartDate = new DateTime (12/12/2012);
                battle.EndDate = new DateTime(12/29/2012);
               

                List<Samurai> Samurais = new();

                Samurai samurai = new();
                samurai.Name = "Hikomato Tatashaki";
                samurai.Hairstyle = Hairstyle.Chonmage;
                Samurais.Add(samurai);

                Samurai samurai2 = new();
                samurai2.Name = "Yokohami Sukkodo";
                samurai2.Hairstyle = Hairstyle.Oicho;
                Samurais.Add(samurai2);


                List<BattleEvent> battleLog = new();

                BattleEvent bEvent = new();
                bEvent.Order = 1;
                bEvent.Summary = "Fight lasted 17 days. 1023 registered casualties. Victorious in the end.";
                bEvent.Description = "Lorem ipsum color sit amet. Latin filler text. Basically, we won. We killed the demons(?) and enemies. All hail the samurais.";
                battleLog.Add(bEvent);
                BattleLog BattleLog = new(bEvent.Order, bEvent.Summary, bEvent.Description);
                battle.BattleLog = BattleLog;

                battle.SamuraiBattle = (ICollection<SamuraiBattle>?)Samurais;
                battle.SamuraiBattle = (ICollection<SamuraiBattle>?)battle;
                //battle.BattleLog = (BattleLog?)(ICollection<BattleEvent>?)bEvent;
                #region
                //Console.WriteLine("What is the name of the battle? Please type in the name and press [ENTER]:");
                //    battle.Name = Console.ReadLine();

                //Console.WriteLine("Please provide a brief description of the battle:");
                //    battle.Description = Console.ReadLine();

                //Console.WriteLine("Was the battle brutal? Respond with Y/N:");
                //if (Console.ReadLine() == "Y")
                //{
                //    battle.IsBrutal = true;
                //}
                //else if (Console.ReadLine() == "N")
                //{
                //    battle.IsBrutal = false;
                //}

                //Console.WriteLine("What is the startdate of the battle? Format: MM/DD/YYYY");
                //battle.StartDate = DateTime.Parse(Console.ReadLine());

                //Console.WriteLine("What is the enddate of the battle? Format: MM/DD/YYYY");
                //battle.EndDate = DateTime.Parse(Console.ReadLine());

                //int orderNum = 1;
                //bool EventLogging = false;

                //Console.WriteLine("Are there any events to report? Respond with Y/N:");
                //if (Console.ReadLine() == "Y")
                //{ EventLogging = true; }

                //while (EventLogging == true)
                //{
                //    BattleEvent bEvent = new();
                //    bEvent.Order = orderNum;
                //    Console.WriteLine("Please tell the events in chronological order.\n Give a summary of the event:");
                //    bEvent.Summary = Console.ReadLine();

                //    Console.WriteLine("Please provide a description of the event:");
                //    bEvent.Description = Console.ReadLine();

                //    BattleEvents.Add(bEvent);
                //    orderNum++;

                //    Console.WriteLine("Are there any more events to report? Respond with Y/N");

                //    if (Console.ReadLine() == "N") { EventLogging = false; }
                //}
                #endregion


                Battle theBattle = new(battle.Name, battle.Description, battle.IsBrutal, battle.StartDate, battle.EndDate, battle.SamuraiBattle, battle.BattleLog);

                //Battles.Add(theBattle);

                using SamuraiDbContext db = new();
                db.Add(theBattle);
                db.SaveChanges();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

