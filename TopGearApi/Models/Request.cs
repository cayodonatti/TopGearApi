using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TopGearApi.Models
{
    public class Request<T>
    {
        public string Token { get; set; }

        public T Dados { get; set; }
    }
}