using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDatenbankLibraryCRM
{
    public class HelperClassMetadata
    {
        public string Tabelle { get; set; }
        public bool IstSchlüsselfeld { get; set; }
        public string Feldname { get; set; }
        public int Feldlänge { get; set; }
        public string SQLServerDatentyp { get; set; }
        public string GenerischerDatentyp { get; set; }
        //public string Beschreibung { get; set; }    
    }
}
