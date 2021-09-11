using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gelateria
{
    public class Ordine
    {
        public string nome { get; set; }
        public string cognome { get; set; }
        public string gelato { get; set; }
        public string codice { get; set; }

        public Ordine()
        {
            nome = "";
            cognome = "";
            codice = "";
            gelato = "";
        }

        public void generaCodice()
        {
            codice = this.nome.Substring(0, 3) + "-" + this.cognome.Substring(0, 3) + "-" + this.gelato.Substring(0, 3) + "-";
        }


        public void setPersona(string s, string d)
        {
            string[] split = s.Split(' ');

            nome = split[0];
            cognome = split[1];
            gelato = d;
        }
        public string toCSV()
        {
            string s;
            s = nome + ";" + cognome + ";" + gelato + ";" + codice + ";";
            return s;
        }
        public void fromCSV(string linea)
        {
            string[] s = linea.Split(';');
            nome = s[0];
            cognome = s[1];
            gelato = s[2];
            codice = s[3];
        }
    }
}
