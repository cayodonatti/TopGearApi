using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TopGearApi.Domain.Models;

namespace TopGearApi.Models
{
    public class RequestCarrosDisponiveis : BaseRequest
    {
        [Required]
        public DateTime Inicial { get; set; }
        [Required]
        public DateTime Final { get; set; }
        public int? AgenciaId { get; set; }
    }
}