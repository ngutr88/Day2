using Day2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day2.Controllers;

[Route("sinh-vien")]
public class StudentsController : Controller
{
    // Attribute Routing: GET /sinh-vien/1
    [HttpGet("{id:int}", Name = "StudentById")]
    public IActionResult Details(int id)
    {
        var student = StudentData.GetAll().Find(s => s.Id == id);
        if (student == null)
        {
            return NotFound("Không tìm thấy sinh viên.");
        }

        ViewData["RoutingType"] = "Attribute Routing";
        return View("~/Views/Lessons/Details.cshtml", student);
    }
}
