using TodoList.DAL.Enums;

namespace TodoList.BLL.Models
{
    public class TaskViewModel
    {
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Priority? Priority { get; set; }

        public DateTime DueDate { get; set; }

    }
}
