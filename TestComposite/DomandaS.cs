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
            NumElementi = risposte.Count;
        }
        public DomandaS(string testo) : base(testo)
        {
            Testo = testo;
            Risposte = new List<Risposta>();
            NumElementi = 0;
        }
        public DomandaS()
        {
            Testo = "";
            Risposte = new List<Risposta>();
            NumElementi = 0;
        }
        public DomandaS(Domanda d)
        {
            Testo = d.Testo;
            Risposte = d.Risposte;
            NumElementi = d.NumElementi;
        }

        //Equals
        public override bool Equals(object obj)
        {
            return Equals(obj as DomandaS);
        }
        public bool Equals(DomandaS d)
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
        public override int CalcolaPunteggio(List<List<string>> lstr)
        {
            throw new NotImplementedException();
        }
    }
}
