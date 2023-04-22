using System;
using System.Collections.Generic;
using System.Text;

namespace tournament_system_dotnet.all_class
{
    public class tournamentClass
    {
        /// <summary>
        /// tournament unique id
        /// </summary>
        public int tournamentId { get; set; }
        /// <summary>
        /// organizer id for traking the current organiger
        /// </summary>
        public int OrganizerId { get; set; }
        /// <summary>
        /// total round in tournament
        /// </summary>
        public int TournamentRound { get; set; }
        /// <summary>
        /// 0 means the tournament is over 1 is runing
        /// </summary>
        public int TournamentStatus { get; set; }
        /// <summary>
        /// the round runing now
        /// </summary>
        public int TournamentCurrentRound { get; set; }
        /// <summary>
        /// tournament Name
        /// </summary>
        public string tournamentName { get; set; }
        /// <summary>
        /// list of teams playing the tournament
        /// </summary>
        public List<teamClass> enteredTeams { get; set; }
        /// <summary>
        /// List of prizes created for this tournament
        /// </summary>
        public List<prizeClass> enteredPeizes { get; set; } = new List<prizeClass>();
        /// <summary>
        /// list of every round list of match in the tournament
        /// </summary>
        public List<List<matchClass>> AllRounds { get; set; } = new List<List<matchClass>>();
    }
}
