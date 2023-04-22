using System;
using System.Collections.Generic;
using System.Text;
using tournament_system_dotnet.all_class;

namespace tournament_system_dotnet.all_class
{
    public class matchParticipentTeamClass
    {
        public int matchParticipentTeamClassId { get; set; }
        /// <summary>
        /// one team of a match
        /// </summary>
        public teamClass matchParticipentTeam { get; set; }
        /// <summary>
        /// the score of the team
        /// </summary>
        public int score { get; set; }
        /// <summary>
        /// which match this team came from as winner
        /// </summary>
        public matchClass parantMatch { get; set; }
    }
}
