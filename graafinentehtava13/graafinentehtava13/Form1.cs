using System.IO;

namespace graafinentehtava13
{
    public partial class SuosikkiForm : Form
    {
        public SuosikkiForm()
        {
            InitializeComponent();
        }

        private void TarkastaBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible = false;
            string[] pojat = File.ReadAllLines("C:\\Users\\leno\\Desktop\\Ohjelmistokehittäjänä toimiminen\\graafisettehtavat13-14\\pojat.txt"); // kenoviivat tulee laittaa tuplana
            string[] tytot = File.ReadAllLines("C:\\Users\\leno\\Desktop\\Ohjelmistokehittäjänä toimiminen\\graafisettehtavat13-14\\tytot.txt");
            string nimi = NimiTB.Text;
            int laskurit = 1; // laskuri tytöille, alustetaan ykkösiksi kun haluamme tietää monesko suosituista on annettu nimi on listasta
            int laskurip = 1;// laskuri pojille
            foreach (string p in pojat) //Käydään taulukko läpi, tässä käytetty p, voi olla myös jokin muu
            {
                if (nimi == p)
                {
                    VastausLB.Text = "Nimesi on " + laskurip + ". suosituin nimi vuonna 2020";
                    VastausLB.Visible = true;
                }
                laskurip++; //kasvatetaan laskuria if-lauseen ulkopuolella
            }
            foreach (string t in tytot) //Käydään taulukko läpi, tässä käytetty p, voi olla myös jokin muu
            {
                if (nimi == t)
                {
                    VastausLB.Text = "Nimesi on " + laskurit + ". suosituin nimi vuonna 2020";
                    VastausLB.Visible = true;
                }
                laskurit++;
            }

            if (VastausLB.Visible == false)
            {
                VastausLB.Text = "Nimeäsi ei löytynyt suosituimpien nimien joukosta";
                VastausLB.Visible = true;
            }
        }
    }
}
