using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zarodolgozat.Dal;

namespace Zarodolgozat
{
    public class DailyLog:BaseModel
    {
        AgreementDbModel _agreement { get; set; }

        public int Id { get; set; }

        public AgreementDbModel Agreement
        {
            get { return _agreement; }
            set { _agreement = value; OnPropertyChange(); }
        }

        public DailyLog(DailyLogDbModel dbModel)
        {
            Agreement = dbModel.Agreement;
        }

        public DailyLog()
        {

        }
    }
}
