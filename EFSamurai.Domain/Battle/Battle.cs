using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSamurai.Domain
{
    /*
    Legg til en Battle klasse. Properties: Id, Name, Description, IsBrutal (bool, som blir til "bit" i 
SQL Server), StartDate (DateTime type), EndDate. 
    */
    public class Battle
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public bool IsBrutal { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<SamuraiBattle>? SamuraiBattle { get; set; }
        public BattleLog BattleLog { get; set; }

        //public Battle(int id, string name, string description, bool isBrutal, DateTime startDate, DateTime endDate, ICollection<SamuraiBattle>? samuraiBattle, BattleLog battleLog)
        //{
        //    Id = id;
        //    Name = name;
        //    Description = description;
        //    IsBrutal = isBrutal;
        //    StartDate = startDate;
        //    EndDate = endDate;
        //    SamuraiBattle = samuraiBattle;
        //    BattleLog = battleLog;
        //}

        public Battle()
        {

        }

        public Battle(string name, string description, bool isBrutal, DateTime startDate, DateTime endDate, ICollection<SamuraiBattle>? samuraiBattle, BattleLog battleLog)
        {
            Name = name;
            Description = description;
            IsBrutal = isBrutal;
            StartDate = startDate;
            EndDate = endDate;
            SamuraiBattle = samuraiBattle;
            BattleLog = battleLog;
        }
    }


}
