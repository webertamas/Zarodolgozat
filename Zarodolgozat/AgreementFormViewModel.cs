using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zarodolgozat.Dal;

namespace Zarodolgozat
{
    public class AgreementFormViewModel : BaseModel
    {
        public Agreement Agreement { get; set; }
        public ObservableCollection<Client> ClientList { get; set; }
        //public ObservableCollection<Agreement> ClientsWithoutAgreements { get; set; }
        public Client SelectClient { get; set; }
        public bool IsNew { get; set; }

        DataManager ctx = new DataManager();
        Context _ctx = new Context();



        public AgreementFormViewModel(Agreement Agreement)
        {
            this.Agreement = Agreement;
            if (IsNew)
            {
                AgreementSave();
            }
        }

        public bool AgreementValidate()
        {
            return Agreement.StartDate != null
                && Agreement.EndDate != null;
        }


        public void AgreementSave()
        {
            if (IsNew)
            {
                ctx.AddAgrees(new AgreementDbModel
                {
                    Client = Agreement.Client,
                    StartDate = Agreement.StartDate,
                    EndDate = Agreement.EndDate
                }
                );
            }
        }

        public AgreementFormViewModel()
        {
            ClientList = new ObservableCollection<Client>();
            //var ctx = new Context();
            var manager = new DataManager();
            foreach (var client in manager.GetClients())
            {
                ClientList.Add(new Client(client));
            }
        }
    }
}
