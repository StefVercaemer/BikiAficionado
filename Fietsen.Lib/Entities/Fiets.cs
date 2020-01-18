﻿using System;
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

        public Fiets(string make, float speed = 0, int aantalWielen = 2,
            bool metBatterij = false, DateTime? aangekochtOp = null, Guid? id = null)
        {
            Merk = make;
            Snelheid = speed;
            AantalWielen = aantalWielen;
            IsElektrisch = metBatterij;
            if (aangekochtOp == null)
            {
                AankoopDatum = DateTime.Now;
            }
            else
            {
                AankoopDatum = (DateTime)aangekochtOp;
            }
            if (id == null)
            {
                Id = Guid.NewGuid();
            }
            else
            {
                Id = (Guid)id;
            }
        }

        public override string ToString()
        {
            return $"{Merk} {Snelheid} km/u.";
        }

    }
}
