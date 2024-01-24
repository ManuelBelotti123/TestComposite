namespace TestComposite
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.aggvf = new System.Windows.Forms.Button();
            this.aggrispf = new System.Windows.Forms.RadioButton();
            this.aggrispv = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.testovf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.creadomandads = new System.Windows.Forms.Button();
            this.aggrispd = new System.Windows.Forms.Button();
            this.risppuntids = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.risptestods = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.testods = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.creadomandam = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.aggrispdm = new System.Windows.Forms.Button();
            this.rispostapuntidm = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rispostatestodm = new System.Windows.Forms.TextBox();
            this.aggdomandam = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.testodm = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.provatest = new System.Windows.Forms.Button();
            this.tabcontrol.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test Editor";
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tabPage1);
            this.tabcontrol.Controls.Add(this.tabPage2);
            this.tabcontrol.Controls.Add(this.tabPage3);
            this.tabcontrol.Location = new System.Drawing.Point(28, 148);
            this.tabcontrol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(874, 526);
            this.tabcontrol.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.aggvf);
            this.tabPage1.Controls.Add(this.aggrispf);
            this.tabPage1.Controls.Add(this.aggrispv);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.testovf);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(866, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vero o Falso";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // aggvf
            // 
            this.aggvf.Location = new System.Drawing.Point(36, 357);
            this.aggvf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aggvf.Name = "aggvf";
            this.aggvf.Size = new System.Drawing.Size(320, 54);
            this.aggvf.TabIndex = 17;
            this.aggvf.Text = "Aggiungi domanda al test";
            this.aggvf.UseVisualStyleBackColor = true;
            this.aggvf.Click += new System.EventHandler(this.aggvf_Click);
            // 
            // aggrispf
            // 
            this.aggrispf.AutoSize = true;
            this.aggrispf.Location = new System.Drawing.Point(192, 263);
            this.aggrispf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aggrispf.Name = "aggrispf";
            this.aggrispf.Size = new System.Drawing.Size(73, 24);
            this.aggrispf.TabIndex = 8;
            this.aggrispf.TabStop = true;
            this.aggrispf.Text = "Falso";
            this.aggrispf.UseVisualStyleBackColor = true;
            // 
            // aggrispv
            // 
            this.aggrispv.AutoSize = true;
            this.aggrispv.Location = new System.Drawing.Point(93, 263);
            this.aggrispv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aggrispv.Name = "aggrispv";
            this.aggrispv.Size = new System.Drawing.Size(68, 24);
            this.aggrispv.TabIndex = 7;
            this.aggrispv.TabStop = true;
            this.aggrispv.Text = "Vero";
            this.aggrispv.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Selezionare il valore della risposta:";
            // 
            // testovf
            // 
            this.testovf.Location = new System.Drawing.Point(40, 122);
            this.testovf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.testovf.Multiline = true;
            this.testovf.Name = "testovf";
            this.testovf.Size = new System.Drawing.Size(313, 59);
            this.testovf.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Inserire il testo della domanda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vero o Falso";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.creadomandads);
            this.tabPage2.Controls.Add(this.aggrispd);
            this.tabPage2.Controls.Add(this.risppuntids);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.risptestods);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.testods);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(866, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Singola";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // creadomandads
            // 
            this.creadomandads.Location = new System.Drawing.Point(498, 123);
            this.creadomandads.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.creadomandads.Name = "creadomandads";
            this.creadomandads.Size = new System.Drawing.Size(298, 54);
            this.creadomandads.TabIndex = 22;
            this.creadomandads.Text = "Crea domanda";
            this.creadomandads.UseVisualStyleBackColor = true;
            this.creadomandads.Click += new System.EventHandler(this.creadomandads_Click);
            // 
            // aggrispd
            // 
            this.aggrispd.Location = new System.Drawing.Point(498, 252);
            this.aggrispd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aggrispd.Name = "aggrispd";
            this.aggrispd.Size = new System.Drawing.Size(298, 54);
            this.aggrispd.TabIndex = 21;
            this.aggrispd.Text = "Aggiungi risposta alla domanda";
            this.aggrispd.UseVisualStyleBackColor = true;
            this.aggrispd.Click += new System.EventHandler(this.aggrispd_Click);
            // 
            // risppuntids
            // 
            this.risppuntids.Location = new System.Drawing.Point(48, 382);
            this.risppuntids.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.risppuntids.Name = "risppuntids";
            this.risppuntids.Size = new System.Drawing.Size(170, 26);
            this.risppuntids.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(46, 206);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Inserire una risposta:";
            // 
            // risptestods
            // 
            this.risptestods.Location = new System.Drawing.Point(51, 235);
            this.risptestods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.risptestods.Multiline = true;
            this.risptestods.Name = "risptestods";
            this.risptestods.Size = new System.Drawing.Size(313, 59);
            this.risptestods.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(498, 358);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(298, 54);
            this.button2.TabIndex = 16;
            this.button2.Text = "Aggiungi domanda al test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 318);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(351, 50);
            this.label7.TabIndex = 13;
            this.label7.Text = "Inserire il punteggio della risposta:\r\n(se <=0 allora errata, altrimenti corretta" +
    ")";
            // 
            // testods
            // 
            this.testods.Location = new System.Drawing.Point(51, 123);
            this.testods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.testods.Multiline = true;
            this.testods.Name = "testods";
            this.testods.Size = new System.Drawing.Size(313, 59);
            this.testods.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 85);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(275, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Inserire il testo della domanda:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(368, 33);
            this.label9.TabIndex = 10;
            this.label9.Text = "Domanda Risposta Singola";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.creadomandam);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.aggrispdm);
            this.tabPage3.Controls.Add(this.rispostapuntidm);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.rispostatestodm);
            this.tabPage3.Controls.Add(this.aggdomandam);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.testodm);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(866, 493);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Multipla";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // creadomandam
            // 
            this.creadomandam.Location = new System.Drawing.Point(494, 126);
            this.creadomandam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.creadomandam.Name = "creadomandam";
            this.creadomandam.Size = new System.Drawing.Size(298, 54);
            this.creadomandam.TabIndex = 32;
            this.creadomandam.Text = "Crea domanda";
            this.creadomandam.UseVisualStyleBackColor = true;
            this.creadomandam.Click += new System.EventHandler(this.creadomandam_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(38, 35);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(372, 33);
            this.label15.TabIndex = 31;
            this.label15.Text = "Domanda Risposta Multipla";
            // 
            // aggrispdm
            // 
            this.aggrispdm.Location = new System.Drawing.Point(494, 246);
            this.aggrispdm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aggrispdm.Name = "aggrispdm";
            this.aggrispdm.Size = new System.Drawing.Size(298, 54);
            this.aggrispdm.TabIndex = 29;
            this.aggrispdm.Text = "Aggiungi risposta alla domanda";
            this.aggrispdm.UseVisualStyleBackColor = true;
            this.aggrispdm.Click += new System.EventHandler(this.aggrispdm_Click);
            // 
            // rispostapuntidm
            // 
            this.rispostapuntidm.Location = new System.Drawing.Point(44, 385);
            this.rispostapuntidm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rispostapuntidm.Name = "rispostapuntidm";
            this.rispostapuntidm.Size = new System.Drawing.Size(170, 26);
            this.rispostapuntidm.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(42, 209);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 25);
            this.label11.TabIndex = 27;
            this.label11.Text = "Inserire una risposta:";
            // 
            // rispostatestodm
            // 
            this.rispostatestodm.Location = new System.Drawing.Point(46, 238);
            this.rispostatestodm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rispostatestodm.Multiline = true;
            this.rispostatestodm.Name = "rispostatestodm";
            this.rispostatestodm.Size = new System.Drawing.Size(313, 59);
            this.rispostatestodm.TabIndex = 26;
            this.rispostatestodm.TextChanged += new System.EventHandler(this.rispostatestodm_TextChanged);
            // 
            // aggdomandam
            // 
            this.aggdomandam.Location = new System.Drawing.Point(494, 362);
            this.aggdomandam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aggdomandam.Name = "aggdomandam";
            this.aggdomandam.Size = new System.Drawing.Size(298, 54);
            this.aggdomandam.TabIndex = 25;
            this.aggdomandam.Text = "Aggiungi domanda al test";
            this.aggdomandam.UseVisualStyleBackColor = true;
            this.aggdomandam.Click += new System.EventHandler(this.aggdomandam_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(42, 322);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(351, 50);
            this.label12.TabIndex = 24;
            this.label12.Text = "Inserire il punteggio della risposta:\r\n(se <=0 allora errata, altrimenti corretta" +
    ")";
            // 
            // testodm
            // 
            this.testodm.Location = new System.Drawing.Point(46, 126);
            this.testodm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.testodm.Multiline = true;
            this.testodm.Name = "testodm";
            this.testodm.Size = new System.Drawing.Size(313, 59);
            this.testodm.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(42, 88);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(275, 25);
            this.label13.TabIndex = 22;
            this.label13.Text = "Inserire il testo della domanda:";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 35);
            this.label14.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(880, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Scegliere la tipologia di domanda da creare tra le schede proposte:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(912, 182);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(268, 484);
            this.listBox1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(908, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Anteprima test";
            // 
            // provatest
            // 
            this.provatest.Location = new System.Drawing.Point(948, 25);
            this.provatest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.provatest.Name = "provatest";
            this.provatest.Size = new System.Drawing.Size(234, 63);
            this.provatest.TabIndex = 11;
            this.provatest.Text = "Prova Test";
            this.provatest.UseVisualStyleBackColor = true;
            this.provatest.Click += new System.EventHandler(this.provatest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.provatest);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabcontrol);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabcontrol.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton aggrispf;
        private System.Windows.Forms.RadioButton aggrispv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox testovf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox risppuntids;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox risptestods;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox testods;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button aggrispdm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox rispostatestodm;
        private System.Windows.Forms.Button aggdomandam;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox testodm;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button provatest;
        private System.Windows.Forms.Button aggvf;
        private System.Windows.Forms.Button aggrispd;
        private System.Windows.Forms.Button creadomandads;
        private System.Windows.Forms.Button creadomandam;
        private System.Windows.Forms.TextBox rispostapuntidm;
    }
}

