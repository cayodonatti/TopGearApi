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
            context.Item.AddOrUpdate(
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
                    UrlImagem = "http://img2.icarros.com/dbimg/imgmodelo/2/134_4",
                    AgenciaId = context.Agencia.Where(a => a.Nome == "São Paulo Car").FirstOrDefault().Id,
                    CategoriaId = context.Categoria.Where(c => c.Descricao == "Popular").FirstOrDefault().Id
                },
                new Carro
                {
                    Marca = "Chevrolet",
                    Modelo = "Camaro",
                    Placa = "ASD1262",
                    Ano = 2015,
                    UrlImagem = "http://www.chevrolet.com/content/dam/chevrolet/na/us/english/index/vehicles/2018/performance/camaro/mov/01-images/2018-camaro-2lt-gd1.jpeg?imwidth=600",
                    AgenciaId = context.Agencia.Where(a => a.Nome == "Copacabana Palace Car").FirstOrDefault().Id,
                    CategoriaId = context.Categoria.Where(c => c.Descricao == "Luxo").FirstOrDefault().Id
                },
                new Carro
                {
                    Marca = "Volkswagen",
                    Modelo = "Gol",
                    Placa = "KHJ5I53",
                    Ano = 1998,
                    UrlImagem = "http://s2.glbimg.com/AZvvHdRFa0N8GdkR-5C0B25678M=/e.glbimg.com/og/ed/f/original/2016/02/22/goldianteira.jpg",
                    AgenciaId = context.Agencia.Where(a => a.Nome == "Copacabana Palace Car").FirstOrDefault().Id,
                    CategoriaId = context.Categoria.Where(c => c.Descricao == "Popular").FirstOrDefault().Id
                },
                new Carro
                {
                    Marca = "Fiat",
                    Modelo = "Palio",
                    Placa = "IEJ9303",
                    UrlImagem = "http://s2.glbimg.com/AGay4FueHIo419fVatvFfYsr6VY=/620x380/e.glbimg.com/og/ed/f/original/2015/12/01/fiat-palio-fire.jpg",
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
                    UrlImagem = "http://motordream.uol.com.br/upload/4(375).jpg",
                    AgenciaId = context.Agencia.Where(a => a.Nome == "São Paulo Car").FirstOrDefault().Id,
                    CategoriaId = context.Categoria.Where(c => c.Descricao == "Popular").FirstOrDefault().Id
                },
                new Carro
                {
                    Marca = "Mercedes",
                    Modelo = "Mercedes AMG",
                    Placa = "IJN3421",
                    Ano = 2016,
                    UrlImagem = "https://cnet4.cbsistatic.com/img/6Vw_-GI36f5rqtpQYTytNxmuWgQ=/770x433/2017/01/08/59ae5b63-3a2f-42f4-a3a2-123a7241567a/2018-mercedes-amg-gt-c-edition-50-6.jpg",
                    AgenciaId = context.Agencia.Where(a => a.Nome == "Copacabana Palace Car").FirstOrDefault().Id,
                    CategoriaId = context.Categoria.Where(c => c.Descricao == "Luxo").FirstOrDefault().Id
                },
                new Carro
                {
                    Marca = "Porsche",
                    Modelo = "Limousine",
                    Placa = "KSJ9123",
                    UrlImagem = "http://www.exoticarhire.com.au/wp-content/uploads/2014/05/0.jpg",
                    Ano = 2014,
                    AgenciaId = context.Agencia.Where(a => a.Nome == "Vix Car").FirstOrDefault().Id,
                    CategoriaId = context.Categoria.Where(c => c.Descricao == "Luxo").FirstOrDefault().Id
                },
                new Carro
                {
                    Marca = "Volkswagen",
                    Modelo = "Fusca",
                    Placa = "ASD1231",
                    UrlImagem = "https://www.flatout.com.br/wp-content/uploads/2016/04/herbie-fusca-turbinado-1.jpg",
                    Ano = 1990,
                    AgenciaId = context.Agencia.Where(a => a.Nome == "Vix Car").FirstOrDefault().Id,
                    CategoriaId = context.Categoria.Where(c => c.Descricao == "Popular").FirstOrDefault().Id
                },
                new Carro
                {
                    Marca = "Jeep",
                    Modelo = "Jeep",
                    Placa = "AED0434",
                    UrlImagem = "http://s3-ap-southeast-2.amazonaws.com/assets-public/jeep-com-au/vehicles/wrangler/colorizer/sport.jpg",
                    Ano = 2017,
                    AgenciaId = context.Agencia.Where(a => a.Nome == "São Paulo Car").FirstOrDefault().Id,
                    CategoriaId = context.Categoria.Where(c => c.Descricao == "Esporte").FirstOrDefault().Id
                },
                new Carro
                {
                    Marca = "Chevrolet",
                    Modelo = "Corolla",
                    Placa = "IKE0123",
                    UrlImagem = "http://triautoautopecas.com.br/media/catalog/category/Corolla.jpg",
                    Ano = 2014,
                    AgenciaId = context.Agencia.Where(a => a.Nome == "Vix Car").FirstOrDefault().Id,
                    CategoriaId = context.Categoria.Where(c => c.Descricao == "Popular").FirstOrDefault().Id
                },
                new Carro
                {
                    Marca = "SpaceX",
                    Modelo = "Falcon II",
                    Placa = "IEJ3940",
                    UrlImagem = "https://cdni.rt.com/files/2015.12/original/5678606ac46188977d8b4580.jpg",
                    Ano = 2017,
                    AgenciaId = context.Agencia.Where(a => a.Nome == "Vix Car").FirstOrDefault().Id,
                    CategoriaId = context.Categoria.Where(c => c.Descricao == "Esporte").FirstOrDefault().Id
                },
                new Carro
                {
                    Marca = "Ferrari",
                    Modelo = "F360",
                    Placa = "MSI2342",
                    UrlImagem = "http://www.lisboa.ferraridealers.com/siteasset/ferraridealer/54f07ac8c35b6/961/420/selected/0/0/0/54f07ac8c35b6.jpg",
                    Ano = 2017,
                    AgenciaId = context.Agencia.Where(a => a.Nome == "Vix Car").FirstOrDefault().Id,
                    CategoriaId = context.Categoria.Where(c => c.Descricao == "Luxo").FirstOrDefault().Id
                },
                new Carro
                {
                    Marca = "Troller",
                    Modelo = "Troller",
                    Placa = "JSJ1231",
                    UrlImagem = "http://www.poweroffroad.com.br/site/wp-content/uploads/TROLLER_LOJA_1024_149.jpg",
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
                    Cartao = "8888777766665555",
                    Nascimento = new DateTime(1994, 01, 24),
                    Senha = "1234"
                },
                new Cliente
                {
                    Nome = "Ricardo Sabaini",
                    CPF = "00000000191",
                    Cartao = "1111222233334444",
                    Nascimento = new DateTime(1992, 03, 15),
                    Senha = "5678"
                }
                );

            context.SaveChanges();

            context.Usuario.AddOrUpdate(
                x => x.Nome,
                new Usuario
                {
                    Nome = "Admin",
                    Token = "PotatoSaladMaionaiseMonster"
                },
                new Usuario
                {
                    Nome = "Website",
                    Token = "NotebookHeadphonePencilBookcase"
                },
                new Usuario
                {
                    Nome = "HotelsApi",
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
