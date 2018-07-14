using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

/// <summary>
/// Summary description for Email
/// </summary>
public class Email
{

    private string _Email = null;
    public Email(string Email)
    {
        this._Email = Email;
    }

    //public int UserInsert(string userEmail)
    //{
    //    //MailMessage mail = new MailMessage("97264511jontohjj@gmail.com", userEmail);
    //    //SmtpClient client = new SmtpClient();
    //    //client.Port = 587;
    //    //client.EnableSsl = true;
    //    //client.DeliveryMethod = SmtpDeliveryMethod.Network;
    //    //client.UseDefaultCredentials = false;
    //    //client.Host = "smtp.gmail.com";
    //    //mail.Subject = "this is a test email.";
    //    //mail.Body = "this is my test email body";
    //    //client.Send(mail);
    //    //return 0;


    //}
    public void CreateTestMessage3(string userEmail)
    {
        MailAddress to = new MailAddress(userEmail);
        MailAddress from = new MailAddress("boxwear.co@gmail.com");
        MailMessage message = new MailMessage(from, to);
        message.Subject = "Welcome to BoxWear";
        message.Body = @"Thank you for signing up with boxwear!";
        // Use the application or machine configuration to get the 
        // host, port, and credentials.
        SmtpClient client = new SmtpClient();
        Console.WriteLine("Sending an e-mail message to {0} at {1} by using the SMTP host={2}.",
            to.User, to.Host, client.Host);
        try
        {
            client.Send(message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception caught in CreateTestMessage3(): {0}",
                        ex.ToString());
        }
    }
}