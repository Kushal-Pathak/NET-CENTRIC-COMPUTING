using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[Route("api/[controller]")]
[ApiController]
public class Assignment5Controller : Controller
{
    // GET api/student/student/{id}
    [HttpGet("student/{id}")]
    public IActionResult GetStudentWithId(int id)
    {
        // Here you can fetch student data with the provided ID
        var student = new Student { Id = id, Name = "Ram", Grade = "A" };
        return Ok(student);
    }

    // GET api/student/allstudents
    [HttpGet("allstudents")]
    public IActionResult GetAllStudents()
    {
        // Here you can fetch all students data
        var students = new List<Student>
            {
                new Student { Id = 1, Name = "Ram", Grade = "A" },
                new Student { Id = 2, Name = "Sam", Grade = "B" },
                new Student { Id = 3, Name = "Hari", Grade = "C" }
            };
        return Ok(students);
    }
}

// Sample Student model
public class Student
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Grade { get; set; }
}