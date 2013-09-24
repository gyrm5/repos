using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace WcfService3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : calculator
    {
        public string Add(string a, string b)
        {
            int c = Convert.ToInt32(a);
            int d = Convert.ToInt32(b);
            int sum = c + d;
            string result= Convert.ToString(sum);
            return result;

        }

        public string Subtract(string a, string b)
        {
            int c = Convert.ToInt32(a);
            int d = Convert.ToInt32(b);
            int sub = c - d;
            string result = Convert.ToString(sub);
            return result;
        }

        public string Multiply(string a, string b)
        {
            int c = Convert.ToInt32(a);
            int d = Convert.ToInt32(b);
            int product = c * d;
            string result = Convert.ToString(product);
            return result;

        }
        
        public string Divide(string a, string b)
        {
            int c = Convert.ToInt32(a);
            int d = Convert.ToInt32(b);
            int reminder = c / d;
            string result = Convert.ToString(reminder);
            return result;

        }

           }


   
}

