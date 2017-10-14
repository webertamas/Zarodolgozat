using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zarodolgozat.Dal;

namespace Zarodolgozat
{
    public class ClientFormViewModel : BaseModel
    {
        public Client Client { get; set; }
        public bool IsNew { get; set; }

        Client client;

        DataManager ctx = new DataManager();
        Context _ctx = new Context();

        public ClientFormViewModel(Client Client)
        {
            this.Client = Client;
            if (IsNew)
            {
                Save();
            }
        }



        public bool ClientValidate()
        {
            return !string.IsNullOrEmpty(Client.BirthName);  //TODO
        }

        public void Save()
        {
            if (IsNew)
            {
                //client = new Client
                //{
                //    FirstName = Client.FirstName,
                //    LastName = Client.LastName,
                //    BirthName = Client.BirthName,
                //    SSN = Client.SSN,
                //    BirthDate = Client.BirthDate,
                //    BirthPlace = Client.BirthPlace,
                //    MothersFirstName = Client.MothersFirstName,
                //    MothersLastName = Client.MothersLastName,
                //    HAZIPCode = Client.HAZIPCode,
                //    HALocality = Client.HALocality,
                //    HAStreet = Client.HAStreet,
                //    HANumber = Client.HANumber,
                //    PAZIPCode = Client.PAZIPCode,
                //    PALocality = Client.PALocality,
                //    PAStreet = Client.PAStreet,
                //    PANumber = Client.PANumber
                //};
                ctx.AddClient(new ClientDbModel
                {
                    FirstName = Client.FirstName,
                    LastName = Client.LastName,
                    BirthName = Client.BirthName,
                    SSN = Client.SSN,
                    BirthDate = Client.BirthDate,
                    BirthPlace = Client.BirthPlace,
                    MothersFirstName = Client.MothersFirstName,
                    MothersLastName = Client.MothersLastName,
                    HAZIPCode = Client.HAZIPCode,
                    HALocality = Client.HALocality,
                    HAStreet = Client.HAStreet,
                    HANumber = Client.HANumber,
                    PAZIPCode = Client.PAZIPCode,
                    PALocality = Client.PALocality,
                    PAStreet = Client.PAStreet,
                    PANumber = Client.PANumber

                });
            }
        }
    }
}
