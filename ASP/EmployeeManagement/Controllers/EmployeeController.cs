using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        var employees = Person.GetEmployees();
        return View(employees);
    }

    public ActionResult Detail(string name)
    {
        var employees = Person.GetEmployees();
        var employee = employees.FirstOrDefault(emp => emp.Name == name);
        return View(employee);
    }

    public ActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public ActionResult<string> Add(Person employee)
    {
        return "Employee saved";
    }
}

//also learn about tag helper and hints
