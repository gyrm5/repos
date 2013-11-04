using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.ComponentModel;
using System.ServiceModel;
using System.IdentityModel;
using System.Net;
using System.Web.Script.Services;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Uncomment the following line if using designed components 
       // InitializeComponent(); 
    }

    
    [WebMethod]
    public string queryRegisrty(string Tag) {

        //Declare Connection by passing the connection string from the web config file
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);

        //Open the connection
        conn.Open();

        string price = "";
        string Name2 = "";
        string Location = "";
        string Comment = "";
        SqlCommand cmd = new SqlCommand("Select * From Registry where Tag='" + Tag + "'", conn);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            price = price+ ";" + reader["Price"];
            Name2 = Name2 + ";" + reader["Name"].ToString();
            Location = Location+ ";" + reader["Location"].ToString();
            Comment = Comment + ";" + reader["Comment"].ToString();
        }
        reader.Close();
        //close the connection
        conn.Close();

        return "info: " + price + "," + Name2 + "," + Location + "," + Comment ;

    }

    [WebMethod]
    public string insertTable(byte[] imgarray, string name, string price, string Location, string Comment, string Tag)
    {
        //Declare Connection by passing the connection string from the web config file
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);

        //Open the connection
        conn.Open();

        //Declare the sql command
        SqlCommand cmd = new SqlCommand
            ("Insert into Registry(Name,Price,Location,Comment,Tag,imagecontent)values('" + name + "','" + price + "','" + Location + "','" + Comment + "','" + Tag + "','"+Convert.ToByte(imgarray.ToString())+"')", conn);

        //Execute the insert query
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        //close the connection
        conn.Close();

        return "Successfully Inserted";

    }

    [WebMethod]
    public string deleteTable(string name)
    {
        //Declare Connection by passing the connection string from the web config file
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);

        //Open the connection
        conn.Open();

        //Declare the sql command
        SqlCommand cmd = new SqlCommand("Delete From Registry Where name= '" + name + "'", conn);

        //Execute the insert query
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        //close the connection
        conn.Close();

        return "Success delete";
    }


   [WebMethod, ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string HelloWorld()
    {
        byte[] bytes;
        if (Context.Request.Files[0] != null && Context.Request.Files[0].InputStream != null)
        {
            bytes = ReadStream(Context.Request.Files[0].InputStream);

            // Read the file and convert it to Byte Array
            string filePath = Context.Request.Files[0].FileName;
            string filename = Path.GetFileName(filePath);
            string ext = Path.GetExtension(filename);
            string contenttype = String.Empty;

            //Set the contenttype based on File Extension
            switch (ext)
            {
                case ".doc":
                    contenttype = "application/vnd.ms-word";
                    break;
                case ".docx":
                    contenttype = "application/vnd.ms-word";
                    break;
                case ".xls":
                    contenttype = "application/vnd.ms-excel";
                    break;
                case ".xlsx":
                    contenttype = "application/vnd.ms-excel";
                    break;
                case ".jpg":
                    contenttype = "image/jpg";
                    break;
                case ".png":
                    contenttype = "image/png";
                    break;
                case ".gif":
                    contenttype = "image/gif";
                    break;
                case ".pdf":
                    contenttype = "application/pdf";
                    break;
            }
            if (contenttype != String.Empty)
            {
                Stream fs = Context.Request.Files[0].InputStream;
                BinaryReader br = new BinaryReader(fs);

                //insert the file into database
                string strQuery = "insert into dbo.Registry(ImgName, ContentType, Data) values (@ImgName, @ContentType, @Data)";
                SqlCommand cmd = new SqlCommand(strQuery);
                cmd.Parameters.Add("@ImgName", SqlDbType.VarChar).Value = filename;
                cmd.Parameters.Add("@ContentType", SqlDbType.VarChar).Value = contenttype;
                cmd.Parameters.Add("@Data", SqlDbType.Binary).Value = bytes;
                InsertUpdateData(cmd);
            }
            else
            {
            }
        }
        return "Hello World";
    }

    public static byte[] ReadStream(Stream input)
    {
        byte[] buffer = new byte[16 * 1024];
        using (MemoryStream ms = new MemoryStream())
        {
            int read;
            while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                ms.Write(buffer, 0, read);
            }
            return ms.ToArray();
        }
    }

    private Boolean InsertUpdateData(SqlCommand cmd)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);
        cmd.CommandType = CommandType.Text;
        cmd.Connection = conn;
        try
        {
            conn.Open();
            cmd.ExecuteNonQuery();
            return true;
        }
        catch (Exception ex)
        {
            //Response.Write(ex.Message);
            return false;
        }
        finally
        {
            conn.Close();
            conn.Dispose();
        }
    }
}