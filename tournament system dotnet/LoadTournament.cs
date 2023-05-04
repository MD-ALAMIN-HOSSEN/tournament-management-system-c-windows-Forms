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
        matchClass match = new matchClass();
        public LoadTournament(tournamentClass selectedtournament__)
        {
            InitializeComponent();
            this.selectedtournament = selectedtournament__;
            this.selectedtournament.enteredPeizes = getAllPrizees(selectedtournament);
            this.selectedtournament.AllRounds = getAllRounds(selectedtournament);           
            this.selectedtournament.enteredTeams = getAllEnteredTeams(selectedtournament);
            //load team participents
            this.selectedtournament.AllRounds = x.getAllmatchParticipentAndScore(selectedtournament);
            loadRoundDropdown();
            loadMatchDropdown(1);
            loadScore(selectedRound[0]);



            
            wirefrom();
        }
        private void loadMatchDropdown(int round)// this selects the list of match in round
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
        private void loadRoundDropdown()// this creats a list of the round number
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
            //matchClass match = (matchClass)comboBox1.SelectedItem;
            int teamOneScore = 0;
            int teamTwoScore = 0;
           
            if (match != null)
            {
                for (int i = 0; i < match.matchPArticipentTeams.Count; i++)
                {
                    if (i == 0)
                    {
                        if (match.matchPArticipentTeams.ElementAt(0).matchParticipentTeam != null)
                        {
                            int Score;
                            bool validScore = int.TryParse(t1Score.Text, out Score);
                            if (validScore)
                            {
                                match.matchPArticipentTeams[0].score = Score;
                                teamOneScore = Score;
                            }

                        }

                    }

                    if (i == 1)
                    {
                        if (match.matchPArticipentTeams.ElementAt(1).matchParticipentTeam != null)
                        {
                            int Score;
                            bool validScore = int.TryParse(t2Score.Text, out Score);
                            if (validScore)
                            {
                                match.matchPArticipentTeams[1].score = Score;
                                teamTwoScore = Score;

                            }

                        }

                    }
                }

            }
            if(teamOneScore> teamTwoScore)
            {
                match.winner = match.matchPArticipentTeams[0].matchParticipentTeam;

            }
            else if (teamOneScore < teamTwoScore)
            {
                match.winner = match.matchPArticipentTeams[1].matchParticipentTeam;
            }
            else
            {
                MessageBox.Show("There need to be one winner.");
            }
            x.saveMatchWinner(match);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int roundselected = (int)comboBox2.SelectedItem;
            loadMatchDropdown(roundselected);
            wireMatchName();
            //wirefrom();
        }

        void loadScore(matchClass match)
        {
            //matchClass match = (matchClass)comboBox1.SelectedItem;
            if (match != null)
            {
                for (int i = 0; i < match.matchPArticipentTeams.Count; i++)
                {
                    if (i == 0)
                    {
                        if (match.matchPArticipentTeams.ElementAt(0).matchParticipentTeam != null)
                        {
                            
                            t1.Text = match.matchPArticipentTeams[0].matchParticipentTeam.teamName;
                            t1Score.Text = match.matchPArticipentTeams[0].score.ToString();
                        }

                        else
                        {
                            t1.Text = "Not yet set";
                            t1Score.Text = "";
                        }
                    }

                    if (i == 1)
                    {
                        if (match.matchPArticipentTeams.ElementAt(1).matchParticipentTeam != null)
                        {
                            t2.Text = match.matchPArticipentTeams.ElementAt(1).matchParticipentTeam.teamName;
                            t2Score.Text = match.matchPArticipentTeams[1].score.ToString();
                        }

                        else
                        {
                            t2.Text = "Not yet set";
                            t2Score.Text = "";
                        }

                    }
                }

            }
            
           
        }
        void cleanScore()
        {
            t1.Text = "Not yet set";
            t2.Text = "Not yet set";
            t1Score.Text = "";
            t2Score.Text = "";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cleanScore();
            matchClass match = (matchClass)comboBox1.SelectedItem;
            this.match = match;
            loadScore(match);
            

        }
    }
}
