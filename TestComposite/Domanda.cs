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
        private int _numelementi;

        //properties
        public string Testo { get => _testo; set => _testo = value; }
        public List<Risposta> Risposte { get => _risposte; set => _risposte = value; }
        public int NumElementi { get => _numelementi; set => _numelementi = value; }
        
        //costruttori
        public Domanda(string testo, List<Risposta> risposte)
        {
            Testo = testo;
            Risposte = risposte;
            NumElementi = risposte.Count;
        }
        public Domanda(string testo)
        {
            Testo = testo;
            Risposte = new List<Risposta>();
            NumElementi = 0;
        }
        public Domanda()
        {
            Testo = "";
            Risposte = new List<Risposta>();
            NumElementi = 0;
        }
        public Domanda(Domanda d)
        {
            Testo = d.Testo;
            Risposte = d.Risposte;
            NumElementi = d.NumElementi;
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
            return Testo;
        }
        
        //metodi add, remove, getChild
        public void add(IComponente cmp)
        {
            Risposte.Add((Risposta)cmp);
            NumElementi++;
        }
        public void remove(int ind)
        {
            Risposte.RemoveAt(ind);
            NumElementi--;
        }
        public void getChild(int ind)
        {
            Risposte.ElementAt(ind);
        }

        //metodo CalcolaPunteggio
        public virtual int CalcolaPunteggio()
        {
            //da aggiornare
            return 1;
        }
    }
}
