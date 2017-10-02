using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zarodolgozat.Dal;

namespace Zarodolgozat
{
    public class MainViewModel : BaseModel
    {
        //public ObservableCollection<>
        public User User { get; set; }
        public ObservableCollection<Client> ClientList { get; set; }
        public Client SelectClient { get; set; }

        public MainViewModel()
        {
            ClientList = new ObservableCollection<Client>();
            var ctx = new Context();
            foreach (var client in ctx.Clients)
            {
                ClientList.Add(new Client(client));
            }
        }
    }
}
