using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zarodolgozat.Dal;

namespace Zarodolgozat
{
    public class ClientViewModel:BaseModel
    {
        DataManager context = new DataManager();
        public ObservableCollection<Client> ClientList { get; set; }
        public Client SelectClient { get; set; }

        public ClientViewModel()
        {
            ClientList = new ObservableCollection<Client>();
            foreach (var client in context.GetClients())
            {
                ClientList.Add(new Client(client));
            }
        }

        internal void RemoveClient()
        {
            context.RemoveClient(SelectClient.Id);
            ClientList.Remove(SelectClient);
        }

        internal void RefreshList()
        {
            foreach (var client in context.GetClients())
            {
                ClientList.Add(new Client(client));
            }
        }
    }
}
