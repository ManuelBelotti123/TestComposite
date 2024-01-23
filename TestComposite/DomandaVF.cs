using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestComposite
{
    internal class DomandaVF : Domanda
    {
        //costruttori
        public DomandaVF(string testo, List<Risposta> risposte) : base(testo, risposte)
        {
            Testo = testo;
            Risposte = risposte;
        }
        public DomandaVF()
        {
            Testo = "";
            Risposte = new List<Risposta>();
        }
        public DomandaVF(Domanda d)
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
