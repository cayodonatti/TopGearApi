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

            context.Carro.AddOrUpdate(
                x => x.Placa,
                new Carro
                {
                    Marca = "Chevrolet",
                    Modelo = "Corsa",
                    Placa = "MST1231",
                    Ano = 2017,
                    AgenciaId = 1,
                    CategoriaId = 3
                },
                new Carro
                {
                    Marca = "Chevrolet",
                    Modelo = "Camaro",
                    Placa = "ASD1262",
                    Ano = 2015,
                    AgenciaId = 1,
                    CategoriaId = 1
                },
                new Carro
                {
                    Marca = "Volkswagen",
                    Modelo = "Gol",
                    Placa = "KHJ5I53",
                    Ano = 1998,
                    AgenciaId = 1,
                    CategoriaId = 3
                },
                new Carro
                {
                    Marca = "Porsche",
                    Modelo = "Limousine",
                    Placa = "KSJ9123",
                    Ano = 2014,
                    AgenciaId = 2,
                    CategoriaId = 1
                },
                new Carro
                {
                    Marca = "Ferrari",
                    Modelo = "Baccardi",
                    Placa = "MSI2342",
                    Ano = 2017,
                    AgenciaId = 2,
                    CategoriaId = 2
                },
                new Carro
                {
                    Marca = "Troller",
                    Modelo = "Troller",
                    Placa = "JSJ1231",
                    Ano = 2014,
                    AgenciaId = 2,
                    CategoriaId = 2
                }
                );

            context.Agencia.AddOrUpdate(
                x => x.Nome,
                new Agencia
                {
                    Nome = "IFES Serra",
                    Rua = "Rua Agenor Silva",
                    Numero = 150,
                    Bairro = "Manguinhos",
                    Cidade = "Serra",
                    Estado = "ES"
                },
                new Agencia
                {
                    Nome = "Shopping Vila Velha",
                    Rua = "Avenida Xablau",
                    Numero = 980,
                    Bairro = "Ibes",
                    Cidade = "Vila Velha",
                    Estado = "ES"
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

            context.Categoria.AddOrUpdate(
                x => x.Descricao,
                new Categoria
                {
                    Descricao = "Luxo",
                    Preco = 250.15
                },
                new Categoria
                {
                    Descricao = "Esporte",
                    Preco = 140.57
                },
                new Categoria
                {
                    Descricao = "Popular",
                    Preco = 99.00
                }
                );

            context.Usuario.AddOrUpdate(
                x => x.Nome,
                new Usuario
                {
                    Nome = "Admin",
                    Token = "CorrectHorseBatteryStaple"
                }
                );
            
        }
    }
}
