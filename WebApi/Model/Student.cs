using System;

namespace WebApi.Model
{
    public class Student : Person
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public Student(string firstName, string lastName, string gender, DateTime dateOfBirth, int phoneNumber, string birthPlace, Boolean isGraduated, DateTime startDate, DateTime endDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
            this.phoneNumber = phoneNumber;
            this.birthPlace = birthPlace;
            this.isGraduated = isGraduated;
            this.startDate = startDate;
            this.endDate = endDate;
        }
    }
}