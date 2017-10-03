﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopGearApi.Test.Utils;
using TopGearApi.Domain.Models;
using System.Collections.Generic;

namespace TopGearApi.Test
{
    public class AgenciaControllerTest : BaseControllerTest<Agencia>
    {
        public AgenciaControllerTest()
        {
            this.path = "agencia";
        }

        [TestMethod]
        public void GetAgencia()
        {
            Get();
        }
    }
}
