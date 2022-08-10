using System.ComponentModel.DataAnnotations.Schema; // Må legges til for å få ForeignKey til å fungere

namespace EFSamurai.Domain

{
    public class Samurai
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public Hairstyle? HairStyle { get; set; }
        public ICollection<SamuraiBattle>? SamuraiBattle { get; set; }

        public ICollection<Quote>? Quote { get; set; }

        
    }

}