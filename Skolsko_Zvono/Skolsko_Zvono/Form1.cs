using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Skolsko_Zvono
{
    public partial class Form1 : Form
    {
        string FilePath = @"C:\Users\User\Documents\Visual Studio 2013\Projects\Skolsko_Zvono\RasporedZvonjenja.txt";
        int[,] TrajanjeCasa = new int[2, 7];
        int MaliOdmor = 5;
        int VelikiOdmor = 20;
        DateTime PrvaSmjena = new DateTime();
        DateTime DrugaSmjena = new DateTime();
        DateTime Zvono = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0, 0);
        DateTime[] Raspored = new DateTime[28];
        bool PlaySound = true;

        DateTime PostaviPodatke(int sati, int minute)
        {
            int dani = 0;
            while (minute >= 60)
            {
                minute -= 60;
                sati++;
            }
            while (sati >= 24)
            {
                sati -= 24;
                dani++;
            }
            DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + dani, sati, minute, 0, 0);
            return dt;
        }
        void PostaviZvono()
        {
            int index = 0;
            Zvono = Raspored[index++];
            while (true)
            {
                if (Zvono.Hour == DateTime.Now.Hour)
                {
                    if (Zvono.Minute >= DateTime.Now.Minute)
                    {
                        break;
                    }
                }
                if (Zvono.Hour > DateTime.Now.Hour) break;
                Zvono = Raspored[index++];
                if (index == 28) break;
            }
            if (index == 28) Zvono = PrvaSmjena;
        }

        void IspisiRaspored()
        {
            int index = 0;
            richTextBox1.Text = " \n\n\n";
            richTextBox1.Text += " Pocetak prve smjene:  " + PrvaSmjena.ToShortTimeString() + "\n";
            Zvono = PrvaSmjena;
            Raspored[index++] = Zvono;
            for (int i = 0; i < 3; i++)
            {
                richTextBox1.Text += (i + 1) + ". cas:  " + Zvono.ToShortTimeString();
                Zvono = PostaviPodatke(Zvono.Hour, Zvono.Minute + TrajanjeCasa[0, i]);
                Raspored[index++] = Zvono;
                richTextBox1.Text += " - " + Zvono.ToShortTimeString() + "\n";
                Zvono = PostaviPodatke(Zvono.Hour, Zvono.Minute + MaliOdmor);
                if (i != 2) Raspored[index++] = Zvono;
            }
            Zvono = PostaviPodatke(Zvono.Hour, Zvono.Minute + VelikiOdmor - MaliOdmor);
            Raspored[index++] = Zvono;
            richTextBox1.Text += "Veliki odmor do: " + Zvono.ToShortTimeString() + "\n";
            for (int i = 3; i < 7; i++)
            {
                richTextBox1.Text += (i + 1) + ". cas:  " + Zvono.ToShortTimeString();
                Zvono = PostaviPodatke(Zvono.Hour, Zvono.Minute + TrajanjeCasa[0, i]);
                Raspored[index++] = Zvono;
                richTextBox1.Text += " - " + Zvono.ToShortTimeString() + "\n";
                Zvono = PostaviPodatke(Zvono.Hour, Zvono.Minute + MaliOdmor);
                if (i != 6) Raspored[index++] = Zvono;//nema potrebe dodavati mali odmor nakon sedmog casa
            }
            //druga smjena
            richTextBox1.Text += "\n\n\n";
            richTextBox1.Text += " Pocetak druge smjene:  " + DrugaSmjena.ToShortTimeString() + "\n";
            Zvono = DrugaSmjena;
            Raspored[index++] = Zvono;
            for (int i = 0; i < 3; i++)
            {
                richTextBox1.Text += (i + 1) + ". cas:  " + Zvono.ToShortTimeString();
                Zvono = PostaviPodatke(Zvono.Hour, Zvono.Minute + TrajanjeCasa[1, i]);
                Raspored[index++] = Zvono;
                richTextBox1.Text += " - " + Zvono.ToShortTimeString() + "\n";
                Zvono = PostaviPodatke(Zvono.Hour, Zvono.Minute + MaliOdmor);
                if (i != 2) Raspored[index++] = Zvono;
            }
            Zvono = PostaviPodatke(Zvono.Hour, Zvono.Minute + VelikiOdmor - MaliOdmor);
            Raspored[index++] = Zvono;
            richTextBox1.Text += "Veliki odmor do: " + Zvono.ToShortTimeString() + "\n";
            for (int i = 3; i < 7; i++)
            {
                richTextBox1.Text += (i + 1) + ". cas:  " + Zvono.ToShortTimeString();
                Zvono = PostaviPodatke(Zvono.Hour, Zvono.Minute + TrajanjeCasa[1, i]);
                Raspored[index++] = Zvono;
                richTextBox1.Text += " - " + Zvono.ToShortTimeString() + "\n";
                Zvono = PostaviPodatke(Zvono.Hour, Zvono.Minute + MaliOdmor);
                if (i != 6) Raspored[index++] = Zvono;
            }
            for(int i=0;i<28;i++)
            {
             for(int j=i;j<28;j++)
                {
                    if(Raspored[i].Hour >Raspored[j].Hour || (Raspored[i].Hour==Raspored[j].Hour && Raspored[i].Minute>Raspored[j].Minute))
                    {
                        DateTime temp = Raspored[i];
                        Raspored[i] = Raspored[j];
                        Raspored[j] = temp;
                    }
                }
            }

                PostaviZvono();
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //inicijalizacija
            string[] lines = File.ReadAllLines(FilePath);    //citanje svih linija koda
            int Index = lines[0].IndexOf(',');               //posto moze biti ejdnoscifreni i dvocifreni broj moramo naci indeks , kako bi ispravno podijelili stringove
            PrvaSmjena = PostaviPodatke(Convert.ToInt32(lines[0].Substring(0, Index)), Convert.ToInt32(lines[0].Substring(Index + 1)));//postavimo vrijendnost sati i minitua pprve smjene prema dokumentu
            Index = lines[1].IndexOf(',');                    //isti proces ponovimo za drugu smjenu
            DrugaSmjena = PostaviPodatke(Convert.ToInt32(lines[1].Substring(0, Index)), Convert.ToInt32(lines[1].Substring(Index + 1)));
            for (int i = 0; i < 2; i++)                       //prema dokumentu zapamtimo u matricu koliko časovi traju 
                for (int j = 0; j < 7; j++)
                    TrajanjeCasa[i, j] = Convert.ToInt32(lines[4 + 7 * i + j]);
            MaliOdmor = Convert.ToInt32(lines[2]);            //duzina malog odmora je zapisana u 3 liniji teksta
            VelikiOdmor = Convert.ToInt32(lines[3]);          //duzina malog odmora je zapisana u 3 liniji teksta
            Cas_comboBox.SelectedIndex = 0;
            Smjena_comboBox.SelectedIndex = 0;
            textBox1.Text = MaliOdmor.ToString();
            textBox2.Text = VelikiOdmor.ToString();
            PrvaSmjena_TimePicker.Value = PrvaSmjena;
            DrugaSmjena_TimePicker.Value = DrugaSmjena;
            timer1.Start();
            IspisiRaspored();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            IspisiRaspored();
        }

        private void Smjena_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cas_comboBox.SelectedIndex != 0)
                textBox3.Text = TrajanjeCasa[Smjena_comboBox.SelectedIndex, Cas_comboBox.SelectedIndex - 1].ToString();
        }

        private void Cas_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cas_comboBox.SelectedIndex != 0)
                textBox3.Text = TrajanjeCasa[Smjena_comboBox.SelectedIndex, Cas_comboBox.SelectedIndex - 1].ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int Minute = new int();
            try
            {
                if (textBox3.Text != "") Minute = Convert.ToInt32(textBox3.Text);
                MaliOdmor = Convert.ToInt32(textBox1.Text);
                VelikiOdmor = Convert.ToInt32(textBox2.Text);
                PrvaSmjena = PrvaSmjena_TimePicker.Value;
                DrugaSmjena = DrugaSmjena_TimePicker.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (textBox3.Text == "") return;
            if (Minute <= 0 || Minute > 60)
            {
                MessageBox.Show("Unesite trajanje časa između 1-60 minuta");
                return;
            }
            if (Cas_comboBox.SelectedIndex == 0)
            {
                for (int i = 0; i < 7; i++)
                    TrajanjeCasa[Smjena_comboBox.SelectedIndex, i] = Minute;
            }
            else TrajanjeCasa[Smjena_comboBox.SelectedIndex, Cas_comboBox.SelectedIndex - 1] = Minute;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Vrijeme_label.Text = DateTime.Now.ToLongTimeString();
            TimeSpan ts = Zvono - DateTime.Now;
            int minute = Convert.ToInt32(ts.TotalMinutes);
            SljedeceZvono_label.Text = "Zvoni za: " + minute + " min";
            if (DateTime.Now.Hour == Zvono.Hour && DateTime.Now.Minute == Zvono.Minute && PlaySound)
            {
                SoundPlayer sp = new SoundPlayer(@"C:\Users\User\Documents\Visual Studio 2013\Projects\Skolsko_Zvono\Zvono.wav");
                sp.Play();
                PlaySound = false;
            }
            if (DateTime.Now.Minute != Zvono.Minute && !PlaySound)
            {
                PlaySound = true;
                PostaviZvono();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(FilePath);
            lines[0] = Convert.ToInt32(PrvaSmjena.Hour) + "," + Convert.ToInt32(PrvaSmjena.Minute);
            lines[1] = Convert.ToInt32(DrugaSmjena.Hour) + "," + Convert.ToInt32(DrugaSmjena.Minute);
            lines[2] = MaliOdmor.ToString();
            lines[3] = VelikiOdmor.ToString();
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 7; j++)
                    lines[4 + i * 7 + j] = TrajanjeCasa[i, j].ToString();
            File.WriteAllLines(FilePath, lines);
            MessageBox.Show("Prommjene su trajno sačuvane");
        }
    }
}
