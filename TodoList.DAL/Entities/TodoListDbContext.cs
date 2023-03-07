using TodoList.DAL.Enums;

namespace TodoList.DAL.Entities
{
    public class TodoListDbContext
    {
        public static IList<User> GetUsersWithTodos()
        {
            return new List<User> {
                new User {
                Id = 1,
                FullName = "John Doe",
                Email = "John.doe@gmail.com",
                Password = "password12345",
                TodoList = new List<Todo>
                {
                    new Todo
                    {
                        Id  = 1,
                        Title = "Reading",
                        Description = "Try and finish the book",
                        Priority = Priority.High,
                        DueDate = DateTime.Now.AddDays(3)


                    },
                    new Todo
                    {
                        Id  = 2,
                        Title = "Cooking",
                        Description = "Try and finish the Rice meal",
                        Priority = Priority.Low,
                        DueDate = DateTime.Now,
                        IsDone  = true


                    },
                    new Todo
                    {
                        Id  = 3,
                        Title = "Jogging",
                        Description = "Try and finish the Rice meal",
                        DueDate = DateTime.Now.AddDays(23)


                    }
                }
                },
                  new User {
                Id = 2,
                FullName = "Chizoba Doe",
                Email = "chizoba.doe@gmail.com",
                Password = "password12345",
                TodoList = new List<Todo>
                {
                    new Todo
                    {
                        Id  = 1,
                        Title = "Running",
                        Description = "Try and finish the Run",
                        DueDate = DateTime.Now.AddDays(3)


                    },
                    new Todo
                    {
                        Id  = 2,
                        Title = "Bowling",
                        Description = "Try and Bowl ",
                        Priority = Priority.High,
                        DueDate = DateTime.Now.AddDays(9),


                    },
                    new Todo
                    {
                        Id  = 3,
                        Title = "Build an App",
                        Description = "Build an application",
                        DueDate = DateTime.Now,
                        IsDone = true


                    }
                }
                },
            };
        }
    }
}
