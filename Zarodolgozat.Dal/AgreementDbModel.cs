using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarodolgozat.Dal
{
    public class AgreementDbModel
    {
        public UserDbModel User { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<ClientDbModel> Clients { get; set; }
        public ClientDbModel Client { get; set; }
    }
}
