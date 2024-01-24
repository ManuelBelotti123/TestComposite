using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestComposite
{
    internal class Risposta : IComponente
    {
        //attributi
        private string _testo;
        private int _punti;

        //properties
        public string Testo { get => _testo; set => _testo = value; }
        public int Punti { get => _punti; set => _punti = value; }

        //costruttori
        public Risposta(string testo, int punti)
        {
            Testo = testo;
            Punti = punti;
        }
        public Risposta()
        {
            Testo = "";
            Punti = 0;
        }
        public Risposta(Risposta r)
        {
            Testo = r.Testo;
            Punti = r.Punti;
        }

        //Equals
        public override bool Equals(object obj)
        {
            return Equals(obj as Risposta);
        }
        public bool Equals(Risposta r)
        {
            return Testo == r.Testo &&
                Punti == r.Punti;
        }
        
        //GetHashCode
        public override int GetHashCode()
        {
            return Testo.GetHashCode() ^
                Punti.GetHashCode();
        }
        
        //ToString
        public override string ToString()
        {
            return Testo + ";" + Punti;
        }

        //metodi add, remove, getChild
        public void add(IComponente r)
        {
            throw new NotImplementedException();
        }
        public void remove(int ind)
        {
            throw new NotImplementedException();
        }
        public void getChild(int ind)
        {
            throw new NotImplementedException();
        }

        //metodo CalcolaPunteggio
        public int CalcolaPunteggio(List<List<string>> lstr)
        {
            return Punti; //da aggiornare
        }


    }
}
