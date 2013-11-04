using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class invitefriends : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string email = TextBox1.Text;
        int id = 0;
        id = Convert.ToInt32(Request.QueryString["id"]);

        /*  Email to User */

        string message1 = "You can select your gifts over here <br>";

        message1 = "http://localhost:61427/DisplayEvents.aspx";

        var fromAddress = new MailAddress("yemparalaguf12038@gmail.com", "From Name");
        var toAddress = new MailAddress(email, "To Name");
        const string fromPassword = "bpharmacy2";
        const string subject = "you are cordially invited to event";
        string body = message1;

        var smtp = new SmtpClient
        {
            Host = "smtp.gmail.com",
            Port = 587,
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
            Timeout = 20000
        };
        using (var message = new MailMessage(fromAddress, toAddress)
        {
            Subject = subject,
            Body = body
        })
        {
            smtp.Send(message);
        }


    }
    }