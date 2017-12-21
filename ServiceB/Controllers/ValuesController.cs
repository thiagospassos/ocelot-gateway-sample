using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ServiceB.Controllers
{
    [Route("")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<ServiceBModel> Get()
        {
            return new []
            {
                new ServiceBModel { Id = Guid.NewGuid(), Subject = "Why Azure?", Body = "..." },
                new ServiceBModel { Id = Guid.NewGuid(), Subject = "Docker is Awesome", Body = "..." },
                new ServiceBModel { Id = Guid.NewGuid(), Subject = "Kubernetes is Amazing", Body = "..." }

            };
        }
    }

    public class ServiceBModel
    {
        public Guid Id { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
