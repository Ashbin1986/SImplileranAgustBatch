using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpliLearn.DataAccessLayer.Repositories
{
    public interface IUserRepository
    {
        void AddUser(UserCredentail user);
    }
}
