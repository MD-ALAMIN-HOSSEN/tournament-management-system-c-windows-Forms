using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using tournament_system_dotnet.all_class;

namespace tournament_system_dotnet
{
    public partial class PlayerDash : Form
    {
        public static string user = "not data for user";
        sqlConnectionClass x = new sqlConnectionClass();
        List<tournamentClass> tournamentRunning = new List<tournamentClass>();
        List<tournamentClass> tournamentFinished = new List<tournamentClass>();
        List<tournamentClass> allTournaments = new List<tournamentClass>();
        List<int> teamIdList=new List<int>();//part of team
        List<int> tournamentIdList = new List<int>();//part of tournament

        public static int Id = 2000;
        /// <summary>
        /// ///////////////////////////
        /// </summary>
        public PlayerDash(string a,int x)
        {
            InitializeComponent();
            user = a;
            Id = x;
            getteamId(Id);
            getteamId_toutnament(teamIdList);
            get_runing_and_finishied_tournament();
            wirefrom();
        }
        private void wirefrom() 
        {
            listBox1.SelectedIndexChanged -= listBox1_SelectedIndexChanged;
            listBox1.DataSource = null;
            listBox1.DataSource = tournamentRunning;

            listBox1.DisplayMember = "tournamentName";
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox2.SelectedIndexChanged -= listBox2_SelectedIndexChanged;
            listBox2.DataSource = null;
            listBox2.DataSource = tournamentFinished;
            listBox2.DisplayMember = "tournamentName";
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
        }
        private void get_runing_and_finishied_tournament()//gets all tournament player is associated with
        {
            foreach (int tournamentId in tournamentIdList)
            {
                tournamentClass a = new tournamentClass();
                a = x.get_tournament_BY_tournament_ID(tournamentId);
                allTournaments.Add(a);
            }
            fill_RUning_And_Finished();
        }
        private void fill_RUning_And_Finished()//fills  running and finished list
        {
            foreach (tournamentClass tournament in allTournaments)
            {
                if (tournament.TournamentStatus==0)
                {
                    tournamentFinished.Add(tournament);
                }
                if (tournament.TournamentStatus == 1)
                {
                    tournamentRunning.Add(tournament);
                }
            }
        }
        private void getteamId_toutnament(List<int> teamIdList)
        {
           
            tournamentIdList = x.get_all_tournaments_for_teamId_list(teamIdList);

        }
        private  void getteamId(int Id)
        {
            teamIdList = x.get_teamID_by_playerId(Id);
        }
        public PlayerDash(string a)
        {
            InitializeComponent();
            user = a;
           // Id = x.get_player_id(a);
           // MessageBox.Show(Id.ToString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createteam_Click(object sender, EventArgs e)
        {
            Create_team forme = new Create_team();
            forme.Show();
        }

        private void PlayerDash_Load(object sender, EventArgs e)
        {

        }

        private void profile_icon_Click(object sender, EventArgs e)
        {
            update_profile forme = new update_profile(user);
            forme.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tournamentClass selectedtournament = (tournamentClass)listBox2.SelectedItem;
            Load_Finished_Match d1 = new Load_Finished_Match(selectedtournament);

            this.Hide();
            d1.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
