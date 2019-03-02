using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace USSDIrancell
{
    public static class Manager
    {
        private static string userID = "userid=app1";
        private static string password = "password=app1";
        private static string MSC = "MSC=9350000";

 
        public static void Post(string strURI, string MSISDN, string contentstring)
        {

            var request = (HttpWebRequest)WebRequest.Create(strURI);

            var postData = "a=4";
            postData += "&b=6";
            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
        }
     

    }
}
