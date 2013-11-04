using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class DisplayEvents : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);
        //Open the connection
        conn.Open();


        SqlCommand cmd = new SqlCommand("select * from Event", conn);

        SqlDataReader r = cmd.ExecuteReader();

        string output = "<table><tr><th>Event Name</th><th>Event Date</th><th>Event Time</th><th></th><th>EventDescription</th></tr>";
        
        while (r.Read())
        {
            output += "<tr>";
            output += "<td>" +r["EventName"] +"</td>" ;
            output += "<td>" + r["EventDate"].ToString().Substring(0, r["EventDate"].ToString().Length-0) + "</td>";
            output += "<td>" + r["EventTime"] +"</td>";
            output += "<td>" + r["EventDescription"].ToString() +"</td>";
            output += "<td><a href='DisplayGifts2.aspx?id=" + r["EventDescription"].ToString() + "'>Display Gifts</a></td>";
            output += "</tr>";
        }

        output += "</table>";
        innercontent.InnerHtml = output;
    }
}
   