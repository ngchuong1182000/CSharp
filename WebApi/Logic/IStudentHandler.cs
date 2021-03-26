using System.Collections.Generic;
using WebApi.Model;

namespace WebApi.Logic
{
    public interface IStudentHandler
    {
        //1. Return list member who is male
        List<Student> FilterStudentByGender(string gender);
        //2. Return the oldest member.
        Student FilterStudentOldest();
        //3. Return  a new list that contains FullName only
        List<string> ListStudentByFullNameOnly();
        //4. Return 3 list of member who born in, before, after 2000.
        List<Student> ListStudentByYear(int year);
        List<Student> ListStudentGtYear(int year);
        List<Student> ListStudentLtYear(int year);
        //5. Return first person who born in Ha Noi
        List<Student> ListStudentBornHn(string place);
        //6. Return list of member who join before 22/3/2021

        List<Student> AddStudent(Student student);

    }
}