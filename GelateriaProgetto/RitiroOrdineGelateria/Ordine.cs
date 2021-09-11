using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionePalestra
{
    public class Ordine
    {
        public string nome { get; set; }
        public string cognome { get; set; }
        public string gusto { get; set; }
        public string codice { get; set; }

        public string toCSV()
        {
            string s;
            s = nome + ";" + cognome + ";" + gusto + ";" + codice + ";";
            return s;
        }
        public void fromCSV(string linea)
        {
            string[] s = linea.Split(';');
            nome = s[0];
            cognome = s[1];
            gusto = s[2];
            codice = s[3];
        }
    }
}
