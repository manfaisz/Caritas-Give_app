//készítette: Mánfai Szabolcs
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;

namespace Caritas_Giveapp
{
    public partial class Lekerdezes : Form
    {
        public Lekerdezes()
        {
            InitializeComponent();
        }


        private void Lekerdezes_Load(object sender, EventArgs e)
        {
            try

            {
                

                //A lekérdezés megjelenítése


                string Query = "SELECT * FROM movedb.kliensek, movedb.adomanyok where movedb.kliensek.Azon=movedb.adomanyok.Idad";

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

        private void Prbt_Click(object sender, EventArgs e)
        {
            try

            {


                //A lekérdezés megjelenítése


                string Query = "SELECT * FROM movedb.kliensek, movedb.adomanyok where (Datum between @d1 and @d2 ) and (movedb.kliensek.Azon=movedb.adomanyok.Idad)";


               

                MySqlConnection MyConn = new MySqlConnection(Bejelntkez.MyConnection);

                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);

                MyCommand.Parameters.Add("@d1", MySqlDbType.Date).Value = dateTimePicker2.Value;
                MyCommand.Parameters.Add("@d2", MySqlDbType.Date).Value = dateTimePicker3.Value;

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

        private void button1_Click(object sender, EventArgs e)
        {
            try

            {


                //A lekérdezés megjelenítése


                string Query = "SELECT * FROM movedb.kliensek, movedb.adomanyok where (azon like '" + AzsstextBox.Text + "%') and (movedb.kliensek.Azon=movedb.adomanyok.Idad)";

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
    }
}
