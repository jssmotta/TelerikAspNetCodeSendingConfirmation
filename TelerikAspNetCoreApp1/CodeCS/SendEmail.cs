namespace TelerikAspNetCoreApp1.CodeCS;
 
using System.Net.Mail; 

public class EmailSender
{
    private SmtpClient _smtpClient;

    public EmailSender(SmtpClient smtpClient)
    {
        _smtpClient = smtpClient;
    }

    public void SendEmail(string emailTo, string subject, string message)
    {
        var mailMessage = new MailMessage("noreply@progress.com", emailTo, subject, message);
        _smtpClient.Send(mailMessage);
    }
}