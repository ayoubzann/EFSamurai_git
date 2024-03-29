﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema; // For å bruke fremmednøkkel

namespace EFSamurai.Domain
{
    public class SecretIdentity
    {
        public int Id { get; set; }
        public string Realname { get; set; } = "";
        public int SamuraiId { get; set; } // Fremmednøkkel fra Samurai
        public Samurai Samurai { get; set; } = null!; // Instansierer Samurai for å ha fremmednøkkel
      
        public SecretIdentity()
        {

        }

        public SecretIdentity(Samurai samurai, string realname)
        {
            Samurai = samurai;
            Realname = realname;
        }
    }
}
