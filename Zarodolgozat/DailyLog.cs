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
        bool _use { get; set; }
        AgreementDbModel _agreement { get; set; }

        public int Id { get; set; }

        public bool Use
        {
            get { return _use; }
            set { _use = value; OnPropertyChange(); }
        }

        public AgreementDbModel Agreement
        {
            get { return _agreement; }
            set { _agreement = value; OnPropertyChange(); }
        }

        public DailyLog(DailyLogDbModel dbModel)
        {
            Use = dbModel.Use;
            Agreement = dbModel.Agreement;
        }

        public DailyLog()
        {

        }
    }
}
