using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models
{
    public class Studenten
    {
        
        public int StudentenNr { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public string Email { get; set; }
        public string GsmNummerStudent { get; set; } 
        public string TelefoonNummerOuder { get; set; }
        public string Adres { get; set; }
        public string Gemeente { get; set; }
        public string Postcode { get; set; }
        public string Geboortedatum { get; set; }
        public string Geslacht { get; set; }
        public bool Aanwezigheid { get; set; }
    
        public Studenten()
        {
            
        }
    
    }
}
