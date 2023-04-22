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
        public LoadTournament(tournamentClass selectedtournament__)
        {
            this.selectedtournament = selectedtournament__;
            InitializeComponent();
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
    }
}
