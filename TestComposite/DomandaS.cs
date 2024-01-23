using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TestComposite
{
    internal class DomandaS : Domanda
    {
        //costruttori
        public DomandaS(string testo, List<Risposta> risposte) : base(testo, risposte)
        {
            Testo = testo;
            Risposte = risposte;
        }
        public DomandaS()
        {
            Testo = "";
            Risposte = new List<Risposta>();
        }
        public DomandaS(Domanda d)
        {
            Testo = d.Testo;
            Risposte = d.Risposte;
        }

        //Equals
        public override bool Equals(object obj)
        {
            return Equals(obj as DomandaVF);
        }
        public bool Equals(DomandaVF d)
        {
            return Testo == d.Testo &&
                Risposte == d.Risposte;
        }

        //GetHashCode
        public override int GetHashCode()
        {
            return Testo.GetHashCode() ^
                Risposte.GetHashCode();
        }

        //ToString
        public override string ToString()
        {
            return Testo + ";" + Risposte;
        }

        //metodi add, remove, getChild ereditati

        //metodo CalcolaPunteggio
        public override int CalcolaPunteggio()
        {
            //da aggiornare
            return 2;
        }
    }
}
