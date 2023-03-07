using Microsoft.AspNetCore.Mvc;
using TodoList.BLL.Interfaces;
using TodoList.BLL.Models;

namespace TodoList.MVC.Controllers
{
    public class TodoListController : Controller
    {
        private readonly IUserService _userService;

        public TodoListController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            IEnumerable<UserWithTaskViewModel> userWithTaskViewModels = _userService.GetUsersWithTask().ToList();
            return View(userWithTaskViewModels);
        }
    }
}
