using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace EFSamurai.Domain
{
    /*
     * ToDo
• I tillegg skal det være ICollection<SamuraiBattle> SamuraiBattles properties andre 
veien – altså i Samurai og Battle klassene. 
• Merk: SamuraiBattle skal ha en sammensatt PK! Dette må spesifiseres i 
SamuraiDbContext klassen. Se bakerst i dagens forelesningsslides på Canvas. Klarer vi 
å gjøre tilsvarende eksempelet, men for SamuraiBattle? 
     */
    public class SamuraiBattle
    {
        public int SamuraiId { get; set; }
        public Samurai Samurai { get; set; }
        
        public int BattleId { get; set; }
        public Battle Battle { get; set; }


        public SamuraiBattle(Samurai samurai, Battle battle)
        {
            Samurai = samurai;
            Battle = battle;
        }

    }
}
