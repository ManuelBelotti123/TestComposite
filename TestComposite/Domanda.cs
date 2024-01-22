using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestComposite
{
    internal class Domanda : IComponente
    {
        //attributi
        private string _testo;
        private List<Risposta> _risposte;

        //properties
        public string Testo { get => _testo; set => _testo = value; }
        public List<Risposta> Risposte { get => _risposte; set => _risposte = value; }
        
        //costruttori
        public Domanda(string testo, List<Risposta> risposte)
        {
            Testo = testo;
            Risposte = risposte;
        }
        public Domanda()
        {
            Testo = "";
            Risposte = new List<Risposta>();
        }
        public Domanda(Domanda d)
        {
            Testo = d.Testo;
            Risposte = d.Risposte;
        }

        //Equals
        public override bool Equals(object obj)
        {
            return Equals(obj as Domanda);
        }
        public bool Equals(Domanda d)
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
        
        //metodi add, remove, getChild
        public void add(IComponente cmp)
        {
            Risposte.Add((Risposta)cmp);
        }
        public void remove(int ind)
        {
            Risposte.RemoveAt(ind);
        }
        public void getChild(int ind)
        {
            Risposte.ElementAt(ind);
        }

        //metodo CalcolaPunteggio
        public int CalcolaPunteggio()
        {
            //da aggiornare
            return 1;
        }
    }
}
