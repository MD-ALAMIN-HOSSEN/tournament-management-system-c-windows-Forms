using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tournament_system_dotnet.all_class;

namespace tournament_system_dotnet.all_class
{
    public class matchClass
    {   /// <summary>
        ///  match unique id
        /// </summary>
        public int matchId { get; set; }
        /// <summary>
        /// teams played in the match
        /// </summary>
        public List<matchParticipentTeamClass> matchPArticipentTeams { get; set; } = new List<matchParticipentTeamClass>();
        /// <summary>
        /// winner of this match
        /// </summary>
        public teamClass winner { get; set; }
        /// <summary>
        /// which round this match is part of
        /// </summary>
        public int matchRound { get; set; }
        public string matchName
        {
            get
            {
                string a = "";

                foreach (matchParticipentTeamClass item in matchPArticipentTeams)
                {
                    if (item.matchParticipentTeam != null)
                    {
                        if (a.Length == 0)
                        {
                            a = item.matchParticipentTeam.teamName;
                            // a = matchPArticipentTeams.ElementAt(0).matchParticipentTeam.teamName;

                        }
                        else
                        {
                            a += $" vs {item.matchParticipentTeam.teamName}";  
                            //a += $" vs {matchPArticipentTeams.ElementAt(1).matchParticipentTeam.teamName}";

                        }
                    }
                    else
                    {
                        a = "The previous round is not complete yet!";
                    }

                }

                return a;

            }
        }
    }
}
