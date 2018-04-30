using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace WinRestClient
{
    public enum HttpMethod
    { 
        GET, POST, PUT, DELETE
    }

    public class RestClient
    {

        public string endPoint { get; set; }

        public HttpMethod httpMethod { get; set; }


        public RestClient()
        {
            endPoint = string.Empty;
            httpMethod = HttpMethod.GET;
        }


        public string RunRequest(string APIKey)
        {
            string strResponseValue = string.Empty;
            bool respOK = true;

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(endPoint);
            req.Method = httpMethod.ToString();

            req.Headers["APIKey"] = APIKey;//"DFSDFSD7G8FGDF87GDF8F";

            using(HttpWebResponse resp = (HttpWebResponse)req.GetResponse())
            {

                if (resp.StatusCode != HttpStatusCode.OK)
                {
                    respOK = false;
                    strResponseValue = "error : " + resp.StatusCode + " : " + resp.StatusDescription;
                }

                if (respOK == true)
                { 
                    using(Stream respStream = resp.GetResponseStream())
                    {
                        if (respStream != null)
                        {
                            using (StreamReader streamReader = new StreamReader(respStream))
                            {
                                strResponseValue = streamReader.ReadToEnd();
                            }//end of streamReader
                        }
                    }// end of respStream
                }
            }

            return strResponseValue;
        }//end of RunRequest()

    }//end of class RestClient


}
