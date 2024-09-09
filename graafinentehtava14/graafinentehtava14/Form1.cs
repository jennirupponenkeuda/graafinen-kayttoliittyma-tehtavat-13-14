using Microsoft.VisualBasic.ApplicationServices;
using System.IO; //T‰m‰ tulee lis‰t‰, jotta kirjoitusten luku ja kirjoitus onnistuu
namespace graafinentehtava14
{
    public partial class PaivakirjaForm : Form
    {
        public PaivakirjaForm()
        {
            InitializeComponent();
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = File.ReadAllText("C:\\Users\\leno\\Desktop\\Ohjelmistokehitt‰j‰n‰ toimiminen\\graafisettehtavat13-14\\paivakirja.txt");//Tulee luoda tyhj‰ txt-tiedosto, johon teksti tallentuu ja ja josta se luetaan
            teksti += SyottoTB.Text; //Lis‰t‰‰n jo olemassa olevaan tekstiin uusi teksti SyotteTB:st‰
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH.mm") + "\n"; //Lis‰t‰‰n p‰iv‰ys ja enter
            TextWriter text = new StreamWriter("C:\\Users\\leno\\Desktop\\Ohjelmistokehitt‰j‰n‰ toimiminen\\graafisettehtavat13-14\\paivakirja.txt"); // eli m‰‰ritell‰‰n, ett‰ t‰nne kirjoitetaan
            text.Write(teksti); // m‰‰ritell‰‰n mit‰ kirjoitetaan
            text.Close(); // suljetaan teksti
            Application.Exit();//suljetaan ohjelma
        }

    }
}
