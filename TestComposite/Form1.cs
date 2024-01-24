using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TestComposite
{
    public partial class Form1 : Form
    {
        //dichiarazione
        Test test;
        DomandaS ds;
        DomandaM dm;

        public Form1()
        {
            //inizializzazione
            test = new Test();
            ds = new DomandaS();
            dm = new DomandaM();
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

        private void creadomandads_Click(object sender, EventArgs e)
        {
            ds = new DomandaS(testods.Text);
            MessageBox.Show("Domanda creata correttamente", "Informazione");
        }

        private void aggrispd_Click(object sender, EventArgs e)
        {
            if (ds.Testo != string.Empty)
            {
                ds.add(new Risposta(risptestods.Text, int.Parse(risppuntids.Text)));
                MessageBox.Show("Risposta creata correttamente", "Informazione");
            }
            else
            {
                MessageBox.Show("Creare prima la domanda", "Errore");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ds.Testo != string.Empty)
            {
                test.add(ds);
                AggiornaAnteprima();
                MessageBox.Show("Domanda creata correttamente", "Informazione");
            }
            else
            {
                MessageBox.Show("Creare prima la domanda", "Errore");
            }
            ds = new DomandaS();
        }

        private void creadomandam_Click(object sender, EventArgs e)
        {
            dm = new DomandaM(testodm.Text);
            MessageBox.Show("Domanda creata correttamente", "Informazione");
        }

        //ciao
        private void rispostatestodm_TextChanged(object sender, EventArgs e)
        {

        }

        private void aggrispdm_Click(object sender, EventArgs e)
        {
            if (dm.Testo != string.Empty)
            {
                dm.add(new Risposta(rispostatestodm.Text, int.Parse(rispostapuntidm.Text)));
                MessageBox.Show("Risposta creata correttamente", "Informazione");
            }
            else
            {
                MessageBox.Show("Creare prima la domanda", "Errore");
            }
        }

        private void aggdomandam_Click(object sender, EventArgs e)
        {
            if (dm.Testo != string.Empty)
            {
                test.add(dm);
                AggiornaAnteprima();
                MessageBox.Show("Domanda creata correttamente", "Informazione");
            }
            else
            {
                MessageBox.Show("Creare prima la domanda", "Errore");
            }
            dm = new DomandaM();
        }

        private void provatest_Click(object sender, EventArgs e)
        {
            int posX = 50;
            int posY = 70;
            Form2 f2 = new Form2();
            for (int i = 0; i < test.Componenti.Count; i++)
            {
                //titolo test
                Label titolo = new Label();
                titolo.Text = "Test Anteprima";
                titolo.Font = new Font("Arial", 20);
                titolo.AutoSize = true;
                titolo.Location = new System.Drawing.Point(10, 20);
                f2.Controls.Add(titolo);
                //domanda
                if (test.Componenti[i] is DomandaVF)
                {
                    //aggiunta domanda
                    DomandaVF dmn = (DomandaVF)test.Componenti[i];
                    Label l = new Label();
                    l.Text = dmn.Testo;
                    l.Location = new System.Drawing.Point(posX, posY);
                    f2.Controls.Add(l);
                    //aggiunta groupBox
                    GroupBox groupBox = new GroupBox();
                    groupBox.Text = string.Empty;
                    groupBox.Location = new System.Drawing.Point(posX, posY + 20);
                    f2.Controls.Add(groupBox);
                    //aggiunta risposte nel groupBox
                    for (int j = 0; j < dmn.Risposte.Count; j++)
                    {
                        RadioButton r = new RadioButton();
                        r.Text = dmn.Risposte[j].Testo;
                        r.Location = new System.Drawing.Point(10, 20 + ((j + 1) * 20));
                        groupBox.Controls.Add(r);
                    }
                    posY += 150;
                }
                else if (test.Componenti[i] is DomandaS)
                {
                    DomandaS dmn = (DomandaS)test.Componenti[i];
                    Label l = new Label();
                    l.Text = dmn.Testo;
                    l.Location = new System.Drawing.Point(posX, posY);
                    f2.Controls.Add(l);
                    //aggiunta groupBox
                    GroupBox groupBox = new GroupBox();
                    groupBox.Text = string.Empty;
                    groupBox.Location = new System.Drawing.Point(posX, posY + 20);
                    f2.Controls.Add(groupBox);
                    for (int j = 0; j < dmn.Risposte.Count; j++)
                    {
                        RadioButton r = new RadioButton();
                        r.Text = dmn.Risposte[j].Testo;
                        r.AutoCheck = false;
                        //r.Click += rbClick;
                        r.Location = new System.Drawing.Point(10, 20 + ((j + 1) * 20));
                        groupBox.Controls.Add(r);
                    }
                    posY += 50 * dmn.Risposte.Count;
                }
                else if (test.Componenti[i] is DomandaM)
                {
                    DomandaM dmn = (DomandaM)test.Componenti[i];
                    Label l = new Label();
                    l.Text = dmn.Testo;
                    l.Location = new System.Drawing.Point(posX, posY);
                    f2.Controls.Add(l);
                    //aggiunta groupBox
                    GroupBox groupBox = new GroupBox();
                    groupBox.Text = string.Empty;
                    groupBox.Location = new System.Drawing.Point(posX, posY + 20);
                    f2.Controls.Add(groupBox);
                    for (int j = 0; j < dmn.Risposte.Count; j++)
                    {
                        CheckBox r = new CheckBox();
                        r.Text = dmn.Risposte[j].Testo;
                        r.Location = new System.Drawing.Point(10, 20 + ((j + 1) * 20));
                        groupBox.Controls.Add(r);
                    }
                    posY += 50 * dmn.Risposte.Count;
                }
            }
            f2.Show();
        }
    }
}
