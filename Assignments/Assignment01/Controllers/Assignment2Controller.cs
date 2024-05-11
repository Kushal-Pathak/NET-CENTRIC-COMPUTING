using Microsoft.AspNetCore.Mvc;

public class Assignment2Controller : Controller
{
    public ActionResult Index()
    {
        TempData["Message"] = "TempData Message";
        ViewData["Title"] = "ViewData Title";
        ViewBag.Info = "ViewBag Info";
        return View();
    }
}