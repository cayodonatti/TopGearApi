using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TopGearApi.Models
{
    public class LoginRequest : BaseRequest
    {
        public string CPF { get; set; }
        public string Senha { get; set; }
    }
}