using MediatR;
using System;

namespace Domain.Commands.Requests
{
    public class CreateUsuarioRequest : IRequest<UsuarioResponse>
    {
        public CreateUsuarioRequest(string nome, string sobreNome, string email, DateTime dataNascimento, int escolaridadeId)
        {
            Nome = nome;
            Sobrenome = sobreNome;
            Email = email;
            DataNascimento = dataNascimento;
            EscolaridadeId = escolaridadeId;
        }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public int EscolaridadeId { get; set; }
        
    }
}