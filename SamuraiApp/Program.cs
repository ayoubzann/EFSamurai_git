using Microsoft.EntityFrameworkCore;
using EFSamurai.Domain;
using EFSamurai.Data;
using Microsoft.Data.SqlClient;

namespace SamuraiApp
{
    public class Program
    {

        private static void AddSomeBattles()
        {
            AddOneBattle("FolkWar");
            AddOneBattle("FreeWar");
            AddOneBattle("FreezeWar");
        }
        private static Battle AddOneBattle(string name)
        {

            using SamuraiDbContext db = new();

            Battle battle = new()
            {
                Name = name,
                Description = "Long description",
                IsBrutal = true,
                StartDate = new DateTime(2001, 10, 10),
                EndDate = new DateTime(2002, 10, 10)
            };


            db.Battles.Add(battle);
            db.SaveChanges();

            AddBattleLog(battle);

            return battle;

        }
        private static void AddBattleLog(Battle battle)
        {
            using SamuraiDbContext db = new();

            BattleLog battleLog = new()
            {
            Name = "BattleLog",
            BattleId = battle.Id,
        };

            db.BattleLogs.Add(battleLog);
            db.SaveChanges();



            AddBattleEvent(battleLog);


        }
        public static void AddBattleEvent(BattleLog battleLog)
        {
            using SamuraiDbContext db = new();

            BattleEvent battleEvent = new()
            {

                Order = 0,
                Summary = "300 warriors dead. Victory",
                Description = "Losses & outcome",
                BattleLogId = battleLog.Id,
        };
            db.BattleEvents.Add(battleEvent);
            db.SaveChanges();



        }

        public static void ListAllSamuraiNames()
        {
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            AddSomeBattles();
        }
    }
}

