using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.BLL.Interfaces;
using TodoList.BLL.Models;
using TodoList.DAL.Entities;
using TodoList.DAL.Enums;

namespace TodoList.BLL.Implementation
{
    public class UserService : IUserService
    {
      
        public UserService() { 
        
        }
        public void Create(UserViewModel model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserWithTaskViewModel> GetUsersWithTask()
        {
         return TodoListDbContext.GetUsersWithTodos().Select(u => new UserWithTaskViewModel
            {
                Fullname = u.FullName,
                Tasks = u.TodoList.Select(t => new TasksVM
                {
                    Title = t.Title,
                    Description = t.Description,
                    Priority = t.Priority.ToString(),
                    DueDate = t.DueDate.ToString("d"),
                    Status = t.IsDone ? "Done" : "Not Done"
                })
            }).ToList();
           
        }
    }
}
