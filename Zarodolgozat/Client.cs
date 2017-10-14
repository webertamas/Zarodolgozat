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
        public string FirstName { get { return _firstName; } set { _firstName = value; OnPropertyChange(); } }
        public string LastName { get { return _lastName; } set { _lastName = value; OnPropertyChange(); } }
        public string BirthName { get { return _birthName; } set { _birthName = value; OnPropertyChange(); } }
        public DateTime BirthDate { get { return _birthDate; } set { _birthDate = value; OnPropertyChange(); } }
        public string BirthPlace { get { return _birthPlace; } set { _birthPlace = value; OnPropertyChange(); } }
        public int SSN { get { return _ssn; } set { _ssn = value; OnPropertyChange(); } }
        public string MothersFirstName { get { return _mothersFirstName; } set { _mothersFirstName = value; OnPropertyChange(); } }
        public string MothersLastName { get { return _mothersLastName; } set { _mothersLastName = value; OnPropertyChange(); } }
        public int HAZIPCode { get { return _haZIPCode; } set { _haZIPCode = value; OnPropertyChange(); } }
        public string HALocality { get { return _haLocality; } set { _haLocality = value; OnPropertyChange(); } }
        public string HAStreet { get { return _haStreet; } set { _haStreet = value; OnPropertyChange(); } }
        public string HANumber { get { return _haNumber; } set { _haNumber = value; OnPropertyChange(); } }
        public int PAZIPCode { get { return _paZIPCode; } set { _paZIPCode = value; OnPropertyChange(); } }
        public string PALocality { get { return _paLocality; } set { _paLocality = value; OnPropertyChange(); } }
        public string PAStreet { get { return _paStreet; } set { _paStreet = value; OnPropertyChange(); } }
        public string PANumber { get { return _paNumber; } set { _paNumber = value; OnPropertyChange(); } }

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
