using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Mrówka
{
    class Automat
    {
        public struct Komórka
        {
            public bool stan;
            public bool stan_następny;
            public PictureBox pole;
            public void Przepisz()
            {
                stan = stan_następny;
            }
            public void ZaznaczOdzaznacz()
            {
                stan = !stan;
                stan_następny = !stan_następny;
            }
        }

        public class Mrówki
        {
            private Point pozycja_;
            private Color kolor_;
            private Kierunek_mrówki kierunek_;
            public Point pozycja
            {
                get
                {
                    return pozycja_;
                }
                set
                {
                    pozycja_ = value;
                }
            }
            public Color kolor
            {
                get
                {
                    return kolor_;
                }
                set
                {
                    kolor_ = value;
                }
            }
            public Kierunek_mrówki kierunek
            {
                get
                {
                    return kierunek_;
                }
                set
                {
                    kierunek_ = value;
                }
            }
        }

        public struct Kierunek_mrówki
        {
            public int x;
            public int y;

            public Kierunek_mrówki(int poz_x, int poz_y)
            {
                x = poz_x;
                y = poz_y;
            }

            public Point ObrótWLewo()
            {
                Point tmp = new Point();
                if (x == 1)
                {
                    x = 0;
                    y = 1;
                }
                else if (x == -1)
                {
                    x = 0;
                    y = -1;
                }
                else if (x == 0 && y == 1)
                {
                    x = -1;
                    y = 0;
                }
                else
                {
                    x = 0;
                    y = 1;
                }
                tmp.X = x;
                tmp.Y = y;
                return tmp;
            }
            public Point ObrótWPrawo()
            {
                Point tmp = new Point();
                if (x == 1)
                {
                    x = 0;
                    y = -1;
                }
                else if (x == -1)
                {
                    x = 0;
                    y = 1;
                }
                else if (x == 0 && y == 1)
                {
                    x = 1;
                    y = 0;
                }
                else
                {
                    x = -1;
                    y = 0;
                }
                tmp.X = x;
                tmp.Y = y;
                return tmp;
            }
        }

        public Komórka[,] siatka;
        private int szerokość;
        private int wysokość;
        private int wielkość_pola;
        private foŻycie adres;
        private ComboBox lista_wzorców;
        private List<Mrówki> mrówki;

        public Automat(foŻycie adres_formy, ComboBox wzory)
        {
            adres = adres_formy;
            lista_wzorców = wzory;
            mrówki = new List<Mrówki>();
            
            //Mrówkimrówki = new List<Point>();
        }
        
        public Automat(int sze, int wys, int wielkość, foŻycie adres_formy, ComboBox wzory)
        {
            mrówki = new List<Mrówki>();
            szerokość = sze;
            wysokość = wys;
            wielkość_pola = wielkość;
            adres = adres_formy;
            lista_wzorców = wzory;
            siatka = new Komórka[szerokość, wysokość];
            for (int i = 0; i < szerokość; i++)
            {
                for (int j = 0; j < wysokość; j++)
                {
                    siatka[i, j].pole = new PictureBox();
                    siatka[i, j].pole.Parent = adres;
                    siatka[i, j].pole.Width = wielkość;
                    siatka[i, j].pole.Height = wielkość;
                    siatka[i, j].pole.Left = wielkość * i;
                    siatka[i, j].pole.Top = 100 + wielkość * j;
                    siatka[i, j].pole.BackColor = Color.White;
                    siatka[i, j].pole.BorderStyle = BorderStyle.FixedSingle;
                    siatka[i, j].pole.Click += pictureBox1_Click;
                    siatka[i, j].pole.Tag = i * wysokość + j;
                    siatka[i, j].stan = false;
                    siatka[i, j].stan_następny = false;
                }
            }
        }

        public void Usuń()
        {
            for (int i = 0; i < szerokość; i++)
            {
                for (int j = 0; j < wysokość; j++)
                {
                    siatka[i, j].pole.Dispose();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Mrówki m = new Mrówki();
            PictureBox tmp;
            tmp = (PictureBox)sender;
            int poz_x = (int)tmp.Tag / wysokość;
            int poz_y = (int)tmp.Tag % wysokość;
            m.pozycja = new Point(poz_x, poz_y);
            m.kolor = Color.Black;
            m.kierunek = new Kierunek_mrówki(1,0);
            if (adres.Czy_mrówka == true) //dodaj mrówkę
            {
                if (tmp.BackColor != Color.Blue) //jeśli tu nie ma mrówki
                {
                    m.kolor = tmp.BackColor;
                    tmp.BackColor = Color.Blue;
                    mrówki.Add(m);
                }
                //w przeciwnym wypadku mrówka już jest - nic nie rób
                adres.Czy_mrówka = false;
            }
            else if (adres.Tryb_usuwania == true) //usuń mrówkę
            {
                int który = 0;
                if (tmp.BackColor == Color.Blue)
                {
                    for (int i = 0; i < mrówki.Count; i++)
                    {
                        if (mrówki[i].pozycja == m.pozycja)
                        {
                            m.kolor = mrówki[i].kolor;
                            m.kierunek = mrówki[i].kierunek;
                            który = i;
                            break;
                        }
                    }
                    tmp.BackColor = m.kolor;
                    mrówki.RemoveAt(który);
                }
                else
                {
                    MessageBox.Show("Tutaj nie ma mrówki. Nic nie zostało usunięte.", "Nłąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                adres.Tryb_usuwania = false;
            }
            else //zaznacz pole
            {
                if (tmp.BackColor == Color.White)
                    tmp.BackColor = Color.Black;
                else if(tmp.BackColor == Color.Black)
                    tmp.BackColor = Color.White;
                //jak niebieski - nie rób nic, tam jest mrówka
            }
        }

        public void Zapisz()
        {
            if (!lista_wzorców.Items.Contains(lista_wzorców.Text))
                lista_wzorców.Items.Add(lista_wzorców.Text);
            StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "\\lista.in");
            sw.WriteLine(lista_wzorców.Items.Count);
            for (int i = 0; i < lista_wzorców.Items.Count; i++)
            {
                sw.WriteLine(lista_wzorców.Items[i].ToString());
            }
            sw.Close();
            sw = new StreamWriter(Directory.GetCurrentDirectory() + "\\wzory\\" + lista_wzorców.Text + ".wzr");
            sw.WriteLine(szerokość);
            sw.WriteLine(wysokość);
            for (int i = 0; i < szerokość; i++)
            {
                for (int j = 0; j < wysokość; j++)
                {
                    if (siatka[i, j].pole.BackColor == Color.White)
                        sw.Write(0);
                    else if (siatka[i, j].pole.BackColor == Color.Black)
                        sw.Write(1);
                    else //niebieski
                    {
                        for (int k = 0; k < mrówki.Count; k++)
                        {
                            if (mrówki[k].pozycja.X == i && mrówki[k].pozycja.Y == j)
                            {
                                if(mrówki[k].kolor == Color.Black)
                                    sw.Write(1);
                                else
                                    sw.Write(0);
                                break;
                            }
                        }
                    }
                }
                sw.WriteLine();
            }
            sw.Close();
        }

        public void Wczytaj()
        {
            StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "\\wzory\\" + lista_wzorców.Text + ".wzr");
            Usuń();
            szerokość = int.Parse(sr.ReadLine());
            wysokość = int.Parse(sr.ReadLine());
            int wielkość_x = adres.Width / szerokość;
            int wielkość_y = (adres.Height - 150) / wysokość;
            if (wielkość_x < wielkość_y)
                wielkość_pola = wielkość_x;
            else
                wielkość_pola = wielkość_y;
            siatka = new Komórka[szerokość, wysokość];
            int stan_komórki;
            for (int i = 0; i < szerokość; i++)
            {
                for (int j = 0; j < wysokość; j++)
                {
                    siatka[i, j].pole = new PictureBox();
                    siatka[i, j].pole.Parent = adres;
                    siatka[i, j].pole.Width = wielkość_pola;
                    siatka[i, j].pole.Height = wielkość_pola;
                    siatka[i, j].pole.Left = wielkość_pola * i;
                    siatka[i, j].pole.Top = 100 + wielkość_pola * j;
                    siatka[i, j].pole.BackColor = Color.White;
                    siatka[i, j].pole.BorderStyle = BorderStyle.FixedSingle;
                    siatka[i, j].pole.Click += pictureBox1_Click;
                    siatka[i, j].pole.Tag = i * wysokość + j;
                    stan_komórki = sr.Read();
                    if (stan_komórki == 49)
                    {
                        siatka[i, j].ZaznaczOdzaznacz();
                        siatka[i, j].pole.BackColor = Color.Black;
                        siatka[i, j].stan_następny = true;
                    }
                    else
                    {
                        siatka[i, j].stan_następny = false;
                        siatka[i, j].stan = false;
                    }
                }
                sr.ReadLine();
            }
            sr.Close();
            //wyczyść listę
            mrówki.Clear();
        }

        public void Krok()
        {
            for (int i = 0; i < mrówki.Count; i++)
            {
                if (mrówki[i].kolor == Color.White)
                {
                    siatka[mrówki[i].pozycja.X, mrówki[i].pozycja.Y].pole.BackColor = Color.Black;
                    Point t = mrówki[i].kierunek.ObrótWLewo();
                    Point poz_tmp = new Point();
                    poz_tmp.X = (mrówki[i].pozycja.X + t.X) % szerokość;
                    poz_tmp.Y = (mrówki[i].pozycja.Y + t.Y) % wysokość;
                    if (poz_tmp.X == -1)
                        poz_tmp.X = szerokość - 1;
                    if (poz_tmp.Y == -1)
                        poz_tmp.Y = wysokość - 1;
                    mrówki[i].pozycja = poz_tmp;
                    Kierunek_mrówki update;
                    update.x = t.X;
                    update.y = t.Y;
                    mrówki[i].kierunek = update;
                    mrówki[i].kolor = siatka[mrówki[i].pozycja.X, mrówki[i].pozycja.Y].pole.BackColor;
                    siatka[mrówki[i].pozycja.X, mrówki[i].pozycja.Y].pole.BackColor = Color.Blue;
                }
                else
                {
                    siatka[mrówki[i].pozycja.X, mrówki[i].pozycja.Y].pole.BackColor = Color.White;
                    Point t = mrówki[i].kierunek.ObrótWPrawo();
                    Point poz_tmp = new Point();
                    poz_tmp.X = (mrówki[i].pozycja.X + t.X) % szerokość;
                    poz_tmp.Y = (mrówki[i].pozycja.Y + t.Y) % wysokość;
                    if (poz_tmp.X == -1)
                        poz_tmp.X = szerokość - 1;
                    if (poz_tmp.Y == -1)
                        poz_tmp.Y = wysokość - 1;
                    Kierunek_mrówki update;
                    update.x = t.X;
                    update.y = t.Y;
                    mrówki[i].kierunek = update;
                    mrówki[i].pozycja = poz_tmp;
                    mrówki[i].kolor = siatka[mrówki[i].pozycja.X, mrówki[i].pozycja.Y].pole.BackColor;
                    siatka[mrówki[i].pozycja.X, mrówki[i].pozycja.Y].pole.BackColor = Color.Blue;
                }
            }
        }

        public int Ile_sąsiadów(int x, int y)
        {
            int liczba_żywych_sąsiadów = 0;
            if (siatka[x, (y + 1)%wysokość].stan == true)
                liczba_żywych_sąsiadów++;
            if (siatka[(x + 1)%szerokość, y].stan == true)
                liczba_żywych_sąsiadów++;
            if (siatka[(x + 1) % szerokość, (y + 1) % wysokość].stan == true)
                liczba_żywych_sąsiadów++;
            if (siatka[(x + szerokość - 1) % szerokość, y].stan == true)
                liczba_żywych_sąsiadów++;
            if (siatka[x, (y + wysokość - 1) % wysokość].stan == true)
                liczba_żywych_sąsiadów++;
            if (siatka[(x + szerokość - 1) % szerokość, (y + wysokość - 1) % wysokość].stan == true)
                liczba_żywych_sąsiadów++;
            if (siatka[(x + 1) % szerokość, (y + wysokość - 1) % wysokość].stan == true)
                liczba_żywych_sąsiadów++;
            if (siatka[(x + szerokość - 1) % szerokość, (y + 1) % wysokość].stan == true)
                liczba_żywych_sąsiadów++;
            return liczba_żywych_sąsiadów;
        }

        public void LosujMrówkę()
        {
            if (mrówki.Count == wysokość * szerokość)
            {
                MessageBox.Show("Wszystkie pola są już zajęte. Nie można stworzyć nowej mrówki.");
                return;
            }
            Random los = new Random();
            Mrówki m = new Mrówki();
            int x, y;
            do
            {
                x = los.Next(szerokość);
                y = los.Next(wysokość);
            } while (siatka[x, y].pole.BackColor == Color.Blue);
            m.kolor = siatka[x, y].pole.BackColor;
            siatka[x, y].pole.BackColor = Color.Blue;
            siatka[x, y].ZaznaczOdzaznacz();
            m.pozycja = new Point(x, y);
            m.kierunek = new Kierunek_mrówki(1,0);
            mrówki.Add(m);
        }
    }
}
