using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarodolgozat.Dal
{
    public class xContext
    {
        public List<UserDbModel> Users { get; } = new List<UserDbModel>
        {
            new UserDbModel { Username="asdf", Password="asdf" }
        };

        public List<ClientDbModel> Clients { get; } = new List<ClientDbModel>
        {
            new ClientDbModel
            {
                FirstName ="István",
                LastName ="Kiss",
                BirthName ="Kiss István",
                BirthPlace = "Budapest",
                BirthDate = DateTime.Parse("1960/01/01"),
                MothersLastName ="Ágnes",
                MothersFirstName ="Szabó",
                SSN =111222333,
                HAZIPCode =1106,
                HALocality ="Budapest",
                HAStreet ="Jászberényi út",
                HANumber ="47/E"
            }
        };
        public List<CompanyDbModel> Companies { get; } = new List<CompanyDbModel>();

        public List<AgreementDbModel> Agreements { get; }

        public List<DailyLogDbModel> DailyLogs { get; }

        public xContext()
        {
            Agreements = new List<AgreementDbModel>
            {
                new AgreementDbModel
                {
                    Clients =new List<ClientDbModel> {Clients[0] },
                    StartDate =DateTime.Parse("01/01/2017"),
                    EndDate=DateTime.Parse("01/01/2018")
                }
            };

            DailyLogs = new List<DailyLogDbModel>
            {
                new DailyLogDbModel
                {
                                       
                }
            };
       }
    }
}
