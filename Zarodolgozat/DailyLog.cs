using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarodolgozat
{
    public class DailyLog:BaseModel
    {
        bool _use;
        

        public bool use
        {
            get
            {
                return _use;
            }
            set
            {
                _use = value;
                OnPropertyCange();
            }
        }
    }
}
