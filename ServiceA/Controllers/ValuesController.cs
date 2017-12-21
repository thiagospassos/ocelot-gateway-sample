using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ServiceA.Controllers
{
    [Route("")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<ServiceAModel> Get()
        {
            return new []
            {
                new ServiceAModel{Name = "Google",Url = "https://www.google.com.au"},
                new ServiceAModel{Name = "SSW",Url = "https://www.ssw.com.au"},
                new ServiceAModel{Name = "eBay",Url = "https://www.ebay.com.au/"},
            };
        }
    }

    public class ServiceAModel
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
