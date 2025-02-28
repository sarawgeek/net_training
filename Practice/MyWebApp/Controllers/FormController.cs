﻿using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

namespace MyWebApp.Controllers
{
    public class FormController : Controller
    {
        List<Person> people;
        public FormController(List<Person> people)
        {
            this.people = people;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Show(Person p)
        {
            people.Add(p);
            return View(people);
        }
    }
}
