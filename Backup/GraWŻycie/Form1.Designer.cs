namespace Mrówka
{
    partial class foŻycie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nuSzerokość = new System.Windows.Forms.NumericUpDown();
            this.nuWysokość = new System.Windows.Forms.NumericUpDown();
            this.buNowaSiatka = new System.Windows.Forms.Button();
            this.tbCzasKroku = new System.Windows.Forms.TrackBar();
            this.teCzasKroku = new System.Windows.Forms.TextBox();
            this.laWysokość = new System.Windows.Forms.Label();
            this.laSzerokość = new System.Windows.Forms.Label();
            this.laCzas = new System.Windows.Forms.Label();
            this.buWykonajKrok = new System.Windows.Forms.Button();
            this.buUruchomSymulację = new System.Windows.Forms.Button();
            this.cbWzory = new System.Windows.Forms.ComboBox();
            this.buZapisz = new System.Windows.Forms.Button();
            this.tiSymulacja = new System.Windows.Forms.Timer(this.components);
            this.laWzory = new System.Windows.Forms.Label();
            this.laSymWł = new System.Windows.Forms.Label();
            this.buMrówkaLosowa = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.UsuńMrówkę = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nuSzerokość)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuWysokość)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCzasKroku)).BeginInit();
            this.SuspendLayout();
            // 
            // nuSzerokość
            // 
            this.nuSzerokość.Location = new System.Drawing.Point(75, 5);
            this.nuSzerokość.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.nuSzerokość.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuSzerokość.Name = "nuSzerokość";
            this.nuSzerokość.Size = new System.Drawing.Size(46, 20);
            this.nuSzerokość.TabIndex = 0;
            this.nuSzerokość.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nuWysokość
            // 
            this.nuWysokość.Location = new System.Drawing.Point(211, 5);
            this.nuWysokość.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nuWysokość.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuWysokość.Name = "nuWysokość";
            this.nuWysokość.Size = new System.Drawing.Size(44, 20);
            this.nuWysokość.TabIndex = 1;
            this.nuWysokość.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // buNowaSiatka
            // 
            this.buNowaSiatka.Location = new System.Drawing.Point(273, 2);
            this.buNowaSiatka.Name = "buNowaSiatka";
            this.buNowaSiatka.Size = new System.Drawing.Size(115, 23);
            this.buNowaSiatka.TabIndex = 2;
            this.buNowaSiatka.Text = "Twórz nową siatkę";
            this.buNowaSiatka.UseVisualStyleBackColor = true;
            this.buNowaSiatka.Click += new System.EventHandler(this.buNowaSiatka_Click);
            // 
            // tbCzasKroku
            // 
            this.tbCzasKroku.Location = new System.Drawing.Point(75, 34);
            this.tbCzasKroku.Maximum = 100;
            this.tbCzasKroku.Minimum = 1;
            this.tbCzasKroku.Name = "tbCzasKroku";
            this.tbCzasKroku.Size = new System.Drawing.Size(548, 45);
            this.tbCzasKroku.TabIndex = 3;
            this.tbCzasKroku.Value = 10;
            this.tbCzasKroku.Scroll += new System.EventHandler(this.tbCzasKroku_Scroll);
            // 
            // teCzasKroku
            // 
            this.teCzasKroku.Location = new System.Drawing.Point(9, 50);
            this.teCzasKroku.Name = "teCzasKroku";
            this.teCzasKroku.Size = new System.Drawing.Size(65, 20);
            this.teCzasKroku.TabIndex = 4;
            this.teCzasKroku.Text = "1 s";
            // 
            // laWysokość
            // 
            this.laWysokość.AutoSize = true;
            this.laWysokość.Location = new System.Drawing.Point(141, 12);
            this.laWysokość.Name = "laWysokość";
            this.laWysokość.Size = new System.Drawing.Size(60, 13);
            this.laWysokość.TabIndex = 5;
            this.laWysokość.Text = "Wysokość:";
            // 
            // laSzerokość
            // 
            this.laSzerokość.AutoSize = true;
            this.laSzerokość.Location = new System.Drawing.Point(9, 12);
            this.laSzerokość.Name = "laSzerokość";
            this.laSzerokość.Size = new System.Drawing.Size(60, 13);
            this.laSzerokość.TabIndex = 6;
            this.laSzerokość.Text = "Szerokość:";
            // 
            // laCzas
            // 
            this.laCzas.AutoSize = true;
            this.laCzas.Location = new System.Drawing.Point(6, 34);
            this.laCzas.Name = "laCzas";
            this.laCzas.Size = new System.Drawing.Size(63, 13);
            this.laCzas.TabIndex = 7;
            this.laCzas.Text = "Czas kroku:";
            // 
            // buWykonajKrok
            // 
            this.buWykonajKrok.Enabled = false;
            this.buWykonajKrok.Location = new System.Drawing.Point(406, 2);
            this.buWykonajKrok.Name = "buWykonajKrok";
            this.buWykonajKrok.Size = new System.Drawing.Size(99, 23);
            this.buWykonajKrok.TabIndex = 8;
            this.buWykonajKrok.Text = "Wykonaj krok";
            this.buWykonajKrok.UseVisualStyleBackColor = true;
            this.buWykonajKrok.Click += new System.EventHandler(this.buWykonajKrok_Click);
            // 
            // buUruchomSymulację
            // 
            this.buUruchomSymulację.Enabled = false;
            this.buUruchomSymulację.Location = new System.Drawing.Point(521, 2);
            this.buUruchomSymulację.Name = "buUruchomSymulację";
            this.buUruchomSymulację.Size = new System.Drawing.Size(120, 23);
            this.buUruchomSymulację.TabIndex = 9;
            this.buUruchomSymulację.Text = "Symulacja Start/ Stop";
            this.buUruchomSymulację.UseVisualStyleBackColor = true;
            this.buUruchomSymulację.Click += new System.EventHandler(this.buUruchomSymulację_Click);
            // 
            // cbWzory
            // 
            this.cbWzory.FormattingEnabled = true;
            this.cbWzory.Location = new System.Drawing.Point(661, 4);
            this.cbWzory.Name = "cbWzory";
            this.cbWzory.Size = new System.Drawing.Size(254, 21);
            this.cbWzory.TabIndex = 10;
            this.cbWzory.SelectedIndexChanged += new System.EventHandler(this.cbWzory_SelectedIndexChanged);
            // 
            // buZapisz
            // 
            this.buZapisz.Enabled = false;
            this.buZapisz.Location = new System.Drawing.Point(921, 2);
            this.buZapisz.Name = "buZapisz";
            this.buZapisz.Size = new System.Drawing.Size(75, 23);
            this.buZapisz.TabIndex = 11;
            this.buZapisz.Text = "Zapisz";
            this.buZapisz.UseVisualStyleBackColor = true;
            this.buZapisz.Click += new System.EventHandler(this.buZapisz_Click);
            // 
            // tiSymulacja
            // 
            this.tiSymulacja.Interval = 1000;
            this.tiSymulacja.Tick += new System.EventHandler(this.tiSymulacja_Tick);
            // 
            // laWzory
            // 
            this.laWzory.AutoSize = true;
            this.laWzory.Location = new System.Drawing.Point(661, 34);
            this.laWzory.Name = "laWzory";
            this.laWzory.Size = new System.Drawing.Size(75, 13);
            this.laWzory.TabIndex = 12;
            this.laWzory.Text = "Wzory gotowe";
            // 
            // laSymWł
            // 
            this.laSymWł.AutoSize = true;
            this.laSymWł.Location = new System.Drawing.Point(753, 34);
            this.laSymWł.Name = "laSymWł";
            this.laSymWł.Size = new System.Drawing.Size(110, 13);
            this.laSymWł.TabIndex = 13;
            this.laSymWł.Text = "Symulacja wyłączona";
            // 
            // buMrówkaLosowa
            // 
            this.buMrówkaLosowa.Location = new System.Drawing.Point(123, 76);
            this.buMrówkaLosowa.Name = "buMrówkaLosowa";
            this.buMrówkaLosowa.Size = new System.Drawing.Size(127, 23);
            this.buMrówkaLosowa.TabIndex = 14;
            this.buMrówkaLosowa.Text = "Mrówka losowo";
            this.buMrówkaLosowa.UseVisualStyleBackColor = true;
            this.buMrówkaLosowa.Click += new System.EventHandler(this.buMrówkaLosowa_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Mrówka ustalona";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UsuńMrówkę
            // 
            this.UsuńMrówkę.Location = new System.Drawing.Point(256, 76);
            this.UsuńMrówkę.Name = "UsuńMrówkę";
            this.UsuńMrówkę.Size = new System.Drawing.Size(117, 23);
            this.UsuńMrówkę.TabIndex = 16;
            this.UsuńMrówkę.Text = "Usuń mrówkę";
            this.UsuńMrówkę.UseVisualStyleBackColor = true;
            this.UsuńMrówkę.Click += new System.EventHandler(this.UsuńMrówkę_Click);
            // 
            // foŻycie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.UsuńMrówkę);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buMrówkaLosowa);
            this.Controls.Add(this.laSymWł);
            this.Controls.Add(this.laWzory);
            this.Controls.Add(this.buZapisz);
            this.Controls.Add(this.cbWzory);
            this.Controls.Add(this.buUruchomSymulację);
            this.Controls.Add(this.buWykonajKrok);
            this.Controls.Add(this.laCzas);
            this.Controls.Add(this.laSzerokość);
            this.Controls.Add(this.laWysokość);
            this.Controls.Add(this.teCzasKroku);
            this.Controls.Add(this.tbCzasKroku);
            this.Controls.Add(this.buNowaSiatka);
            this.Controls.Add(this.nuWysokość);
            this.Controls.Add(this.nuSzerokość);
            this.Name = "foŻycie";
            this.Text = "Gra w życie";
            this.Load += new System.EventHandler(this.Życie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuSzerokość)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuWysokość)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCzasKroku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nuSzerokość;
        private System.Windows.Forms.NumericUpDown nuWysokość;
        private System.Windows.Forms.Button buNowaSiatka;
        private System.Windows.Forms.TrackBar tbCzasKroku;
        private System.Windows.Forms.TextBox teCzasKroku;
        private System.Windows.Forms.Label laWysokość;
        private System.Windows.Forms.Label laSzerokość;
        private System.Windows.Forms.Label laCzas;
        private System.Windows.Forms.Button buWykonajKrok;
        private System.Windows.Forms.Button buUruchomSymulację;
        private System.Windows.Forms.ComboBox cbWzory;
        private System.Windows.Forms.Button buZapisz;
        private System.Windows.Forms.Timer tiSymulacja;
        private System.Windows.Forms.Label laWzory;
        private System.Windows.Forms.Label laSymWł;
        private System.Windows.Forms.Button buMrówkaLosowa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button UsuńMrówkę;
    }
}

