using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestComposite
{
    internal class Test : IComponente
    {
        //attributi
        private List<IComponente> _componenti;
        private int _numelementi;

        //properties
        public List<IComponente> Componenti { get => _componenti; set => _componenti = value; }
        public int NumElementi { get => _numelementi; set => _numelementi = value; }

        //costruttori con parametri
        public Test(List<IComponente> componenti, int numelementi)
        {
            Componenti = componenti;
            NumElementi = numelementi;
        }

        //costruttore senza parametri
        public Test()
        {
            Componenti = new List<IComponente>();
            NumElementi = 0;
        }

        //costruttore di copia
        public Test(Test t)
        {
            Componenti = t.Componenti;
            NumElementi = t.NumElementi;
        }

        //Equals
        public override bool Equals(object obj)
        {
            return Equals(obj as Test);
        }
        public bool Equals(Test t)
        {
            return Componenti == t.Componenti &&
                NumElementi == t.NumElementi;
        }

        //GetHashCode
        public override int GetHashCode()
        {
            return Componenti.GetHashCode() ^
                NumElementi.GetHashCode();
        }

        //ToString
        public override string ToString()
        {
            string str = string.Empty;
            for (int i = 0; i < Componenti.Count; i++)
            {
                str += Componenti[i].ToString();
       
            }
            return str;
        }

        //metodi add, remove, getChild
        public void add(IComponente cmp)
        {
            Componenti.Add(cmp);
            NumElementi++;
        }
        public void remove(int ind)
        {
            Componenti.RemoveAt(ind);
            NumElementi--;
        }
        public void getChild(int ind)
        {
            Componenti.ElementAt(ind);
        }

        //metodo CalcolaPunteggio
        public int CalcolaPunteggio(List<List<string>> rispdate)
        {
            int punteggio = 0;
            for (int i = 0; i < Componenti.Count; i++)
            {
                Domanda dmn = (Domanda)Componenti[i];
                for (int j = 0; j < dmn.Risposte.Count; j++)
                {
                    if (dmn.Risposte[j].Testo == rispdate[i][j])
                    {
                        punteggio += dmn.Risposte[j].Punti;
                    }
                }
            }
            return punteggio;
        }
    }
}