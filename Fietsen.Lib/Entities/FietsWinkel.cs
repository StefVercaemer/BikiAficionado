using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fietsen.Lib.Entities
{
    public class FietsWinkel
    {
        public string Naam { get; set; }
        public List<Fiets> Fietsen { get; set; }

        public FietsWinkel(string naam)
        {
            Fietsen = new List<Fiets>();
            Naam = naam;
        }

        public override string ToString()
        {
            return $"{Naam} {Fietsen.Count} fietsen";
        }

    }
}
