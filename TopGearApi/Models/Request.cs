﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TopGearApi.Models
{
    public class Request<T> : BaseRequest
    {
        public T Dados { get; set; }
    }
}