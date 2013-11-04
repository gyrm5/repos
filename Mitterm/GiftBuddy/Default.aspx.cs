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

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String fn;
        String path;
        string name = TextBox1.Text;
        string price = TextBox2.Text;
        string Location = TextBox3.Text;
        string Comment = TextBox4.Text;
        string Tag = DropDownList1.SelectedValue;

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);

        //Open the connection

       
            if (FileUpload1.HasFile)
            {
                byte[] imageB = new byte[FileUpload1.PostedFile.ContentLength];
                fn = Path.GetFileName(FileUpload1.FileName);
                FileUpload1.SaveAs(Server.MapPath("images") + "/" + fn);
                string dbpath = "http://localhost:61427/images/" + fn;

                conn.Open();

                //Declare the sql command
                SqlCommand cmd = new SqlCommand
                    ("Insert into Registry(Name,Price,Location,Comment,Tag,image_id)values('" + name + "','" + price + "','" + Location + "','" + Comment + "','" + Tag + "','" + dbpath + "')", conn);

                //Execute the insert query
                int x = cmd.ExecuteNonQuery();
                cmd.Dispose();
                //close the connection
                conn.Close();
                if (x != 0)
                {
                    Label6.Text = "Successfully Inserted";
                }
                else
                {
                    Label6.Text = "error";

                    imageB = FileUpload1.FileBytes;



                    test123.WebService ws = new test123.WebService();
                    string testing = ws.insertTable(imageB, "a", "a", "a", "a", "a");
                    // string testing  = ws.insertTable(imageB,'a','a','a','a','a');
                    //ServiceReference1.insertTableRequest giftdetails = new ServiceReference1.insertTableRequest();
                }
            }
        }
        
   






}




