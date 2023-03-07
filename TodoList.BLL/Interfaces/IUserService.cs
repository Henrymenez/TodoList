using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.BLL.Models;
using TodoList.DAL.Entities;

namespace TodoList.BLL.Interfaces
{
    public interface IUserService
    {
        void Create(UserViewModel model);

        IEnumerable<User> GetUsers();

        IEnumerable<UserWithTaskViewModel> GetUsersWithTask();
    }
}
