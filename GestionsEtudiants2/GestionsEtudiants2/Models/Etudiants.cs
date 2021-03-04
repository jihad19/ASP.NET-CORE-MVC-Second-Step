using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionsEtudiants2.Models
{
    public class Etudiants
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Cin { get; set; }
        public string Adresse { get; set; }

        public Etudiants()
        {
             
        }

    }
}
