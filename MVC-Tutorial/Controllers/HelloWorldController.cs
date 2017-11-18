using System.Web;
using System.Web.Mvc; 
 
namespace MvcMovie.Controllers 
{ 
    public class HelloWorldController : Controller 
    { 
        // 
        // GET: /HelloWorld/ 
 
        public ActionResult Index() 
        { 
            return View(); 
        } 
 
        // 
        // GET: /HelloWorld/Welcome/ 
 
        public string Welcome() 
        { 
            return "This is the Welcome action method..."; 
        }

        //
        // GET: /HelloWorld/ParamWelcome?name=x&numTimes=y
        public string ParamWelcome(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes); ;
        }

        //
        // GET: /HelloWorld/RouteParamWelcome/name=x?numTimes=y
        // This method introduces the concept of a route parameter. In this case, the route parameter is "ID". 
        // The tutorial explains how the RouteConfig.cs file defines how a URL is handled and how it can be customised. 
        public string RouteParamWelcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + ID); ;
        }

        //
        // GET: /HelloWorld/ViewWelcome?name=x&numTimes=y
        // Learnt that the Method name and the View file name must be the same. If they are not the same view will not 
        // render the page according conditions presented in the method. 
        public ActionResult ViewWelcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    } 
}