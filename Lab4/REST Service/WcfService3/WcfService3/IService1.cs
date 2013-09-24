using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace WcfService3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface calculator
    {

        [OperationContract]
    
    [WebInvoke(Method = "GET", ResponseFormat= WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "Add/{a}/{b}" )]

        String Add(string a,string b); 

        [OperationContract]
     
    [WebInvoke(Method = "GET", ResponseFormat= WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "Subtract/{a}/{b}")]

        String Subtract(string a, string b);

        [OperationContract]
     
    [WebInvoke(Method = "GET", ResponseFormat= WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "Multiply/{a}/{b}")]

        String Multiply(string a, string b);
        
        [OperationContract]
     
    [WebInvoke(Method = "GET", ResponseFormat= WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "Divide/{a}/{b}")]

        String Divide(string a, string b);

        // TODO: Add your service operations here
    }
}

