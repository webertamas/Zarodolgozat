using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zarodolgozat.Dal;

namespace Zarodolgozat
{
    public class Client : BaseModel
    {

        string _firstName;
        string _lastName;
        string _birthName;
        DateTime _birthDate;
        string _birthPlace;
        int _ssn;
        string _mothersFirstName;
        string _mothersLastName;
        int _haZIPCode;
        string _haLocality;
        string _haStreet;
        string _haNumber;
        int _paZIPCode;
        string _paLocality;
        string _paStreet;
        string _paNumber;

        public int Id { get; set; }
        public string FirstName { get { return _firstName; } set { _firstName = value; OnPropertyCange(); } }
        public string LastName { get { return _lastName; } set { _lastName = value; OnPropertyCange(); } }
        public string BirthName { get { return _birthName; } set { _birthName = value; OnPropertyCange(); } }
        //TODO
        public DateTime BirthDate { get { return _birthDate; } set { _birthDate = value; OnPropertyCange(); } }

        public string BirthPlace { get { return _birthPlace; } set { _birthPlace = value; OnPropertyCange(); } }
        public int SSN { get { return _ssn; } set { _ssn = value; OnPropertyCange(); } }
        public string MothersFirstName { get { return _mothersFirstName; } set { _mothersFirstName = value; OnPropertyCange(); } }
        public string MothersLastName { get { return _mothersLastName; } set { _mothersLastName = value; OnPropertyCange(); } }
        public int HAZIPCode { get { return _haZIPCode; } set { _haZIPCode = value; OnPropertyCange(); } }
        public string HALocality { get { return _haLocality; } set { _haLocality = value; OnPropertyCange(); } }
        public string HAStreet { get { return _haStreet; } set { _haStreet = value; OnPropertyCange(); } }
        public string HANumber { get { return _haNumber; } set { _haNumber = value; OnPropertyCange(); } }
        public int PAZIPCode { get { return _paZIPCode; } set { _paZIPCode = value; OnPropertyCange(); } }
        public string PALocality { get { return _paLocality; } set { _paLocality = value; OnPropertyCange(); } }
        public string PAStreet { get { return _paStreet; } set { _paStreet = value; OnPropertyCange(); } }
        public string PANumber { get { return _paNumber; } set { _paNumber = value; OnPropertyCange(); } }

        public Client(ClientDbModel dbModel)
        {
            Id = dbModel.Id;
            FirstName = dbModel.FirstName;
            LastName = dbModel.LastName;
            BirthName = dbModel.BirthName;
            BirthDate = dbModel.BirthDate;
            BirthPlace = dbModel.BirthPlace;
            SSN = dbModel.SSN;
            MothersFirstName = dbModel.MothersFirstName;
            MothersLastName = dbModel.MothersLastName;
            HAZIPCode = dbModel.HAZIPCode;
            HALocality = dbModel.HALocality;
            HAStreet = dbModel.HAStreet;
            HANumber = dbModel.HANumber;
            PAZIPCode = dbModel.PAZIPCode;
            PALocality = dbModel.PALocality;
            PAStreet = dbModel.PAStreet;
            PANumber = dbModel.PANumber;
        }
        public Client()
        {

        }
    }
}
