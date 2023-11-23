using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace TelerikAspNetCoreApp1.Controllers;
public class HomeController : Controller
{

    public override void OnActionExecuting(ActionExecutingContext context)
    {
        if (!string.IsNullOrEmpty(context.HttpContext.Request.Query["culture"]))
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo(context.HttpContext.Request.Query["culture"]);
        }
        base.OnActionExecuting(context);
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        ViewData["Message"] = "Your application description page.";

        return View();
    }

    public IActionResult Contact()
    {
        ViewData["Message"] = "Your contact page.";

        return View();
    }

    public IActionResult SendEmailConfirm()
    {
        ViewData["Message"] = "Choose your plan";

        return View();
    }

    public IActionResult Error()
    {
        return View();
    }
}
