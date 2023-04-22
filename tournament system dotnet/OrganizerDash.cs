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
    public partial class OrganizerDash : Form
    {
        public static string user = "not data for user";
        sqlConnectionClass x = new sqlConnectionClass();

        List<tournamentClass> tournamentRunning = new List<tournamentClass>();
        List<tournamentClass> tournamentFinished = new List<tournamentClass>();

        public static int Id = 2000;
        void wireforme()
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
        public OrganizerDash(string a,int x)
        {
            InitializeComponent();
            user = a;
            Id = x;
            getallTournament(Id);
            wireforme();/////////////////////////////////////////
            //MessageBox.Show(Id.ToString());
            // MessageBox.Show(user);
        }
        void getallTournament(int ID) 
        {
            tournamentRunning = x.getAllTournamentForOrganizerRunning(ID);
            tournamentFinished = x.getAllTournamentForOrganizerfinishied(ID);

        }
        public OrganizerDash(string a)
        {
            InitializeComponent();
            user = a;
            Id = x.get_OrganizerId(a);

            // MessageBox.Show(user);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createteam_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create_new_tournament forme = new Create_new_tournament(Id);
            forme.ShowDialog();
            this.Show();
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

            tournamentClass selectedtournament = (tournamentClass)listBox1.SelectedItem;
            LoadTournament d1 = new LoadTournament(selectedtournament);

            this.Hide();
            d1.ShowDialog();
            this.Show();


        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)//for finished tournament
        {
            //tournamentClass selectedtournament = (tournamentClass)listBox1.SelectedItem;
            //LoadTournament d1 = new LoadTournament(selectedtournament);

            //this.Hide();
            //d1.ShowDialog();
            //this.Show();
        }

        private void OrganizerDash_Load(object sender, EventArgs e)
        {

        }
    }
}
