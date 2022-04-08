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
        //[HttpPost]
        //public string[] AddValue(string[] data)
        //{
        //    if (data is null)
        //    {
        //        //throw new ArgumentNullException(nameof(data));
        //        data = new string[1];//Fizz_BuzzModel();
        //    }  
        //    string[] newData = new string[data.Length + 1];
        //    for(int index = 0; index < data.Length; index++)
        //    {
        //        newData[index] = data[index];
        //    }
        //    //data.Data = newData;
        //    return newData;
        //}
        [HttpPost]
        public IActionResult Calculate([FromForm]string[] inputValue)//Fizz_BuzzModel inputValue)
        {
            if (inputValue is null)
            {
                //throw new ArgumentNullException(nameof(data));
                //data = new string[1];
                Fizz_BuzzModel data = new Fizz_BuzzModel(1);
                return View("Index", data);
            }
            Fizz_BuzzModel model = new Fizz_BuzzModel(inputValue.Length);
            
            //string[] newData = new string[data.Length + 1];
            for (int index = 0; index < inputValue.Length; index++)
            {
                model.Data[index] = inputValue[index];
            }
            model.Calculate();
            //data.Data = newData;
            return View("Result", model);
        }
        
        [HttpPost]
        public IActionResult Calculate2(string[] Data)
        {
            //if (datos is null)
            //{
            //    return View("Index");
            //}
            var cero = HttpContext.Request.Form["inputValue-0"];
            var data = new string[1];//Fizz_BuzzModel();
            Fizz_BuzzModel model = new Fizz_BuzzModel(data.Length);

            //string[] newData = new string[data.Length + 1];
            for (int index = 0; index < data.Length; index++)
            {
                model.Data[index] = data[index];
            }
            model.Calculate();
            //data.Data = newData;
            return View("Result", model);
        }
    }
}
