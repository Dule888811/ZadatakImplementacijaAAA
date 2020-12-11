using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZadatakImplementacijaAAA.Models
{
    public class Proizvod
    {
        public string naziv { get; set; }

        public string opis { get; set; }

        public string kategorija { get; set; }

        public string proizvođač { get; set; }


        public string dobavljač { get; set; }

        public double cena { get; set; }
    }
}