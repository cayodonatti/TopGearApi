using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace TopGearApi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        [System.Web.Http.HttpGet]
        [Route("Test")]
        public IHttpActionResult Obter()
        {
            /*var content = JsonConvert.SerializeObject(new { ab = "teste1", cd = "teste2 " });

            return base.Json(content);*/
            // Then I return the list
            return new JsonResult { Data = new { ab = "teste1", cd = "teste2 " } };
        }
    }
}
