using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Mrówka
{
    public partial class foŻycie : Form
    {
        private Automat życie;
        private bool nowa_mrówka;
        private bool usuwanie;

        public foŻycie()
        {
            InitializeComponent();
        }

        private void buNowaSiatka_Click(object sender, EventArgs e)
        {
            if(życie != null)
                życie.Usuń();
            int wielkość_pola;
            int wielkość_x = this.Width / (int)nuSzerokość.Value;
            int wielkość_y = (this.Height - 150) / (int)nuWysokość.Value;
            if (wielkość_x < wielkość_y)
                wielkość_pola = wielkość_x;
            else
                wielkość_pola = wielkość_y;
            foŻycie f = this;
            życie = new Automat((int)nuSzerokość.Value, (int)nuWysokość.Value, wielkość_pola, f, cbWzory);
            buZapisz.Enabled = true;
            buWykonajKrok.Enabled = true;
            buUruchomSymulację.Enabled = true;
            nowa_mrówka = false;
            usuwanie = false;
        }
        
        private void Życie_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "\\lista.in");
            int ile = int.Parse(sr.ReadLine());
            for (int i = 0; i < ile; i++)
            {
                cbWzory.Items.Add(sr.ReadLine());
            }
            sr.Close();
        }

        private void buZapisz_Click(object sender, EventArgs e)
        {
            życie.Zapisz();
        }

        private void cbWzory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbWzory.SelectedIndex >= 0)
            {
                if (życie == null)
                    życie = new Automat(this, cbWzory);
                życie.Wczytaj();
                buZapisz.Enabled = true;
                buWykonajKrok.Enabled = true;
                buUruchomSymulację.Enabled = true;
            }
        }

        private void buWykonajKrok_Click(object sender, EventArgs e)
        {
            życie.Krok();
        }

        private void buUruchomSymulację_Click(object sender, EventArgs e)
        {
            tiSymulacja.Enabled = !tiSymulacja.Enabled;
            if (laSymWł.Text == "Symulacja wyłączona")
                laSymWł.Text = "Symulacja włączona";
            else
                laSymWł.Text = "Symulacja wyłączona";
        }

        private void tiSymulacja_Tick(object sender, EventArgs e)
        {
            życie.Krok();
        }

        private void tbCzasKroku_Scroll(object sender, EventArgs e)
        {
            tiSymulacja.Interval = tbCzasKroku.Value * 100;
            teCzasKroku.Text = (tbCzasKroku.Value / 10.0).ToString() + " s";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nowa_mrówka = true;
            usuwanie = false;
        }

        public bool Czy_mrówka
        {
            get
            {
                return nowa_mrówka;
            }
            set
            {
                nowa_mrówka = value;
            }
        }

        public bool Tryb_usuwania
        {
            get
            {
                return usuwanie;
            }
            set
            {
                usuwanie = value;
            }
        }

        private void buMrówkaLosowa_Click(object sender, EventArgs e)
        {
            życie.LosujMrówkę();
        }

        private void UsuńMrówkę_Click(object sender, EventArgs e)
        {
            usuwanie = true;
            nowa_mrówka = false;
        }
    }
}
