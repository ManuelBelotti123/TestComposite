using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestComposite
{
    internal interface IComponente
    {
        void add(IComponente cmp);
        void remove(int ind);
        void getChild(int ind);
        string ToString();
        bool Equals(object obj);
        int CalcolaPunteggio();
    }
}
