using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TopGearApi.DataAccess;
using TopGearApi.Domain.Models;
using TopGearApi.Models;

namespace TopGearApi.Controllers
{
    public class BaseController : ApiController
    {
        [NonAction]
        protected bool IsValid(string token)
        {
            return TopGearDA<Usuario>.CheckToken(token);
        }
    }
}
