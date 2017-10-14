using System;
using System.Collections.Generic;
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
        public List<Agreement> Agreements { get; }
        public AgreementViewModel(Client client)
        {
            var ctx = new Context();
            //Agreements = ctx.Agreements.Where(x => x.Client.BirthName == client.BirthName).Select(x => new Agreement { StartDate = x.StartDate.ToString("f") }).ToList();
        }

    }
}
