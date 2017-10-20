using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopGearApi.Access;
using TopGearApi.Domain.Models;
using TopGearApi.Promotions;

namespace TopGearApi.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Promotion p = new Promotion
            {
                CategoriaId = TopGearApi<List<Categoria>>.Get("categoria").Dados.FirstOrDefault().Id,
                Validade = new DateTime(2017, 12, 31),
                Valor = 499.99,
                QtdDias = 4
            };

            PromotionBusController.PostPromotion(p);

            Promotion p2 = PromotionBusController.GetPromotion();

            System.Console.WriteLine("Valor: " + p2.Valor + ", QtdDias: " + p2.QtdDias);
            System.Console.ReadLine();
        }
    }
}
