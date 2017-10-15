using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zarodolgozat.Dal;

namespace Zarodolgozat
{
    public class ClientViewModel : BaseModel
    {
        public User User { get; set; }
        public ObservableCollection<Client> ClientList { get; set; }
        public Client SelectClient { get; set; }

        public ClientViewModel()
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
