using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarodolgozat.Dal
{
    public class DataManager
    {
        readonly Seeds _seeds;

        Context ctx;

        public DataManager()
        {
            _seeds = new Seeds();
            //if (!_ctx.Users.Any(x => x.Username == "asdf"))
            //{
            //    _ctx.Users.Add(new UserDbModel
            //    {
            //        Username = "asdf",
            //        Password = "asdf",
            //    });
            //    _ctx.SaveChanges();
            //}
        }
        public UserDbModel GetUser(string username, string password)
        {
            try
            {
                return _seeds.Users.SingleOrDefault(x => x.Username == username && x.Password == password);
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }
        public IEnumerable<ClientDbModel> GetClients()
        {
            return _seeds.Clients.OrderBy(x => x.BirthName);
        }

        public void AddClient(ClientDbModel client)
        {
            using (ctx = new Context())
            {
                var cl = client;
                ctx.Clients.Add(cl);
                try
                {
                    ctx.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    //throw;
                }
                //ctx.SaveChanges();

            }
        }
        public IEnumerable<AgreementDbModel> GetAgrees()
        {
            return _seeds.Agreements; //.OrderBy(x => x.Client.BirthName);// .OrderBy(x => x.StartDate);
        }

        
    }
}
