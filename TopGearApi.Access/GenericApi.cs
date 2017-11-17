using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TopGearApi.Access
{
    public class GenericApi
    {
        protected GenericApi() { }

        protected static readonly string Token = ConfigurationManager.AppSettings["Token"];
        protected static readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri(ConfigurationManager.AppSettings["baseUrlTeste"])
        };
    }
}
