using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using RestSharp;
using Web.Models;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private const string vsoBaseUrl = "https://sda-iatec.visualstudio.com/defaultcollection/_apis";

        public ActionResult Index()
        {
            // construct HTTP REST client, configured with Basic authentication  
            var client = new RestSharp.RestClient(vsoBaseUrl)
            {
                Authenticator = new HttpBasicAuthenticator(
                    Security.Authentication.Username, 
                    Security.Authentication.Password)
            };

            // construct query for top 10 (most recent) changesets
            var request = new RestRequest("tfvc/changesets", Method.GET);
            request.AddQueryParameter("api-version", "1.0");
            request.AddQueryParameter("$top", "10");

            // execute query and parse into strongly-typed viewModel
            var response = client.Execute(request);
            var model = new HomeViewModel()
            {
                ChangesetResult = JsonConvert.DeserializeObject<ChangesetResult>(response.Content)
            };

            return View(model);
        }

        public ActionResult Projects()
        {

            var client = new RestSharp.RestClient(vsoBaseUrl)
            {
                Authenticator = new HttpBasicAuthenticator(
                Security.Authentication.Username,
                Security.Authentication.Password)
            };

            // construct query for top 10 (most recent) changesets
            var request = new RestRequest("projects", Method.GET);
            request.AddQueryParameter("api-version", "1.0");
            request.AddQueryParameter("stateFilter", "All");

            // execute query and parse into strongly-typed viewModel
            var response = client.Execute(request);
            var model = new ProjectsViewModel()
            {                
                ProjectResult = JsonConvert.DeserializeObject<ProjectResult>(response.Content)
            };

            return View(model);
            
        }
        

    }
}