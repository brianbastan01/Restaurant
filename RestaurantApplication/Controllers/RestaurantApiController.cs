using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestaurantApplication.Models;

namespace RestaurantApplication.Controllers
{
    public class RestaurantApiController : ApiController
    {

        [HttpGet]
        public List<RestaurantsBO> GetRestaurantsDtls()
        {

            List<RestaurantsBO> restaurantsBOList = new List<RestaurantsBO>() {
             new RestaurantsBO() {
            RestaurantName = "Tst Name",
            ReviewCount = 1,
            latitude = "123.6",
            longitude = "123.66",
            city = "City",
            state = "State1",
            ZipCode = 12333,
            AvgRating = 12.3,
        },
               new RestaurantsBO() {
            RestaurantName = "Tst Name1",
            ReviewCount = 1,
            latitude = "123.6",
            longitude = "123.66",
            city = "City",
            state = "State1",
            ZipCode = 12333,
            AvgRating = 10.3,
        },
               new RestaurantsBO() {
            RestaurantName = "Tst Name2",
            ReviewCount = 1,
            latitude = "123.6",
            longitude = "123.66",
            city = "City",
            state = "State1",
            ZipCode = 12333,
            AvgRating = 11.3,
        }

        };
            
            return restaurantsBOList;
        }



    }
}
