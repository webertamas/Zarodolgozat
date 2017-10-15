namespace Zarodolgozat.Dal
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Context : DbContext
    {
        public Context() : base("name=Context")
        {
        }
        //Databases
        public virtual DbSet<UserDbModel> Users { get; set; }
        public virtual DbSet<ClientDbModel> Clients { get; set; }
        public virtual DbSet<AgreementDbModel> Agreements { get; set; }
        public virtual DbSet<DailyLogDbModel> DailyLogs { get; set; }
        public virtual DbSet<CompanyDbModel> Companies { get; set; }
    }
}