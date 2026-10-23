using Day2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day2.ViewComponents;

public class StudentCountViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        // Component tự lấy dữ liệu và đếm số sinh viên.
        int count = StudentData.GetAll().Count;
        return View(count);
    }
}
