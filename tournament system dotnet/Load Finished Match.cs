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
    public partial class Load_Finished_Match : Form
    {
        sqlConnectionClass x = new sqlConnectionClass();
        tournamentClass selectedtournament = new tournamentClass();
        List<Match_history> match_details = new List<Match_history>();
        string FirstPLace;
        string SecondPLace;
        public Load_Finished_Match()
        {
            InitializeComponent();
        }

      
    public Load_Finished_Match(tournamentClass selectedtournament)
        {
            this.selectedtournament = selectedtournament;
            InitializeComponent();
            this.selectedtournament.enteredPeizes = getAllPrizees(selectedtournament);
            this.selectedtournament.AllRounds = getAllRounds(selectedtournament);
            this.selectedtournament.enteredTeams = getAllEnteredTeams(selectedtournament);
            //load team participents
            this.selectedtournament.AllRounds = x.getAllmatchParticipentAndScore(selectedtournament);
            Get_match_history_Populated();
            get_Winners();
            wireFrome();
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
            prizes = x.getAllOrganizerPrizeForTurnament(tournamet.tournamentId);
            return prizes;
        }
        private void get_Winners()
        {
            List<matchClass> last = new List<matchClass>();
            last = selectedtournament.AllRounds.Last();
            FirstPLace = last.First().winner.teamName;
            foreach (matchParticipentTeamClass team in last.First().matchPArticipentTeams)
            {
                if (team.matchParticipentTeam.teamName!= FirstPLace)
                {
                    SecondPLace = team.matchParticipentTeam.teamName;
                    break;
                }    
            }


        }
        private void Get_match_history_Populated()
        {
            List<List<matchClass>> AllRoundsT = new List<List<matchClass>>();
            foreach (List<matchClass> round in selectedtournament.AllRounds)
            {
                foreach (matchClass match in round)
                {
                    Match_history a = new Match_history();
                    a.Match_Name = match.matchName;
                    a.Winner_Name = match.winner.teamName;
                    a.round = match.matchRound;
                    match_details.Add(a);
                }
            }

        }
        private void wireFrome()
        {
            Tournament_Name.Text = selectedtournament.tournamentName;
            textBox1.Text = FirstPLace;
            textBox2.Text = SecondPLace;
            dataGridView1.DataSource = match_details;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
