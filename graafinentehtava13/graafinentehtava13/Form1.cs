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
            string[] pojat = File.ReadAllLines("C:\\Users\\leno\\Desktop\\Ohjelmistokehitt�j�n� toimiminen\\graafisettehtavat13-14\\pojat.txt"); // kenoviivat tulee laittaa tuplana
            string[] tytot = File.ReadAllLines("C:\\Users\\leno\\Desktop\\Ohjelmistokehitt�j�n� toimiminen\\graafisettehtavat13-14\\tytot.txt");
            string nimi = NimiTB.Text;
            int laskurit = 1; // laskuri tyt�ille, alustetaan ykk�siksi kun haluamme tiet�� monesko suosituista on annettu nimi on listasta
            int laskurip = 1;// laskuri pojille
            foreach (string p in pojat) //K�yd��n taulukko l�pi, t�ss� k�ytetty p, voi olla my�s jokin muu
            {
                if (nimi == p)
                {
                    VastausLB.Text = "Nimesi on " + laskurip + ". suosituin nimi vuonna 2020";
                    VastausLB.Visible = true;
                }
                laskurip++; //kasvatetaan laskuria if-lauseen ulkopuolella
            }
            foreach (string t in tytot) //K�yd��n taulukko l�pi, t�ss� k�ytetty p, voi olla my�s jokin muu
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
                VastausLB.Text = "Nime�si ei l�ytynyt suosituimpien nimien joukosta";
                VastausLB.Visible = true;
            }
        }
    }
}
