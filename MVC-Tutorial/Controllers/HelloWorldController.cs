using System.Web;
using System.Web.Mvc; 
 
namespace MvcMovie.Controllers 
{ 
    public class HelloWorldController : Controller 
    { 
        // 
        // GET: /HelloWorld/ 
 
        public string Index() 
        { 
            return "This is my <b>default</b> action..."; 
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
    } 
}