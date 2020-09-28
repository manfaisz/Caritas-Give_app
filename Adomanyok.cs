//készítette: Mánfai Szabolcs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Caritas_Giveapp
{
    public partial class Adomanyok : Form
    {
        public Adomanyok()
        {
            InitializeComponent();
        }

        private void Mentesbt_Click(object sender, EventArgs e)
        {
            try
            {
                               
                //Ez a beszúrási lekérdezés, amelyben a felhasználók által a Windows formon keresztül bevittem
                string Query = "insert into movedb.adomanyok(Idad,Ruha_adomany,Elelmiszer_adomany,Datum) values('" + this.ITextBox.Text + "','" + this.RhTextBox.Text + "','" + this.EltextBox.Text + "','" + this.dateTimePicker1.Text + "');";

                //Ez itt a MySqlConnection, amit létrehoztam az objektumot, és átadom a kapcsolati karaktersorozatot.

                MySqlConnection MyConn = new MySqlConnection(Bejelntkez.MyConnection);
                //Ez egy parancsosztály, amely a lekérdezést és a kapcsolódási objektumot kezeli.
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                MySqlDataReader MyReader;
                //  MyConn.nyitássa();
                MyConn.Open();
                MyReader = MyCommand.ExecuteReader();     // Itt lekérdezésünk végrehajtásra kerül, és az adatok az adatbázisba kerülnek.
                MessageBox.Show("Adományok kíadva!");
                while (MyReader.Read())
                {

                }
                // MyConn.zárássa(); 
                MyConn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }






        }

        private void Listbutton_Click(object sender, EventArgs e)
        {
            try

            {

               

                //A lekérdezés megjelenítése

                string Query = "SELECT * FROM movedb.kliensek, movedb.adomanyok where movedb.kliensek.Azon=movedb.adomanyok.Idad;";

                MySqlConnection MyConn = new MySqlConnection(Bejelntkez.MyConnection);

                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);



                //  MyConn.nyitás(); 

                //Offilne kapcsolat MySqlDataAdapter osztály

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();

                MyAdapter.SelectCommand = MyCommand;

                DataTable dTable = new DataTable();

                MyAdapter.Fill(dTable);





                dataGridView1.DataSource = dTable; // dataGridView1 objektumba az adatok mejelenitése.  



                // MyConn.zárássa(); 
                MyConn.Close();
            }

            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }

              }

        private void Nbt_Click(object sender, EventArgs e)
        {
            try

            {
                              
                //A lekérdezés megjelenítése

                string Query = "select * from movedb.kliensek where nev like '" + IdTextBox.Text + "%'";
                MySqlConnection MyConn = new MySqlConnection(Bejelntkez.MyConnection);

                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);

                
                //  MyConn.nyitássa(); 

                //Offilne kapcsolat MySqlDataAdapter osztály

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();

                MyAdapter.SelectCommand = MyCommand;

                DataTable dTable = new DataTable();

                MyAdapter.Fill(dTable);
                                             

                dataGridView1.DataSource = dTable; // dataGridView1 objektumba az adatok mejelenitése. 

                
                // MyConn.zárássa(); 
                MyConn.Close();
            }

            catch (Exception ex)

            {



                MessageBox.Show(ex.Message);

            }
        }

        private void Abt_Click(object sender, EventArgs e)
        {
            try

            {

                MySqlConnection MyConn = new MySqlConnection(Bejelntkez.MyConnection);
                //A lekérdezés megjelenítése

                string Query = "select * from movedb.kliensek where azon like '" + AzstextBox.Text + "%'";
               

                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);



                //  MyConn.nyitássa(); 

                //Offilne kapcsolat MySqlDataAdapter osztály

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();

                MyAdapter.SelectCommand = MyCommand;

                DataTable dTable = new DataTable();

                MyAdapter.Fill(dTable);
                                                          
                dataGridView1.DataSource = dTable; // dataGridView1 objektumba az adatok mejelenitése. 
                

                // MyConn.zárássa(); 
                MyConn.Close();
            }

            catch (Exception ex)

            {
                               
                MessageBox.Show(ex.Message);

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}


 