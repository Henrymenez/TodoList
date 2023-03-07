using Microsoft.AspNetCore.Mvc;
using TodoList.BLL.Implementation;
using TodoList.BLL.Interfaces;
using TodoList.BLL.Models;

namespace TodoList.MVC.Controllers
{
    public class TodoListController : Controller
    {
        private readonly IUserService _user;

        public TodoListController(IUserService user)
        {
            _user = user;
        }
        public IActionResult Index()
        {
      IEnumerable<UserWithTaskViewModel> userWithTaskViewModels = _user.GetUsersWithTask().ToList();
            return View(userWithTaskViewModels);
        }
    }
}
