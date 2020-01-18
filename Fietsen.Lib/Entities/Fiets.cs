using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fietsen.Lib.Entities
{
    public class Fiets
    {
        static Random random = new Random();

        public Guid Id { get; set; }

        public int AantalWielen { get; set; }

        public DateTime AankoopDatum { get; set; }

        public bool IsElektrisch { get; set; }

        public string Merk { get; set; }

        public float Snelheid { get; set; }

        public Fiets(string make, float speed = 0, int aantalWielen = 2,
            bool metBatterij = false, DateTime? aangekochtOp = null, Guid? id = null)
        {
            Merk = make;
            AantalWielen = aantalWielen;
            IsElektrisch = metBatterij;

            Snelheid = (speed == 0) ? Snelheid = random.Next(0, 41) : speed;

            AankoopDatum = (aangekochtOp == null) ? DateTime.Now : (DateTime)aangekochtOp;
            Id = (id == null) ? Guid.NewGuid() : (Guid)id;
        }

        public override string ToString()
        {
            return $"{Merk} {Snelheid} km/u.";
        }

    }
}
