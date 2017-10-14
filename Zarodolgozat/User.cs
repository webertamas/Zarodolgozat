using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zarodolgozat.Dal;

namespace Zarodolgozat
{
    public class User:BaseModel
    {
        string _username;
        string _password;

        public string Username { get { return _username; }set { _username = value;OnPropertyChange(); } }
        public string Password { get { return _password; }set { _password = value;OnPropertyChange(); } }

        public User(UserDbModel dbModel)
        {
            Username = dbModel.Username;
            Password = dbModel.Password;
        }
        public User()
        {

        }
    }
}
