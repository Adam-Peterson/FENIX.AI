using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace AzureMLAPI
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var client = new RestClient("https://ussouthcentral.services.azureml.net/workspaces/9d5c479f32b0474c9cd569ba02e4411c/services/e160e605c3b14d8f8a57d1860a0a3e5f/execute?api-version=2.0&details=true");
            //var request = new RestRequest(Method.POST);
           // request.AddHeader("Postman-Token", "b4df259c-8b4d-48a7-86bd-0276a127b823");
           // request.AddHeader("cache-control", "no-cache");
            //request.AddHeader("Content-Type", "application/json");
            //request.AddHeader("Authorization", "Bearer fSj9ISeXrDIfaie8RjSciJnfBnCYGixYWrkQVLzpjmgiDut1tr3ZP+g9qYVAvzxXlcpicCGchcOSWq3W2NAP4w==");
           // request.AddParameter("undefined", "{\r\n  \"Inputs\": {\r\n    \"input1\": {\r\n      \"ColumnNames\": [\r\n        \"ClientID\",\r\n        \"Client\",\r\n        \"Needed Hours\",\r\n        \"Industry\",\r\n        \"Rating\",\r\n        \"Consultant\"\r\n      ],\r\n      \"Values\": [\r\n        [\r\n          \"1\",\r\n          \"Client1\",\r\n          \"" + dti.Text + "\",\r\n          \"" + industryList.SelectedValue + "\",\r\n          \"0\",\r\n          \"1\"\r\n        ]\r\n      ]\r\n    }\r\n  },\r\n  \"GlobalParameters\": {}\r\n}", ParameterType.RequestBody);
           // IRestResponse response = client.Execute(request);
            //lblResults.Text = response.Content.ToString();
        }

        protected void lbPredict_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://ussouthcentral.services.azureml.net/workspaces/9d5c479f32b0474c9cd569ba02e4411c/services/e160e605c3b14d8f8a57d1860a0a3e5f/execute?api-version=2.0&details=true");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Postman-Token", "b4df259c-8b4d-48a7-86bd-0276a127b823");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer fSj9ISeXrDIfaie8RjSciJnfBnCYGixYWrkQVLzpjmgiDut1tr3ZP+g9qYVAvzxXlcpicCGchcOSWq3W2NAP4w==");
            request.AddParameter("undefined", "{\r\n  \"Inputs\": {\r\n    \"input1\": {\r\n      \"ColumnNames\": [\r\n        \"ClientID\",\r\n        \"Client\",\r\n        \"Needed Hours\",\r\n        \"Industry\",\r\n        \"Rating\",\r\n        \"Consultant\"\r\n      ],\r\n      \"Values\": [\r\n        [\r\n          \"1\",\r\n          \"Client1\",\r\n          \"" + dti.Text + "\",\r\n          \"" + industryList.SelectedValue + "\",\r\n          \"0\",\r\n          \"1\"\r\n        ]\r\n      ]\r\n    }\r\n  },\r\n  \"GlobalParameters\": {}\r\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            //lblResults.Text = response.Content.ToString();

            var results = JObject.Parse(response.Content);
            string prediction = results["Results"]["output1"]["value"]["Values"].ToString();
            prediction = prediction.Replace("[", "").Replace("]", "").Replace("\"", "");

           lblResults.Text = (prediction);
        }
    }
}