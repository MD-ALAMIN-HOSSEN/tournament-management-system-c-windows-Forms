using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using tournament_system_dotnet.all_class;

namespace tournament_system_dotnet
{
    public partial class Create_user : Form
    {
        public Create_user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                if (Userx.Text=="Player") 
                {
                    if (chackPlayer())
                    {
                        playerClass model = new playerClass(Namex.Text, Passwordx.Text, Emailx.Text, numberx.Text);

                        sqlConnectionClass a = new sqlConnectionClass();
                        //MessageBox.Show("Player created.");
                        model = a.createUsernPlayer(model);

                        string number = model.playerId.ToString();
                        
                    }
                }
                if (Userx.Text == "Organizer")
                {
                    
                    if (chackOrganiger())
                    {
                        organizerClass model2 = new organizerClass(Namex.Text, Passwordx.Text, Emailx.Text, numberx.Text);

                        sqlConnectionClass a = new sqlConnectionClass();
                        //MessageBox.Show("Organizer created.");
                        model2 = a.createUsernOrganizer(model2);

                        string number = model2.organizerId.ToString();
                        
                    }
                   
                }

                Namex.Text = "";
                Passwordx.Text = "";
                Emailx.Text = "";
                numberx.Text = "";
            }
            
        }

        private bool chackPlayer()
        {
            bool output = true;
            string connection = "Data Source=LAPTOP-J4FO9U9C\\SQLEXPRESS;Initial Catalog=\"tournament system 2\";Integrated Security=True";

            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand command = new SqlCommand("Select password from dbo.Login where user__name=@player_name", con);
            command.Parameters.AddWithValue("@player_name", Namex.Text);
            SqlDataReader reader1;
            reader1 = command.ExecuteReader();
            string password = "a";
            if (reader1.Read())
            {
                password = reader1["password"].ToString();
            }

            if (password == Passwordx.Text)
            {
                MessageBox.Show("Change your Usarname and password Username alrady exists ");
                output = false;
            }
            con.Close();
            return output;
        }

        private bool chackOrganiger()
        {
            bool output = true;
            string connection = "Data Source=LAPTOP-J4FO9U9C\\SQLEXPRESS;Initial Catalog=\"tournament system 2\";Integrated Security=True";
            
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand command = new SqlCommand("Select password from dbo.Login where user__name=@player_name", con);
            command.Parameters.AddWithValue("@player_name", Namex.Text);
            SqlDataReader reader1;
            reader1 = command.ExecuteReader();
            string password="a";
            if (reader1.Read())
            {
                password = reader1["password"].ToString();
            }
            
            if (password == Passwordx.Text)
            {
                MessageBox.Show("Change your Usarname and password Username alrady exists");
                output = false;
            }
            con.Close();
            return output;
        }

        private bool ValidateForm()
        {
            bool output = true;
            //Namex
            //Passwordx
            if (String.IsNullOrEmpty(Namex.Text))
            {
                //MessageBox.Show("invalid name");
                output = false;
            }
            if (String.IsNullOrEmpty(Passwordx.Text))
            {
               // MessageBox.Show("invalid password");
                output = false;
            }
            //string a = Emailx.Text;
            //MessageBox.Show(a);
            if (String.IsNullOrEmpty(Emailx.Text))
            //if (Emailx.Text == null)
            {
                //MessageBox.Show("invalid email");
                output = false;
            }
            int number = 0;
            bool numberValidNumber = int.TryParse(numberx.Text, out number);
            if (numberValidNumber == false)
            {
                //MessageBox.Show("invalid number");
                output = false;
            }
            //string getText = Userx.SelectedItem.ToString();
            if (String.IsNullOrEmpty(Userx.Text))
            {
               // MessageBox.Show("select name");
                output = false;
            }

            if(output== false)
            {
                MessageBox.Show("please fill all the fields.  Number must be Integer Number.");
            }

            return output;
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Create_user_Load(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
