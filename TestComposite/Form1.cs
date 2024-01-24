using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
        Form2 f2;
        List<GroupBox> grb;

        public Form1()
        {
            //inizializzazione
            test = new Test();
            ds = new DomandaS();
            dm = new DomandaM();
            f2 = new Form2();
            grb = new List<GroupBox>();
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
            f2 = new Form2();
            int posX = 50;
            int posY = 70;
            //titolo test
            Label titolo = new Label();
            titolo.Text = "Test Anteprima";
            titolo.Font = new Font("Arial", 20);
            titolo.AutoSize = true;
            titolo.Location = new System.Drawing.Point(10, 20);
            f2.Controls.Add(titolo);
            for (int i = 0; i < test.Componenti.Count; i++)
            {
                //domanda
                if (test.Componenti[i] is DomandaVF)
                {
                    //aggiunta domanda
                    DomandaVF dmn = (DomandaVF)test.Componenti[i];
                    //aggiunta groupBox
                    GroupBox groupBox = new GroupBox();
                    groupBox.Text = dmn.Testo;
                    groupBox.Location = new System.Drawing.Point(posX, posY + 20);
                    groupBox.AutoSize = true;
                    f2.Controls.Add(groupBox);
                    grb.Add(groupBox);
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
                if (test.Componenti[i] is DomandaS)
                {
                    DomandaS dmn = (DomandaS)test.Componenti[i];
                    //aggiunta groupBox
                    GroupBox groupBox = new GroupBox();
                    groupBox.Text = dmn.Testo;
                    groupBox.Location = new System.Drawing.Point(posX, posY + 20);
                    groupBox.AutoSize = true;
                    f2.Controls.Add(groupBox);
                    grb.Add(groupBox);
                    //risposte
                    for (int j = 0; j < dmn.Risposte.Count; j++)
                    {
                        RadioButton r = new RadioButton();
                        r.Text = dmn.Risposte[j].Testo;
                        r.Location = new System.Drawing.Point(10, 20 + ((j + 1) * 20));
                        groupBox.Controls.Add(r);
                    }
                    posY += 170;
                }
                else if (test.Componenti[i] is DomandaM)
                {
                    DomandaM dmn = (DomandaM)test.Componenti[i];
                    //aggiunta groupBox
                    GroupBox groupBox = new GroupBox();
                    groupBox.Text = dmn.Testo;
                    groupBox.Location = new System.Drawing.Point(posX, posY + 20);
                    groupBox.AutoSize = true;
                    f2.Controls.Add(groupBox);
                    grb.Add(groupBox);
                    for (int j = 0; j < dmn.Risposte.Count; j++)
                    {
                        CheckBox c = new CheckBox();
                        c.Text = dmn.Risposte[j].Testo;
                        c.Location = new System.Drawing.Point(10, 20 + ((j + 1) * 20));
                        groupBox.Controls.Add(c);
                    }
                    posY += 50 * dmn.Risposte.Count;
                }
            }
            posY += 100;
            Button b = new Button();
            b.Text = "Invia";
            b.Location = new System.Drawing.Point(posX, posY);
            b.Click += invia_Click;
            f2.Controls.Add(b);
            f2.Show();
        }

        public void invia_Click(object sender, EventArgs e)
        {
            List<List<string>> rispdate = new List<List<string>>();
            rispdate.Clear();
            for (int i = 0; i < grb.Count; i++)
            {
                rispdate.Add(new List<string>());
            }
            for (int i = 0; i < grb.Count; i++)
            {
                for (int j = 0; j < grb[i].Controls.Count; j++)
                {
                    if (grb[i].Controls[j] is RadioButton)
                    {
                        RadioButton r = (RadioButton)grb[i].Controls[j];
                        if (r.Checked)
                        {
                            rispdate[i].Add(r.Text);
                        }
                        else
                        {
                            rispdate[i].Add("*");
                        }
                    }
                    else if (grb[i].Controls[j] is CheckBox)
                    {
                        CheckBox c = (CheckBox)grb[i].Controls[j];
                        if (c.Checked)
                        {
                            rispdate[i].Add(c.Text);
                        }
                        else
                        {
                            rispdate[i].Add("*");
                        }
                    }
                }
            }
            MessageBox.Show(Text = "Punteggio: " + test.CalcolaPunteggio(rispdate), "Informazione");
        }
    }
}
