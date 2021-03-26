using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApi.Logic;
using WebApi.Model;

namespace WebApi.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentHandler _menberHandler;

        public StudentController(IStudentHandler memberHandler)
        {
            _menberHandler = memberHandler;
        }

        [HttpGet]
        [Route("/api/student/membersByGender/{gender}")]
        public List<Student> FilterStudentByGender(string gender){
            return _menberHandler.FilterStudentByGender(gender);
        }

        [HttpPost]
        [Route("/api/student/membersByGender/{gender}")]
        public List<Student> AddMember(Student student){
            return _menberHandler.AddStudent(student);
        }


    }
}