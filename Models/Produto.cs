using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagement.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Categoria { get; set; }
        public int Quantidade { get; set; }
    }

    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(p => p.Nome).NotEmpty().WithMessage("O preenchimento deste campo é obrigatório!").Length(60);
            RuleFor(p => p.Preco).NotEmpty().WithMessage("O preenchimento deste campo é obrigatório!");
            RuleFor(p => p.Categoria).NotEmpty().WithMessage("O preenchimento deste campo é obrigatório!").Length(60);
            RuleFor(p => p.Quantidade).NotEmpty().WithMessage("O preenchimento deste campo é obrigatório!");
        }
    }
}
