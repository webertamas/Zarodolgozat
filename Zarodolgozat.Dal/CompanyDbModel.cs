using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarodolgozat.Dal
{
    public class CompanyDbModel
    {
        public string CompanyName { get; set; }
        public int HQZIPCode { get; set; }
        public string HQLocality { get; set; }
        public string HQStreet { get; set; }
        public string HQNumber { get; set; }
        public string SiteName { get; set; }
        public int SiteZIPCode { get; set; }
        public string SiteLocality { get; set; }
        public string SiteStreet { get; set; }
        public string SiteNumber { get; set; }
    }
}
