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
    public partial class login : Form
    {
        sqlConnectionClass x = new sqlConnectionClass();
        int Id;

        public login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Create_user form = new Create_user();

            form.ShowDialog();
            form = null;
            this.Show();
        }
        
        string user = "a";// the selected user is stord in user variable
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                //chackUsser();
                //if (user == "a")
                //{
                //    MessageBox.Show("invalid user or password.");
                //}
                if (chackUsser())
                {
                    // TODO - go to dash form
                   
                    if (user== "Player")
                    {
                         get_Id_Player();
                        PlayerDash forme = new PlayerDash(Namex.Text,Id);
                        this.Hide();
                        
                        forme.ShowDialog();

                        this.Show();
                    }
                    if (user == "Organizer")
                    {
                        this.Hide();
                        /////get_OrganizerId(Namex.Text);
                        get_Organizer_Id();
                        OrganizerDash forme = new OrganizerDash(Namex.Text,Id);/////////////////////////////////////////////////////////////////////////////////////////
                        forme.ShowDialog();
                        this.Show();
                    }
                    if(!chackUsser())
                    {
                        MessageBox.Show("invalid user or password.");
                    }
                    
                }
                Namex.Text = "";
                Passwordx.Text = "";

            }
        }
        //
        private void get_Organizer_Id()///get the primery key of organizer table if its organizer 
        {
            string connection = "Data Source=LAPTOP-J4FO9U9C\\SQLEXPRESS;Initial Catalog=\"tournament system 2\";Integrated Security=True";

            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand command = new SqlCommand("Select organizer_password,organizer_id from dbo.organizer where organizer_name=@organizer_name", con);
            command.Parameters.AddWithValue("@organizer_name", Namex.Text);
            SqlDataReader reader1;
            reader1 = command.ExecuteReader();
            string password = "bhuhvguvbiuh";
            while (reader1.Read())
            {
                password = reader1["organizer_password"].ToString();


                if (password == Passwordx.Text)
                {
                    Id = (int)reader1["organizer_id"];
                    break;
                }


            }
            con.Close();

        }
        private void get_Id_Player()///get the primery key of player table if its player 
        {
            string connection = "Data Source=LAPTOP-J4FO9U9C\\SQLEXPRESS;Initial Catalog=\"tournament system 2\";Integrated Security=True";

            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand command = new SqlCommand("Select player_password,player_id from dbo.player where player_name=@player_name", con);
            command.Parameters.AddWithValue("@player_name", Namex.Text);
            SqlDataReader reader1;
            reader1 = command.ExecuteReader();
            string password = "bhuhvguvbiuh";
            while (reader1.Read())
            {
                password = reader1["player_password"].ToString();
                

                if (password == Passwordx.Text)
                {
                    Id = (int)reader1["player_id"];
                    break;
                }


            }
            con.Close();

        }
        private bool chackUsser()
        {
            bool output = false;
            string connection = "Data Source=LAPTOP-J4FO9U9C\\SQLEXPRESS;Initial Catalog=\"tournament system 2\";Integrated Security=True";

            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand command = new SqlCommand("Select password,status from dbo.Login where user__name=@player_name", con);
            command.Parameters.AddWithValue("@player_name", Namex.Text);
            SqlDataReader reader1;
            reader1 = command.ExecuteReader();
            string password = "bhuhvguvbiuh";
            while (reader1.Read())
            {
                password = reader1["password"].ToString();
                user = reader1["status"].ToString();

                if (password == Passwordx.Text)
                {
                    output = true;
                    break;
                }
               

            }
            if (password != Passwordx.Text)
            {
                MessageBox.Show("invalid user or password.");
            }


            con.Close();
            return output;
        }
        // chaking user and password in login table for login
        //private bool chackUsser()
        //{
        //    bool output = false;
        //    string connection = "Data Source=LAPTOP-J4FO9U9C\\SQLEXPRESS;Initial Catalog=\"tournament system 2\";Integrated Security=True";

        //    SqlConnection con = new SqlConnection(connection);
        //    con.Open();
        //    SqlCommand command = new SqlCommand("Select password,status from dbo.Login where user__name=@player_name", con);
        //    command.Parameters.AddWithValue("@player_name", Namex.Text);
        //    SqlDataReader reader1;
        //    reader1 = command.ExecuteReader();
        //    string password = "bhuhvguvbiuh";
        //    if (reader1.Read())
        //    {
        //        password = reader1["password"].ToString();
        //        user = reader1["status"].ToString();

        //        //MessageBox.Show(password);
        //        //MessageBox.Show("the password given gor login is"+ Passwordx.Text);
        //    }

        //    if (password == Passwordx.Text)
        //    {
        //        output = true;
        //    }
        //    if (password != Passwordx.Text)
        //    {
        //        MessageBox.Show("invalid user or password.");
        //    }

        //    con.Close();
        //    return output;
        //}

        private bool ValidateForm()
        {
            bool output = true;
            //Namex
            //Passwordx
            if (String.IsNullOrEmpty(Namex.Text))
            {
                MessageBox.Show("User field  empty.");
                output = false;
            }
            if (String.IsNullOrEmpty(Passwordx.Text))
            {
                MessageBox.Show("Password field empty.");
                output = false;
            }
            
            return output;
        }
    }
}
