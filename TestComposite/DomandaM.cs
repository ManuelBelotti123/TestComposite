using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TestComposite
{
    internal class DomandaM : Domanda
    {
        //costruttori
        public DomandaM(string testo, List<Risposta> risposte) : base(testo, risposte)
        {
            Testo = testo;
            Risposte = risposte;
            NumElementi = risposte.Count;
        }
        public DomandaM(string testo) : base(testo)
        {
            Testo = testo;
            Risposte = new List<Risposta>();
            NumElementi = 0;
        }
        public DomandaM()
        {
            Testo = "";
            Risposte = new List<Risposta>();
        }
        public DomandaM(Domanda d)
        {
            Testo = d.Testo;
            Risposte = d.Risposte;
        }

        //Equals
        public override bool Equals(object obj)
        {
            return Equals(obj as DomandaM);
        }
        public bool Equals(DomandaM d)
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
            return Testo;
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
