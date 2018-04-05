using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class TestController : ApiController
    {
        public string Get(int id, string woot)
        {
            return "Get!";
        }

        public IHttpActionResult Post([FromBody]MojaKlasa model)
        {
            return Json(model);
        }

        public string Delete()
        {
            return "Delete!";
        }

        public string Patch()
        {
            return "Patch!";
        }
    }

    public class MojaKlasa
    {
        public string Woot { get; set; }
        public int Zoot { get; set; }
        public List<string> Toot { get; set; }
    }
}
