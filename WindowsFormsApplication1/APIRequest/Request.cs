using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public static class Request
    {
        static string URL = "https://jam.document.fish/api/1.1/obj/importData1";

        private static RestClient client = new RestClient(URL);

        static string BEARERTOKEN = "d82306e25fe54df5857efd427bc7014a";

        public static string PostRequest(List<FishRecord> requestList)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            RestRequest request = new RestRequest( Method.POST);

            foreach (var post in requestList)
            {
                request.AddJsonBody(post);
                //client.AddDefaultHeader("Authorization", string.Format("Bearer {0}", BEARERTOKEN));
                //client.Execute(request);
                request.RequestFormat = RestSharp.DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", "Bearer " + BEARERTOKEN);
                client.Execute(request);

            }

            return "Record has been Successfully Uploaded."; //
           
        }

    }
}
