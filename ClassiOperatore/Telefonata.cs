using System;

namespace ClassiOperatore
{
    public class Telefonata
    {
        public DateTime data { get; private set; }

        public int durataSecondi { get; private set; }
        public string Contatto { get; private set; }

        public Telefonata(DateTime data, int durataSecondi, string contatto)
        {
            this.data = data;
            this.durataSecondi = durataSecondi;
            Contatto = contatto;
        }
        public override string ToString()
        {
            return $"Chiamato {Contatto} in {data} per {durataSecondi} secondi";
        }
    }
}
