using Microsoft.AspNetCore.Mvc;

public class DemoCsitController : Controller
{
    public ActionResult<string> Student(string name = "Ram")
    {
        return "Student Name: " + name;
    }
    public ActionResult<string> Employee(string name = "Hari", string department = "IT")
    {
        return "Employee name: " + name + " Department: " + department;
    }
}