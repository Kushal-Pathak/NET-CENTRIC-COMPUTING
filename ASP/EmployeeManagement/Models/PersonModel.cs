using System.ComponentModel.DataAnnotations;
public class Person
{
    [Required(ErrorMessage = "Enter name to continue")]
    public string Name { get; set; }
    public string? Address { get; set; } = "Gaindakot";
    public double? Salary { get; set; }

    public Person(string name, string address, double salary)
    {
        Name = name;
        Address = address;
        Salary = salary;
    }

    public Person() { }

    public static List<Person> GetEmployees()
    {
        Person p1 = new Person("Ram", "Gaindakot", 555);
        Person p2 = new Person("Sam", "Bharatpur", 444);
        Person p3 = new Person("Sita", "Ktm", 333);
        Person p4 = new Person("Hari", "Madi", 222);
        Person p5 = new Person("Kisna", "Tadi", 111.55);
        List<Person> employees = new List<Person>() { p1, p2, p3, p4, p5 };
        return employees;
    }
}

//learn about nullable variable
//learn about generic and collections