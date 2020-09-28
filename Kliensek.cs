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
    public partial class Kliensek : Form
    {
        public Kliensek()
               
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {

            if (IdTextBox.Text == "" || NameTextBox.Text == "" || FnameTextBox.Text == "" || AgeTextBox.Text == "" || AdreesTextBox.Text == "" || TeltextBox.Text == "" || CsaltextBox.Text == "")
            {
                MessageBox.Show("A mezők kitöltése kötelező!");
            }
            else
            {

                try
                {
                    MySqlConnection MyConn = new MySqlConnection(Bejelntkez.MyConnection);
                    //Ez a beszúrási lekérdezés, amelyben a felhasználók által a Windows formon keresztül bevittem
                    string Query = "insert into movedb.kliensek(Azon,Nev,Anyaneve,Szulev,Cim,Telefon,Csalelfo) " +
                        "values('" + this.IdTextBox.Text + "','" + this.NameTextBox.Text + "','" + this.FnameTextBox.Text 
                        + "','" + this.AgeTextBox.Text + "','" + this.AdreesTextBox.Text + "','" + this.TeltextBox.Text 
                        + "','" + this.CsaltextBox.Text + "');";
                    //Ez itt a MySqlConnection, amit létrehoztam az objektumot, és átadom a kapcsolati karaktersorozatot.
                    //Ez egy parancsosztály, amely a lekérdezést és a kapcsolódási objektumot kezeli.
                    MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                    MySqlDataReader MyReader;
                    //  MyConn.nyitássa();
                    MyConn.Open();
                    // MyConn.nyitássa(); 
                    MyReader = MyCommand.ExecuteReader();     
                    //Itt lekérdezésünk végrehajtásra kerül, és az adatok az adatbázisba kerülnek.
                    MessageBox.Show("Kliens adatai hozzáadva!");
                    while (MyReader.Read())
                    {

                    }
                    MyConn.Close();
                    // MyConn.zárássa(); 
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text == "" || NameTextBox.Text == "" || FnameTextBox.Text == "" || AgeTextBox.Text == "" || AdreesTextBox.Text == "" || TeltextBox.Text == "" || CsaltextBox.Text == "")
            {
                MessageBox.Show("A mezők kitöltése kötelező!");
            }
            else
            {

                try
                {

                    //Ez a beszúrási lekérdezés, amelyben a felhasználók által a Windows formon keresztül bevittem
                    string Query = "update movedb.kliensek set Azon='" + this.IdTextBox.Text + "',Nev='" + this.NameTextBox.Text + "',Anyaneve='" + this.FnameTextBox.Text + "',Szulev='" + this.AgeTextBox.Text + "',Cim='" + this.AdreesTextBox.Text + "' where Azon='" + this.IdTextBox.Text + "';";
                    //Ez egy parancsosztály, amely a lekérdezést és a kapcsolódási objektumot kezeli.
                    MySqlConnection MyConn = new MySqlConnection(Bejelntkez.MyConnection);
                    MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                    MySqlDataReader MyReader;
                    MyConn.Open();
                    // MyConn.nyitássa();
                    MyReader = MyCommand.ExecuteReader();
                    MessageBox.Show("Kliens adatai frissítve");
                    while (MyReader.Read())
                    {

                    }
                    MyConn.Close();
                    // MyConn.zárássa();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
       
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try

            {

                


                //A lekérdezés megjelenítése
       

                string Query = "select * from movedb.kliensek;";

                MySqlConnection MyConn = new MySqlConnection(Bejelntkez.MyConnection);

                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);


                MyConn.Open();
                //  MyConn.nyitássa(); 

                //Offilne kapcsolat MySqlDataAdapter osztály 

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();

                MyAdapter.SelectCommand = MyCommand;

                DataTable dTable = new DataTable();

                MyAdapter.Fill(dTable);





                dataGridView1.DataSource = dTable; // dataGridView1 objektumba az adatok mejelenitése.  


                MyConn.Close();
                // MyConn.zárássa(); 

            }

            catch (Exception ex)

            {



                MessageBox.Show(ex.Message);

            }

           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            IdTextBox.Clear();
            NameTextBox.Clear();
            FnameTextBox.Clear();
            AgeTextBox.Clear();
            AdreesTextBox.Clear();
            TeltextBox.Clear();
            CsaltextBox.Clear();
        }
    }
}