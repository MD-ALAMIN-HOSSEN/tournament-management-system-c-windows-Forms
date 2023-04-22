using System;
using System.Collections.Generic;
using System.Text;

namespace tournament_system_dotnet.all_class
{
    public class prizeClass
    {
        /// <summary>
        ///  prizeId
        /// </summary>
        public int prizeId { get; set; }
        /// <summary>
        ///  organizer tournamentId_inprize
        /// </summary>
        public int tournamentId_inprize { get; set; }
        /// <summary>
        ///  organizer prizeName
        /// </summary>
        public string prizeName { get; set; }
        /// <summary>
        ///  organizer prizeNumber
        /// </summary>
        public int prizeNumber { get; set; }
        /// <summary>
        /// organizer prizeAmount
        /// </summary>
        public int prizeAmount { get; set; }
    }
}
