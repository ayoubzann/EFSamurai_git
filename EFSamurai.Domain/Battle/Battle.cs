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

     }


}
