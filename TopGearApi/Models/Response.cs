using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TopGearApi.Models
{
    public class Response<T>
    {
        public bool Sucesso { get; set; }

        public T Dados { get; set; }
    }
}