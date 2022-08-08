using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSamurai.Domain
{
    /*
     * En samurai kan delta i flere slag, og hvert slag består av flere samuraier. Med andre ord: Det 
skal være et M-M forhold mellom Samurai og Battle. Opprett koplingsentiteten 
SamuraiBattle. Denne trenger da SamuraiId, Samurai, BattleId og Battle properties. 
• I tillegg skal det være ICollection<SamuraiBattle> SamuraiBattles properties andre 
veien – altså i Samurai og Battle klassene. 
• Merk: SamuraiBattle skal ha en sammensatt PK! Dette må spesifiseres i 
SamuraiDbContext klassen. Se bakerst i dagens forelesningsslides på Canvas. Klarer vi 
å gjøre tilsvarende eksempelet, men for SamuraiBattle? 
     */
    public class SamuraiBattle
    {
        public int SamuraiId { get; set; }
        public Samurai samurai { get; set; }

        public int BattleId { get; set; }
        public Battle battle { get; set; }

        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool IsBrutal { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


    }
}
