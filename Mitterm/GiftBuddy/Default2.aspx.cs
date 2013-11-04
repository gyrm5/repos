using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Configuration;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string en = TextBox1.Text;
        string ed = datepicker.Value;
        string et = TextBox5.Text;
        string location = TextBox3.Text;
        string edes = DropDownList1.SelectedValue;
        

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);
        //Open the connection
        conn.Open();

        SqlCommand cmd = new SqlCommand("insert into Event (EventName,EventDate,EventTime,EventLocation,EventDescription) values('" + en + "','" + ed + "','" + et + "','" + location + "','" + edes + "')", conn);

        int result = cmd.ExecuteNonQuery();

        if (result != 0)
        {
            Label2.Text = "Added Sucessfully";
        }
        else
        {
            Label2.Text = "Failed";
        }


    }
   
}