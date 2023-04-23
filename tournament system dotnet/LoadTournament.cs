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
    public partial class LoadTournament : Form
    {
        tournamentClass selectedtournament = new tournamentClass();
        sqlConnectionClass x = new sqlConnectionClass();
        public LoadTournament(tournamentClass selectedtournament__)
        {
            this.selectedtournament = selectedtournament__;
            this.selectedtournament.enteredPeizes = getAllPrizees(selectedtournament);
            this.selectedtournament.AllRounds = getAllRounds(selectedtournament);
            //load team participents
            InitializeComponent();
        }

        public List<List<matchClass>> getAllRounds(tournamentClass tournamet)
        {
            List<List<matchClass>> allRounds = new List<List<matchClass>>();
            allRounds = x.getAllroundforTournamentLOad( tournamet);
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
    }
}
