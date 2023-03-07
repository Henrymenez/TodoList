using TodoList.DAL.Enums;

namespace TodoList.DAL.Entities
{
    public class Todo : BaseEntity
    {

        public string Title { get; set; }

        public string Description { get; set; }

        public Priority Priority { get; set; } = Priority.Normal;


        public bool IsDone { get; set; }

        public DateTime DueDate { get; set; }



    }


}
