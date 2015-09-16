using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class TestController : ApiController
    {

        [HttpGet]
        public string GetTest()
        {
            return "test";
        }

        [HttpPost]
        public string PostTest([FromBody]PostObject hello)
        {
            return "Sucess!";
        }

    }
}
