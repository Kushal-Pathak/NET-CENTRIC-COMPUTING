using Microsoft.AspNetCore.Mvc;
public class ConsumerController : Controller
{
    public ActionResult Price(int p = 10000)
    {
        return Ok($"price: {p}");
    }
    public ActionResult Information(string name = "Sita", string email = "sita@gmail.com")
    {
        return Ok($"Name: {name} email: {email}");
    }

    public ActionResult Tax(int price = 10000)
    {
        if (price < 10000) return Ok("Tax: " + price * 0.1);
        else if (price < 20000) return Ok("Tax: " + 0.2 * price);
        else return Ok("Tax: " + 0.3 * price);
    }
}