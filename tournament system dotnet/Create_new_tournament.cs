using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using tournament_system_dotnet.all_class;

namespace tournament_system_dotnet
{
    public partial class Create_new_tournament : Form
    {
        tournamentClass tournament = new tournamentClass();
        sqlConnectionClass a = new sqlConnectionClass();
        

        public static Create_new_tournament foem_Create_new_tournament;
        // selected least of items
        List<prizeClass> prizelist = new List<prizeClass>();
        List<teamClass> selectedteam_id_name_List = new List<teamClass>();
        List<teamClass> availableteam_id_name_List = new List<teamClass>();
        public void passPrize_object_to_tournament_forme(prizeClass model)
        {
            prizelist.Add(model);
        }

        //int i = 2000;
        int Organizer_Id = 0;
        public Create_new_tournament(int i)
        {
            InitializeComponent();
            foem_Create_new_tournament = this;
            getallteamsfrom_database();
            //MessageBox.Show(i.ToString());
            Organizer_Id = i;
            tournament.OrganizerId = Organizer_Id;
            wireforme();

        }

       
       public Create_new_tournament()
        {
            InitializeComponent();
            foem_Create_new_tournament = this;
            getallteamsfrom_database();
            wireforme();

        }
        
        void wireforme()
        {
            
            select_team_combox.DataSource = null;
            select_team_combox.DataSource = availableteam_id_name_List;
            select_team_combox.DisplayMember = "teamName";
            member_listbox.DataSource = null;
            member_listbox.DataSource = selectedteam_id_name_List;
            member_listbox.DisplayMember = "teamName";
            //prizelist (thelist containing all prize model) 
            Selected_prize_list_listbox.DataSource = null;
            Selected_prize_list_listbox.DataSource = prizelist;
            Selected_prize_list_listbox.DisplayMember = "prizeName";
        }
        
        void getallteamsfrom_database()
        {
            availableteam_id_name_List = a.getAllTeams_id_name();
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Teams_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = availableteam_id_name_List.Count();
            if (a > 0)
            {
                teamClass t = (teamClass)select_team_combox.SelectedItem;
                availableteam_id_name_List.Remove(t);
                selectedteam_id_name_List.Add(t);
                wireforme();
               
            }
            else
            {
                MessageBox.Show("No more teams are avilabile for adding.");///////////////////////////////////
            }
            

        }

        private void create_tournament_Click(object sender, EventArgs e)///////////////////////////////////////////////////////////////////
        {
            if (Validate_forme())
            {
                // adding all the teams that have entered the tournament in tournament entered teamlist
                tournament.enteredTeams = selectedteam_id_name_List;
                //get the number of rounds will be in the tournament total
                int tournamentRoundsNumber = tournament_creator.FindNumberOfRournd(selectedteam_id_name_List.Count);
                tournament= tournament_creator.createRounds(tournament);////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////@@@@@@@@@@@@@@@@@@@@@@@@@@@???????????
                //MessageBox.Show(tournament_name.Text + "  tournament is created. There will have " + tournamentRoundsNumber + " rounds in the tournament."+tournament.OrganizerId);
                tournament.tournamentName = tournament_name.Text;
                tournament.enteredPeizes = prizelist;
                 a.SaveTurnament(tournament, tournamentRoundsNumber);
              
                prizelist.Clear();
                selectedteam_id_name_List.Clear();
                availableteam_id_name_List.Clear();
                tournament_name.Clear();
                getallteamsfrom_database();
                wireforme();

            }
            
            //int a = prizelist.Count();
           // MessageBox.Show("prize list has prize model number of ==" + a);
        }

        //private bool chackPlayer()
        //{
        //    bool output = true;
        //    string connection = "Data Source=LAPTOP-J4FO9U9C\\SQLEXPRESS;Initial Catalog=\"tournament system 2\";Integrated Security=True";

        //    SqlConnection con = new SqlConnection(connection);
        //    con.Open();
        //    SqlCommand command = new SqlCommand("Select password from dbo.Login where user__name=@player_name", con);
        //    command.Parameters.AddWithValue("@player_name", Namex.Text);
        //    SqlDataReader reader1;
        //    reader1 = command.ExecuteReader();
        //    string password = "a";
        //    if (reader1.Read())
        //    {
        //        password = reader1["password"].ToString();
        //    }

        //    if (password == Passwordx.Text)
        //    {
        //        MessageBox.Show("Change your Usarname and password Username alrady exists ");
        //        output = false;
        //    }
        //    con.Close();
        //    return output;
        //}

        bool Validate_forme()
        {
            bool output = true;
               if (String.IsNullOrEmpty(tournament_name.Text))
                {
                    //MessageBox.Show("tournament name box empty ");
                   output = false;
                }
               int a = selectedteam_id_name_List.Count();
               if (a <= 0)
               {
                   output = false;
               }
               int b = prizelist.Count();
               if (b <= 0)
               {
                output = false;
               }
              if (output == false)
              {
                MessageBox.Show("please fill tournament name, select atlest one team and create atlest one prize for tournament.");
              }

            return output;
        }
        //bool Validate_forme()
        //{
        //    bool output = true;
        //    if (String.IsNullOrEmpty(textBox1.Text))
        //    {
        //        // MessageBox.Show("Team name box empty ");
        //        output = false;
        //    }
        //    int a = selectedPlayerList.Count();
        //    //string s = a.ToString();
        //    //MessageBox.Show(s);
        //    if (a <= 0)
        //    {
        //        //MessageBox.Show("list box empty ");
        //        output = false;
        //    }
            //if (output == false)
            //{
            //    MessageBox.Show("please fill team name and select atlest one member for team.");
            //}

    //    return output;
    //}

    private void member_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            teamClass t = (teamClass)member_listbox.SelectedItem;
            int i = member_listbox.SelectedIndex;
            if (i >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("would you like to remove team (" + t.teamName + ") ?", "confirm remove player", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    
                    availableteam_id_name_List.Add(t);
                    selectedteam_id_name_List.Remove(t);
                    wireforme();
                }
    
            }
           
        }

        private void Create_prize_Click(object sender, EventArgs e)
        {
            Create_Prize forme = new Create_Prize();
            forme.ShowDialog();
            wireforme();
            /////////////////////////////////////////////////////////
            ////////////////// must update to show the added prize to the listbox
            ///////////////////////////////////
        }

        private void Selected_prize_list_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            prizeClass p= (prizeClass)Selected_prize_list_listbox.SelectedItem;
            int i = Selected_prize_list_listbox.SelectedIndex;
            if (i >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("would you like to remove Prize (" + p.prizeName + ") ?", "confirm remove Prize", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    prizelist.Remove(p);
                    //availableplayerList.Add(p);//////////////////////////////////////////////////////////////////////
                    //selectedPlayerList.Remove(p);///////////////////////////////////////////////////////////
                    wireforme();////////////////////////////////////////////////////////////////////////////////////////////////
                }

            }
            //playerClass p = (playerClass)member_listbox.SelectedItem;
            //int i = member_listbox.SelectedIndex;
            //if (i >= 0)
            //{
            //    DialogResult dialogResult = MessageBox.Show("would you like to remove player (" + p.playerName + ") ?", "confirm remove player", MessageBoxButtons.YesNo);

            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        availableplayerList.Add(p);
            //        selectedPlayerList.Remove(p);
            //        wireforme();
            //    }

            //}
        }

        private void Create_new_tournament_Load(object sender, EventArgs e)
        {

        }
    }
}
