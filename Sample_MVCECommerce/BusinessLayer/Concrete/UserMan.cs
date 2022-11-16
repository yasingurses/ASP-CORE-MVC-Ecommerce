using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserMan : IUserService
    {
        IUserDal users;

        public UserMan(IUserDal users)
        {
            this.users = users;
        }

        public int AddUser(User user)
        {
            return users.Add(user);
        }

        public int DeleteUser(User user)
        {
            return users.Delete(user);
        }

        public List<User> GetAllUser()
        {
            return users.GetAll();
        }

        public User GetUserByID(int id)
        {
            return users.getByID(id);
        }

        public int UpdateUser(User user)
        {
            return users.Update(user);
        }
    }
}
