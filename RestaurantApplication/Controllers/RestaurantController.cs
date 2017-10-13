using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantApplication.Models;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace RestaurantApplication.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: Restaurant
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult GetRDetails()
        {
            List<RestaurantsBO> rsBo = new List<RestaurantsBO>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:60367/");
            client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/RestaurantApi/GetRestaurantsDtls").Result;
            if (response.IsSuccessStatusCode)
            {
                var EmpResponse = response.Content.ReadAsStringAsync().Result;
                rsBo = JsonConvert.DeserializeObject<List<RestaurantsBO>>(EmpResponse);

            }

                return View(rsBo);
        }
    }
}