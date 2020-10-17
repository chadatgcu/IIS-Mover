// supports API calls

using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IIS_Mover
{
    class APICallService
    {
        public string MakeCall(String sMethod, String sURL)
        {
            string sResults = "";
            var vClient = new RestClient(sURL);
            vClient.Timeout = -1;
            RestRequest oRestRequest = new RestRequest();
            switch (sMethod.Trim().ToUpper())
            {
                case "GET":
                    oRestRequest = new RestRequest(Method.GET);
                    break;
                case "PUT":
                    oRestRequest = new RestRequest(Method.PUT);
                    break;
                case "POST":
                    oRestRequest = new RestRequest(Method.POST);
                    break;
                case "DELETE":
                    oRestRequest = new RestRequest(Method.DELETE);
                    break;
            }
            oRestRequest.AddHeader("Accept", "*/*");
            IRestResponse oResponse = vClient.Execute(oRestRequest);

            if (oResponse.IsSuccessful)
            {
                sResults = "Call results: oResponse.StatusCode.ToString()";
            } else
            {
                sResults = "Call failed.  Reason : " + oResponse.ResponseStatus.ToString();
            }
            return sResults;
        }
    }
}
