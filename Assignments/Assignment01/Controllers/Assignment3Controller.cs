using Microsoft.AspNetCore.Mvc;

public class Assignment3Controller : Controller
{
    public ActionResult Index()
    {
        TempData["Message"] = "TempData Message from index";
        ViewData["Title"] = "ViewData Title from index";
        ViewBag.Info = "ViewBag Info from index";
        return View();
    }

    public ActionResult Index1()
    {
        TempData["Message1"] = "TempData Message from index1";
        ViewData["Title1"] = "ViewData Title from index1";
        ViewBag.Info1 = "ViewBag Info from index1";
        return View();
    }

    public ActionResult Index2()
    {
        string msgIndex = TempData["Message"] as string ?? "Message";
        string msgIndex1 = TempData["Message1"] as string ?? "Message1";
        string title = ViewData["Title"] as string ?? "Title";
        string title1 = ViewData["Title1"] as string ?? "Title1";
        string info = ViewBag.Info;
        string info1 = ViewBag.Info1;
        ViewBag.MsgIndex = msgIndex;
        ViewBag.msgIndex1 = msgIndex1;
        ViewBag.Title = title;
        ViewBag.Title1 = title1;
        ViewBag.Info = info;
        ViewBag.Info1 = info1;
        return View();
    }
}