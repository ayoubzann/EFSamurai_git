using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSamurai.Domain
{
    public class BattleLog
    {
        /*
Hvert slag har en BattleLog. BattleLog inneholder Id og Navn, og har et 1-1 forhold til Battle, 
dvs. den skal ha en BattleId som FK til Battle samt en Battle property. (Husk at det da også 
skal lages en BattleLog property i Battle klassen. 
         */

        public int Id { get; set; }
        public string Name { get; set; }

        public int BattleId { get; set; }
        public Battle Battle { get; set; }

        public ICollection<BattleEvent>? BattleEvents { get; set; }
    }
}
