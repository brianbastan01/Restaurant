using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantApplication.Models
{
    public class RestaurantsBO
    {

        public string RestaurantName { get; set; }
        public int ReviewCount { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int ZipCode { get; set; }
        public double AvgRating { get; set; }
    }
}