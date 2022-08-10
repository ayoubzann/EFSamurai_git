using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFSamurai.Data;
using EFSamurai.Domain;

namespace EFSamurai.Data
{
    public class EfMethods
    {
        /*
       I EfMethods, legg til metodene GetSamurai og UpdateSamuraiSetSecretIdentity. 
         */
        public static Samurai GetSamurai(int samuraiId)
        {
            using SamuraiDbContext db = new();
            Samurai samurai = db.Samurais!.FirstOrDefault(s => s.Id == samuraiId)!;
            return samurai;
        }

        public static int AddOneSamurai(Samurai samurai)
        {
            using SamuraiDbContext db = new();
            db.Samurais!.Add(samurai);
            db.SaveChanges();
            return samurai.Id;
        }

        public static int AddOneSamurai(string name)
        {
            Samurai samurai = new()
            {
                Name = name,
                HairStyle = Hairstyle.Chonmage,
            };
            using SamuraiDbContext db = new();
            db.Samurais!.Add(samurai);
            db.SaveChanges();
            return samurai.Id;
        }

        public static string[] GetAllSamuraiNames()
        {
            using SamuraiDbContext db = new();
            string[] samuraiNames = db.Samurais!.Select(s => s.Name).ToArray();
            return samuraiNames;

        }

     
    }
}
