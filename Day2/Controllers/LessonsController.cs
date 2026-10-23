using Day2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day2.Controllers;

public class LessonsController : Controller
{
    // Conventional Routing: /Lessons hoặc /Lessons/Index
    public IActionResult Index()
    {
        var students = StudentData.GetAll();
        return View(students);
    }

    // Conventional Routing: /Lessons/Details/1
    public IActionResult Details(int id)
    {
        var student = StudentData.GetAll().Find(s => s.Id == id);
        if (student == null)
        {
            return NotFound("Không tìm thấy sinh viên.");
        }

        ViewData["RoutingType"] = "Conventional Routing";
        return View(student);
    }
}
