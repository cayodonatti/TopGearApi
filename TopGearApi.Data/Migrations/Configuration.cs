namespace TopGearApi.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TopGearApi.Domain.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TopGearApi.Data.TopGearContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TopGearApi.Data.TopGearContext context)
        {
            context.Itens.AddOrUpdate(
                x => x.Descricao,
                new Item
                {
                    Descricao = "Ar Condicionado"
                },
                new Item
                {
                    Descricao = "Teto Solar"
                }
                );

            context.Agencia.AddOrUpdate(
                x => x.Nome,
                new Agencia
                {
                    Id = 1,
                    Nome = "Vix Car",
                    Rua = "Rua Agenor Silva",
                    Numero = 150,
                    Bairro = "Centro",
                    Cidade = "Vitória",
                    Estado = "ES"
                },
                new Agencia
                {
                    Id = 2,
                    Nome = "Copacabana Palace Car",
                    Rua = "Avenida Xablau",
                    Numero = 980,
                    Bairro = "Copacabaa",
                    Cidade = "Rio de Janeiro",
                    Estado = "RJ"
                },
                new Agencia
                {
                    Id = 3,
                    Nome = "São Paulo Car",
                    Rua = "Avenida Bandeirantes",
                    Numero = 1234,
                    Bairro = "Zona Oeste",
                    Cidade = "São Paulo",
                    Estado = "SP"
                }
                );

            context.Categoria.AddOrUpdate(
                x => x.Descricao,
                new Categoria
                {
                    Id = 1,
                    Descricao = "Luxo",
                    Preco = 250.15
                },
                new Categoria
                {
                    Id = 2,
                    Descricao = "Esporte",
                    Preco = 140.57
                },
                new Categoria
                {
                    Id = 3,
                    Descricao = "Popular",
                    Preco = 99.00
                }
                );

            context.SaveChanges();

            context.Carro.AddOrUpdate(
                x => x.Placa,
                new Carro
                {
                    Marca = "Chevrolet",
                    Modelo = "Corsa",
                    Placa = "MST1231",
                    Ano = 2017,
                    AgenciaId = context.Agencia.Where(a => a.Nome == "São Paulo Car").FirstOrDefault().Id,
                    CategoriaId = context.Categoria.Where(c => c.Descricao == "Popular").FirstOrDefault().Id
                },
                new Carro
                {
                    Marca = "Chevrolet",
                    Modelo = "Camaro",
                    Placa = "ASD1262",
                    Ano = 2015,
                    AgenciaId = context.Agencia.Where(a => a.Nome == "Copacabana Palace Car").FirstOrDefault().Id,
                    CategoriaId = context.Categoria.Where(c => c.Descricao == "Luxo").FirstOrDefault().Id
                },
                new Carro
                {
                    Marca = "Volkswagen",
                    Modelo = "Gol",
                    Placa = "KHJ5I53",
                    Ano = 1998,
                    AgenciaId = context.Agencia.Where(a => a.Nome == "Copacabana Palace Car").FirstOrDefault().Id,
                    CategoriaId = context.Categoria.Where(c => c.Descricao == "Popular").FirstOrDefault().Id
                },
                new Carro
                {
                    Marca = "Fiat",
                    Modelo = "Palio",
                    Placa = "IEJ9303",
                    Ano = 2010,
                    AgenciaId = context.Agencia.Where(a => a.Nome == "Copacabana Palace Car").FirstOrDefault().Id,
                    CategoriaId = context.Categoria.Where(c => c.Descricao == "Popular").FirstOrDefault().Id
                },
                new Carro
                {
                    Marca = "Volkswagen",
                    Modelo = "Uno",
                    Placa = "ENH3123",
                    Ano = 1998,
                    AgenciaId = context.Agencia.Where(a => a.Nome == "São Paulo Car").FirstOrDefault().Id,
                    CategoriaId = context.Categoria.Where(c => c.Descricao == "Popular").FirstOrDefault().Id
                },
                new Carro
                {
                    Marca = "Mercedes",
                    Modelo = "Mercedes AMG",
                    Placa = "IJN3421",
                    Ano = 2016,
                    AgenciaId = context.Agencia.Where(a => a.Nome == "Copacabana Palace Car").FirstOrDefault().Id,
                    CategoriaId = context.Categoria.Where(c => c.Descricao == "Luxo").FirstOrDefault().Id
                },
                new Carro
                {
                    Marca = "Porsche",
                    Modelo = "Limousine",
                    Placa = "KSJ9123",
                    Ano = 2014,
                    AgenciaId = context.Agencia.Where(a => a.Nome == "Vix Car").FirstOrDefault().Id,
                    CategoriaId = context.Categoria.Where(c => c.Descricao == "Luxo").FirstOrDefault().Id
                },
                new Carro
                {
                    Marca = "Volkswagen",
                    Modelo = "Fusca",
                    Placa = "ASD1231",
                    Ano = 1990,
                    AgenciaId = context.Agencia.Where(a => a.Nome == "Vix Car").FirstOrDefault().Id,
                    CategoriaId = context.Categoria.Where(c => c.Descricao == "Popular").FirstOrDefault().Id
                },
                new Carro
                {
                    Marca = "Jeep",
                    Modelo = "Jeep",
                    Placa = "AED0434",
                    Ano = 2017,
                    AgenciaId = context.Agencia.Where(a => a.Nome == "São Paulo Car").FirstOrDefault().Id,
                    CategoriaId = context.Categoria.Where(c => c.Descricao == "Esporte").FirstOrDefault().Id
                },
                new Carro
                {
                    Marca = "Chevrolet",
                    Modelo = "Corolla",
                    Placa = "IKE0123",
                    Ano = 2014,
                    AgenciaId = context.Agencia.Where(a => a.Nome == "Vix Car").FirstOrDefault().Id,
                    CategoriaId = context.Categoria.Where(c => c.Descricao == "Popular").FirstOrDefault().Id
                },
                new Carro
                {
                    Marca = "SpaceX",
                    Modelo = "Falcon II",
                    Placa = "IEJ3940",
                    Ano = 2017,
                    AgenciaId = context.Agencia.Where(a => a.Nome == "Vix Car").FirstOrDefault().Id,
                    CategoriaId = context.Categoria.Where(c => c.Descricao == "Esporte").FirstOrDefault().Id
                },
                new Carro
                {
                    Marca = "Ferrari",
                    Modelo = "Baccardi",
                    Placa = "MSI2342",
                    Ano = 2017,
                    AgenciaId = context.Agencia.Where(a => a.Nome == "Vix Car").FirstOrDefault().Id,
                    CategoriaId = context.Categoria.Where(c => c.Descricao == "Luxo").FirstOrDefault().Id
                },
                new Carro
                {
                    Marca = "Troller",
                    Modelo = "Troller",
                    Placa = "JSJ1231",
                    Ano = 2014,
                    AgenciaId = context.Agencia.Where(a => a.Nome == "Vix Car").FirstOrDefault().Id,
                    CategoriaId = context.Categoria.Where(c => c.Descricao == "Esporte").FirstOrDefault().Id
                }
                );

            context.Cliente.AddOrUpdate(
                x => x.CPF,
                new Cliente
                {
                    Nome = "Cayo Donatti",
                    CPF = "00000000272",
                    Endereco = "Rua X",
                    Telefone = "2733263638",
                    Cartao = "8888777766665555"
                },
                new Cliente
                {
                    Nome = "Ricardo Sabaini",
                    CPF = "00000000191",
                    Endereco = "Rua Y",
                    Telefone = "2764654852",
                    Cartao = "1111222233334444"
                }
                );

            context.SaveChanges();

            context.Usuario.AddOrUpdate(
                x => x.Nome,
                new Usuario
                {
                    Nome = "Admin",
                    Token = "CorrectHorseBatteryStaple"
                }
                );

            context.Locacao.AddOrUpdate(
                x => x.Retirada,
                new Locacao
                {
                    CarroId = context.Carro.Where(c => c.Placa == "JSJ1231").FirstOrDefault().Id,
                    Retirada = new DateTime(2017, 10, 03),
                    Entrega = new DateTime(2017, 10, 07),
                    ClienteId = context.Cliente.Where(c => c.CPF == "00000000272").FirstOrDefault().Id,
                    Agencia_RetiradaId = context.Agencia.Where(a => a.Nome == "São Paulo Car").FirstOrDefault().Id,
                    Agencia_EntregaId = context.Agencia.Where(a => a.Nome == "Vix Car").FirstOrDefault().Id,
                    Finalizada = false
                }
                );
        }
    }
}
