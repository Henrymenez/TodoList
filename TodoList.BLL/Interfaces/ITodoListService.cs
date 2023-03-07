using TodoList.BLL.Models;
using TodoList.DAL.Entities;

namespace TodoList.BLL.Interfaces
{
    public interface ITodoListService
    {
        void Add(TaskViewModel model);
        void Update(TaskViewModel model);
        void Delete(int userId, int taskId);
        void MarkAsDone(int userId, int taskId);
        Todo GetTask(int userId, int taskId);
        IEnumerable<Todo> GetTodoList();
    }
}
