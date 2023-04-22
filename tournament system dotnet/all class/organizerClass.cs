  using System;
using System.Collections.Generic;
using System.Text;

namespace tournament_system_dotnet.all_class
{
    public class organizerClass
    {
        public organizerClass() { }
        public organizerClass(string Namex, string Passwordx, string Emailx, string numberx)
        {
            organizerName = Namex;
            organizerEmail = Emailx;
            organizerPassword = Passwordx;
            organizerNumber = int.Parse(numberx);

        }
        /// <summary>
        ///  oeganizer Name
        /// </summary>
        public string organizerName { get; set; }
        /// <summary>
        ///  oeganizer unique id
        /// </summary>
        public int organizerId { get; set; }
        /// <summary>
        ///  oeganizer  Email
        /// </summary>
        public string organizerEmail { get; set; }
        /// <summary>
        ///  oeganizer  Number
        /// </summary>
        public int organizerNumber { get; set; }
        /// <summary>
        /// organizer password
        /// </summary>
        public string organizerPassword { get; set; }

    }
}
