using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.BLL.Interfaces;
using TodoList.BLL.Models;
using TodoList.DAL.Entities;

namespace TodoList.BLL.Implementation
{
    public class TodoListService : ITodoListService
    {
        public void Add(TaskViewModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int userId, int taskId)
        {
            throw new NotImplementedException();
        }

        public Todo GetTask(int userId, int taskId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Todo> GetTodoList()
        {
            throw new NotImplementedException();
        }

        public void MarkAsDone(int userId, int taskId)
        {
            throw new NotImplementedException();
        }

        public void Update(TaskViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
