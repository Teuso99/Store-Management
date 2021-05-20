using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagement.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Cargo { get; set; }
    }

    public class FuncionarioValidator: AbstractValidator<Funcionario>
    {
        public FuncionarioValidator()
        {
            RuleFor(f => f.Nome).NotEmpty().WithMessage("O preenchimento deste campo é obrigatório!").Length(60);
            RuleFor(f => f.Idade).NotEmpty().WithMessage("O preenchimento deste campo é obrigatório!");
            RuleFor(f => f.Endereco).NotEmpty().WithMessage("O preenchimento deste campo é obrigatório!").Length(200);
            RuleFor(f => f.Cpf).NotEmpty().WithMessage("O preenchimento deste campo é obrigatório!").Length(14);
            RuleFor(f => f.Email).NotEmpty().WithMessage("O preenchimento deste campo é obrigatório!").EmailAddress().WithMessage("Informe um email válido!");
            RuleFor(f => f.Telefone).NotEmpty().WithMessage("O preenchimento deste campo é obrigatório!").Length(20);
            RuleFor(f => f.Cargo).NotEmpty().WithMessage("O preenchimento deste campo é obrigatório!");
        }
    }
}
