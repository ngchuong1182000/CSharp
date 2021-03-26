using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using LessonMvc.Models;
using Microsoft.AspNetCore.Http;

namespace LessonMvc.Controllers
{
    public class UserController : Controller
    {
        public List<Person> listPerson = new List<Person>();
        public IActionResult Index()
        {
            Person student = new Person("Chu Nguyên ", "Chương", "male", new DateTime(2000, 11, 08), 0987374741, "bac giang", true);
            listPerson.Add(student);
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTime.Now.AddMinutes(1);
            Response.Cookies.Append("user", student.lastName, cookieOptions);
            return View(listPerson);
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Person user)
        {
            string message = "";

            if (ModelState.IsValid)
            {
                Console.WriteLine(user.firstName);
                message = "product " + user.firstName + " Rate " + user.lastName + " With Rating created successfully";
            }
            else
            {
                message = "Failed to create the product. Please try again";
            }
            return Content(message);
        }
    }
}