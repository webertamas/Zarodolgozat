using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarodolgozat.Dal
{
    public class Context
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
                BirthDate ="1960/01/01",
                MothersLastName ="Ágnes",
                MothersFirstName ="Szabó",
                SSN =111222333,
                HAZIPCode =1106,
                HALocality ="Budapest",
                HAStreet ="Jászberényi út",
                HANumber ="47/E" }
        };
    }
}
