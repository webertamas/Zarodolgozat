using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarodolgozat.Dal
{
    public class ClientDbModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthName { get; set; }
        //TODO
        public string BirthDate { get; set; }

        public string BirthPlace { get; set; }
        public int SSN { get; set; }
        public string MothersFirstName { get; set; }
        public string MothersLastName { get; set; }
        public int HAZIPCode { get; set; }
        public string HALocality { get; set; }
        public string HAStreet { get; set; }
        public string HANumber { get; set; } //?????
        public int PAZIPCode { get; set; }
        public string PALocality { get; set; }
        public string PAStreet { get; set; }
        public string PANumber { get; set; } //?????
    }
}
