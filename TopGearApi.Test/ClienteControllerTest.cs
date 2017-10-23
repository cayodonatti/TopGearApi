using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopGearApi.Domain.Models;

namespace TopGearApi.Test
{
    public class ClienteControllerTest : BaseControllerTest<Cliente>
    {
        public ClienteControllerTest()
        {
            this.path = "cliente";
        }
    }
}
