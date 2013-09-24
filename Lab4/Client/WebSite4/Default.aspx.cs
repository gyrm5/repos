using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
       
           

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int c = Convert.ToInt32(TextBox1.Text);
        int d = Convert.ToInt32(TextBox2.Text);
        ServiceReference1.ServiceSoapClient sr = new ServiceReference1.ServiceSoapClient("ServiceSoap");
        int cd = sr.addition(c, d);
       Label1.Text = Convert.ToString(cd);
       
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int c = Convert.ToInt32(TextBox1.Text);
        int d = Convert.ToInt32(TextBox2.Text);
        ServiceReference1.ServiceSoapClient sr = new ServiceReference1.ServiceSoapClient("ServiceSoap");
        int cd = sr.substract(c, d);
        Label1.Text = Convert.ToString(cd);
        
    }


    protected void Button3_Click(object sender, EventArgs e)
    {
        int c = Convert.ToInt32(TextBox1.Text);
        int d = Convert.ToInt32(TextBox2.Text);
        ServiceReference1.ServiceSoapClient sr = new ServiceReference1.ServiceSoapClient("ServiceSoap");
        int cd = sr.Multiplication(c, d);
        Label1.Text = Convert.ToString(cd);
       
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
       
        int c = Convert.ToInt32(TextBox1.Text);
        int d = Convert.ToInt32(TextBox2.Text);
        ServiceReference1.ServiceSoapClient sr = new ServiceReference1.ServiceSoapClient("ServiceSoap");
        int cd = sr.division(c, d);
        Label1.Text = Convert.ToString(cd);
       
    }
}