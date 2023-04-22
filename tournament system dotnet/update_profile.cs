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
    public partial class update_profile : Form
    {
        public static string user = "not data for user";
        public update_profile(string a)
        {
            InitializeComponent();
            user = a;
            //MessageBox.Show(user);
        }

        private void update_profile_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                chackUsser();
                string n = "";
                playerClass model = new playerClass(n, Passwordx.Text, Emailx.Text, numberx.Text);

                sqlConnectionClass a = new sqlConnectionClass();

                if (status == "Organizer") { a.updateUsernOrganizer(model, user); }////////////////////////////////////////////////////////////////////
                if (status == "Player") { a.updateUsernPlayer(model, user); }
                MessageBox.Show("updated details.");
                this.Close();

            }
        }
        string status = "";
        private void Delete_Click(object sender, EventArgs e)
        {
            chackUsser();
            sqlConnectionClass a = new sqlConnectionClass();
            if (status== "Organizer") { a.deleteUsernOrganizer(user); }////////////////////////////////////////////////////////////////////
            if(status== "Player") { a.deleteUsernPlayer(user); }
            MessageBox.Show("Your User has been deleted you can not login to this user after logout.");

            this.Close();
                // a.deleteUsernPlayer(user);
            
        }
        private bool chackUsser()
        {
            bool output = false;
            string connection = "Data Source=LAPTOP-J4FO9U9C\\SQLEXPRESS;Initial Catalog=\"tournament system 2\";Integrated Security=True";

            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand command = new SqlCommand("Select password,status from dbo.Login where user__name=@player_name", con);
            command.Parameters.AddWithValue("@player_name", user);
            SqlDataReader reader1;
            reader1 = command.ExecuteReader();
            string password = "a";
            if (reader1.Read())
            {
                password = reader1["password"].ToString();
                status = reader1["status"].ToString();
            }

            
            con.Close();
            return output;
        }

        private bool ValidateForm()
        {
            bool output = true;
            
            if (String.IsNullOrEmpty(Passwordx.Text))
            {
                //MessageBox.Show("invalid password");
                output = false;
            }
            //string a = Emailx.Text;
            //MessageBox.Show(a);
            if (String.IsNullOrEmpty(Emailx.Text))
            //if (Emailx.Text == null)
            {
               // MessageBox.Show("invalid email");
                output = false;
            }
            int number = 0;
            bool numberValidNumber = int.TryParse(numberx.Text, out number);
            if (numberValidNumber == false)
            {
               // MessageBox.Show("invalid number");
                output = false;
            }
            if (output == false)
            {
                MessageBox.Show("please fill all the fields and Number must be an integer.");
            }

            return output;
        }

    }
}
