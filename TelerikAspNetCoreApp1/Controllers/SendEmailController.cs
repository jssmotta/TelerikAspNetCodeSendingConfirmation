using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using TelerikAspNetCoreApp1.CodeCS;

namespace TelerikAspNetCoreApp1.Controllers;
public class SendEmailController : Controller
{
    public IActionResult SendEmail(string typePlan)
    {
        try
        {
            var email = new EmailSender(new SmtpClient());

            email.SendEmail("customer@email.com", "Confirmation " + typePlan, "This is the confirmation for your plan " + typePlan);
            
            return StatusCode(StatusCodes.Status200OK);
        }
        catch 
        {
#if (DEBUG)
            return StatusCode(StatusCodes.Status200OK);
#else
            return StatusCode(StatusCodes.Status500InternalServerError);
#endif
        }
    }
}
