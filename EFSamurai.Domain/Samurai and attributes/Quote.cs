using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFSamurai.Domain
{
    public class Quote
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public int SamuraiId { get; set; } // Fremmednøkkel fra Samurai
        public Samurai samurai { get; set; } = null!; // Instansierer Samurai for å ha fremmednøkkel
        public QuoteStyle? QuoteStyle { get; set; }

        public Quote(int id, string? text, Samurai Samurai, QuoteStyle quoteStyle)
        {
            Id = id;
            Text = text;
            samurai = Samurai;
            QuoteStyle = quoteStyle;
        }

        public Quote()
        {

        }
    }
}
