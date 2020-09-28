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
    public partial class Felhasznalok : Form
    {
        public Felhasznalok()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string Query = "insert into movedb.userinfo(Id,user_name,password,rights) values('" + this.IdTextBox.Text+ "','" +this.NameTextBox.Text+ "','" +this.FnameTextBox.Text+ "','" + this.UsercBox.Text+ "'); ";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn = new MySqlConnection(Bejelntkez.MyConnection);
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                MySqlDataReader MyReader;
                MyConn.Open();
                MyReader = MyCommand.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show("Felhasználó adatai hozzáadva!");
                while (MyReader.Read())
                {
                    
                }
                MyConn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                //This is my update query in which i am taking input from the user through windows forms and update the record.
                string Query = "update movedb.userinfo set Id='" + this.IdTextBox.Text + "',user_name='" + this.NameTextBox.Text + "',password='" + this.FnameTextBox.Text + "',rights='" + this.UsercBox.Text + "'where Id='" + this.IdTextBox.Text + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn = new MySqlConnection(Bejelntkez.MyConnection);
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                MySqlDataReader MyReader;
                MyConn.Open();
                MyReader = MyCommand.ExecuteReader();
                MessageBox.Show("Felhasználó adatai frissítve");
                while (MyReader.Read())
                {

                }
                MyConn.Close();//Connection closed here
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                
                string Query = "delete from movedb.userinfo where Id='" + this.IdTextBox.Text + "';";
                MySqlConnection MyConn = new MySqlConnection(Bejelntkez.MyConnection);
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                MySqlDataReader MyReader;
                MyConn.Open();
                MyReader = MyCommand.ExecuteReader();
                MessageBox.Show("Felhasználó adatai törölve!");
                while (MyReader.Read())
                {

                }
                MyConn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try

            {

                
                //Display query 

                string Query = "select * from movedb.userinfo;";

                MySqlConnection MyConn = new MySqlConnection(Bejelntkez.MyConnection);

                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);



                //  MyConn.Megnyitása(); 

                //For offline connection we weill use  MySqlDataAdapter class. 

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();

                MyAdapter.SelectCommand = MyCommand;

                DataTable dTable = new DataTable();

                MyAdapter.Fill(dTable);





                dataGridView1.DataSource = dTable; // dTable  hozárendelése az dataGridView1 objektumhoz az adatok megjelenítéséhez.


                // MyConn.Lezárása(); 

            }

            catch (Exception ex)

            {



                MessageBox.Show(ex.Message);

            }

           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}