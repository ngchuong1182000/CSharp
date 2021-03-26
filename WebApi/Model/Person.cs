using System;
namespace WebApi.Model
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public DateTime dateOfBirth { get; set; }
        public int phoneNumber { get; set; }
        public string birthPlace { get; set; }
        public Boolean isGraduated { get; set; }
    }
}