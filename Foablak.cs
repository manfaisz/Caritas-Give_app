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
    public partial class Foablak : Form
    {
        public Foablak()
       
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
            Kliensek fom = new Kliensek();
            {
                if (Bejelntkez.IsAdminUser == false)
                {
                    fom.button2.Enabled = false;
                }
                
                fom.Show();
            }

             

        }
    }
}