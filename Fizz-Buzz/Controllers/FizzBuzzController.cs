using Fizz_Buzz.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Fizz_Buzz.Controllers
{
    public class FizzBuzzController : Controller
    {
        public IActionResult Index()
        {
            Fizz_BuzzModel data = new Fizz_BuzzModel(1);
            return View(data);
        }
        [HttpPost]
        public IActionResult Calculate([FromForm]string[] inputValue)
        {
            if (inputValue is null)
            {
                Fizz_BuzzModel data = new Fizz_BuzzModel(1);
                return View("Index", data);
            }
            Fizz_BuzzModel model = new Fizz_BuzzModel(inputValue.Length);
            
            for (int index = 0; index < inputValue.Length; index++)
            {
                model.Data[index] = inputValue[index];
            }
            model.Calculate();
            return View("Result", model);
        }        
    }
}
