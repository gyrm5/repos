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


public partial class DisplayGifts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);

        //Open the connection
        conn.Open();

        string price = "";
        string Name2 = "";
        string Location = "";
        string Comment = "";
        string Tag = DropDownList2.SelectedValue;
        string url = "";

        SqlCommand cmd = new SqlCommand("Select * From Registry where Tag='" + Tag + "'", conn);
        SqlDataReader reader = cmd.ExecuteReader();

        string var1 = "<table><tr><th>image_id</th><th>Price</th><th>Name2</th><th>Location</th><th>Comment</th></tr>";
        while (reader.Read())
        {

            var1 += "<tr>";
            var1 += "<td>" + reader["price"] + "</td>";
            var1 += "<td>" + reader["Name"] + "</td>";
            var1 += "<td>" + reader["Location"] + "</td>";
            var1 += "<td>" + reader["Comment"] + "</td>";
            url = reader["image_id"].ToString();
            var1 += "<td>" + "<img width = '100px' src='" + url + "' />" + "</td>";
            var1 += "</tr>";

        }
        var1 += "</table>";

        //price = price + ";" + reader["Price"];
        //Name2 = Name2 + ";" + reader["Name"].ToString();
        //Location = Location + ";" + reader["Location"].ToString();
        //Comment = Comment + ";" + reader["Comment"].ToString();
        //url = reader["image_id"].ToString();

        reader.Close();
        //close the connection
        conn.Close();


        string i = "<img src='" + url + "' />";

        imgurl.InnerHtml = var1;


    }
}