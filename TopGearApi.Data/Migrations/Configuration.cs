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
            context.Carro.AddOrUpdate(
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
                },
                new Carro
                {
                    Id = 3,
                    Marca = "Volkswagen",
                    Modelo = "Gol",
                    Placa = "KHJ5I53",
                    Ano = 1998
                },
                new Carro
                {
                    Id = 4,
                    Marca = "Porsche",
                    Modelo = "Limousine",
                    Placa = "KSJ9123",
                    Ano = 2014
                },
                new Carro
                {
                    Id = 5,
                    Marca = "Ferrari",
                    Modelo = "Baccardi",
                    Placa = "MSI2342",
                    Ano = 2017
                },
                new Carro
                {
                    Id = 3,
                    Marca = "Troller",
                    Modelo = "Troller",
                    Placa = "JSJ1231",
                    Ano = 2014
                }
                );

            context.Agencia.AddOrUpdate(
                new Agencia
                {
                    Id = 1,
                    Rua = "Rua Agenor Silva",
                    Numero = 150,
                    Bairro = "Manguinhos",
                    Cidade = "Serra",
                    Estado = "ES"
                },
                new Agencia
                {
                    Id = 2,
                    Rua = "Avenida Xablau",
                    Numero = 980,
                    Bairro = "Ibes",
                    Cidade = "Vila Velha",
                    Estado = "ES"
                }
                );

            context.Cliente.AddOrUpdate(
                new Cliente
                {
                    Id = 1,
                    Nome = "Cayo Donatti",
                    CPF = "00000000272",
                    Endereco = "Rua X",
                    Telefone = "2733263638",
                    Cartao = "8888777766665555"
                },
                new Cliente
                {
                    Id = 2,
                    Nome = "Ricardo Sabaini",
                    CPF = "00000000191",
                    Endereco = "Rua Y",
                    Telefone = "2764654852",
                    Cartao = "1111222233334444"
                }
                );

            context.Categoria.AddOrUpdate(
                new Categoria
                {
                    Id = 1,
                    Descricao = "Luxo",
                    Preco = 250.15,
                    Itens = "Ar Condicionado, Vidro Elétrico, Câmbio Automático, Direção Hidráulica"
                },
                new Categoria
                {
                    Id = 2,
                    Descricao = "Esporte",
                    Preco = 140.57,
                    Itens = "Ar Condicionado, Vidro Elétrico, Direção Hidráulica"
                },
                new Categoria
                {
                    Id = 3,
                    Descricao = "Popular",
                    Preco = 99.00,
                    Itens = "Direção Hidráulica"
                }
                );
        }
    }
}
