using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarodolgozat
{
    class MainViewModel:BaseModel
    {
        //public ObservableCollection<>
        public User User { get; set; }
        public ObservableCollection<Client> ClientList { get; set; }
    }
}
