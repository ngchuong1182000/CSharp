using System;
namespace ManagerStudent.Models
{
    public class Student
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Boolean isAdmin { get; set; }

        public Student(string id, string userName, string password, Boolean isAdmin)
        {
            this.Id = id;
            this.UserName = userName;
            this.Password = password;
            this.isAdmin = isAdmin;
        }

        public Student()
        {
        }
    }
}