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
    public partial class Create_team : Form
    {
        sqlConnectionClass a = new sqlConnectionClass();
        string team_name;
        List<teamClass> availableteam_id_name_List = new List<teamClass>();// all team name and id list in database
        List<playerClass> availableplayerList = new List<playerClass>();/// the players your can select
        List<playerClass> selectedPlayerList = new List<playerClass>();/// the players selected
        void getallteamsfrom_database()
        {
            availableteam_id_name_List = a.getAllTeams_id_name();
        }

        //allplayerList = a.getAllPlayer();
        public Create_team()
        {
            InitializeComponent();
            getallteamsfrom_database();// get the teams name from database  stor in a list
            getallplayerfrom_database();
            wireforme();
            
        }
        void wireforme()
        {
            select_team_member_combo_box.DataSource = null;
            select_team_member_combo_box.DataSource = availableplayerList;
            select_team_member_combo_box.DisplayMember = "playerName";

            // listBox1
            member_listbox.DataSource = null;
            member_listbox.DataSource = selectedPlayerList;
            member_listbox.DisplayMember = "playerName";
        }
        //just to import all players as an object list in forme
        void getallplayerfrom_database()
        {
            availableplayerList = a.getAllPlayer();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createteam_Click(object sender, EventArgs e)
        {
            //getallteamsfrom_database();
            if (Validate_forme())
            {
                team_name = textBox1.Text;
                if (chack_does_this_team_name_exist())
                {
                    MessageBox.Show(team_name + " is created.");
                    a.Save_team_in_database(selectedPlayerList, team_name);
                    
                }
                availableplayerList.Clear();
                selectedPlayerList.Clear();
                textBox1.Text = "";
                getallplayerfrom_database();
                wireforme();

            }
            
        }
        bool chack_does_this_team_name_exist()////////////////////////////////////////////////////////
        {
            bool output = true;
            foreach (teamClass team in availableteam_id_name_List)
            {
                //MessageBox.Show(team_name);
                //MessageBox.Show("=");
                //MessageBox.Show(team.teamName);
                if (team_name== team.teamName)
                {
                    MessageBox.Show("This team name is not available.");
                    output = false;
                }
            }
            return output;
        }
        bool Validate_forme()
        {
            bool output = true;
            if (String.IsNullOrEmpty(textBox1.Text))
            {
               // MessageBox.Show("Team name box empty ");
                output = false;
            }
            int a = selectedPlayerList.Count();
            //string s = a.ToString();
            //MessageBox.Show(s);
            if (a <= 0)
            {
                //MessageBox.Show("list box empty ");
             output= false;
            }
            if (output == false)
            {
                MessageBox.Show("please fill team name and select atlest one member for team.");
            }

            return output;
        }

        private void teame_name_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            playerClass p = (playerClass)member_listbox.SelectedItem;
            int i = member_listbox.SelectedIndex;
            if (i>=0)
            {
                DialogResult dialogResult = MessageBox.Show("would you like to remove player (" + p.playerName + ") ?", "confirm remove player", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    availableplayerList.Add(p);
                    selectedPlayerList.Remove(p);
                    wireforme();
                }
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Members_Click(object sender, EventArgs e)
        {

        }

        private void Create_team_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = availableplayerList.Count();
            if(a>0)
            {
                playerClass p = (playerClass)select_team_member_combo_box.SelectedItem;

                availableplayerList.Remove(p);
                selectedPlayerList.Add(p);
                wireforme();
            }
            else
            {
                MessageBox.Show("No more players are avilabile for adding.");
            }
           
           
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
