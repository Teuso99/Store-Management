using Bogus;
using Bogus.Extensions.Brazil;
using StoreManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagement.Data
{
    public static class SeedData
    {
        public static List<Produto> Produtos = new List<Produto>();
        public static List<Funcionario> Funcionarios = new List<Funcionario>();

        public static void Init(int count)
        {
            var produtoId = 1;
            var funcionarioId = 1;

            var produtoFaker = new Faker<Produto>(locale: "pt_BR")
                .RuleFor(p => p.Id, _ => produtoId++)
                .RuleFor(p => p.Nome, f => f.Commerce.ProductName())
                .RuleFor(p => p.Preco, f => f.Finance.Amount())
                .RuleFor(p => p.Categoria, f => f.Commerce.Department())
                .RuleFor(p => p.Quantidade, f => f.Random.Number(1,99));

            var funcionarioFaker = new Faker<Funcionario>(locale: "pt_BR")
                .RuleFor(x => x.Id, _ => funcionarioId++)
                .RuleFor(x => x.Nome, f => f.Name.FullName())
                .RuleFor(x => x.Idade, f => f.Random.Number(18,50))
                .RuleFor(x => x.Endereco, f => f.Address.FullAddress())
                .RuleFor(x => x.Cpf, f => f.Person.Cpf())
                .RuleFor(x => x.Email, f => f.Internet.Email())
                .RuleFor(x => x.Telefone, f => f.Phone.PhoneNumber("(##) #####-####"))
                .RuleFor(x => x.Cargo, f => f.Name.JobTitle());

            var produtos = produtoFaker.Generate(count);
            var funcionarios = funcionarioFaker.Generate(count);

            SeedData.Produtos.AddRange(produtos);
            SeedData.Funcionarios.AddRange(funcionarios);
        }
    }
}
