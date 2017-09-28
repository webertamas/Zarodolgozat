using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zarodolgozat.Dal;

namespace Zarodolgozat
{
    public class Client:BaseModel
    {
        int _haZIPCode;
        string _haLocality;
        string _haStreet;
        string _haNumber;
        int _paZIPCode;
        string _paLocality;
        string _paStreet;
        string _paNumber;


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthName { get; set; }
        //TODO
        public string BirthDate { get; set; }

        public string BirthPlace { get; set; }
        public int SSN { get; set; }
        public string MothersFirstName { get; set; }
        public string MothersLastName { get; set; }
        public int HAZIPCode { get { return _haZIPCode; } set { _haZIPCode = value; OnPropertyChange(); } }
        public string HALocality { get { return _haLocality; } set { _haLocality = value; OnPropertyChange(); } }
        public string HAStreet { get { return _haStreet; } set { _haStreet = value; OnPropertyChange(); } }
        public string HANumber { get { return _haNumber; } set { _haNumber = value; OnPropertyChange(); } } //?????
        public int PAZIPCode { get { return _paZIPCode; } set { _paZIPCode = value; OnPropertyChange(); } }
        public string PALocality { get { return _paLocality; } set { _paLocality = value; OnPropertyChange(); } }
        public string PAStreet { get { return _paStreet; } set { _paStreet = value; OnPropertyChange(); } }
        public string PANumber { get { return _paNumber; } set { _paNumber = value; OnPropertyChange(); } }

        public Client(ClientDbModel dbModel)
        {
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
