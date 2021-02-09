using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassiOperatore
{
    public class SIM
    {
        private static long serialeCorrente = 0;
        public string numeroTelefono { get; private set; }
        public long seriale { get; private set; }
        public double credito { get; private set; }
        public List<Telefonata> Telefonate { get; private set; } = new List<Telefonata>();

        public SIM(string numeroTelefono, int seriale, double credito)
        {
            this.numeroTelefono = numeroTelefono;
            this.seriale = seriale;
            this.credito = credito;
        }

        public long SerialeGenerato()
        {
            return ++serialeCorrente;
        }

        public Telefonata Chiamata(DateTime data, int durata, string numeroTelefono)
        {
            Telefonata t = new Telefonata(data, durata, numeroTelefono);
            Telefonate.Add(t);
            return t;
        }
        public int CalcolaMinutiTotali()
        {
            return Telefonate.Sum(t => t.durataSecondi) / 60;
        }

        public int CalcolaMinutiTotali(string numero)
        {
            return Telefonate.Where(t => t.Contatto == numero).Sum(t => t.durataSecondi) / 60;
        }
        public Telefonata CalcolaTelefonataPiùLunga()
        {
            return Telefonate.OrderBy(t => t.durataSecondi).Last();
        }
        public string StampaElencoChiamate()
        {
            string s ="";
            foreach (Telefonata t in Telefonate.OrderByDescending(t => t.data))
            {
                s += t.ToString() + "\n";
            }
            return s;
        }
        public override string ToString()
        {
            return $"SIM {numeroTelefono} ({seriale}) {credito}€";
        }


    }
}
