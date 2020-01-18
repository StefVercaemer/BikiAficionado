using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fietsen.Lib.Entities
{
    public class Fiets
    {
        public Guid Id { get; set; }

        public int AantalWielen { get; set; }

        public DateTime AankoopDatum { get; set; }

        public bool IsElektrisch { get; set; }

        public string Merk { get; set; }

        public float Snelheid { get; set; }
    }
}
