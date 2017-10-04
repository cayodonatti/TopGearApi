using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TopGearApi.Models
{
    public class BaseRequest
    {
        [Required]
        public string Token { get; set; }
    }
}