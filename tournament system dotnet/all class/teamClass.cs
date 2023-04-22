using System;
using System.Collections.Generic;
using System.Text;

namespace tournament_system_dotnet.all_class
{
    public class teamClass
    {
        /// <summary>
        ///  team unique id
        /// </summary>
        public int teamId { get; set; }
        /// <summary>
        /// player id
        /// </summary>
        public int playerId { get; set; }

        /// <summary>
        ///  team Name 
        /// </summary>
        public string teamName { get; set; }

        /// <summary>
        ///  List of team Members in the team 
        /// </summary>
        public List<playerClass> teamMembers { get; set; } = new List<playerClass>();

    }
}
