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
            return !string.IsNullOrEmpty(Client.FirstName)
                && !string.IsNullOrEmpty(Client.LastName)
                && !string.IsNullOrEmpty(Client.BirthName)
                && Client.SSN != 0
                && Client.SSN < 1000000000
                && Client.BirthDate != null
                && !string.IsNullOrEmpty(Client.BirthPlace)
                && !string.IsNullOrEmpty(Client.MothersFirstName)
                && !string.IsNullOrEmpty(Client.MothersLastName)
                && Client.HAZIPCode != 0
                && Client.HAZIPCode >= 1000
                && Client.HAZIPCode < 10000
                && !string.IsNullOrEmpty(Client.HALocality)
                && !string.IsNullOrEmpty(Client.HAStreet)
                && !string.IsNullOrEmpty(Client.HANumber)
                && (Client.PAZIPCode == 0 ||
                ((Client.PAZIPCode >= 1000 && Client.PAZIPCode < 10000)
                && !string.IsNullOrEmpty(Client.PALocality)
                && !string.IsNullOrEmpty(Client.PAStreet)
                && !string.IsNullOrEmpty(Client.PANumber)));
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
