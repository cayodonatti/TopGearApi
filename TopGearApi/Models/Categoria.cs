﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TopGearApi.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required]
        public double Preco { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public string Itens { get; set; }
    }
}