using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarodolgozat
{
    class CompanyFormViewModel:BaseModel
    {
        public Company Company { get; set; }
        public bool IsNew { get; set; }

        Company company;
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
            if (!IsNew)
            {
                company = new Company
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
                };
            }
        }

        public void OriginalValue()
        {
            Company.CompanyName = company.CompanyName;
        }

        //public void SaveP()
        //{
        //    if (!IsNew)
        //        product = new Product { Name = Product.Name, Price = Product.Price, Quantity = Product.Quantity };
        //}

        //public void OriginalValueP()
        //{
        //    Product.Name = product.Name;
        //    Product.Price = product.Price;
        //    Product.Quantity = product.Quantity;
        //}
    }
}
