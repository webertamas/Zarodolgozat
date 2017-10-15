using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zarodolgozat.Dal;

namespace Zarodolgozat
{
    public class Agreement:BaseModel
    {
        
        DateTime _startDate { get; set; }
        DateTime _endDate { get; set; }

        public int Id { get; set; }
        public DateTime StartDate { get { return _startDate; } set { _startDate = value; OnPropertyChange(); } }
        public DateTime EndDate { get { return _endDate; } set { _endDate = value; OnPropertyChange(); } }

        ClientDbModel _client;
       


        public ClientDbModel Client
        {
            get { return _client; }
            set { _client = value; OnPropertyChange(); }
        }


        public Agreement(AgreementDbModel dbModel)
        {
            StartDate = dbModel.StartDate;
            EndDate = dbModel.EndDate;
            Client = dbModel.Client;
            
        }
        public Agreement()
        {

        }
    }
}
