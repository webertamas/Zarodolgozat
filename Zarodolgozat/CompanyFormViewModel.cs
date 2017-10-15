using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zarodolgozat.Dal;

namespace Zarodolgozat
{
    class CompanyFormViewModel:BaseModel
    {

        public Company Company { get; set; }
        public bool IsNew { get; set; }

        DataManager ctx = new DataManager();
        Context _ctx = new Context();

        //Company company;
        public CompanyFormViewModel(Company Company)
        {
            this.Company = Company;
            if (!IsNew)
                Save();
        }

        public bool CompanyValidate()
        {
            return !string.IsNullOrEmpty(Company.CompanyName)
                && !string.IsNullOrEmpty(Company.HQLocality)
                && !string.IsNullOrEmpty(Company.HQStreet)
                && !string.IsNullOrEmpty(Company.HQNumber)
                && !string.IsNullOrEmpty(Company.SiteName)
                && !string.IsNullOrEmpty(Company.SiteLocality)
                && !string.IsNullOrEmpty(Company.SiteNumber) 
                && Company.HQZIPCode > 0 
                && Company.SiteZIPCode > 0;
        }

        public void Save()
        {
            //if (IsNew)
            //{
            //    company = new Company
            //    {
            //        CompanyName = Company.CompanyName,
            //        HQZIPCode = Company.HQZIPCode,
            //        HQLocality = Company.HQLocality,
            //        HQStreet = Company.HQStreet,
            //        HQNumber = Company.HQNumber,
            //        SiteName = Company.SiteName,
            //        SiteZIPCode = Company.SiteZIPCode,
            //        SiteLocality = Company.SiteLocality,
            //        SiteStreet = Company.SiteStreet,
            //        SiteNumber = Company.SiteNumber
            //    };
            //}
            if (IsNew)
            {
                ctx.AddCompanies (new CompanyDbModel
                {
                    CompanyName = Company.CompanyName,
                    HQZIPCode = Company.HQZIPCode,
                    HQLocality = Company.HQLocality,
                    HQStreet = Company.HQStreet,
                    HQNumber = Company.HQNumber,
                    SiteName = Company.SiteName,
                    SiteZIPCode = Company.SiteZIPCode,
                    SiteLocality = Company.SiteLocality,
                    SiteStreet = Company.SiteStreet,
                    SiteNumber = Company.SiteNumber
                }
                    );
            }
        }

        //public void OriginalValue()
        //{
        //    Company.CompanyName = company.CompanyName;
        //}
    }
}
