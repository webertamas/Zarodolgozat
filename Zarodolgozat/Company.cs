using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zarodolgozat.Dal;

namespace Zarodolgozat
{
    class Company:BaseModel
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

        public Company(CompanyDbModel dbModel)
        {
            CompanyName = dbModel.CompanyName;
            HQZIPCode = dbModel.HQZIPCode;
            HQLocality = dbModel.HQLocality;
            HQStreet = dbModel.HQStreet;
            HQNumber = dbModel.HQNumber;
            SiteName = dbModel.SiteName;
            SiteZIPCode = dbModel.SiteZIPCode;
            SiteLocality = dbModel.SiteLocality;
            SiteStreet = dbModel.SiteStreet;
            SiteNumber = dbModel.SiteNumber;
        }
        public Company()
        {

        }
    }
}
