using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarodolgozat.Dal
{
    public class Seeds
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
                BirthPlace ="Budapest",
                BirthDate = DateTime.Parse("1960/01/01"),
                MothersLastName ="Ágnes",
                MothersFirstName ="Szabó",
                SSN =111222333,
                HAZIPCode =1106,
                HALocality ="Budapest",
                HAStreet ="Jászberényi út",
                HANumber ="47/E"
            },
            new ClientDbModel
            {
                FirstName ="Zoltán",
                LastName ="Nagy",
                BirthName ="Nagy Zoltán",
                BirthPlace ="Budapest",
                BirthDate = DateTime.Parse("1945/03/05"),
                MothersLastName ="Irma",
                MothersFirstName ="Pető",
                SSN =156156156,
                HAZIPCode =1106,
                HALocality ="Budapest",
                HAStreet ="Jászberényi út",
                HANumber ="47/E"
            }
        };
        public List<CompanyDbModel> Companies { get; } = new List<CompanyDbModel>();

        public List<AgreementDbModel> Agreements { get; } = new List<AgreementDbModel>();

        //public List<AgreementDbModel> Agreements { get; } = new List<AgreementDbModel>
        //{
        //    new AgreementDbModel
        //    {
        //        Clients=new List<ClientDbModel> {Clients[0] }
        //    }
        //};

        public Seeds()
        {
            Agreements = new List<AgreementDbModel>
            {
                new AgreementDbModel
                {
                    StartDate=DateTime.Parse("2017/10/01"),
                    EndDate=DateTime.Parse("2018/01/01"),
                    Client =(ClientDbModel)Clients[0]
                }
            };
            Console.WriteLine("m");

        }
        
    }
}
