using Microsoft.AspNetCore.Mvc;
using ModelValidationExample.Models;

namespace ModelValidationExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("register")]
        public IActionResult Index(Person person)
        {
          //  List<string> errorList=new List<string>();

            ////////////////////////////////////////
            ///



            if (!ModelState.IsValid)
            {
               string errors =string.Join("\n" ,ModelState.Values.SelectMany(value => value.Errors).Select(err => err.ErrorMessage));
                //foreach (var value in ModelState.Values)
                //{
                //    foreach(var error in value.Errors)
                //    {
                //        errorList.Add(error.ErrorMessage);
                //    }
                //}
                //string errors=string.Join("\n",errorList);
                return BadRequest(errors);
            }
            return Content($"{person}");
        }
    }
}
