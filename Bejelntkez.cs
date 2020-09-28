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
    public partial class Bejelntkez : Form
    {

        public static string MyConnection = @"datasource=localhost;port=3306;username=root;password=";
        public static MySqlConnection MyConn = new MySqlConnection(MyConnection);
        public static MySqlCommand MyCommand = new MySqlCommand();
     
        
        public bool userrights;
        public Bejelntkez()
        
        {
            InitializeComponent();
            PassTextBox.PasswordChar = '•';
        }

        public static bool IsAdminUser { get; internal set; }
        

        private void button1_Click(object sender, EventArgs e)
        {
                try

                {

                                
                MySqlConnection MyConn = new MySqlConnection(MyConnection);
                MySqlCommand MyCommand = new MySqlCommand("select * from movedb.userinfo where user_name='" 
                    + this.UserTextBox.Text + "' and password='" + this.PassTextBox.Text + "' ;", MyConn);
                MySqlDataReader MyReader;

                                                
                MyConn.Open();
                MyReader = MyCommand.ExecuteReader();
                int count = 0;
                bool IsAdminUser = false;
                while (MyReader.Read())
                {
                    count = count + 1;
                    IsAdminUser = MyReader["rights"].ToString().Equals("Admin");
                }
                if (count == 1 && IsAdminUser == true)
                {
                                    
                    MessageBox.Show("A felhasználó Admin hozzáféréssel rendelkezik!");
                    this.Hide();
                    Adminablak adminForm = new Adminablak();
                    adminForm.ShowDialog();
                }
                else if (count == 1)
                {

                    this.Hide();
                    Foablak f3 = new Foablak();
                    f3.ShowDialog();
                }

                else if (count > 1)
                {
                    MessageBox.Show("A azonos felhasznlónév és jelszó!....Hozzáférés megtagadva! ", "Hiba üzenet!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("A felhasznlónév és jelszó hibás!....Probálja újra!", "Hiba üzenet!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MyConn.Close();
                }
                                                             
                }

            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}