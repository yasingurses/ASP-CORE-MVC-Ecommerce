using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserService
    {

        int AddUser(User user);
        int UpdateUser(User user);
        int DeleteUser(User user);
        List<User> GetAllUser();
        User GetUserByID(int id);
    }
}
