using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Model;

namespace WebApi.Logic
{
    public class StudentHandler : IStudentHandler
    {
        private List<Student> MyListStudent;

        public StudentHandler()
        {
            SeedingStudent();
        }

        public List<Student> AddStudent(Student student)
        {
            MyListStudent.Add(student);
            return MyListStudent;
        }

        public List<Student> FilterStudentByGender(string gender)
        {
            var result = MyListStudent.Where(s => s.gender == gender).ToList();
            return result;
        }

        public Student FilterStudentOldest()
        {
            var minDob = MyListStudent.Min(s => s.dateOfBirth);
            var result = MyListStudent.FirstOrDefault(s => s.dateOfBirth == minDob);
            return result;
        }

        public List<Student> ListStudentBornHn(string place)
        {
            var result = MyListStudent.Where(s => s.birthPlace == place).ToList();
            return result;
        }

        public List<string> ListStudentByFullNameOnly()
        {
            var result = MyListStudent.Select(s => s.firstName + " " + s.lastName).ToList();
            return result;
        }

        public List<Student> ListStudentByYear(int year)
        {
            var result = MyListStudent.Where(s => s.dateOfBirth.Year == year).ToList();
            return result;
        }

        public List<Student> ListStudentGtYear(int year)
        {
            var result = MyListStudent.Where(s => s.dateOfBirth.Year < year).ToList();
            return result;
        }

        public List<Student> ListStudentLtYear(int year)
        {
            var result = MyListStudent.Where(s => s.dateOfBirth.Year > year).ToList();
            return result;
        }

        private void SeedingStudent()
        {
            MyListStudent = new List<Student>{
                new Student("Chu Nguyên ", "Chương", "male", new DateTime(2000, 11, 08), 0987374741, "bac giang", true, new DateTime(2020, 03, 20), DateTime.Now),
                new Student("Thị ", "Nở", "female", new DateTime(1987, 01, 22), 0987374741, "ha noi", true, DateTime.Now, DateTime.Now),
                new Student("Chí ", "Phèo", "male", new DateTime(1997, 04, 01), 0987374741, "bac ninh", true, DateTime.Now, DateTime.Now),
                new Student("Trần Đức ", "Bo", "female", new DateTime(1998, 02, 09), 0987374741, "hai duong", true, DateTime.Now, DateTime.Now),
            };
        }
    }
}
