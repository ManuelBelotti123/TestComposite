using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestComposite
{
    public partial class Form1 : Form
    {
        //dichiarazione
        Test test;

        public Form1()
        {
            test = new Test();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aggvf_Click(object sender, EventArgs e)
        {
            DomandaVF dmn = new DomandaVF(testovf.Text);
            if (aggrispv.Checked)
            {
                dmn.add(new Risposta("Vero", 1));
                dmn.add(new Risposta("Falso", 0));
            }
            else
            {
                dmn.add(new Risposta("Vero", 0));
                dmn.add(new Risposta("Falso", 1));
            }
            test.add(dmn);
            AggiornaAnteprima();
        }

        public void AggiornaAnteprima()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < test.Componenti.Count; i++)
            {
                listBox1.Items.Add(test.Componenti[i].ToString());
            }
        }
    }
}
