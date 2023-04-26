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
    public partial class LoadTournament : Form
    {
        tournamentClass selectedtournament = new tournamentClass();
        sqlConnectionClass x = new sqlConnectionClass();
        List<int> rounds = new List<int>();
        List<matchClass> selectedRound = new List<matchClass>();
        public LoadTournament(tournamentClass selectedtournament__)
        {
            this.selectedtournament = selectedtournament__;
            this.selectedtournament.enteredPeizes = getAllPrizees(selectedtournament);
            this.selectedtournament.AllRounds = getAllRounds(selectedtournament);           
            this.selectedtournament.enteredTeams = getAllEnteredTeams(selectedtournament);
            //load team participents
            this.selectedtournament.AllRounds = x.getAllmatchParticipentAndScore(selectedtournament);
            loadRoundDropdown();
            loadMatchDropdown(1);




            InitializeComponent();
            wirefrom();
        }
        private void loadMatchDropdown(int round)
        {
            //int round = (int)comboBox2.SelectedItem;
            foreach (List<matchClass> roundd in selectedtournament.AllRounds)
            {
                if (roundd.First().matchRound == round)
                {
                    selectedRound = roundd;

                }
            }
        }
        private void loadRoundDropdown()
        {
            rounds = new List<int>();
            rounds.Add(1);
            int currentRound = 1;
            foreach (List<matchClass> round  in selectedtournament.AllRounds)
            {
                if (round.First().matchRound > currentRound)
                {
                    currentRound = round.First().matchRound;
                    rounds.Add(currentRound);
                    
                }
            }
        }

        void wireround()
        {
            label1.Text = selectedtournament.tournamentName;
            comboBox2.SelectedIndexChanged -= comboBox2_SelectedIndexChanged;
            comboBox2.DataSource = null;
            comboBox2.DataSource = rounds;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;

        }
        void wireMatchName()
        {
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.DataSource = null;
            comboBox1.DataSource = selectedRound;
            comboBox1.DisplayMember = "matchName";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        void wirefrom()
        {
            wireround();
            wireMatchName();
            //comboBox1.DisplayMember = "teamName";
            //member_listbox.DataSource = null;
            //member_listbox.DataSource = selectedteam_id_name_List;
            //member_listbox.DisplayMember = "teamName";
        }
        public List<teamClass> getAllEnteredTeams(tournamentClass tournamet)
        {
            List<teamClass> EnteredTeams = new List<teamClass>();
            EnteredTeams = x.getTournamentEnteredTeams(tournamet.tournamentId);
            return EnteredTeams;
        }
        public List<List<matchClass>> getAllRounds(tournamentClass tournamet)
        {
            List<List<matchClass>> allRounds = new List<List<matchClass>>();
            allRounds = x.getAllroundforTournamentLOad(tournamet);
            return allRounds;
        }
        public List<prizeClass> getAllPrizees(tournamentClass tournamet)
        {
            List<prizeClass> prizes = new List<prizeClass>();
            prizes= x.getAllOrganizerPrizeForTurnament(tournamet.tournamentId);
            return prizes;
        }

        public LoadTournament()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int roundselected = (int)comboBox2.SelectedItem;
            loadMatchDropdown(roundselected);
            wireMatchName();
            //wirefrom();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
