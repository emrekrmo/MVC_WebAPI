using Microsoft.AspNet.Identity;
using MVC_EryazSoftwareTask.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MVC_EryazSoftwareTask.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Task()
        {
            return View();
        }

        public ActionResult Filter()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Filter(string t, string y, string plot)
        {
            string strJson = string.Empty;
            string filter = ("?t=" + t + "&y=" + y + "&plot=" + plot + "&apikey=79844872");
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.omdbapi.com/");

                var responseTask = client.GetAsync(filter);
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();

                    strJson = readTask.Result;
                }
            }

            OmdbAPIViewModel filteredResult = JsonConvert.DeserializeObject<OmdbAPIViewModel>(strJson);

            return View(filteredResult);
        }
    }
}