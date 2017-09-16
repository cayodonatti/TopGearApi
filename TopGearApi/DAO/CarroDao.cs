using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TopGearApi.Models;

namespace TopGearApi.DAO
{
    public class CarroDao
    {
        public List<Carro> Carros;

        public CarroDao()
        {
            Carros = new List<Carro>
            {
                new Carro
                {
                    Id = 1,
                    Marca = "Chevrolet",
                    Modelo = "Corsa",
                    Placa = "MST1231",
                    Ano = 2017
                },
                new Carro
                {
                    Id = 2,
                    Marca = "Chevrolet",
                    Modelo = "Camaro",
                    Placa = "ASD1262",
                    Ano = 2015
                }
                ,
                new Carro
                {
                    Id = 3,
                    Marca = "Volkswagen",
                    Modelo = "Gol",
                    Placa = "KHJ5I53",
                    Ano = 1998
                }
            };
        }

        public List<Carro> Obter()
        {
            return Carros;
        }

        public Carro Obter(int id)
        {
            return Carros.Where(car => car.Id == id).First();
        }
    }
}