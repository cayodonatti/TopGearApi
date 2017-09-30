﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopGearApi.Domain.Models;

namespace TopGearApi.DataAccess
{
    public class LocacaoDA : TopGearDA<Locacao>
    {
        public static Locacao GetAtivaByCarro(int carroId)
        {
            using (var context = GetContext())
            {
                return context.Set<Locacao>().Where(l => l.CarroId == carroId && !l.Finalizada).FirstOrDefault();
            }
        }
    }
}