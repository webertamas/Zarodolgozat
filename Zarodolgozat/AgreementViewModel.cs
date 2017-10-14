using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Zarodolgozat.Dal;

namespace Zarodolgozat
{
    public class AgreementViewModel:BaseModel
    {
        public ObservableCollection<Agreement> AgreementList { get; set; }
        
        public Client SelectClient { get; set; }

        public AgreementViewModel()
        {
            AgreementList = new ObservableCollection<Agreement>();
            var manager = new DataManager();
            foreach (var agree in manager.GetAgrees())
            {
                AgreementList.Add(new Agreement(agree));
            }
        }

    }
}
