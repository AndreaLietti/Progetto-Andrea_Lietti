using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RitiroOrdineGelateria
{
    public class Ordini
    {
        public List<Ordine> ordini = new List<Ordine>();
        public string ToCSV()
        {
            string contenuto = "";
            for (int i = 0; i < ordini.Count; i++)
            {
                if (i < ordini.Count - 1)
                    contenuto += ordini.ElementAt(i).toCSV() + "\n";
                else
                    contenuto += ordini.ElementAt(i).toCSV();
            }
            return contenuto;
        }
        public void delOrdine(int i)
        {
            ordini.RemoveAt(i);
        }

        public void FromCSV(string contenuto)
        {
            string[] linee = contenuto.Split('\n');
            for (int i = 0; i < linee.Length; i++)
            {
                Ordine p = new Ordine();
                p.fromCSV(linee[i]);
                ordini.Add(p);
            }
        }
        public void caricaLista(string file)
        {
            string lettura = System.IO.File.ReadAllText(file);
            FromCSV(lettura);
        }

        public void salvaLista(string file)
        {
            System.IO.File.WriteAllText(file, ToCSV());
        }
    }
}
