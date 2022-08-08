using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSamurai.Domain
{
    public class BattleEvent
    {
        /*
         Opprett BattleEvent klassen, som inneholder en hendelse fra et slag. Denne skal ha int Id, int 
Order, string Summary, string Description. En krigslogg inneholder mange hendelser, så lag 1-
M forhold mellom BattleLog og BattleEvent. 
         */

        public int Id { get; set; }
        public int Order { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public int BattleLogId { get; set; }
        public BattleLog BattleLog { get; set; }
    }
}
