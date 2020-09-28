using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caritas_Giveapp
{
    public partial class Adminablak : Form
    {
        public Adminablak()
        {
            InitializeComponent();
        }

       
        private void kilépésToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();                                     //kilépés a programból
        }

        private void rászolonakKözvetlenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adomanyok ablak1 = new Adomanyok();                          //Adomány kíadás ablak létrehozása
            ablak1.Show();                                           //Adomány kíadás ablak megjelenítése
        }

        private void kliensekFelvételetörléseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kliensek ablak2 = new Kliensek();                          //Kliensek ablak létrehozása
            ablak2.Show();                                           //Kliensek ablak megjelenítése
        }

        private void újFelhasználóRögzítéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Felhasznalok ablak3 = new Felhasznalok();                          //Felhaszlálók ablak létrehozása
            ablak3.Show();                                           //Felhaszlálók ablak megjelenítése
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
        