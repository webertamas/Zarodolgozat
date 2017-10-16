using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zarodolgozat.Dal;

namespace Zarodolgozat
{
    public class DailyLogViewModel:BaseModel
    {
        public ObservableCollection<Agreement> AgreementList { get; set; }


        DateTime _chosenDate;
        
        public DateTime ChosenDate
        {
            get { return _chosenDate; }
            set
            {
                _chosenDate = value; OnPropertyChange("ChosenDate"); OnPropertyChange("FilteredAgreements");
            }
        }

        public IEnumerable<Agreement> FilteredAgreements
        {
            get
            { 
                return AgreementList.Where(x => x.StartDate <= ChosenDate).Where(x => x.EndDate >= ChosenDate);
            }
        }
        
        public DailyLogViewModel()
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

