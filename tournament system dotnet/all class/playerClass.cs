using System;
using System.Collections.Generic;
using System.Text;

namespace tournament_system_dotnet.all_class
{
    public class playerClass
    {
        public playerClass() { }
        public playerClass(string Namex, string Passwordx, string Emailx, string numberx)
        {
            playerName = Namex;
            playerEmail = Emailx;
            playerPassword = Passwordx;
            playerNumber = int.Parse(numberx);

        }
        /// <summary>
        ///  player Name
        /// </summary>
        public string playerName { get; set; }
        /// <summary>
        ///  player unique id
        /// </summary>
        public int playerId { get; set; }
        /// <summary>
        ///  player Email
        /// </summary>
        public string playerEmail { get; set; }
        /// <summary>
        ///  player Number
        /// </summary>
        public int playerNumber { get; set; }
        /// <summary>
        /// organizer password
        /// </summary>
        public string playerPassword { get; set; }
    }
}
