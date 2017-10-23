﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopGearApi.Domain.Models;

namespace TopGearApi.Test
{
    [TestClass]
    public class CategoriaControllerTest : BaseControllerTest<Categoria>
    {
        public CategoriaControllerTest()
        {
            this.path = "categoria";
        }
    }
}
